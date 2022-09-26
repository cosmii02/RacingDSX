using ForzaDSX.Properties;
using System;
//using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using static ForzaDSX.ForzaDSXWorker;

namespace ForzaDSX
{
	public partial class UI : Form
    {
        protected ForzaDSXWorker forzaDSXWorker;
		protected ForzaDSX.Properties.Settings currentSettings;
		//protected Configuration config;
		public ForzaDSX.Properties.Settings CurrentSettings { get => currentSettings; set => currentSettings = value; }

		bool bForzaConnected = false;
		bool bDsxConnected = false;

		Thread appCheckThread;
		Thread forzaDsxThread;

		CancellationTokenSource appCheckThreadCancellationToken;
		CancellationToken appCheckThreadToken;

		CancellationTokenSource forzaThreadCancellationToken;
		CancellationToken forzaThreadToken;

		public UI()
        {
            InitializeComponent();

			//forzaDSXWorker = new ForzaDSXWorker(this);
		}
		
		void UpdateDSXConnectionStatus(bool bConnected)
		{
			toolStripStatusDSX.Image = bConnected ? Resources.greenBtn : Resources.redBtn;
			bDsxConnected = bConnected;
		}

		void UpdateForzaConnectionStatus(bool bConnected)
		{
			toolStripStatusForza.Image = bConnected ? Resources.greenBtn : Resources.redBtn;
			bForzaConnected = bConnected;
		}

		public void Output(string Text, bool bShowMessageBox = false)
		{
			outputListBox.Items.Insert(0, Text);

			if(outputListBox.Items.Count > 50)
			{
				outputListBox.Items.RemoveAt(50);
			}

			if(bShowMessageBox)
			{
				MessageBox.Show(Text);
			}
		}

		private void UI_Load(object sender, EventArgs e)
        {
			this.Text = "ForzaDSX version: " + Program.VERSION;

			LoadSettings();

			noRaceText.Text = String.Empty;
			throttleVibrationMsg.Text = String.Empty;
			throttleMsg.Text = String.Empty;
			brakeVibrationMsg.Text = String.Empty;
			brakeMsg.Text = String.Empty;

			noRaceGroupBox.Visible = currentSettings.Verbose > 0;
			raceGroupBox.Visible = currentSettings.Verbose > 0;

			// Starts the background Worker
			//this.connectionWorker.RunWorkerAsync();

			var progressHandler = new Progress<AppCheckReportStruct>(AppCheckReporter);

			AppCheckThread act = new AppCheckThread(ref currentSettings, progressHandler);
			appCheckThreadCancellationToken = new CancellationTokenSource();
			appCheckThreadToken = appCheckThreadCancellationToken.Token;

			appCheckThreadToken.Register(() => act.Stop());

			appCheckThread = new Thread(new ThreadStart(act.Run));
			appCheckThread.IsBackground = true;

			appCheckThread.Start();

			var forzaProgressHandler = new Progress<ForzaDSXReportStruct>(WorkerThreadReporter);

			forzaDSXWorker = new ForzaDSXWorker(currentSettings, forzaProgressHandler);

			forzaThreadCancellationToken = new CancellationTokenSource();
			forzaThreadToken = forzaThreadCancellationToken.Token;

			forzaThreadToken.Register(() => forzaDSXWorker.Stop());
		}

		protected void AppCheckReporter(AppCheckReportStruct value)
		{
			if (value.type == AppCheckReportStruct.AppType.NONE)
			{
				Output(value.message);
			}
			else if (value.type == AppCheckReportStruct.AppType.DSX)
			{
				UpdateDSXConnectionStatus(value.value);
			}
			else
			{
				UpdateForzaConnectionStatus(value.value);
			}

			if (forzaDsxThread == null)
			{
				if (bForzaConnected && bDsxConnected)
				{
					StartForzaDSXThread();
				}
			}
			else
			{
				if (!bForzaConnected || !bDsxConnected)
				{
					StopForzaDSXThread();
				}
			}
		}

		protected void StartForzaDSXThread()
		{
			if (forzaDsxThread != null
				|| forzaDSXWorker == null)
				return;

			forzaDsxThread = new Thread(new ThreadStart(forzaDSXWorker.Run));
			forzaDsxThread.IsBackground = true;

			forzaDsxThread.Start();
		}

