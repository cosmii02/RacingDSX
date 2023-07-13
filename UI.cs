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

			if (outputListBox.Items.Count > 50)
			{
				outputListBox.Items.RemoveAt(50);
			}

			if (bShowMessageBox)
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

			noRaceGroupBox.Visible = currentSettings._verbose > 0;
			raceGroupBox.Visible = currentSettings._verbose > 0;

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
					if (currentSettings._verbose > 0)
					{
						noRaceGroupBox.Visible = true;
						raceGroupBox.Visible = false;
					}

					noRaceText.Text = value.message;
					break;
				case ForzaDSXReportStruct.ReportType.RACING:
					if (currentSettings._verbose > 0)
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
				currentSettings = Properties.Settings.Default;

				currentSettings._left_Trigger_Effect_Intensity = Math.Clamp(currentSettings._left_Trigger_Effect_Intensity, 0.0f, 1.0f);
				currentSettings._right_Trigger_Effect_Intensity = Math.Clamp(currentSettings._right_Trigger_Effect_Intensity, 0.0f, 1.0f);

				verboseModeOffToolStripMenuItem.Checked = currentSettings._verbose == 0;
				verboseModeLowToolStripMenuItem.Checked = currentSettings._verbose == 1;
				verboseModeFullToolStripMenuItem.Checked = currentSettings._verbose == 2;
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
			this.rpmTrackBar.Value = DenormalizeValue(currentSettings._rpm_Redline_Ratio);
			rpmValueNumericUpDown.Value = rpmTrackBar.Value;

			this.appCheckBox.Checked = currentSettings._disable_App_Check;
			this.dsxNumericUpDown.Value = currentSettings._dsx_PORT;
			this.forzaPortNumericUpDown.Value = currentSettings._forza_PORT;

			// Brake Panel
			this.brakeTriggerModeComboBox.SelectedIndex = currentSettings.BrakeTriggerMode;
			this.brakeEffectIntensityTrackBar.Value = DenormalizeValue(currentSettings._left_Trigger_Effect_Intensity);
			this.gripLossTrackBar.Value = DenormalizeValue(currentSettings._grip_Loss_Val);
			this.brakeVibrationStartTrackBar.Value = currentSettings._brake_Vibration_Start;
			this.brakeVibrationModeTrackBar.Value = currentSettings._brake_Vibration_Mode_Start;
			this.minBrakeVibrationTrackBar.Value = currentSettings._min_Brake_Vibration;
			this.maxBrakeVibrationTrackBar.Value = currentSettings._max_Brake_Vibration;
			this.vibrationSmoothingTrackBar.Value = DenormalizeValue(currentSettings._ewma_Alpha_Brake_Freq, 500.0f);
			this.minBrakeStiffnessTrackBar.Value = currentSettings._min_Brake_Stiffness;
			this.maxBrakeStiffnessTrackBar.Value = currentSettings._max_Brake_Stiffness;
			this.minBrakeResistanceTrackBar.Value = currentSettings._min_Brake_Resistance;
			this.maxBrakeResistanceTrackBar.Value = currentSettings._max_Brake_Resistance;
			this.brakeResistanceSmoothingTrackBar.Value = DenormalizeValue(currentSettings._ewma_Alpha_Brake, 500.0f);

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
			this.throttleTriggerModeComboBox.SelectedIndex = currentSettings.ThrottleTriggerMode;
			this.throttleIntensityTrackBar.Value = DenormalizeValue(currentSettings._right_Trigger_Effect_Intensity);
			this.throttleGripLossTrackBar.Value = DenormalizeValue(currentSettings._throttle_Grip_Loss_Val);
			this.throttleTurnAccelScaleTrackBar.Value = DenormalizeValue(currentSettings._turn_Accel_Mod);
			this.throttleForwardAccelScaleTrackBar.Value = DenormalizeValue(currentSettings._forward_Accel_Mod);
			this.throttleAccelLimitTrackBar.Value = currentSettings._acceleration_Limit;
			this.throttleVibrationModeStartTrackBar.Value = currentSettings._throttle_Vibration_Mode_Start;
			this.throttleMinVibrationTrackBar.Value = currentSettings._min_Accel_Griploss_Vibration;
			this.throttleMaxVibrationTrackBar.Value = currentSettings._max_Accel_Griploss_Vibration;
			this.throttleVibrationSmoothTrackBar.Value = DenormalizeValue(currentSettings._ewma_Alpha_Throttle_Freq);
			this.throttleMinStiffnessTrackBar.Value = currentSettings._min_Accel_Griploss_Stiffness;
			this.throttleMaxStiffnessTrackBar.Value = currentSettings._max_Accel_Griploss_Stiffness;
			this.throttleMinResistanceTrackBar.Value = currentSettings._min_Throttle_Resistance;
			this.throttleMaxResistanceTrackBar.Value = currentSettings._max_Throttle_Resistance;
			this.throttleResistanceSmoothTrackBar.Value = DenormalizeValue(currentSettings._ewma_Alpha_Throttle);

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
			currentSettings._verbose = 2;
			verboseModeOffToolStripMenuItem.Checked = false;
			verboseModeLowToolStripMenuItem.Checked = false;
			verboseModeFullToolStripMenuItem.Checked = true;
		}

		private void verboseModeLowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentSettings._verbose = 1;
			verboseModeOffToolStripMenuItem.Checked = false;
			verboseModeLowToolStripMenuItem.Checked = true;
			verboseModeFullToolStripMenuItem.Checked = false;
		}

		private void verboseModeOffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentSettings._verbose = 0;
			verboseModeOffToolStripMenuItem.Checked = true;
			verboseModeLowToolStripMenuItem.Checked = false;
			verboseModeFullToolStripMenuItem.Checked = false;

			noRaceGroupBox.Visible = false;
			raceGroupBox.Visible = false;
		}

		#region Misc
		private void rpmTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._rpm_Redline_Ratio = NormalizeValue(this.rpmTrackBar.Value);
			rpmValueNumericUpDown.Value = rpmTrackBar.Value;
		}

		private void rpmValueNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._rpm_Redline_Ratio = NormalizeValue((float)this.rpmValueNumericUpDown.Value);
			rpmTrackBar.Value = (int)Math.Floor(rpmValueNumericUpDown.Value);
		}

		private void appCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			currentSettings._disable_App_Check = this.appCheckBox.Checked;
		}

		private void dsxNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._dsx_PORT = (int)Math.Floor(this.dsxNumericUpDown.Value);
		}

		private void forzaPortNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._forza_PORT = (int)Math.Floor(this.forzaPortNumericUpDown.Value);
		}
		#endregion

		#region Brake
		private void brakeEffectIntensityTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._left_Trigger_Effect_Intensity = NormalizeValue(brakeEffectIntensityTrackBar.Value);
			this.brakeEffectNumericUpDown.Value = brakeEffectIntensityTrackBar.Value;
		}

		private void brakeEffectNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._left_Trigger_Effect_Intensity = NormalizeValue((float)brakeEffectNumericUpDown.Value);
			brakeEffectIntensityTrackBar.Value = (int)Math.Floor(brakeEffectNumericUpDown.Value);
		}

		private void gripLossTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._grip_Loss_Val = NormalizeValue(this.gripLossTrackBar.Value);
			gripLossNumericUpDown.Value = gripLossTrackBar.Value;
		}

		private void gripLossNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._grip_Loss_Val = NormalizeValue((float)gripLossNumericUpDown.Value);
			gripLossTrackBar.Value = (int)Math.Floor(gripLossNumericUpDown.Value);
		}

		private void brakeVibrationStartTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._brake_Vibration_Start = this.brakeVibrationStartTrackBar.Value;
			brakeVibrationStartNumericUpDown.Value = brakeVibrationStartTrackBar.Value;
		}

		private void brakeVibrationStartNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._brake_Vibration_Start = (int)Math.Floor(brakeVibrationStartNumericUpDown.Value);
			brakeVibrationStartTrackBar.Value = currentSettings._brake_Vibration_Start;
		}

		private void brakeVibrationModeTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._brake_Vibration_Mode_Start = this.brakeVibrationModeTrackBar.Value;
			brakeVibrationModeNumericUpDown.Value = brakeVibrationModeTrackBar.Value;
		}

		private void brakeVibrationModeNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._brake_Vibration_Mode_Start = (int)Math.Floor(brakeVibrationModeNumericUpDown.Value);
			brakeVibrationModeTrackBar.Value = currentSettings._brake_Vibration_Mode_Start;
		}

		private void minBrakeVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._min_Brake_Vibration = minBrakeVibrationTrackBar.Value;
			minBrakeVibrationNumericUpDown.Value = minBrakeVibrationTrackBar.Value;
		}

		private void minBrakeVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._min_Brake_Vibration = (int)Math.Floor(minBrakeVibrationNumericUpDown.Value);
			minBrakeVibrationTrackBar.Value = currentSettings._min_Brake_Vibration;
		}

		private void maxBrakeVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._max_Brake_Vibration = maxBrakeVibrationTrackBar.Value;
			maxBrakeVibrationNumericUpDown.Value = maxBrakeVibrationTrackBar.Value;
		}

		private void maxBrakeVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._max_Brake_Vibration = (int)Math.Floor(maxBrakeVibrationNumericUpDown.Value);
			maxBrakeVibrationTrackBar.Value = currentSettings._max_Brake_Vibration;
		}

		private void vibrationSmoothingTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._ewma_Alpha_Brake_Freq = NormalizeValue(vibrationSmoothingTrackBar.Value, 500);
			brakeVibrationSmoothNumericUpDown.Value = vibrationSmoothingTrackBar.Value;
		}

		private void brakeVibrationSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._ewma_Alpha_Brake_Freq = NormalizeValue((float)brakeVibrationSmoothNumericUpDown.Value, 500);
			vibrationSmoothingTrackBar.Value = (int)Math.Floor(brakeVibrationSmoothNumericUpDown.Value);
		}

		private void minBrakeStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._min_Brake_Stiffness = minBrakeStiffnessTrackBar.Value;
			minBrakeStifnessNumericUpDown.Value = minBrakeStiffnessTrackBar.Value;
		}

		private void minBrakeStifnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._min_Brake_Stiffness = (int)Math.Floor(minBrakeVibrationNumericUpDown.Value);
			minBrakeVibrationTrackBar.Value = currentSettings._min_Brake_Stiffness;
		}

		private void maxBrakeStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._max_Brake_Stiffness = maxBrakeStiffnessTrackBar.Value;
			maxBrakeStifnessNumericUpDown.Value = maxBrakeStiffnessTrackBar.Value;
		}

		private void maxBrakeStifnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._max_Brake_Stiffness = (int)Math.Floor(maxBrakeVibrationNumericUpDown.Value);
			maxBrakeVibrationTrackBar.Value = currentSettings._max_Brake_Stiffness;
		}

		private void minBrakeResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = minBrakeResistanceTrackBar.Value;
			if (value > currentSettings._max_Brake_Resistance)
				value = currentSettings._max_Brake_Resistance;

			currentSettings._min_Brake_Resistance = value;

			minBrakeResistanceTrackBar.Value = value;
			minBrakeResistanceNumericUpDown.Value = value;
		}

		private void minBrakeResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(minBrakeResistanceNumericUpDown.Value);
			if (value > currentSettings._max_Brake_Resistance)
				value = currentSettings._max_Brake_Resistance;

			currentSettings._min_Brake_Resistance = value;

			minBrakeResistanceTrackBar.Value = value;
			minBrakeResistanceNumericUpDown.Value = value;
		}

		private void maxBrakeResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = maxBrakeResistanceTrackBar.Value;
			if (value < currentSettings._min_Brake_Resistance)
				value = currentSettings._min_Brake_Resistance;

			currentSettings._max_Brake_Resistance = value;

			maxBrakeResistanceTrackBar.Value = value;
			maxBrakeResistanceNumericUpDown.Value = value;
		}

		private void maxBrakeResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(maxBrakeResistanceNumericUpDown.Value);
			if (value < currentSettings._min_Brake_Resistance)
				value = currentSettings._min_Brake_Resistance;

			currentSettings._max_Brake_Resistance = value;

			maxBrakeResistanceTrackBar.Value = value;
			maxBrakeResistanceNumericUpDown.Value = value;
		}

		private void brakeResistanceSmoothingTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._ewma_Alpha_Brake = NormalizeValue(brakeResistanceSmoothingTrackBar.Value, 500);
			brakeResistanceSmoothNumericUpDown.Value = brakeResistanceSmoothingTrackBar.Value;
		}

		private void brakeResistanceSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._ewma_Alpha_Brake = NormalizeValue((float)brakeResistanceSmoothNumericUpDown.Value, 500);
			brakeResistanceSmoothingTrackBar.Value = (int)Math.Floor(brakeResistanceSmoothNumericUpDown.Value);
		}
		#endregion

		#region Throttle
		private void throttleIntensityTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings._right_Trigger_Effect_Intensity = NormalizeValue(throttleIntensityTrackBar.Value);
			throttleIntensityNumericUpDown.Value = throttleIntensityTrackBar.Value;
		}

		private void throttleIntensityNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings._right_Trigger_Effect_Intensity = NormalizeValue((float)throttleIntensityNumericUpDown.Value);
			throttleIntensityTrackBar.Value = (int)Math.Floor(throttleIntensityNumericUpDown.Value);
		}

		private void throttleGripLossTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleGripLossTrackBar.Value;
			currentSettings._throttle_Grip_Loss_Val = NormalizeValue(value);
			throttleGripLossNumericUpDown.Value = value;
		}

		private void throttleGripLossNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleGripLossNumericUpDown.Value;
			currentSettings._throttle_Grip_Loss_Val = NormalizeValue(value);
			throttleGripLossTrackBar.Value = (int)Math.Floor(value);
		}

		private void throttleTurnAccelScaleTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleTurnAccelScaleTrackBar.Value;
			currentSettings._turn_Accel_Mod = NormalizeValue(value);
			throttleTurnAccelScaleNumericUpDown.Value = value;
		}

		private void throttleTurnAccelScaleNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleTurnAccelScaleNumericUpDown.Value;
			currentSettings._turn_Accel_Mod = NormalizeValue(value);
			throttleTurnAccelScaleTrackBar.Value = (int)Math.Floor(value);
		}

		private void throttleForwardAccelScaleTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleForwardAccelScaleTrackBar.Value;
			currentSettings._forward_Accel_Mod = NormalizeValue(value);
			throttleForwardAccelScaleNumericUpDown.Value = value;
		}

		private void throttleForwardAccelScaleNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleForwardAccelScaleNumericUpDown.Value;
			currentSettings._forward_Accel_Mod = NormalizeValue(value);
			throttleForwardAccelScaleTrackBar.Value = (int)Math.Floor(value);
		}

		private void throttleAccelLimitTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleAccelLimitTrackBar.Value;
			currentSettings._acceleration_Limit = value;
			throttleAccelLimitNumericUpDown.Value = value;
		}

		private void throttleAccelLimitNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleAccelLimitNumericUpDown.Value);
			currentSettings._acceleration_Limit = value;
			throttleAccelLimitTrackBar.Value = value;
		}

		private void throttleVibrationModeStartTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleVibrationModeStartTrackBar.Value;
			currentSettings._throttle_Vibration_Mode_Start = value;
			throttleVibrationStartNumericUpDown.Value = value;
		}

		private void throttleVibrationStartNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleVibrationStartNumericUpDown.Value);
			currentSettings._throttle_Vibration_Mode_Start = value;
			throttleVibrationModeStartTrackBar.Value = value;
		}

		private void throttleMinVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMinVibrationTrackBar.Value;
			currentSettings._min_Accel_Griploss_Vibration = value;
			throttleMinVibrationNumericUpDown.Value = value;
		}

		private void throttleMinVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMinVibrationNumericUpDown.Value);
			currentSettings._min_Accel_Griploss_Vibration = value;
			throttleMinVibrationTrackBar.Value = value;
		}

		private void throttleMaxVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMaxVibrationTrackBar.Value;
			currentSettings._max_Accel_Griploss_Vibration = value;
			throttleMaxVibrationNumericUpDown.Value = value;
		}

		private void throttleMaxVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMaxVibrationNumericUpDown.Value);
			currentSettings._max_Accel_Griploss_Vibration = value;
			throttleMaxVibrationTrackBar.Value = value;
		}

		private void throttleVibrationSmoothTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleVibrationSmoothTrackBar.Value;
			currentSettings._ewma_Alpha_Throttle_Freq = NormalizeValue(value);
			throttleVibrationSmoothNumericUpDown.Value = value;
		}

		private void throttleVibrationSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleVibrationSmoothNumericUpDown.Value;
			currentSettings._ewma_Alpha_Throttle_Freq = NormalizeValue(value);
			throttleVibrationSmoothTrackBar.Value = (int)Math.Floor(value);
		}

		private void throttleMinStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMinStiffnessTrackBar.Value;
			currentSettings._min_Accel_Griploss_Stiffness = value;
			throttleMinStiffnessNumericUpDown.Value = value;
		}

		private void throttleMinStiffnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMinStiffnessNumericUpDown.Value);
			currentSettings._min_Accel_Griploss_Stiffness = value;
			throttleMinStiffnessTrackBar.Value = value;
		}

		private void throttleMaxStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMaxStiffnessTrackBar.Value;
			currentSettings._max_Accel_Griploss_Stiffness = value;
			throttleMaxStiffnessNumericUpDown.Value = value;
		}

		private void throttleMaxStiffnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMaxStiffnessNumericUpDown.Value);
			currentSettings._max_Accel_Griploss_Stiffness = value;
			throttleMaxStiffnessTrackBar.Value = value;
		}

		private void throttleMinResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMinResistanceTrackBar.Value;
			currentSettings._min_Throttle_Resistance = value;
			throttleMinResistanceNumericUpDown.Value = value;
		}

		private void throttleMinResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMinResistanceNumericUpDown.Value);
			currentSettings._min_Throttle_Resistance = value;
			throttleMinResistanceTrackBar.Value = value;
		}

		private void throttleMaxResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleMaxResistanceTrackBar.Value;
			currentSettings._max_Throttle_Resistance = value;
			throttleMaxResistanceNumericUpDown.Value = value;
		}

		private void throttleMaxResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(throttleMaxResistanceNumericUpDown.Value);
			currentSettings._max_Throttle_Resistance = value;
			throttleMaxResistanceTrackBar.Value = value;
		}

		private void throttleResistanceSmoothTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = throttleResistanceSmoothTrackBar.Value;
			currentSettings._ewma_Alpha_Throttle = NormalizeValue(value);
			throttleResistanceSmoothNumericUpDown.Value = value;
		}

		private void throttleResistanceSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			float value = (float)throttleResistanceSmoothNumericUpDown.Value;
			currentSettings._ewma_Alpha_Throttle = NormalizeValue(value);
			throttleResistanceSmoothTrackBar.Value = (int)Math.Floor(value);
		}
		#endregion

		#endregion

		private void buttonApplyMisc_Click(object sender, EventArgs e)
		{
			if (forzaDSXWorker != null)
			{
				CurrentSettings.Save();

				forzaDSXWorker.SetSettings(CurrentSettings);
			}
		}

		private void buttonApply_Brake_Click(object sender, EventArgs e)
		{
			if (forzaDSXWorker != null)
			{
				CurrentSettings.Save();

				forzaDSXWorker.SetSettings(CurrentSettings);
			}
		}

		private void buttonApply_Throttle_Click(object sender, EventArgs e)
		{
			if (forzaDSXWorker != null)
			{
				CurrentSettings.Save();

				forzaDSXWorker.SetSettings(CurrentSettings);
			}
		}

		private void miscDefaultsButton_Click(object sender, EventArgs e)
		{
			FullResetValues();
		}

		private void brakeDefaultsButton_Click(object sender, EventArgs e)
		{
			FullResetValues();
		}

		private void throttleDefaultsButton_Click(object sender, EventArgs e)
		{
			FullResetValues();
		}

		protected void FullResetValues()
		{
			CurrentSettings.Reset();

			SetupUI();

			if (forzaDSXWorker != null)
			{
				CurrentSettings.Save();

				forzaDSXWorker.SetSettings(CurrentSettings);

				StartForzaDSXThread();
			}
		}

		private void brakeTriggerModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentSettings.BrakeTriggerMode = (sbyte)brakeTriggerModeComboBox.SelectedIndex;
		}

		private void throttleTriggerModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentSettings.ThrottleTriggerMode = (sbyte)throttleTriggerModeComboBox.SelectedIndex;
		}
	}
}