		protected void StopForzaDSXThread()
		{
			try
			{
				if (forzaDsxThread != null
					&& forzaThreadCancellationToken != null)
				{
					forzaThreadCancellationToken.Cancel();
				}
			}
			catch (Exception)
			{

				throw;
			}
			
			forzaDsxThread = null;
		}

		protected void WorkerThreadReporter(ForzaDSXReportStruct value)
		{
			switch (value.type)
			{
				case ForzaDSXReportStruct.ReportType.VERBOSEMESSAGE:
					Output(value.message);
					break;
				case ForzaDSXReportStruct.ReportType.NORACE:
					if (currentSettings.Verbose > 0)
					{
						noRaceGroupBox.Visible = true;
						raceGroupBox.Visible = false;
					}

					noRaceText.Text = value.message;
					break;
				case ForzaDSXReportStruct.ReportType.RACING:
					if (currentSettings.Verbose > 0)
					{
						noRaceGroupBox.Visible = false;
						raceGroupBox.Visible = true;
					}

					switch (value.racingType)
					{
						case ForzaDSXReportStruct.RacingReportType.THROTTLE_VIBRATION:
							throttleVibrationMsg.Text = value.message;
							break;
						case ForzaDSXReportStruct.RacingReportType.THROTTLE:
							throttleMsg.Text = value.message;
							break;
						case ForzaDSXReportStruct.RacingReportType.BRAKE_VIBRATION:
							brakeVibrationMsg.Text = value.message;
							break;
						case ForzaDSXReportStruct.RacingReportType.BRAKE:
							brakeMsg.Text = value.message;
							break;
					}
					break;
			}
		}

		private void UI_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			appCheckThreadCancellationToken.Cancel();
			appCheckThreadCancellationToken.Dispose();

			forzaThreadCancellationToken.Cancel();
			forzaThreadCancellationToken.Dispose();
		}

		public void LoadSettings()
		{
			//// Build a config object, using env vars and JSON providers.
			//config = new ConfigurationBuilder()
			//	.AddIniFile("appsettings.ini")
			//	.Build();

			try
			{

				// Get values from the config given their key and their target type.
				currentSettings = Properties.Settings.Default;//.Get<ForzaDSXSettings>();

				currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY = Math.Clamp(currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY, 0.0f, 1.0f);
				currentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY = Math.Clamp(currentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY, 0.0f, 1.0f);

				verboseModeOffToolStripMenuItem.Checked = currentSettings.Verbose == 0;
				verboseModeLowToolStripMenuItem.Checked = currentSettings.Verbose == 1;
				verboseModeFullToolStripMenuItem.Checked = currentSettings.Verbose == 2;
			}
			catch (Exception e)
			{
				Output("Invalid Configuration File!\n" + e.Message, true);
			}

			SetupUI();
		}

		#region UI Forms control
		void SetupUI()
		{
			// Misc panel
			this.rpmTrackBar.Value = DenormalizeValue(currentSettings.RPM_REDLINE_RATIO);
			rpmValueNumericUpDown.Value = rpmTrackBar.Value;

			this.appCheckBox.Checked = currentSettings.DISABLE_APP_CHECK;
			this.dsxNumericUpDown.Value = currentSettings.DSX_PORT;
			this.forzaPortNumericUpDown.Value = currentSettings.FORZA_PORT;

			// Brake Panel
			this.brakeEffectIntensityTrackBar.Value = DenormalizeValue(currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY);
			this.gripLossTrackBar.Value = DenormalizeValue(currentSettings.GRIP_LOSS_VAL);
			this.brakeVibrationStartTrackBar.Value = currentSettings.BRAKE_VIBRATION_START;
			this.brakeVibrationModeTrackBar.Value = currentSettings.BRAKE_VIBRATION__MODE_START;
			this.minBrakeVibrationTrackBar.Value = currentSettings.MIN_BRAKE_VIBRATION;
			this.maxBrakeVibrationTrackBar.Value = currentSettings.MAX_BRAKE_VIBRATION;
			this.vibrationSmoothingTrackBar.Value = DenormalizeValue(currentSettings.EWMA_ALPHA_BRAKE_FREQ, 500.0f);
			this.minBrakeStiffnessTrackBar.Value = currentSettings.MIN_BRAKE_STIFFNESS;
			this.maxBrakeStiffnessTrackBar.Value = currentSettings.MAX_BRAKE_STIFFNESS;
			this.minBrakeResistanceTrackBar.Value = currentSettings.MIN_BRAKE_RESISTANCE;
			this.maxBrakeResistanceTrackBar.Value = currentSettings.MAX_BRAKE_RESISTANCE;
			this.brakeResistanceSmoothingTrackBar.Value = DenormalizeValue(currentSettings.EWMA_ALPHA_BRAKE, 500.0f);

			this.brakeEffectNumericUpDown.Value = this.brakeEffectIntensityTrackBar.Value;
			this.gripLossNumericUpDown.Value = this.gripLossTrackBar.Value;
			this.brakeVibrationStartNumericUpDown.Value = this.brakeVibrationStartTrackBar.Value;
			this.brakeVibrationModeNumericUpDown.Value = this.brakeVibrationModeTrackBar.Value;
			this.minBrakeVibrationNumericUpDown.Value = this.minBrakeVibrationTrackBar.Value;
			this.maxBrakeVibrationNumericUpDown.Value = this.maxBrakeVibrationTrackBar.Value;
			this.brakeVibrationSmoothNumericUpDown.Value = this.vibrationSmoothingTrackBar.Value;
			this.minBrakeStifnessNumericUpDown.Value = this.minBrakeStiffnessTrackBar.Value;
			this.maxBrakeStifnessNumericUpDown.Value = this.maxBrakeStiffnessTrackBar.Value;
			this.minBrakeResistanceNumericUpDown.Value = this.minBrakeResistanceTrackBar.Value;
			this.maxBrakeResistanceNumericUpDown.Value = this.maxBrakeResistanceTrackBar.Value;
			this.brakeResistanceSmoothNumericUpDown.Value = this.brakeResistanceSmoothingTrackBar.Value;

			// Throttle Panel
			this.throttleIntensityTrackBar.Value = DenormalizeValue(currentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY);
			this.throttleGripLossTrackBar.Value = DenormalizeValue(currentSettings.THROTTLE_GRIP_LOSS_VAL);
			this.throttleTurnAccelScaleTrackBar.Value = DenormalizeValue(currentSettings.TURN_ACCEL_MOD);
			this.throttleForwardAccelScaleTrackBar.Value = DenormalizeValue(currentSettings.FORWARD_ACCEL_MOD);
			this.throttleAccelLimitTrackBar.Value = currentSettings.ACCELERATION_LIMIT;
			this.throttleVibrationModeStartTrackBar.Value = currentSettings.THROTTLE_VIBRATION_MODE_START;
			this.throttleMinVibrationTrackBar.Value = currentSettings.MIN_ACCEL_GRIPLOSS_VIBRATION;
			this.throttleMaxVibrationTrackBar.Value = currentSettings.MAX_ACCEL_GRIPLOSS_VIBRATION;
			this.throttleVibrationSmoothTrackBar.Value = DenormalizeValue(currentSettings.EWMA_ALPHA_THROTTLE_FREQ);
			this.throttleMinStiffnessTrackBar.Value = currentSettings.MIN_ACCEL_GRIPLOSS_STIFFNESS;
			this.throttleMaxStiffnessTrackBar.Value = currentSettings.MAX_ACCEL_GRIPLOSS_STIFFNESS;
			this.throttleMinResistanceTrackBar.Value = currentSettings.MIN_THROTTLE_RESISTANCE;
			this.throttleMaxResistanceTrackBar.Value = currentSettings.MAX_THROTTLE_RESISTANCE;
			this.throttleResistanceSmoothTrackBar.Value = DenormalizeValue(currentSettings.EWMA_ALPHA_THROTTLE);

			this.throttleIntensityNumericUpDown.Value = this.throttleIntensityTrackBar.Value;
			this.throttleGripLossNumericUpDown.Value = this.throttleGripLossTrackBar.Value;
			this.throttleTurnAccelScaleNumericUpDown.Value = this.throttleTurnAccelScaleTrackBar.Value;
			this.throttleForwardAccelScaleNumericUpDown.Value = this.throttleForwardAccelScaleTrackBar.Value;
			this.throttleAccelLimitNumericUpDown.Value = this.throttleAccelLimitTrackBar.Value;
			this.throttleVibrationStartNumericUpDown.Value = this.throttleVibrationModeStartTrackBar.Value;
			this.throttleMinVibrationNumericUpDown.Value = this.throttleMinVibrationTrackBar.Value;
			this.throttleMaxVibrationNumericUpDown.Value = this.throttleMaxVibrationTrackBar.Value;
			this.throttleVibrationSmoothNumericUpDown.Value = this.throttleVibrationSmoothTrackBar.Value;
			this.throttleMinStiffnessNumericUpDown.Value = this.throttleMinStiffnessTrackBar.Value;
			this.throttleMaxStiffnessNumericUpDown.Value = this.throttleMaxStiffnessTrackBar.Value;
			this.throttleMinResistanceNumericUpDown.Value = this.throttleMinResistanceTrackBar.Value;
			this.throttleMaxResistanceNumericUpDown.Value = this.throttleMaxResistanceTrackBar.Value;
			this.throttleResistanceSmoothNumericUpDown.Value = this.throttleResistanceSmoothTrackBar.Value;
		}

		static int DenormalizeValue(float normalizedValue, float scale = 100.0f)
		{
			return (int)Math.Floor(normalizedValue * scale);
		}

		static float NormalizeValue(float value, float scale = 100.0f)
		{
			if (scale == 0)
				return value;

			return value / scale;
		}

		private void verboseModeFullToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentSettings.Verbose = 2;
			verboseModeOffToolStripMenuItem.Checked = false;
			verboseModeLowToolStripMenuItem.Checked = false;
			verboseModeFullToolStripMenuItem.Checked = true;
		}

		private void verboseModeLowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentSettings.Verbose = 1;
			verboseModeOffToolStripMenuItem.Checked = false;
			verboseModeLowToolStripMenuItem.Checked = true;
			verboseModeFullToolStripMenuItem.Checked = false;
		}

		private void verboseModeOffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentSettings.Verbose = 0;
			verboseModeOffToolStripMenuItem.Checked = true;
			verboseModeLowToolStripMenuItem.Checked = false;
			verboseModeFullToolStripMenuItem.Checked = false;

			noRaceGroupBox.Visible = false;
			raceGroupBox.Visible = false;
		}

		#region Misc
		private void rpmTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.RPM_REDLINE_RATIO = NormalizeValue(this.rpmTrackBar.Value);
			rpmValueNumericUpDown.Value = rpmTrackBar.Value;
		}

		private void rpmValueNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.RPM_REDLINE_RATIO = NormalizeValue((float)this.rpmValueNumericUpDown.Value);
			rpmTrackBar.Value = (int)Math.Floor(rpmValueNumericUpDown.Value);
		}

		private void appCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			currentSettings.DISABLE_APP_CHECK = this.appCheckBox.Checked;
		}

		private void dsxNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.DSX_PORT = (int)Math.Floor(this.dsxNumericUpDown.Value);
		}

		private void forzaPortNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.FORZA_PORT = (int)Math.Floor(this.forzaPortNumericUpDown.Value);
		}
		#endregion

		#region Brake
		private void brakeEffectIntensityTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY = NormalizeValue(brakeEffectIntensityTrackBar.Value);
			this.brakeEffectNumericUpDown.Value = brakeEffectIntensityTrackBar.Value;
		}

		private void brakeEffectNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY = NormalizeValue((float)brakeEffectNumericUpDown.Value);
			brakeEffectIntensityTrackBar.Value = (int)Math.Floor(brakeEffectNumericUpDown.Value);
		}

		private void gripLossTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.GRIP_LOSS_VAL = NormalizeValue(this.gripLossTrackBar.Value);
			gripLossNumericUpDown.Value = gripLossTrackBar.Value;
		}

		private void gripLossNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.GRIP_LOSS_VAL = NormalizeValue((float)gripLossNumericUpDown.Value);
			gripLossTrackBar.Value = (int)Math.Floor(gripLossNumericUpDown.Value);
		}

		private void brakeVibrationStartTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.BRAKE_VIBRATION_START = this.brakeVibrationStartTrackBar.Value;
			brakeVibrationStartNumericUpDown.Value = brakeVibrationStartTrackBar.Value;
		}

		private void brakeVibrationStartNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.BRAKE_VIBRATION_START = (int)Math.Floor(brakeVibrationStartNumericUpDown.Value);
			brakeVibrationStartTrackBar.Value = currentSettings.BRAKE_VIBRATION_START;
		}

		private void brakeVibrationModeTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.BRAKE_VIBRATION__MODE_START = this.brakeVibrationModeTrackBar.Value;
			brakeVibrationModeNumericUpDown.Value = brakeVibrationModeTrackBar.Value;
		}

		private void brakeVibrationModeNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.BRAKE_VIBRATION__MODE_START = (int)Math.Floor(brakeVibrationModeNumericUpDown.Value);
			brakeVibrationModeTrackBar.Value = currentSettings.BRAKE_VIBRATION__MODE_START;
		}

		private void minBrakeVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.MIN_BRAKE_VIBRATION = minBrakeVibrationTrackBar.Value;
			minBrakeVibrationNumericUpDown.Value = minBrakeVibrationTrackBar.Value;
		}

		private void minBrakeVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.MIN_BRAKE_VIBRATION = (int)Math.Floor(minBrakeVibrationNumericUpDown.Value);
			minBrakeVibrationTrackBar.Value = currentSettings.MIN_BRAKE_VIBRATION;
		}

		private void maxBrakeVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.MAX_BRAKE_VIBRATION = maxBrakeVibrationTrackBar.Value;
			maxBrakeVibrationNumericUpDown.Value = maxBrakeVibrationTrackBar.Value;
		}

		private void maxBrakeVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.MAX_BRAKE_VIBRATION = (int)Math.Floor(maxBrakeVibrationNumericUpDown.Value);
			maxBrakeVibrationTrackBar.Value = currentSettings.MAX_BRAKE_VIBRATION;
		}

		private void vibrationSmoothingTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.EWMA_ALPHA_BRAKE_FREQ = NormalizeValue(vibrationSmoothingTrackBar.Value, 500);
			brakeVibrationSmoothNumericUpDown.Value = vibrationSmoothingTrackBar.Value;
		}

		private void brakeVibrationSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.EWMA_ALPHA_BRAKE_FREQ = NormalizeValue((float)brakeVibrationSmoothNumericUpDown.Value, 500);
			vibrationSmoothingTrackBar.Value = (int)Math.Floor(brakeVibrationSmoothNumericUpDown.Value);
		}

		private void minBrakeStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.MIN_BRAKE_STIFFNESS = minBrakeStiffnessTrackBar.Value;
			minBrakeStifnessNumericUpDown.Value = minBrakeStiffnessTrackBar.Value;
		}

		private void minBrakeStifnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.MIN_BRAKE_STIFFNESS = (int)Math.Floor(minBrakeVibrationNumericUpDown.Value);
			minBrakeVibrationTrackBar.Value = currentSettings.MIN_BRAKE_STIFFNESS;
		}

		private void maxBrakeStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.MAX_BRAKE_STIFFNESS = maxBrakeStiffnessTrackBar.Value;
			maxBrakeStifnessNumericUpDown.Value = maxBrakeStiffnessTrackBar.Value;
		}

		private void maxBrakeStifnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.MAX_BRAKE_STIFFNESS = (int)Math.Floor(maxBrakeVibrationNumericUpDown.Value);
			maxBrakeVibrationTrackBar.Value = currentSettings.MAX_BRAKE_STIFFNESS;
		}

		private void minBrakeResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = minBrakeResistanceTrackBar.Value;
			if (value > currentSettings.MAX_BRAKE_RESISTANCE)
				value = currentSettings.MAX_BRAKE_RESISTANCE;

			currentSettings.MIN_BRAKE_RESISTANCE = value;

			minBrakeResistanceTrackBar.Value = value;
			minBrakeResistanceNumericUpDown.Value = value;
		}

		private void minBrakeResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(minBrakeResistanceNumericUpDown.Value);
			if (value > currentSettings.MAX_BRAKE_RESISTANCE)
				value = currentSettings.MAX_BRAKE_RESISTANCE;

			currentSettings.MIN_BRAKE_RESISTANCE = value;

			minBrakeResistanceTrackBar.Value = value;
			minBrakeResistanceNumericUpDown.Value = value;
		}

		private void maxBrakeResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = maxBrakeResistanceTrackBar.Value;
			if (value < currentSettings.MIN_BRAKE_RESISTANCE)
				value = currentSettings.MIN_BRAKE_RESISTANCE;

			currentSettings.MAX_BRAKE_RESISTANCE = value;

			maxBrakeResistanceTrackBar.Value = value;
			maxBrakeResistanceNumericUpDown.Value = value;
		}

		private void maxBrakeResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(maxBrakeResistanceNumericUpDown.Value);
			if (value < currentSettings.MIN_BRAKE_RESISTANCE)
				value = currentSettings.MIN_BRAKE_RESISTANCE;

			currentSettings.MAX_BRAKE_RESISTANCE = value;

			maxBrakeResistanceTrackBar.Value = value;
			maxBrakeResistanceNumericUpDown.Value = value;
		}

		private void brakeResistanceSmoothingTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.EWMA_ALPHA_BRAKE = NormalizeValue(brakeResistanceSmoothingTrackBar.Value, 500);
			brakeResistanceSmoothNumericUpDown.Value = brakeResistanceSmoothingTrackBar.Value;
		}

		private void brakeResistanceSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.EWMA_ALPHA_BRAKE = NormalizeValue((float)brakeResistanceSmoothNumericUpDown.Value, 500);
			brakeResistanceSmoothingTrackBar.Value = (int)Math.Floor(brakeResistanceSmoothNumericUpDown.Value);
		}
		#endregion

		#region Throttle
		private void throttleIntensityTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY = NormalizeValue(throttleIntensityTrackBar.Value);
			throttleIntensityNumericUpDown.Value = throttleIntensityTrackBar.Value;
		}

		private void throttleIntensityNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY = NormalizeValue((float)throttleIntensityNumericUpDown.Value);
			throttleIntensityTrackBar.Value = (int)Math.Floor(throttleIntensityNumericUpDown.Value);
		}

		private void throttleGripLossTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleGripLossTrackBar.Value;
			currentSettings.THROTTLE_GRIP_LOSS_VAL = NormalizeValue(value);
			throttleGripLossNumericUpDown.Value = value;
		}

		private void throttleGripLossNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleGripLossNumericUpDown.Value;
			currentSettings.THROTTLE_GRIP_LOSS_VAL = NormalizeValue(value);
			throttleGripLossTrackBar.Value = (int)Math.Floor(value);
		}

		private void throttleTurnAccelScaleTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleTurnAccelScaleTrackBar.Value;
			currentSettings.TURN_ACCEL_MOD = NormalizeValue(value);
			throttleTurnAccelScaleNumericUpDown.Value = value;
		}

		private void throttleTurnAccelScaleNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleTurnAccelScaleNumericUpDown.Value;
			currentSettings.TURN_ACCEL_MOD = NormalizeValue(value);
			throttleTurnAccelScaleTrackBar.Value = (int)Math.Floor(value);
		}

		private void throttleForwardAccelScaleTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleForwardAccelScaleTrackBar.Value;
			currentSettings.FORWARD_ACCEL_MOD = NormalizeValue(value);
			throttleForwardAccelScaleNumericUpDown.Value = value;
		}

		private void throttleForwardAccelScaleNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleForwardAccelScaleNumericUpDown.Value;
			currentSettings.FORWARD_ACCEL_MOD = NormalizeValue(value);
			throttleForwardAccelScaleTrackBar.Value = (int)Math.Floor(value);
		}

		private void throttleAccelLimitTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleAccelLimitTrackBar.Value;
			currentSettings.ACCELERATION_LIMIT = value;
			throttleAccelLimitNumericUpDown.Value = value;
		}

		private void throttleAccelLimitNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleAccelLimitNumericUpDown.Value);
			currentSettings.ACCELERATION_LIMIT = value;
			throttleAccelLimitTrackBar.Value = value;
		}

		private void throttleVibrationModeStartTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleVibrationModeStartTrackBar.Value;
			currentSettings.THROTTLE_VIBRATION_MODE_START = value;
			throttleVibrationStartNumericUpDown.Value = value;
		}

		private void throttleVibrationStartNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleVibrationStartNumericUpDown.Value);
			currentSettings.THROTTLE_VIBRATION_MODE_START = value;
			throttleVibrationModeStartTrackBar.Value = value;
		}

		private void throttleMinVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMinVibrationTrackBar.Value;
			currentSettings.MIN_ACCEL_GRIPLOSS_VIBRATION = value;
			throttleMinVibrationNumericUpDown.Value = value;
		}

		private void throttleMinVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMinVibrationNumericUpDown.Value);
			currentSettings.MIN_ACCEL_GRIPLOSS_VIBRATION = value;
			throttleMinVibrationTrackBar.Value = value;
		}

		private void throttleMaxVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMaxVibrationTrackBar.Value;
			currentSettings.MAX_ACCEL_GRIPLOSS_VIBRATION = value;
			throttleMaxVibrationNumericUpDown.Value = value;
		}

		private void throttleMaxVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMaxVibrationNumericUpDown.Value);
			currentSettings.MAX_ACCEL_GRIPLOSS_VIBRATION = value;
			throttleMaxVibrationTrackBar.Value = value;
		}

		private void throttleVibrationSmoothTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleVibrationSmoothTrackBar.Value;
			currentSettings.EWMA_ALPHA_THROTTLE_FREQ = NormalizeValue(value);
			throttleVibrationSmoothNumericUpDown.Value = value;
		}

		private void throttleVibrationSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleVibrationSmoothNumericUpDown.Value;
			currentSettings.EWMA_ALPHA_THROTTLE_FREQ = NormalizeValue(value);
			throttleVibrationSmoothTrackBar.Value = (int)Math.Floor(value);
		}

		private void throttleMinStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMinStiffnessTrackBar.Value;
			currentSettings.MIN_ACCEL_GRIPLOSS_STIFFNESS = value;
			throttleMinStiffnessNumericUpDown.Value = value;
		}

		private void throttleMinStiffnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMinStiffnessNumericUpDown.Value);
			currentSettings.MIN_ACCEL_GRIPLOSS_STIFFNESS = value;
			throttleMinStiffnessTrackBar.Value = value;
		}

		private void throttleMaxStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMaxStiffnessTrackBar.Value;
			currentSettings.MAX_ACCEL_GRIPLOSS_STIFFNESS = value;
			throttleMaxStiffnessNumericUpDown.Value = value;
		}

		private void throttleMaxStiffnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMaxStiffnessNumericUpDown.Value);
			currentSettings.MAX_ACCEL_GRIPLOSS_STIFFNESS = value;
			throttleMaxStiffnessTrackBar.Value = value;
		}

		private void throttleMinResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMinResistanceTrackBar.Value;
			currentSettings.MIN_THROTTLE_RESISTANCE = value;
			throttleMinResistanceNumericUpDown.Value = value;
		}

		private void throttleMinResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMinResistanceNumericUpDown.Value);
			currentSettings.MIN_THROTTLE_RESISTANCE = value;
			throttleMinResistanceTrackBar.Value = value;
		}

		private void throttleMaxResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMaxResistanceTrackBar.Value;
			currentSettings.MAX_THROTTLE_RESISTANCE = value;
			throttleMaxResistanceNumericUpDown.Value = value;
		}

		private void throttleMaxResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMaxResistanceNumericUpDown.Value);
			currentSettings.MAX_THROTTLE_RESISTANCE = value;
			throttleMaxResistanceTrackBar.Value = value;
		}

		private void throttleResistanceSmoothTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleResistanceSmoothTrackBar.Value;
			currentSettings.EWMA_ALPHA_THROTTLE = NormalizeValue(value);
			throttleResistanceSmoothNumericUpDown.Value = value;
		}

		private void throttleResistanceSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleResistanceSmoothNumericUpDown.Value;
			currentSettings.EWMA_ALPHA_THROTTLE = NormalizeValue(value);
			throttleResistanceSmoothTrackBar.Value = (int)Math.Floor(value);
		}
		#endregion

		#endregion

		private void buttonApplyMisc_Click(object sender, EventArgs e)
		{
			StopForzaDSXThread();

			if (forzaDSXWorker != null)
			{
				CurrentSettings.Save();

				forzaDSXWorker.SetSettings(CurrentSettings);

				StartForzaDSXThread();
			}
		}

		private void buttonApply_Brake_Click(object sender, EventArgs e)
		{
			StopForzaDSXThread();

			if (forzaDSXWorker != null)
			{
				CurrentSettings.Save();

				forzaDSXWorker.SetSettings(CurrentSettings);

				StartForzaDSXThread();
			}
		}

		private void buttonApply_Throttle_Click(object sender, EventArgs e)
		{
			StopForzaDSXThread();

			if (forzaDSXWorker != null)
			{
				CurrentSettings.Save();

				forzaDSXWorker.SetSettings(CurrentSettings);

				StartForzaDSXThread();
			}
		}
	}
}
