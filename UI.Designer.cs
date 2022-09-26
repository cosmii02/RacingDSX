using System;
using System.ComponentModel;

namespace ForzaDSX
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.miscTabPage = new System.Windows.Forms.TabPage();
			this.miscTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.forzaPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.forzaPortLabel = new System.Windows.Forms.Label();
			this.dsxPortLabel = new System.Windows.Forms.Label();
			this.appCheckLabel = new System.Windows.Forms.Label();
			this.rpmLabel = new System.Windows.Forms.Label();
			this.rpmTrackBar = new System.Windows.Forms.TrackBar();
			this.appCheckBox = new System.Windows.Forms.CheckBox();
			this.dsxNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.rpmValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.buttonApplyMisc = new System.Windows.Forms.Button();
			this.brakeConfigTabPage = new System.Windows.Forms.TabPage();
			this.brakeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.brakeResistanceSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxBrakeResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minBrakeResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxBrakeStifnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minBrakeStifnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeVibrationSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxBrakeVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minBrakeVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeVibrationModeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeVibrationStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.gripLossNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeEffectNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeResistanceSmoothingTrackBar = new System.Windows.Forms.TrackBar();
			this.brakeResistanceSmoothingLabel = new System.Windows.Forms.Label();
			this.maxBrakeResistanceTrackBar = new System.Windows.Forms.TrackBar();
			this.maxBrakeResistanceLabel = new System.Windows.Forms.Label();
			this.minBrakeResistanceTrackBar = new System.Windows.Forms.TrackBar();
			this.minBrakeResistanceLabel = new System.Windows.Forms.Label();
			this.maxBrakeStiffnessTrackBar = new System.Windows.Forms.TrackBar();
			this.maxBrakeStiffnessLabel = new System.Windows.Forms.Label();
			this.minBrakeStiffnessTrackBar = new System.Windows.Forms.TrackBar();
			this.minBrakeStiffnessLabel = new System.Windows.Forms.Label();
			this.vibrationSmoothingTrackBar = new System.Windows.Forms.TrackBar();
			this.vibrationSmoothingLabel = new System.Windows.Forms.Label();
			this.maxBrakeVibrationTrackBar = new System.Windows.Forms.TrackBar();
			this.maxBrakeVibrationLabel = new System.Windows.Forms.Label();
			this.minBrakeVibrationTrackBar = new System.Windows.Forms.TrackBar();
			this.minBrakeVibrationLabel = new System.Windows.Forms.Label();
			this.brakeVibrationModeTrackBar = new System.Windows.Forms.TrackBar();
			this.brakeVibrationModeStartLabel = new System.Windows.Forms.Label();
			this.brakeVibrationStartTrackBar = new System.Windows.Forms.TrackBar();
			this.brakeVibrationStartLabel = new System.Windows.Forms.Label();
			this.gripLossTrackBar = new System.Windows.Forms.TrackBar();
			this.gripLossLabel = new System.Windows.Forms.Label();
			this.brakeEffectIntensityLabel = new System.Windows.Forms.Label();
			this.brakeEffectIntensityTrackBar = new System.Windows.Forms.TrackBar();
			this.buttonApply_Brake = new System.Windows.Forms.Button();
			this.throttleConfigTabPage = new System.Windows.Forms.TabPage();
			this.throttleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.throttleResistanceSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleMaxResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleMinResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleMaxStiffnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleMinStiffnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleVibrationSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleMaxVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleMinVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleVibrationStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleAccelLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleForwardAccelScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleTurnAccelScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleGripLossNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleIntensityNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.throttleResistanceSmoothTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleMaxResistanceTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleMinResistanceTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleMaxStiffnessTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleMinStiffnessTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleVibrationSmoothTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleMaxVibrationTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleMinVibrationTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleVibrationModeStartTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleAccelLimitTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleForwardAccelScaleTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleTurnAccelScaleTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleGripLossTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleIntensityTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleResistanceSmoothingLabel = new System.Windows.Forms.Label();
			this.maxThrottleResistanceLabel = new System.Windows.Forms.Label();
			this.minThrottleResistanceLabel = new System.Windows.Forms.Label();
			this.maxThrottleStiffnessLabel = new System.Windows.Forms.Label();
			this.minThrottleStiffnessLabel = new System.Windows.Forms.Label();
			this.throttleVibrationSmoothingLabel = new System.Windows.Forms.Label();
			this.maxThrottleVibrationLabel = new System.Windows.Forms.Label();
			this.minThrottleVibrationLabel = new System.Windows.Forms.Label();
			this.throttleVibrationStartLabel = new System.Windows.Forms.Label();
			this.accelerationLimitLabel = new System.Windows.Forms.Label();
			this.forwardAccelLabel = new System.Windows.Forms.Label();
			this.turnAccelLabel = new System.Windows.Forms.Label();
			this.throttleGripLossLabel = new System.Windows.Forms.Label();
			this.throttleIntensityLabel = new System.Windows.Forms.Label();
			this.buttonApply_Throttle = new System.Windows.Forms.Button();
			this.outputTabPage = new System.Windows.Forms.TabPage();
			this.raceGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.brakeMsg = new System.Windows.Forms.Label();
			this.brakeVibrationMsg = new System.Windows.Forms.Label();
			this.throttleMsg = new System.Windows.Forms.Label();
			this.throttleVibrationMsg = new System.Windows.Forms.Label();
			this.noRaceGroupBox = new System.Windows.Forms.GroupBox();
			this.noRaceText = new System.Windows.Forms.Label();
			this.outputListBox = new System.Windows.Forms.ListBox();
			this.toolStripStatusDSX = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusForza = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripVerboseMode = new System.Windows.Forms.ToolStripDropDownButton();
			this.verboseModeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verboseModeLowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verboseModeFullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.mainPanel.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.miscTabPage.SuspendLayout();
			this.miscTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.forzaPortNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpmTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsxNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpmValueNumericUpDown)).BeginInit();
			this.brakeConfigTabPage.SuspendLayout();
			this.brakeTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.brakeResistanceSmoothNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeResistanceNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeResistanceNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeStifnessNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeStifnessNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationSmoothNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeVibrationNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeVibrationNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationModeNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationStartNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gripLossNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeEffectNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeResistanceSmoothingTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeResistanceTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeResistanceTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeStiffnessTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeStiffnessTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vibrationSmoothingTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeVibrationTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeVibrationTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationModeTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationStartTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gripLossTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeEffectIntensityTrackBar)).BeginInit();
			this.throttleConfigTabPage.SuspendLayout();
			this.throttleTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.throttleResistanceSmoothNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxResistanceNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinResistanceNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxStiffnessNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinStiffnessNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleVibrationSmoothNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxVibrationNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinVibrationNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleVibrationStartNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleAccelLimitNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleForwardAccelScaleNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleTurnAccelScaleNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleGripLossNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleIntensityNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleResistanceSmoothTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxResistanceTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinResistanceTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxStiffnessTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinStiffnessTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleVibrationSmoothTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxVibrationTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinVibrationTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleVibrationModeStartTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleAccelLimitTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleForwardAccelScaleTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleTurnAccelScaleTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleGripLossTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleIntensityTrackBar)).BeginInit();
			this.outputTabPage.SuspendLayout();
			this.raceGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.noRaceGroupBox.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.mainTabControl);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(721, 761);
			this.mainPanel.TabIndex = 0;
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.miscTabPage);
			this.mainTabControl.Controls.Add(this.brakeConfigTabPage);
			this.mainTabControl.Controls.Add(this.throttleConfigTabPage);
			this.mainTabControl.Controls.Add(this.outputTabPage);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(721, 761);
			this.mainTabControl.TabIndex = 0;
			// 
			// miscTabPage
			// 
			this.miscTabPage.Controls.Add(this.miscTableLayoutPanel);
			this.miscTabPage.Location = new System.Drawing.Point(4, 24);
			this.miscTabPage.Name = "miscTabPage";
			this.miscTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.miscTabPage.Size = new System.Drawing.Size(713, 733);
			this.miscTabPage.TabIndex = 3;
			this.miscTabPage.Text = "Misc";
			this.miscTabPage.UseVisualStyleBackColor = true;
			// 
			// miscTableLayoutPanel
			// 
			this.miscTableLayoutPanel.AutoScroll = true;
			this.miscTableLayoutPanel.AutoSize = true;
			this.miscTableLayoutPanel.ColumnCount = 3;
			this.miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.miscTableLayoutPanel.Controls.Add(this.forzaPortNumericUpDown, 1, 3);
			this.miscTableLayoutPanel.Controls.Add(this.forzaPortLabel, 0, 3);
			this.miscTableLayoutPanel.Controls.Add(this.dsxPortLabel, 0, 2);
			this.miscTableLayoutPanel.Controls.Add(this.appCheckLabel, 0, 1);
			this.miscTableLayoutPanel.Controls.Add(this.rpmLabel, 0, 0);
			this.miscTableLayoutPanel.Controls.Add(this.rpmTrackBar, 1, 0);
			this.miscTableLayoutPanel.Controls.Add(this.appCheckBox, 1, 1);
			this.miscTableLayoutPanel.Controls.Add(this.dsxNumericUpDown, 1, 2);
			this.miscTableLayoutPanel.Controls.Add(this.rpmValueNumericUpDown, 2, 0);
			this.miscTableLayoutPanel.Controls.Add(this.buttonApplyMisc, 1, 4);
			this.miscTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.miscTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.miscTableLayoutPanel.Name = "miscTableLayoutPanel";
			this.miscTableLayoutPanel.RowCount = 5;
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.miscTableLayoutPanel.Size = new System.Drawing.Size(707, 727);
			this.miscTableLayoutPanel.TabIndex = 0;
			// 
			// forzaPortNumericUpDown
			// 
			this.forzaPortNumericUpDown.AutoSize = true;
			this.forzaPortNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.forzaPortNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.forzaPortNumericUpDown.Location = new System.Drawing.Point(120, 103);
			this.forzaPortNumericUpDown.Maximum = new decimal(new int[] {
            65353,
            0,
            0,
            0});
			this.forzaPortNumericUpDown.MaximumSize = new System.Drawing.Size(100, 0);
			this.forzaPortNumericUpDown.Name = "forzaPortNumericUpDown";
			this.forzaPortNumericUpDown.Size = new System.Drawing.Size(100, 23);
			this.forzaPortNumericUpDown.TabIndex = 7;
			this.toolTip.SetToolTip(this.forzaPortNumericUpDown, "Port for Forza UDP server");
			this.forzaPortNumericUpDown.ValueChanged += new System.EventHandler(this.forzaPortNumericUpDown_ValueChanged);
			// 
			// forzaPortLabel
			// 
			this.forzaPortLabel.AutoSize = true;
			this.forzaPortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.forzaPortLabel.Location = new System.Drawing.Point(3, 100);
			this.forzaPortLabel.Name = "forzaPortLabel";
			this.forzaPortLabel.Size = new System.Drawing.Size(111, 29);
			this.forzaPortLabel.TabIndex = 6;
			this.forzaPortLabel.Text = "Forza Port";
			this.forzaPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.forzaPortLabel, "Port for Forza UDP server");
			// 
			// dsxPortLabel
			// 
			this.dsxPortLabel.AutoSize = true;
			this.dsxPortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dsxPortLabel.Location = new System.Drawing.Point(3, 71);
			this.dsxPortLabel.Name = "dsxPortLabel";
			this.dsxPortLabel.Size = new System.Drawing.Size(111, 29);
			this.dsxPortLabel.TabIndex = 4;
			this.dsxPortLabel.Text = "DSX Port";
			this.dsxPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.dsxPortLabel, "Port for DSX Port Listener");
			// 
			// appCheckLabel
			// 
			this.appCheckLabel.AutoSize = true;
			this.appCheckLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.appCheckLabel.Location = new System.Drawing.Point(3, 51);
			this.appCheckLabel.Name = "appCheckLabel";
			this.appCheckLabel.Size = new System.Drawing.Size(111, 20);
			this.appCheckLabel.TabIndex = 2;
			this.appCheckLabel.Text = "Disable App Check?";
			this.appCheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.appCheckLabel, "Should we disable the check for running applications?");
			// 
			// rpmLabel
			// 
			this.rpmLabel.AutoSize = true;
			this.rpmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpmLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			this.rpmLabel.Location = new System.Drawing.Point(3, 0);
			this.rpmLabel.Name = "rpmLabel";
			this.rpmLabel.Size = new System.Drawing.Size(111, 51);
			this.rpmLabel.TabIndex = 0;
			this.rpmLabel.Text = "RPM Redline Ratio";
			this.rpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.rpmLabel, "The percentage of the current RPM when we are in the \"redline\" of the engine");
			// 
			// rpmTrackBar
			// 
			this.rpmTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.rpmTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
			this.rpmTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpmTrackBar.LargeChange = 50;
			this.rpmTrackBar.Location = new System.Drawing.Point(120, 3);
			this.rpmTrackBar.Maximum = 100;
			this.rpmTrackBar.Name = "rpmTrackBar";
			this.rpmTrackBar.Size = new System.Drawing.Size(415, 45);
			this.rpmTrackBar.TabIndex = 1;
			this.rpmTrackBar.TickFrequency = 5;
			this.rpmTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.rpmTrackBar, "The percentage of the current RPM when we are in the \"redline\" of the engine");
			this.rpmTrackBar.Scroll += new System.EventHandler(this.rpmTrackBar_Scroll);
			// 
			// appCheckBox
			// 
			this.appCheckBox.AutoSize = true;
			this.appCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.appCheckBox.Location = new System.Drawing.Point(120, 54);
			this.appCheckBox.Name = "appCheckBox";
			this.appCheckBox.Size = new System.Drawing.Size(415, 14);
			this.appCheckBox.TabIndex = 3;
			this.toolTip.SetToolTip(this.appCheckBox, "Should we disable the check for running applications?");
			this.appCheckBox.UseVisualStyleBackColor = true;
			this.appCheckBox.CheckedChanged += new System.EventHandler(this.appCheckBox_CheckedChanged);
			// 
			// dsxNumericUpDown
			// 
			this.dsxNumericUpDown.AutoSize = true;
			this.dsxNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.dsxNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dsxNumericUpDown.Location = new System.Drawing.Point(120, 74);
			this.dsxNumericUpDown.Maximum = new decimal(new int[] {
            65353,
            0,
            0,
            0});
			this.dsxNumericUpDown.MaximumSize = new System.Drawing.Size(100, 0);
			this.dsxNumericUpDown.Name = "dsxNumericUpDown";
			this.dsxNumericUpDown.Size = new System.Drawing.Size(100, 23);
			this.dsxNumericUpDown.TabIndex = 5;
			this.toolTip.SetToolTip(this.dsxNumericUpDown, "Port for DSX Port Listener");
			this.dsxNumericUpDown.ValueChanged += new System.EventHandler(this.dsxNumericUpDown_ValueChanged);
			// 
			// rpmValueNumericUpDown
			// 
			this.rpmValueNumericUpDown.AutoSize = true;
			this.rpmValueNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.rpmValueNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpmValueNumericUpDown.Location = new System.Drawing.Point(541, 3);
			this.rpmValueNumericUpDown.Name = "rpmValueNumericUpDown";
			this.rpmValueNumericUpDown.Size = new System.Drawing.Size(163, 23);
			this.rpmValueNumericUpDown.TabIndex = 8;
			this.toolTip.SetToolTip(this.rpmValueNumericUpDown, "The percentage of the current RPM when we are in the \"redline\" of the engine");
			this.rpmValueNumericUpDown.ValueChanged += new System.EventHandler(this.rpmValueNumericUpDown_ValueChanged);
			// 
			// buttonApplyMisc
			// 
			this.buttonApplyMisc.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonApplyMisc.Location = new System.Drawing.Point(120, 132);
			this.buttonApplyMisc.MaximumSize = new System.Drawing.Size(300, 30);
			this.buttonApplyMisc.MinimumSize = new System.Drawing.Size(200, 25);
			this.buttonApplyMisc.Name = "buttonApplyMisc";
			this.buttonApplyMisc.Size = new System.Drawing.Size(300, 25);
			this.buttonApplyMisc.TabIndex = 9;
			this.buttonApplyMisc.Text = "Apply";
			this.buttonApplyMisc.UseVisualStyleBackColor = true;
			this.buttonApplyMisc.Click += new System.EventHandler(this.buttonApplyMisc_Click);
			// 
			// brakeConfigTabPage
			// 
			this.brakeConfigTabPage.Controls.Add(this.brakeTableLayoutPanel);
			this.brakeConfigTabPage.Location = new System.Drawing.Point(4, 24);
			this.brakeConfigTabPage.Name = "brakeConfigTabPage";
			this.brakeConfigTabPage.Size = new System.Drawing.Size(713, 733);
			this.brakeConfigTabPage.TabIndex = 4;
			this.brakeConfigTabPage.Text = "Brake Trigger";
			// 
			// brakeTableLayoutPanel
			// 
			this.brakeTableLayoutPanel.AutoScroll = true;
			this.brakeTableLayoutPanel.AutoSize = true;
			this.brakeTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.brakeTableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeTableLayoutPanel.ColumnCount = 3;
			this.brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.brakeTableLayoutPanel.Controls.Add(this.brakeResistanceSmoothNumericUpDown, 2, 11);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeResistanceNumericUpDown, 2, 10);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeResistanceNumericUpDown, 2, 9);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeStifnessNumericUpDown, 2, 8);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeStifnessNumericUpDown, 2, 7);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationSmoothNumericUpDown, 2, 6);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeVibrationNumericUpDown, 2, 5);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeVibrationNumericUpDown, 2, 4);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationModeNumericUpDown, 2, 3);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationStartNumericUpDown, 2, 2);
			this.brakeTableLayoutPanel.Controls.Add(this.gripLossNumericUpDown, 2, 1);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeEffectNumericUpDown, 2, 0);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeResistanceSmoothingTrackBar, 1, 11);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeResistanceSmoothingLabel, 0, 11);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeResistanceTrackBar, 1, 10);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeResistanceLabel, 0, 10);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeResistanceTrackBar, 1, 9);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeResistanceLabel, 0, 9);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeStiffnessTrackBar, 1, 8);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeStiffnessLabel, 0, 8);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeStiffnessTrackBar, 1, 7);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeStiffnessLabel, 0, 7);
			this.brakeTableLayoutPanel.Controls.Add(this.vibrationSmoothingTrackBar, 1, 6);
			this.brakeTableLayoutPanel.Controls.Add(this.vibrationSmoothingLabel, 0, 6);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeVibrationTrackBar, 1, 5);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeVibrationLabel, 0, 5);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeVibrationTrackBar, 1, 4);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeVibrationLabel, 0, 4);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationModeTrackBar, 1, 3);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationModeStartLabel, 0, 3);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationStartTrackBar, 1, 2);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationStartLabel, 0, 2);
			this.brakeTableLayoutPanel.Controls.Add(this.gripLossTrackBar, 1, 1);
			this.brakeTableLayoutPanel.Controls.Add(this.gripLossLabel, 0, 1);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeEffectIntensityLabel, 0, 0);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeEffectIntensityTrackBar, 1, 0);
			this.brakeTableLayoutPanel.Controls.Add(this.buttonApply_Brake, 1, 12);
			this.brakeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.brakeTableLayoutPanel.Name = "brakeTableLayoutPanel";
			this.brakeTableLayoutPanel.RowCount = 13;
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.brakeTableLayoutPanel.Size = new System.Drawing.Size(713, 733);
			this.brakeTableLayoutPanel.TabIndex = 0;
			// 
			// brakeResistanceSmoothNumericUpDown
			// 
			this.brakeResistanceSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeResistanceSmoothNumericUpDown.AutoSize = true;
			this.brakeResistanceSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeResistanceSmoothNumericUpDown.Location = new System.Drawing.Point(541, 575);
			this.brakeResistanceSmoothNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.brakeResistanceSmoothNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.brakeResistanceSmoothNumericUpDown.Name = "brakeResistanceSmoothNumericUpDown";
			this.brakeResistanceSmoothNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeResistanceSmoothNumericUpDown.TabIndex = 36;
			this.toolTip.SetToolTip(this.brakeResistanceSmoothNumericUpDown, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
			this.brakeResistanceSmoothNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.brakeResistanceSmoothNumericUpDown.ValueChanged += new System.EventHandler(this.brakeResistanceSmoothNumericUpDown_ValueChanged);
			// 
			// maxBrakeResistanceNumericUpDown
			// 
			this.maxBrakeResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.maxBrakeResistanceNumericUpDown.AutoSize = true;
			this.maxBrakeResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.maxBrakeResistanceNumericUpDown.Location = new System.Drawing.Point(541, 524);
			this.maxBrakeResistanceNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.maxBrakeResistanceNumericUpDown.Name = "maxBrakeResistanceNumericUpDown";
			this.maxBrakeResistanceNumericUpDown.Size = new System.Drawing.Size(29, 23);
			this.maxBrakeResistanceNumericUpDown.TabIndex = 35;
			this.toolTip.SetToolTip(this.maxBrakeResistanceNumericUpDown, "The Maximum resistance on the Brake (0-7)");
			this.maxBrakeResistanceNumericUpDown.ValueChanged += new System.EventHandler(this.maxBrakeResistanceNumericUpDown_ValueChanged);
			// 
			// minBrakeResistanceNumericUpDown
			// 
			this.minBrakeResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.minBrakeResistanceNumericUpDown.AutoSize = true;
			this.minBrakeResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.minBrakeResistanceNumericUpDown.Location = new System.Drawing.Point(541, 473);
			this.minBrakeResistanceNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.minBrakeResistanceNumericUpDown.Name = "minBrakeResistanceNumericUpDown";
			this.minBrakeResistanceNumericUpDown.Size = new System.Drawing.Size(29, 23);
			this.minBrakeResistanceNumericUpDown.TabIndex = 34;
			this.toolTip.SetToolTip(this.minBrakeResistanceNumericUpDown, "The Minimum resistance on the Brake (0-7)");
			this.minBrakeResistanceNumericUpDown.ValueChanged += new System.EventHandler(this.minBrakeResistanceNumericUpDown_ValueChanged);
			// 
			// maxBrakeStifnessNumericUpDown
			// 
			this.maxBrakeStifnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.maxBrakeStifnessNumericUpDown.AutoSize = true;
			this.maxBrakeStifnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.maxBrakeStifnessNumericUpDown.Location = new System.Drawing.Point(541, 422);
			this.maxBrakeStifnessNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.maxBrakeStifnessNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxBrakeStifnessNumericUpDown.Name = "maxBrakeStifnessNumericUpDown";
			this.maxBrakeStifnessNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.maxBrakeStifnessNumericUpDown.TabIndex = 33;
			this.toolTip.SetToolTip(this.maxBrakeStifnessNumericUpDown, "On a scale of 1-255 with 1 being most stiff");
			this.maxBrakeStifnessNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxBrakeStifnessNumericUpDown.ValueChanged += new System.EventHandler(this.maxBrakeStifnessNumericUpDown_ValueChanged);
			// 
			// minBrakeStifnessNumericUpDown
			// 
			this.minBrakeStifnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.minBrakeStifnessNumericUpDown.AutoSize = true;
			this.minBrakeStifnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.minBrakeStifnessNumericUpDown.Location = new System.Drawing.Point(541, 371);
			this.minBrakeStifnessNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.minBrakeStifnessNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.minBrakeStifnessNumericUpDown.Name = "minBrakeStifnessNumericUpDown";
			this.minBrakeStifnessNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.minBrakeStifnessNumericUpDown.TabIndex = 32;
			this.toolTip.SetToolTip(this.minBrakeStifnessNumericUpDown, "On a scale of 1-255 with 1 being most stiff");
			this.minBrakeStifnessNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.minBrakeStifnessNumericUpDown.ValueChanged += new System.EventHandler(this.minBrakeStifnessNumericUpDown_ValueChanged);
			// 
			// brakeVibrationSmoothNumericUpDown
			// 
			this.brakeVibrationSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeVibrationSmoothNumericUpDown.AutoSize = true;
			this.brakeVibrationSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeVibrationSmoothNumericUpDown.Location = new System.Drawing.Point(541, 320);
			this.brakeVibrationSmoothNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.brakeVibrationSmoothNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.brakeVibrationSmoothNumericUpDown.Name = "brakeVibrationSmoothNumericUpDown";
			this.brakeVibrationSmoothNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeVibrationSmoothNumericUpDown.TabIndex = 31;
			this.toolTip.SetToolTip(this.brakeVibrationSmoothNumericUpDown, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
			this.brakeVibrationSmoothNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.brakeVibrationSmoothNumericUpDown.ValueChanged += new System.EventHandler(this.brakeVibrationSmoothNumericUpDown_ValueChanged);
			// 
			// maxBrakeVibrationNumericUpDown
			// 
			this.maxBrakeVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.maxBrakeVibrationNumericUpDown.AutoSize = true;
			this.maxBrakeVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.maxBrakeVibrationNumericUpDown.Location = new System.Drawing.Point(541, 269);
			this.maxBrakeVibrationNumericUpDown.Name = "maxBrakeVibrationNumericUpDown";
			this.maxBrakeVibrationNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.maxBrakeVibrationNumericUpDown.TabIndex = 30;
			this.toolTip.SetToolTip(this.maxBrakeVibrationNumericUpDown, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
			this.maxBrakeVibrationNumericUpDown.ValueChanged += new System.EventHandler(this.maxBrakeVibrationNumericUpDown_ValueChanged);
			// 
			// minBrakeVibrationNumericUpDown
			// 
			this.minBrakeVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.minBrakeVibrationNumericUpDown.AutoSize = true;
			this.minBrakeVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.minBrakeVibrationNumericUpDown.Location = new System.Drawing.Point(541, 218);
			this.minBrakeVibrationNumericUpDown.Name = "minBrakeVibrationNumericUpDown";
			this.minBrakeVibrationNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.minBrakeVibrationNumericUpDown.TabIndex = 29;
			this.toolTip.SetToolTip(this.minBrakeVibrationNumericUpDown, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in contro" +
        "ller");
			this.minBrakeVibrationNumericUpDown.ValueChanged += new System.EventHandler(this.minBrakeVibrationNumericUpDown_ValueChanged);
			// 
			// brakeVibrationModeNumericUpDown
			// 
			this.brakeVibrationModeNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeVibrationModeNumericUpDown.AutoSize = true;
			this.brakeVibrationModeNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeVibrationModeNumericUpDown.Location = new System.Drawing.Point(541, 167);
			this.brakeVibrationModeNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.brakeVibrationModeNumericUpDown.Name = "brakeVibrationModeNumericUpDown";
			this.brakeVibrationModeNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeVibrationModeNumericUpDown.TabIndex = 28;
			this.toolTip.SetToolTip(this.brakeVibrationModeNumericUpDown, "The depression of the brake lever at which the program should switch to vibration" +
        " mode rather than smooth resistance. This helps to avoid clicking as vibration m" +
        "ode clicks when no force is applied. ");
			this.brakeVibrationModeNumericUpDown.ValueChanged += new System.EventHandler(this.brakeVibrationModeNumericUpDown_ValueChanged);
			// 
			// brakeVibrationStartNumericUpDown
			// 
			this.brakeVibrationStartNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeVibrationStartNumericUpDown.AutoSize = true;
			this.brakeVibrationStartNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeVibrationStartNumericUpDown.Location = new System.Drawing.Point(541, 116);
			this.brakeVibrationStartNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.brakeVibrationStartNumericUpDown.Name = "brakeVibrationStartNumericUpDown";
			this.brakeVibrationStartNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeVibrationStartNumericUpDown.TabIndex = 27;
			this.toolTip.SetToolTip(this.brakeVibrationStartNumericUpDown, "The position in the Trigger (0-255) at which the brake should feel engaged with l" +
        "ow grip surfaces");
			this.brakeVibrationStartNumericUpDown.ValueChanged += new System.EventHandler(this.brakeVibrationStartNumericUpDown_ValueChanged);
			// 
			// gripLossNumericUpDown
			// 
			this.gripLossNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.gripLossNumericUpDown.AutoSize = true;
			this.gripLossNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.gripLossNumericUpDown.Location = new System.Drawing.Point(541, 65);
			this.gripLossNumericUpDown.Name = "gripLossNumericUpDown";
			this.gripLossNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.gripLossNumericUpDown.TabIndex = 26;
			this.toolTip.SetToolTip(this.gripLossNumericUpDown, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no" +
        " grip)");
			this.gripLossNumericUpDown.ValueChanged += new System.EventHandler(this.gripLossNumericUpDown_ValueChanged);
			// 
			// brakeEffectNumericUpDown
			// 
			this.brakeEffectNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeEffectNumericUpDown.AutoSize = true;
			this.brakeEffectNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeEffectNumericUpDown.Location = new System.Drawing.Point(541, 14);
			this.brakeEffectNumericUpDown.Name = "brakeEffectNumericUpDown";
			this.brakeEffectNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeEffectNumericUpDown.TabIndex = 2;
			this.toolTip.SetToolTip(this.brakeEffectNumericUpDown, "The percentage of the current RPM when we are in the \"redline\" of the engine");
			this.brakeEffectNumericUpDown.ValueChanged += new System.EventHandler(this.brakeEffectNumericUpDown_ValueChanged);
			// 
			// brakeResistanceSmoothingTrackBar
			// 
			this.brakeResistanceSmoothingTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeResistanceSmoothingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeResistanceSmoothingTrackBar.LargeChange = 50;
			this.brakeResistanceSmoothingTrackBar.Location = new System.Drawing.Point(133, 564);
			this.brakeResistanceSmoothingTrackBar.Maximum = 500;
			this.brakeResistanceSmoothingTrackBar.Minimum = 1;
			this.brakeResistanceSmoothingTrackBar.Name = "brakeResistanceSmoothingTrackBar";
			this.brakeResistanceSmoothingTrackBar.Size = new System.Drawing.Size(402, 45);
			this.brakeResistanceSmoothingTrackBar.TabIndex = 23;
			this.brakeResistanceSmoothingTrackBar.TickFrequency = 10;
			this.brakeResistanceSmoothingTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.brakeResistanceSmoothingTrackBar, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
			this.brakeResistanceSmoothingTrackBar.Value = 1;
			this.brakeResistanceSmoothingTrackBar.Scroll += new System.EventHandler(this.brakeResistanceSmoothingTrackBar_Scroll);
			// 
			// brakeResistanceSmoothingLabel
			// 
			this.brakeResistanceSmoothingLabel.AutoSize = true;
			this.brakeResistanceSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeResistanceSmoothingLabel.Location = new System.Drawing.Point(3, 561);
			this.brakeResistanceSmoothingLabel.Name = "brakeResistanceSmoothingLabel";
			this.brakeResistanceSmoothingLabel.Size = new System.Drawing.Size(124, 51);
			this.brakeResistanceSmoothingLabel.TabIndex = 22;
			this.brakeResistanceSmoothingLabel.Text = "Resistance Smoothing";
			this.brakeResistanceSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.brakeResistanceSmoothingLabel, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
			// 
			// maxBrakeResistanceTrackBar
			// 
			this.maxBrakeResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.maxBrakeResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeResistanceTrackBar.LargeChange = 50;
			this.maxBrakeResistanceTrackBar.Location = new System.Drawing.Point(133, 513);
			this.maxBrakeResistanceTrackBar.Maximum = 7;
			this.maxBrakeResistanceTrackBar.Name = "maxBrakeResistanceTrackBar";
			this.maxBrakeResistanceTrackBar.Size = new System.Drawing.Size(402, 45);
			this.maxBrakeResistanceTrackBar.TabIndex = 21;
			this.maxBrakeResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.maxBrakeResistanceTrackBar, "The Maximum resistance on the Brake (0-7)");
			this.maxBrakeResistanceTrackBar.Scroll += new System.EventHandler(this.maxBrakeResistanceTrackBar_Scroll);
			// 
			// maxBrakeResistanceLabel
			// 
			this.maxBrakeResistanceLabel.AutoSize = true;
			this.maxBrakeResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeResistanceLabel.Location = new System.Drawing.Point(3, 510);
			this.maxBrakeResistanceLabel.Name = "maxBrakeResistanceLabel";
			this.maxBrakeResistanceLabel.Size = new System.Drawing.Size(124, 51);
			this.maxBrakeResistanceLabel.TabIndex = 20;
			this.maxBrakeResistanceLabel.Text = "Max Resistance";
			this.maxBrakeResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxBrakeResistanceLabel, "The Maximum resistance on the Brake (0-7)");
			// 
			// minBrakeResistanceTrackBar
			// 
			this.minBrakeResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.minBrakeResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeResistanceTrackBar.LargeChange = 50;
			this.minBrakeResistanceTrackBar.Location = new System.Drawing.Point(133, 462);
			this.minBrakeResistanceTrackBar.Maximum = 7;
			this.minBrakeResistanceTrackBar.Name = "minBrakeResistanceTrackBar";
			this.minBrakeResistanceTrackBar.Size = new System.Drawing.Size(402, 45);
			this.minBrakeResistanceTrackBar.TabIndex = 19;
			this.minBrakeResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.minBrakeResistanceTrackBar, "The Minimum resistance on the Brake (0-7)");
			this.minBrakeResistanceTrackBar.Scroll += new System.EventHandler(this.minBrakeResistanceTrackBar_Scroll);
			// 
			// minBrakeResistanceLabel
			// 
			this.minBrakeResistanceLabel.AutoSize = true;
			this.minBrakeResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeResistanceLabel.Location = new System.Drawing.Point(3, 459);
			this.minBrakeResistanceLabel.Name = "minBrakeResistanceLabel";
			this.minBrakeResistanceLabel.Size = new System.Drawing.Size(124, 51);
			this.minBrakeResistanceLabel.TabIndex = 18;
			this.minBrakeResistanceLabel.Text = "Min Resistance";
			this.minBrakeResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minBrakeResistanceLabel, "The Minimum resistance on the Brake (0-7)");
			// 
			// maxBrakeStiffnessTrackBar
			// 
			this.maxBrakeStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.maxBrakeStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeStiffnessTrackBar.LargeChange = 50;
			this.maxBrakeStiffnessTrackBar.Location = new System.Drawing.Point(133, 411);
			this.maxBrakeStiffnessTrackBar.Maximum = 255;
			this.maxBrakeStiffnessTrackBar.Minimum = 1;
			this.maxBrakeStiffnessTrackBar.Name = "maxBrakeStiffnessTrackBar";
			this.maxBrakeStiffnessTrackBar.Size = new System.Drawing.Size(402, 45);
			this.maxBrakeStiffnessTrackBar.TabIndex = 17;
			this.maxBrakeStiffnessTrackBar.TickFrequency = 5;
			this.maxBrakeStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.maxBrakeStiffnessTrackBar, "On a scale of 1-255 with 1 being most stiff");
			this.maxBrakeStiffnessTrackBar.Value = 1;
			this.maxBrakeStiffnessTrackBar.Scroll += new System.EventHandler(this.maxBrakeStiffnessTrackBar_Scroll);
			// 
			// maxBrakeStiffnessLabel
			// 
			this.maxBrakeStiffnessLabel.AutoSize = true;
			this.maxBrakeStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeStiffnessLabel.Location = new System.Drawing.Point(3, 408);
			this.maxBrakeStiffnessLabel.Name = "maxBrakeStiffnessLabel";
			this.maxBrakeStiffnessLabel.Size = new System.Drawing.Size(124, 51);
			this.maxBrakeStiffnessLabel.TabIndex = 16;
			this.maxBrakeStiffnessLabel.Text = "Max Stiffness";
			this.maxBrakeStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxBrakeStiffnessLabel, "On a scale of 1-255 with 1 being most stiff");
			// 
			// minBrakeStiffnessTrackBar
			// 
			this.minBrakeStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.minBrakeStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeStiffnessTrackBar.LargeChange = 50;
			this.minBrakeStiffnessTrackBar.Location = new System.Drawing.Point(133, 360);
			this.minBrakeStiffnessTrackBar.Maximum = 255;
			this.minBrakeStiffnessTrackBar.Minimum = 1;
			this.minBrakeStiffnessTrackBar.Name = "minBrakeStiffnessTrackBar";
			this.minBrakeStiffnessTrackBar.Size = new System.Drawing.Size(402, 45);
			this.minBrakeStiffnessTrackBar.TabIndex = 15;
			this.minBrakeStiffnessTrackBar.TickFrequency = 5;
			this.minBrakeStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.minBrakeStiffnessTrackBar, "On a scale of 1-255 with 1 being most stiff");
			this.minBrakeStiffnessTrackBar.Value = 1;
			this.minBrakeStiffnessTrackBar.Scroll += new System.EventHandler(this.minBrakeStiffnessTrackBar_Scroll);
			// 
			// minBrakeStiffnessLabel
			// 
			this.minBrakeStiffnessLabel.AutoSize = true;
			this.minBrakeStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeStiffnessLabel.Location = new System.Drawing.Point(3, 357);
			this.minBrakeStiffnessLabel.Name = "minBrakeStiffnessLabel";
			this.minBrakeStiffnessLabel.Size = new System.Drawing.Size(124, 51);
			this.minBrakeStiffnessLabel.TabIndex = 14;
			this.minBrakeStiffnessLabel.Text = "Min Stifness";
			this.minBrakeStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minBrakeStiffnessLabel, "On a scale of 1-255 with 1 being most stiff");
			// 
			// vibrationSmoothingTrackBar
			// 
			this.vibrationSmoothingTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.vibrationSmoothingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vibrationSmoothingTrackBar.LargeChange = 50;
			this.vibrationSmoothingTrackBar.Location = new System.Drawing.Point(133, 309);
			this.vibrationSmoothingTrackBar.Maximum = 500;
			this.vibrationSmoothingTrackBar.Minimum = 1;
			this.vibrationSmoothingTrackBar.Name = "vibrationSmoothingTrackBar";
			this.vibrationSmoothingTrackBar.Size = new System.Drawing.Size(402, 45);
			this.vibrationSmoothingTrackBar.TabIndex = 13;
			this.vibrationSmoothingTrackBar.TickFrequency = 10;
			this.vibrationSmoothingTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.vibrationSmoothingTrackBar, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
			this.vibrationSmoothingTrackBar.Value = 1;
			this.vibrationSmoothingTrackBar.Scroll += new System.EventHandler(this.vibrationSmoothingTrackBar_Scroll);
			// 
			// vibrationSmoothingLabel
			// 
			this.vibrationSmoothingLabel.AutoSize = true;
			this.vibrationSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vibrationSmoothingLabel.Location = new System.Drawing.Point(3, 306);
			this.vibrationSmoothingLabel.Name = "vibrationSmoothingLabel";
			this.vibrationSmoothingLabel.Size = new System.Drawing.Size(124, 51);
			this.vibrationSmoothingLabel.TabIndex = 12;
			this.vibrationSmoothingLabel.Text = "Vibration Smoothing";
			this.vibrationSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.vibrationSmoothingLabel, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
			// 
			// maxBrakeVibrationTrackBar
			// 
			this.maxBrakeVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.maxBrakeVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeVibrationTrackBar.LargeChange = 50;
			this.maxBrakeVibrationTrackBar.Location = new System.Drawing.Point(133, 258);
			this.maxBrakeVibrationTrackBar.Maximum = 100;
			this.maxBrakeVibrationTrackBar.Name = "maxBrakeVibrationTrackBar";
			this.maxBrakeVibrationTrackBar.Size = new System.Drawing.Size(402, 45);
			this.maxBrakeVibrationTrackBar.TabIndex = 11;
			this.maxBrakeVibrationTrackBar.TickFrequency = 5;
			this.maxBrakeVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.maxBrakeVibrationTrackBar, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
			this.maxBrakeVibrationTrackBar.Scroll += new System.EventHandler(this.maxBrakeVibrationTrackBar_Scroll);
			// 
			// maxBrakeVibrationLabel
			// 
			this.maxBrakeVibrationLabel.AutoSize = true;
			this.maxBrakeVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeVibrationLabel.Location = new System.Drawing.Point(3, 255);
			this.maxBrakeVibrationLabel.Name = "maxBrakeVibrationLabel";
			this.maxBrakeVibrationLabel.Size = new System.Drawing.Size(124, 51);
			this.maxBrakeVibrationLabel.TabIndex = 10;
			this.maxBrakeVibrationLabel.Text = "Max Brake Vibration";
			this.maxBrakeVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxBrakeVibrationLabel, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
			// 
			// minBrakeVibrationTrackBar
			// 
			this.minBrakeVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.minBrakeVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeVibrationTrackBar.LargeChange = 50;
			this.minBrakeVibrationTrackBar.Location = new System.Drawing.Point(133, 207);
			this.minBrakeVibrationTrackBar.Maximum = 100;
			this.minBrakeVibrationTrackBar.Name = "minBrakeVibrationTrackBar";
			this.minBrakeVibrationTrackBar.Size = new System.Drawing.Size(402, 45);
			this.minBrakeVibrationTrackBar.TabIndex = 9;
			this.minBrakeVibrationTrackBar.TickFrequency = 5;
			this.minBrakeVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.minBrakeVibrationTrackBar, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in contro" +
        "ller");
			this.minBrakeVibrationTrackBar.Scroll += new System.EventHandler(this.minBrakeVibrationTrackBar_Scroll);
			// 
			// minBrakeVibrationLabel
			// 
			this.minBrakeVibrationLabel.AutoSize = true;
			this.minBrakeVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeVibrationLabel.Location = new System.Drawing.Point(3, 204);
			this.minBrakeVibrationLabel.Name = "minBrakeVibrationLabel";
			this.minBrakeVibrationLabel.Size = new System.Drawing.Size(124, 51);
			this.minBrakeVibrationLabel.TabIndex = 8;
			this.minBrakeVibrationLabel.Text = "Min Brake Vibration";
			this.minBrakeVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minBrakeVibrationLabel, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in contro" +
        "ller");
			// 
			// brakeVibrationModeTrackBar
			// 
			this.brakeVibrationModeTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeVibrationModeTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeVibrationModeTrackBar.LargeChange = 50;
			this.brakeVibrationModeTrackBar.Location = new System.Drawing.Point(133, 156);
			this.brakeVibrationModeTrackBar.Maximum = 255;
			this.brakeVibrationModeTrackBar.Name = "brakeVibrationModeTrackBar";
			this.brakeVibrationModeTrackBar.Size = new System.Drawing.Size(402, 45);
			this.brakeVibrationModeTrackBar.TabIndex = 7;
			this.brakeVibrationModeTrackBar.TickFrequency = 5;
			this.brakeVibrationModeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.brakeVibrationModeTrackBar, "The depression of the brake lever at which the program should switch to vibration" +
        " mode rather than smooth resistance. This helps to avoid clicking as vibration m" +
        "ode clicks when no force is applied. ");
			this.brakeVibrationModeTrackBar.Scroll += new System.EventHandler(this.brakeVibrationModeTrackBar_Scroll);
			// 
			// brakeVibrationModeStartLabel
			// 
			this.brakeVibrationModeStartLabel.AutoSize = true;
			this.brakeVibrationModeStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeVibrationModeStartLabel.Location = new System.Drawing.Point(3, 153);
			this.brakeVibrationModeStartLabel.Name = "brakeVibrationModeStartLabel";
			this.brakeVibrationModeStartLabel.Size = new System.Drawing.Size(124, 51);
			this.brakeVibrationModeStartLabel.TabIndex = 6;
			this.brakeVibrationModeStartLabel.Text = "Vibration Mode Start";
			this.brakeVibrationModeStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.brakeVibrationModeStartLabel, "The depression of the brake lever at which the program should switch to vibration" +
        " mode rather than smooth resistance. This helps to avoid clicking as vibration m" +
        "ode clicks when no force is applied. ");
			// 
			// brakeVibrationStartTrackBar
			// 
			this.brakeVibrationStartTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeVibrationStartTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeVibrationStartTrackBar.LargeChange = 50;
			this.brakeVibrationStartTrackBar.Location = new System.Drawing.Point(133, 105);
			this.brakeVibrationStartTrackBar.Maximum = 255;
			this.brakeVibrationStartTrackBar.Name = "brakeVibrationStartTrackBar";
			this.brakeVibrationStartTrackBar.Size = new System.Drawing.Size(402, 45);
			this.brakeVibrationStartTrackBar.TabIndex = 5;
			this.brakeVibrationStartTrackBar.TickFrequency = 5;
			this.brakeVibrationStartTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.brakeVibrationStartTrackBar, "The position in the Trigger (0-255) at which the brake should feel engaged with l" +
        "ow grip surfaces");
			this.brakeVibrationStartTrackBar.Scroll += new System.EventHandler(this.brakeVibrationStartTrackBar_Scroll);
			// 
			// brakeVibrationStartLabel
			// 
			this.brakeVibrationStartLabel.AutoSize = true;
			this.brakeVibrationStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeVibrationStartLabel.Location = new System.Drawing.Point(3, 102);
			this.brakeVibrationStartLabel.Name = "brakeVibrationStartLabel";
			this.brakeVibrationStartLabel.Size = new System.Drawing.Size(124, 51);
			this.brakeVibrationStartLabel.TabIndex = 4;
			this.brakeVibrationStartLabel.Text = "Vibration Start";
			this.brakeVibrationStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.brakeVibrationStartLabel, "The position in the Trigger (0-255) at which the brake should feel engaged with l" +
        "ow grip surfaces");
			// 
			// gripLossTrackBar
			// 
			this.gripLossTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.gripLossTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gripLossTrackBar.Location = new System.Drawing.Point(133, 54);
			this.gripLossTrackBar.Maximum = 100;
			this.gripLossTrackBar.Name = "gripLossTrackBar";
			this.gripLossTrackBar.Size = new System.Drawing.Size(402, 45);
			this.gripLossTrackBar.TabIndex = 3;
			this.gripLossTrackBar.TickFrequency = 5;
			this.gripLossTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.gripLossTrackBar, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no" +
        " grip)");
			this.gripLossTrackBar.Value = 50;
			this.gripLossTrackBar.Scroll += new System.EventHandler(this.gripLossTrackBar_Scroll);
			// 
			// gripLossLabel
			// 
			this.gripLossLabel.AutoSize = true;
			this.gripLossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gripLossLabel.Location = new System.Drawing.Point(3, 51);
			this.gripLossLabel.Name = "gripLossLabel";
			this.gripLossLabel.Size = new System.Drawing.Size(124, 51);
			this.gripLossLabel.TabIndex = 2;
			this.gripLossLabel.Text = "Grip Loss Value";
			this.gripLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.gripLossLabel, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no" +
        " grip)");
			// 
			// brakeEffectIntensityLabel
			// 
			this.brakeEffectIntensityLabel.AutoSize = true;
			this.brakeEffectIntensityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeEffectIntensityLabel.Location = new System.Drawing.Point(3, 0);
			this.brakeEffectIntensityLabel.Name = "brakeEffectIntensityLabel";
			this.brakeEffectIntensityLabel.Size = new System.Drawing.Size(124, 51);
			this.brakeEffectIntensityLabel.TabIndex = 0;
			this.brakeEffectIntensityLabel.Text = "Effect Intensity";
			this.brakeEffectIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.brakeEffectIntensityLabel, "The percentage of the trigger effects");
			// 
			// brakeEffectIntensityTrackBar
			// 
			this.brakeEffectIntensityTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeEffectIntensityTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeEffectIntensityTrackBar.LargeChange = 10;
			this.brakeEffectIntensityTrackBar.Location = new System.Drawing.Point(133, 3);
			this.brakeEffectIntensityTrackBar.Maximum = 100;
			this.brakeEffectIntensityTrackBar.Name = "brakeEffectIntensityTrackBar";
			this.brakeEffectIntensityTrackBar.Size = new System.Drawing.Size(402, 45);
			this.brakeEffectIntensityTrackBar.TabIndex = 1;
			this.brakeEffectIntensityTrackBar.TickFrequency = 5;
			this.brakeEffectIntensityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.brakeEffectIntensityTrackBar, "The percentage of the trigger effects");
			this.brakeEffectIntensityTrackBar.Value = 100;
			this.brakeEffectIntensityTrackBar.Scroll += new System.EventHandler(this.brakeEffectIntensityTrackBar_Scroll);
			// 
			// buttonApply_Brake
			// 
			this.buttonApply_Brake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply_Brake.Location = new System.Drawing.Point(133, 615);
			this.buttonApply_Brake.Name = "buttonApply_Brake";
			this.buttonApply_Brake.Size = new System.Drawing.Size(402, 22);
			this.buttonApply_Brake.TabIndex = 37;
			this.buttonApply_Brake.Text = "Apply";
			this.buttonApply_Brake.UseVisualStyleBackColor = true;
			this.buttonApply_Brake.Click += new System.EventHandler(this.buttonApply_Brake_Click);
			// 
			// throttleConfigTabPage
			// 
			this.throttleConfigTabPage.Controls.Add(this.throttleTableLayoutPanel);
			this.throttleConfigTabPage.Location = new System.Drawing.Point(4, 24);
			this.throttleConfigTabPage.Name = "throttleConfigTabPage";
			this.throttleConfigTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.throttleConfigTabPage.Size = new System.Drawing.Size(713, 733);
			this.throttleConfigTabPage.TabIndex = 2;
			this.throttleConfigTabPage.Text = "Throttle Trigger";
			this.throttleConfigTabPage.UseVisualStyleBackColor = true;
			// 
			// throttleTableLayoutPanel
			// 
			this.throttleTableLayoutPanel.AutoScroll = true;
			this.throttleTableLayoutPanel.ColumnCount = 3;
			this.throttleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.throttleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.throttleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.throttleTableLayoutPanel.Controls.Add(this.throttleResistanceSmoothNumericUpDown, 2, 13);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMaxResistanceNumericUpDown, 2, 12);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMinResistanceNumericUpDown, 2, 11);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMaxStiffnessNumericUpDown, 2, 10);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMinStiffnessNumericUpDown, 2, 9);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleVibrationSmoothNumericUpDown, 2, 8);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMaxVibrationNumericUpDown, 2, 7);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMinVibrationNumericUpDown, 2, 6);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleVibrationStartNumericUpDown, 2, 5);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleAccelLimitNumericUpDown, 2, 4);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleForwardAccelScaleNumericUpDown, 2, 3);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleTurnAccelScaleNumericUpDown, 2, 2);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleGripLossNumericUpDown, 2, 1);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleIntensityNumericUpDown, 2, 0);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleResistanceSmoothTrackBar, 1, 13);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMaxResistanceTrackBar, 1, 12);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMinResistanceTrackBar, 1, 11);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMaxStiffnessTrackBar, 1, 10);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMinStiffnessTrackBar, 1, 9);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleVibrationSmoothTrackBar, 1, 8);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMaxVibrationTrackBar, 1, 7);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleMinVibrationTrackBar, 1, 6);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleVibrationModeStartTrackBar, 1, 5);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleAccelLimitTrackBar, 1, 4);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleForwardAccelScaleTrackBar, 1, 3);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleTurnAccelScaleTrackBar, 1, 2);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleGripLossTrackBar, 1, 1);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleIntensityTrackBar, 1, 0);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleResistanceSmoothingLabel, 0, 13);
			this.throttleTableLayoutPanel.Controls.Add(this.maxThrottleResistanceLabel, 0, 12);
			this.throttleTableLayoutPanel.Controls.Add(this.minThrottleResistanceLabel, 0, 11);
			this.throttleTableLayoutPanel.Controls.Add(this.maxThrottleStiffnessLabel, 0, 10);
			this.throttleTableLayoutPanel.Controls.Add(this.minThrottleStiffnessLabel, 0, 9);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleVibrationSmoothingLabel, 0, 8);
			this.throttleTableLayoutPanel.Controls.Add(this.maxThrottleVibrationLabel, 0, 7);
			this.throttleTableLayoutPanel.Controls.Add(this.minThrottleVibrationLabel, 0, 6);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleVibrationStartLabel, 0, 5);
			this.throttleTableLayoutPanel.Controls.Add(this.accelerationLimitLabel, 0, 4);
			this.throttleTableLayoutPanel.Controls.Add(this.forwardAccelLabel, 0, 3);
			this.throttleTableLayoutPanel.Controls.Add(this.turnAccelLabel, 0, 2);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleGripLossLabel, 0, 1);
			this.throttleTableLayoutPanel.Controls.Add(this.throttleIntensityLabel, 0, 0);
			this.throttleTableLayoutPanel.Controls.Add(this.buttonApply_Throttle, 1, 14);
			this.throttleTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.throttleTableLayoutPanel.Name = "throttleTableLayoutPanel";
			this.throttleTableLayoutPanel.RowCount = 15;
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.throttleTableLayoutPanel.Size = new System.Drawing.Size(707, 727);
			this.throttleTableLayoutPanel.TabIndex = 0;
			// 
			// throttleResistanceSmoothNumericUpDown
			// 
			this.throttleResistanceSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleResistanceSmoothNumericUpDown.AutoSize = true;
			this.throttleResistanceSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleResistanceSmoothNumericUpDown.Location = new System.Drawing.Point(549, 677);
			this.throttleResistanceSmoothNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.throttleResistanceSmoothNumericUpDown.Name = "throttleResistanceSmoothNumericUpDown";
			this.throttleResistanceSmoothNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleResistanceSmoothNumericUpDown.TabIndex = 42;
			this.toolTip.SetToolTip(this.throttleResistanceSmoothNumericUpDown, "Smoothing for Throttle Resistance output. Lower = smoother. Must be greater than " +
        "0");
			this.throttleResistanceSmoothNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.throttleResistanceSmoothNumericUpDown.ValueChanged += new System.EventHandler(this.throttleResistanceSmoothNumericUpDown_ValueChanged);
			// 
			// throttleMaxResistanceNumericUpDown
			// 
			this.throttleMaxResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleMaxResistanceNumericUpDown.AutoSize = true;
			this.throttleMaxResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleMaxResistanceNumericUpDown.Location = new System.Drawing.Point(549, 626);
			this.throttleMaxResistanceNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.throttleMaxResistanceNumericUpDown.Name = "throttleMaxResistanceNumericUpDown";
			this.throttleMaxResistanceNumericUpDown.Size = new System.Drawing.Size(29, 23);
			this.throttleMaxResistanceNumericUpDown.TabIndex = 41;
			this.toolTip.SetToolTip(this.throttleMaxResistanceNumericUpDown, "The Maximum resistance on the throttle (0-7)");
			this.throttleMaxResistanceNumericUpDown.ValueChanged += new System.EventHandler(this.throttleMaxResistanceNumericUpDown_ValueChanged);
			// 
			// throttleMinResistanceNumericUpDown
			// 
			this.throttleMinResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleMinResistanceNumericUpDown.AutoSize = true;
			this.throttleMinResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleMinResistanceNumericUpDown.Location = new System.Drawing.Point(549, 575);
			this.throttleMinResistanceNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.throttleMinResistanceNumericUpDown.Name = "throttleMinResistanceNumericUpDown";
			this.throttleMinResistanceNumericUpDown.Size = new System.Drawing.Size(29, 23);
			this.throttleMinResistanceNumericUpDown.TabIndex = 40;
			this.toolTip.SetToolTip(this.throttleMinResistanceNumericUpDown, "The Minimum resistance on the throttle (0-7)");
			this.throttleMinResistanceNumericUpDown.ValueChanged += new System.EventHandler(this.throttleMinResistanceNumericUpDown_ValueChanged);
			// 
			// throttleMaxStiffnessNumericUpDown
			// 
			this.throttleMaxStiffnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleMaxStiffnessNumericUpDown.AutoSize = true;
			this.throttleMaxStiffnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleMaxStiffnessNumericUpDown.Location = new System.Drawing.Point(549, 524);
			this.throttleMaxStiffnessNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.throttleMaxStiffnessNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.throttleMaxStiffnessNumericUpDown.Name = "throttleMaxStiffnessNumericUpDown";
			this.throttleMaxStiffnessNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleMaxStiffnessNumericUpDown.TabIndex = 39;
			this.toolTip.SetToolTip(this.throttleMaxStiffnessNumericUpDown, "On a scale of 1-255 with 1 being most stiff");
			this.throttleMaxStiffnessNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.throttleMaxStiffnessNumericUpDown.ValueChanged += new System.EventHandler(this.throttleMaxStiffnessNumericUpDown_ValueChanged);
			// 
			// throttleMinStiffnessNumericUpDown
			// 
			this.throttleMinStiffnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleMinStiffnessNumericUpDown.AutoSize = true;
			this.throttleMinStiffnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleMinStiffnessNumericUpDown.Location = new System.Drawing.Point(549, 473);
			this.throttleMinStiffnessNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.throttleMinStiffnessNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.throttleMinStiffnessNumericUpDown.Name = "throttleMinStiffnessNumericUpDown";
			this.throttleMinStiffnessNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleMinStiffnessNumericUpDown.TabIndex = 38;
			this.toolTip.SetToolTip(this.throttleMinStiffnessNumericUpDown, "On a scale of 1-255 with 1 being most stiff");
			this.throttleMinStiffnessNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.throttleMinStiffnessNumericUpDown.ValueChanged += new System.EventHandler(this.throttleMinStiffnessNumericUpDown_ValueChanged);
			// 
			// throttleVibrationSmoothNumericUpDown
			// 
			this.throttleVibrationSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleVibrationSmoothNumericUpDown.AutoSize = true;
			this.throttleVibrationSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleVibrationSmoothNumericUpDown.Location = new System.Drawing.Point(549, 422);
			this.throttleVibrationSmoothNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.throttleVibrationSmoothNumericUpDown.Name = "throttleVibrationSmoothNumericUpDown";
			this.throttleVibrationSmoothNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleVibrationSmoothNumericUpDown.TabIndex = 37;
			this.toolTip.SetToolTip(this.throttleVibrationSmoothNumericUpDown, "Smoothing for Throttle Vibration output. Lower = smoother. Must be greater than 0" +
        "");
			this.throttleVibrationSmoothNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.throttleVibrationSmoothNumericUpDown.ValueChanged += new System.EventHandler(this.throttleVibrationSmoothNumericUpDown_ValueChanged);
			// 
			// throttleMaxVibrationNumericUpDown
			// 
			this.throttleMaxVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleMaxVibrationNumericUpDown.AutoSize = true;
			this.throttleMaxVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleMaxVibrationNumericUpDown.Location = new System.Drawing.Point(549, 371);
			this.throttleMaxVibrationNumericUpDown.Name = "throttleMaxVibrationNumericUpDown";
			this.throttleMaxVibrationNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleMaxVibrationNumericUpDown.TabIndex = 36;
			this.toolTip.SetToolTip(this.throttleMaxVibrationNumericUpDown, "The maximum acceleration frequency in Hz (avoid over 40). Correlates to better gr" +
        "ip");
			this.throttleMaxVibrationNumericUpDown.ValueChanged += new System.EventHandler(this.throttleMaxVibrationNumericUpDown_ValueChanged);
			// 
			// throttleMinVibrationNumericUpDown
			// 
			this.throttleMinVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleMinVibrationNumericUpDown.AutoSize = true;
			this.throttleMinVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleMinVibrationNumericUpDown.Location = new System.Drawing.Point(549, 320);
			this.throttleMinVibrationNumericUpDown.Name = "throttleMinVibrationNumericUpDown";
			this.throttleMinVibrationNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleMinVibrationNumericUpDown.TabIndex = 35;
			this.toolTip.SetToolTip(this.throttleMinVibrationNumericUpDown, "The minimum acceleration frequency in Hz (avoid over 40). Helps avoid clicking in" +
        " controller");
			this.throttleMinVibrationNumericUpDown.ValueChanged += new System.EventHandler(this.throttleMinVibrationNumericUpDown_ValueChanged);
			// 
			// throttleVibrationStartNumericUpDown
			// 
			this.throttleVibrationStartNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleVibrationStartNumericUpDown.AutoSize = true;
			this.throttleVibrationStartNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleVibrationStartNumericUpDown.Location = new System.Drawing.Point(549, 269);
			this.throttleVibrationStartNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.throttleVibrationStartNumericUpDown.Name = "throttleVibrationStartNumericUpDown";
			this.throttleVibrationStartNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleVibrationStartNumericUpDown.TabIndex = 34;
			this.toolTip.SetToolTip(this.throttleVibrationStartNumericUpDown, "The depression of the throttle lever at which the program should switch to vibrat" +
        "ion mode rather than smooth resistance. This helps to avoid clicking as vibratio" +
        "n mode clicks when no force is applied.");
			this.throttleVibrationStartNumericUpDown.ValueChanged += new System.EventHandler(this.throttleVibrationStartNumericUpDown_ValueChanged);
			// 
			// throttleAccelLimitNumericUpDown
			// 
			this.throttleAccelLimitNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleAccelLimitNumericUpDown.AutoSize = true;
			this.throttleAccelLimitNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleAccelLimitNumericUpDown.Location = new System.Drawing.Point(549, 218);
			this.throttleAccelLimitNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.throttleAccelLimitNumericUpDown.Name = "throttleAccelLimitNumericUpDown";
			this.throttleAccelLimitNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleAccelLimitNumericUpDown.TabIndex = 33;
			this.toolTip.SetToolTip(this.throttleAccelLimitNumericUpDown, "The upper end acceleration when calculating the throttle resistance. Any accelera" +
        "tion above this will be counted as this value when determining the throttle resi" +
        "stance.");
			this.throttleAccelLimitNumericUpDown.ValueChanged += new System.EventHandler(this.throttleAccelLimitNumericUpDown_ValueChanged);
			// 
			// throttleForwardAccelScaleNumericUpDown
			// 
			this.throttleForwardAccelScaleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleForwardAccelScaleNumericUpDown.AutoSize = true;
			this.throttleForwardAccelScaleNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleForwardAccelScaleNumericUpDown.Location = new System.Drawing.Point(549, 167);
			this.throttleForwardAccelScaleNumericUpDown.Name = "throttleForwardAccelScaleNumericUpDown";
			this.throttleForwardAccelScaleNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleForwardAccelScaleNumericUpDown.TabIndex = 32;
			this.toolTip.SetToolTip(this.throttleForwardAccelScaleNumericUpDown, "How to scale Forward acceleration in determining throttle stiffness.");
			this.throttleForwardAccelScaleNumericUpDown.ValueChanged += new System.EventHandler(this.throttleForwardAccelScaleNumericUpDown_ValueChanged);
			// 
			// throttleTurnAccelScaleNumericUpDown
			// 
			this.throttleTurnAccelScaleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleTurnAccelScaleNumericUpDown.AutoSize = true;
			this.throttleTurnAccelScaleNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleTurnAccelScaleNumericUpDown.Location = new System.Drawing.Point(549, 116);
			this.throttleTurnAccelScaleNumericUpDown.Name = "throttleTurnAccelScaleNumericUpDown";
			this.throttleTurnAccelScaleNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleTurnAccelScaleNumericUpDown.TabIndex = 31;
			this.toolTip.SetToolTip(this.throttleTurnAccelScaleNumericUpDown, "How to scale turning acceleration in determining throttle stiffness.");
			this.throttleTurnAccelScaleNumericUpDown.ValueChanged += new System.EventHandler(this.throttleTurnAccelScaleNumericUpDown_ValueChanged);
			// 
			// throttleGripLossNumericUpDown
			// 
			this.throttleGripLossNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleGripLossNumericUpDown.AutoSize = true;
			this.throttleGripLossNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleGripLossNumericUpDown.Location = new System.Drawing.Point(549, 65);
			this.throttleGripLossNumericUpDown.Name = "throttleGripLossNumericUpDown";
			this.throttleGripLossNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleGripLossNumericUpDown.TabIndex = 30;
			this.toolTip.SetToolTip(this.throttleGripLossNumericUpDown, "The point at which the throttle will begin to become choppy (0 = full grip, 100 =" +
        " no grip)");
			this.throttleGripLossNumericUpDown.ValueChanged += new System.EventHandler(this.throttleGripLossNumericUpDown_ValueChanged);
			// 
			// throttleIntensityNumericUpDown
			// 
			this.throttleIntensityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.throttleIntensityNumericUpDown.AutoSize = true;
			this.throttleIntensityNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.throttleIntensityNumericUpDown.Location = new System.Drawing.Point(549, 14);
			this.throttleIntensityNumericUpDown.Name = "throttleIntensityNumericUpDown";
			this.throttleIntensityNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.throttleIntensityNumericUpDown.TabIndex = 29;
			this.toolTip.SetToolTip(this.throttleIntensityNumericUpDown, "The percentage of the trigger effects");
			this.throttleIntensityNumericUpDown.ValueChanged += new System.EventHandler(this.throttleIntensityNumericUpDown_ValueChanged);
			// 
			// throttleResistanceSmoothTrackBar
			// 
			this.throttleResistanceSmoothTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleResistanceSmoothTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleResistanceSmoothTrackBar.LargeChange = 50;
			this.throttleResistanceSmoothTrackBar.Location = new System.Drawing.Point(141, 666);
			this.throttleResistanceSmoothTrackBar.Maximum = 100;
			this.throttleResistanceSmoothTrackBar.Minimum = 1;
			this.throttleResistanceSmoothTrackBar.Name = "throttleResistanceSmoothTrackBar";
			this.throttleResistanceSmoothTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleResistanceSmoothTrackBar.TabIndex = 28;
			this.throttleResistanceSmoothTrackBar.TickFrequency = 10;
			this.throttleResistanceSmoothTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleResistanceSmoothTrackBar, "Smoothing for Throttle Resistance output. Lower = smoother. Must be greater than " +
        "0");
			this.throttleResistanceSmoothTrackBar.Value = 1;
			this.throttleResistanceSmoothTrackBar.Scroll += new System.EventHandler(this.throttleResistanceSmoothTrackBar_Scroll);
			// 
			// throttleMaxResistanceTrackBar
			// 
			this.throttleMaxResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleMaxResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleMaxResistanceTrackBar.LargeChange = 50;
			this.throttleMaxResistanceTrackBar.Location = new System.Drawing.Point(141, 615);
			this.throttleMaxResistanceTrackBar.Maximum = 7;
			this.throttleMaxResistanceTrackBar.Name = "throttleMaxResistanceTrackBar";
			this.throttleMaxResistanceTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleMaxResistanceTrackBar.TabIndex = 27;
			this.throttleMaxResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleMaxResistanceTrackBar, "The Maximum resistance on the throttle (0-7)");
			this.throttleMaxResistanceTrackBar.Scroll += new System.EventHandler(this.throttleMaxResistanceTrackBar_Scroll);
			// 
			// throttleMinResistanceTrackBar
			// 
			this.throttleMinResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleMinResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleMinResistanceTrackBar.LargeChange = 50;
			this.throttleMinResistanceTrackBar.Location = new System.Drawing.Point(141, 564);
			this.throttleMinResistanceTrackBar.Maximum = 7;
			this.throttleMinResistanceTrackBar.Name = "throttleMinResistanceTrackBar";
			this.throttleMinResistanceTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleMinResistanceTrackBar.TabIndex = 26;
			this.throttleMinResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleMinResistanceTrackBar, "The Minimum resistance on the throttle (0-7)");
			this.throttleMinResistanceTrackBar.Scroll += new System.EventHandler(this.throttleMinResistanceTrackBar_Scroll);
			// 
			// throttleMaxStiffnessTrackBar
			// 
			this.throttleMaxStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleMaxStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleMaxStiffnessTrackBar.LargeChange = 50;
			this.throttleMaxStiffnessTrackBar.Location = new System.Drawing.Point(141, 513);
			this.throttleMaxStiffnessTrackBar.Maximum = 255;
			this.throttleMaxStiffnessTrackBar.Minimum = 1;
			this.throttleMaxStiffnessTrackBar.Name = "throttleMaxStiffnessTrackBar";
			this.throttleMaxStiffnessTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleMaxStiffnessTrackBar.TabIndex = 25;
			this.throttleMaxStiffnessTrackBar.TickFrequency = 5;
			this.throttleMaxStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleMaxStiffnessTrackBar, "On a scale of 1-255 with 1 being most stiff");
			this.throttleMaxStiffnessTrackBar.Value = 1;
			this.throttleMaxStiffnessTrackBar.Scroll += new System.EventHandler(this.throttleMaxStiffnessTrackBar_Scroll);
			// 
			// throttleMinStiffnessTrackBar
			// 
			this.throttleMinStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleMinStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleMinStiffnessTrackBar.LargeChange = 50;
			this.throttleMinStiffnessTrackBar.Location = new System.Drawing.Point(141, 462);
			this.throttleMinStiffnessTrackBar.Maximum = 255;
			this.throttleMinStiffnessTrackBar.Minimum = 1;
			this.throttleMinStiffnessTrackBar.Name = "throttleMinStiffnessTrackBar";
			this.throttleMinStiffnessTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleMinStiffnessTrackBar.TabIndex = 24;
			this.throttleMinStiffnessTrackBar.TickFrequency = 5;
			this.throttleMinStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleMinStiffnessTrackBar, "On a scale of 1-255 with 1 being most stiff");
			this.throttleMinStiffnessTrackBar.Value = 1;
			this.throttleMinStiffnessTrackBar.Scroll += new System.EventHandler(this.throttleMinStiffnessTrackBar_Scroll);
			// 
			// throttleVibrationSmoothTrackBar
			// 
			this.throttleVibrationSmoothTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleVibrationSmoothTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleVibrationSmoothTrackBar.LargeChange = 50;
			this.throttleVibrationSmoothTrackBar.Location = new System.Drawing.Point(141, 411);
			this.throttleVibrationSmoothTrackBar.Maximum = 100;
			this.throttleVibrationSmoothTrackBar.Minimum = 1;
			this.throttleVibrationSmoothTrackBar.Name = "throttleVibrationSmoothTrackBar";
			this.throttleVibrationSmoothTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleVibrationSmoothTrackBar.TabIndex = 23;
			this.throttleVibrationSmoothTrackBar.TickFrequency = 10;
			this.throttleVibrationSmoothTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleVibrationSmoothTrackBar, "Smoothing for Throttle Vibration output. Lower = smoother. Must be greater than 0" +
        "");
			this.throttleVibrationSmoothTrackBar.Value = 1;
			this.throttleVibrationSmoothTrackBar.Scroll += new System.EventHandler(this.throttleVibrationSmoothTrackBar_Scroll);
			// 
			// throttleMaxVibrationTrackBar
			// 
			this.throttleMaxVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleMaxVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleMaxVibrationTrackBar.LargeChange = 50;
			this.throttleMaxVibrationTrackBar.Location = new System.Drawing.Point(141, 360);
			this.throttleMaxVibrationTrackBar.Maximum = 100;
			this.throttleMaxVibrationTrackBar.Name = "throttleMaxVibrationTrackBar";
			this.throttleMaxVibrationTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleMaxVibrationTrackBar.TabIndex = 22;
			this.throttleMaxVibrationTrackBar.TickFrequency = 5;
			this.throttleMaxVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleMaxVibrationTrackBar, "The maximum acceleration frequency in Hz (avoid over 40). Correlates to better gr" +
        "ip");
			this.throttleMaxVibrationTrackBar.Scroll += new System.EventHandler(this.throttleMaxVibrationTrackBar_Scroll);
			// 
			// throttleMinVibrationTrackBar
			// 
			this.throttleMinVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleMinVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleMinVibrationTrackBar.LargeChange = 50;
			this.throttleMinVibrationTrackBar.Location = new System.Drawing.Point(141, 309);
			this.throttleMinVibrationTrackBar.Maximum = 100;
			this.throttleMinVibrationTrackBar.Name = "throttleMinVibrationTrackBar";
			this.throttleMinVibrationTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleMinVibrationTrackBar.TabIndex = 21;
			this.throttleMinVibrationTrackBar.TickFrequency = 5;
			this.throttleMinVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleMinVibrationTrackBar, "The minimum acceleration frequency in Hz (avoid over 40). Helps avoid clicking in" +
        " controller");
			this.throttleMinVibrationTrackBar.Scroll += new System.EventHandler(this.throttleMinVibrationTrackBar_Scroll);
			// 
			// throttleVibrationModeStartTrackBar
			// 
			this.throttleVibrationModeStartTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleVibrationModeStartTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleVibrationModeStartTrackBar.LargeChange = 50;
			this.throttleVibrationModeStartTrackBar.Location = new System.Drawing.Point(141, 258);
			this.throttleVibrationModeStartTrackBar.Maximum = 255;
			this.throttleVibrationModeStartTrackBar.Name = "throttleVibrationModeStartTrackBar";
			this.throttleVibrationModeStartTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleVibrationModeStartTrackBar.TabIndex = 20;
			this.throttleVibrationModeStartTrackBar.TickFrequency = 5;
			this.throttleVibrationModeStartTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleVibrationModeStartTrackBar, "The depression of the throttle lever at which the program should switch to vibrat" +
        "ion mode rather than smooth resistance. This helps to avoid clicking as vibratio" +
        "n mode clicks when no force is applied.");
			this.throttleVibrationModeStartTrackBar.Scroll += new System.EventHandler(this.throttleVibrationModeStartTrackBar_Scroll);
			// 
			// throttleAccelLimitTrackBar
			// 
			this.throttleAccelLimitTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleAccelLimitTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleAccelLimitTrackBar.LargeChange = 50;
			this.throttleAccelLimitTrackBar.Location = new System.Drawing.Point(141, 207);
			this.throttleAccelLimitTrackBar.Maximum = 255;
			this.throttleAccelLimitTrackBar.Name = "throttleAccelLimitTrackBar";
			this.throttleAccelLimitTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleAccelLimitTrackBar.TabIndex = 19;
			this.throttleAccelLimitTrackBar.TickFrequency = 5;
			this.throttleAccelLimitTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleAccelLimitTrackBar, "The upper end acceleration when calculating the throttle resistance. Any accelera" +
        "tion above this will be counted as this value when determining the throttle resi" +
        "stance.");
			this.throttleAccelLimitTrackBar.Scroll += new System.EventHandler(this.throttleAccelLimitTrackBar_Scroll);
			// 
			// throttleForwardAccelScaleTrackBar
			// 
			this.throttleForwardAccelScaleTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleForwardAccelScaleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleForwardAccelScaleTrackBar.Location = new System.Drawing.Point(141, 156);
			this.throttleForwardAccelScaleTrackBar.Maximum = 100;
			this.throttleForwardAccelScaleTrackBar.Name = "throttleForwardAccelScaleTrackBar";
			this.throttleForwardAccelScaleTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleForwardAccelScaleTrackBar.TabIndex = 18;
			this.throttleForwardAccelScaleTrackBar.TickFrequency = 5;
			this.throttleForwardAccelScaleTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleForwardAccelScaleTrackBar, "How to scale Forward acceleration in determining throttle stiffness.");
			this.throttleForwardAccelScaleTrackBar.Value = 50;
			this.throttleForwardAccelScaleTrackBar.Scroll += new System.EventHandler(this.throttleForwardAccelScaleTrackBar_Scroll);
			// 
			// throttleTurnAccelScaleTrackBar
			// 
			this.throttleTurnAccelScaleTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleTurnAccelScaleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleTurnAccelScaleTrackBar.Location = new System.Drawing.Point(141, 105);
			this.throttleTurnAccelScaleTrackBar.Maximum = 100;
			this.throttleTurnAccelScaleTrackBar.Name = "throttleTurnAccelScaleTrackBar";
			this.throttleTurnAccelScaleTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleTurnAccelScaleTrackBar.TabIndex = 17;
			this.throttleTurnAccelScaleTrackBar.TickFrequency = 5;
			this.throttleTurnAccelScaleTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleTurnAccelScaleTrackBar, "How to scale turning acceleration in determining throttle stiffness.");
			this.throttleTurnAccelScaleTrackBar.Value = 50;
			this.throttleTurnAccelScaleTrackBar.Scroll += new System.EventHandler(this.throttleTurnAccelScaleTrackBar_Scroll);
			// 
			// throttleGripLossTrackBar
			// 
			this.throttleGripLossTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleGripLossTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleGripLossTrackBar.LargeChange = 50;
			this.throttleGripLossTrackBar.Location = new System.Drawing.Point(141, 54);
			this.throttleGripLossTrackBar.Maximum = 100;
			this.throttleGripLossTrackBar.Name = "throttleGripLossTrackBar";
			this.throttleGripLossTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleGripLossTrackBar.TabIndex = 16;
			this.throttleGripLossTrackBar.TickFrequency = 5;
			this.throttleGripLossTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleGripLossTrackBar, "The point at which the throttle will begin to become choppy (0 = full grip, 100 =" +
        " no grip)");
			this.throttleGripLossTrackBar.Scroll += new System.EventHandler(this.throttleGripLossTrackBar_Scroll);
			// 
			// throttleIntensityTrackBar
			// 
			this.throttleIntensityTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.throttleIntensityTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleIntensityTrackBar.LargeChange = 10;
			this.throttleIntensityTrackBar.Location = new System.Drawing.Point(141, 3);
			this.throttleIntensityTrackBar.Maximum = 100;
			this.throttleIntensityTrackBar.Name = "throttleIntensityTrackBar";
			this.throttleIntensityTrackBar.Size = new System.Drawing.Size(402, 45);
			this.throttleIntensityTrackBar.TabIndex = 2;
			this.throttleIntensityTrackBar.TickFrequency = 5;
			this.throttleIntensityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.throttleIntensityTrackBar, "The percentage of the trigger effects");
			this.throttleIntensityTrackBar.Value = 100;
			this.throttleIntensityTrackBar.Scroll += new System.EventHandler(this.throttleIntensityTrackBar_Scroll);
			// 
			// throttleResistanceSmoothingLabel
			// 
			this.throttleResistanceSmoothingLabel.AutoSize = true;
			this.throttleResistanceSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleResistanceSmoothingLabel.Location = new System.Drawing.Point(3, 663);
			this.throttleResistanceSmoothingLabel.Name = "throttleResistanceSmoothingLabel";
			this.throttleResistanceSmoothingLabel.Size = new System.Drawing.Size(132, 51);
			this.throttleResistanceSmoothingLabel.TabIndex = 15;
			this.throttleResistanceSmoothingLabel.Text = "Resistance Smoothing";
			this.throttleResistanceSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.throttleResistanceSmoothingLabel, "Smoothing for Throttle Resistance output. Lower = smoother. Must be greater than " +
        "0");
			// 
			// maxThrottleResistanceLabel
			// 
			this.maxThrottleResistanceLabel.AutoSize = true;
			this.maxThrottleResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxThrottleResistanceLabel.Location = new System.Drawing.Point(3, 612);
			this.maxThrottleResistanceLabel.Name = "maxThrottleResistanceLabel";
			this.maxThrottleResistanceLabel.Size = new System.Drawing.Size(132, 51);
			this.maxThrottleResistanceLabel.TabIndex = 14;
			this.maxThrottleResistanceLabel.Text = "Max Throttle Resistance";
			this.maxThrottleResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxThrottleResistanceLabel, "The Maximum resistance on the throttle (0-7)");
			// 
			// minThrottleResistanceLabel
			// 
			this.minThrottleResistanceLabel.AutoSize = true;
			this.minThrottleResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minThrottleResistanceLabel.Location = new System.Drawing.Point(3, 561);
			this.minThrottleResistanceLabel.Name = "minThrottleResistanceLabel";
			this.minThrottleResistanceLabel.Size = new System.Drawing.Size(132, 51);
			this.minThrottleResistanceLabel.TabIndex = 13;
			this.minThrottleResistanceLabel.Text = "Min Throttle Resistance";
			this.minThrottleResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minThrottleResistanceLabel, "The Minimum resistance on the throttle (0-7)");
			// 
			// maxThrottleStiffnessLabel
			// 
			this.maxThrottleStiffnessLabel.AutoSize = true;
			this.maxThrottleStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxThrottleStiffnessLabel.Location = new System.Drawing.Point(3, 510);
			this.maxThrottleStiffnessLabel.Name = "maxThrottleStiffnessLabel";
			this.maxThrottleStiffnessLabel.Size = new System.Drawing.Size(132, 51);
			this.maxThrottleStiffnessLabel.TabIndex = 12;
			this.maxThrottleStiffnessLabel.Text = "Max Throttle Stiffness";
			this.maxThrottleStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxThrottleStiffnessLabel, "On a scale of 1-255 with 1 being most stiff");
			// 
			// minThrottleStiffnessLabel
			// 
			this.minThrottleStiffnessLabel.AutoSize = true;
			this.minThrottleStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minThrottleStiffnessLabel.Location = new System.Drawing.Point(3, 459);
			this.minThrottleStiffnessLabel.Name = "minThrottleStiffnessLabel";
			this.minThrottleStiffnessLabel.Size = new System.Drawing.Size(132, 51);
			this.minThrottleStiffnessLabel.TabIndex = 11;
			this.minThrottleStiffnessLabel.Text = "Min Throttle Stiffness";
			this.minThrottleStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minThrottleStiffnessLabel, "On a scale of 1-255 with 1 being most stiff");
			// 
			// throttleVibrationSmoothingLabel
			// 
			this.throttleVibrationSmoothingLabel.AutoSize = true;
			this.throttleVibrationSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleVibrationSmoothingLabel.Location = new System.Drawing.Point(3, 408);
			this.throttleVibrationSmoothingLabel.Name = "throttleVibrationSmoothingLabel";
			this.throttleVibrationSmoothingLabel.Size = new System.Drawing.Size(132, 51);
			this.throttleVibrationSmoothingLabel.TabIndex = 10;
			this.throttleVibrationSmoothingLabel.Text = "Vibration Smoothing";
			this.throttleVibrationSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.throttleVibrationSmoothingLabel, "Smoothing for Throttle Vibration output. Lower = smoother. Must be greater than 0" +
        "");
			// 
			// maxThrottleVibrationLabel
			// 
			this.maxThrottleVibrationLabel.AutoSize = true;
			this.maxThrottleVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxThrottleVibrationLabel.Location = new System.Drawing.Point(3, 357);
			this.maxThrottleVibrationLabel.Name = "maxThrottleVibrationLabel";
			this.maxThrottleVibrationLabel.Size = new System.Drawing.Size(132, 51);
			this.maxThrottleVibrationLabel.TabIndex = 9;
			this.maxThrottleVibrationLabel.Text = "Max Throttle Vibration";
			this.maxThrottleVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxThrottleVibrationLabel, "The maximum acceleration frequency in Hz (avoid over 40). Correlates to better gr" +
        "ip");
			// 
			// minThrottleVibrationLabel
			// 
			this.minThrottleVibrationLabel.AutoSize = true;
			this.minThrottleVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minThrottleVibrationLabel.Location = new System.Drawing.Point(3, 306);
			this.minThrottleVibrationLabel.Name = "minThrottleVibrationLabel";
			this.minThrottleVibrationLabel.Size = new System.Drawing.Size(132, 51);
			this.minThrottleVibrationLabel.TabIndex = 8;
			this.minThrottleVibrationLabel.Text = "Min Throttle Vibration";
			this.minThrottleVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minThrottleVibrationLabel, "The minimum acceleration frequency in Hz (avoid over 40). Helps avoid clicking in" +
        " controller");
			// 
			// throttleVibrationStartLabel
			// 
			this.throttleVibrationStartLabel.AutoSize = true;
			this.throttleVibrationStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleVibrationStartLabel.Location = new System.Drawing.Point(3, 255);
			this.throttleVibrationStartLabel.Name = "throttleVibrationStartLabel";
			this.throttleVibrationStartLabel.Size = new System.Drawing.Size(132, 51);
			this.throttleVibrationStartLabel.TabIndex = 7;
			this.throttleVibrationStartLabel.Text = "Vibration Mode Start";
			this.throttleVibrationStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.throttleVibrationStartLabel, "The depression of the throttle lever at which the program should switch to vibrat" +
        "ion mode rather than smooth resistance. This helps to avoid clicking as vibratio" +
        "n mode clicks when no force is applied.");
			// 
			// accelerationLimitLabel
			// 
			this.accelerationLimitLabel.AutoSize = true;
			this.accelerationLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accelerationLimitLabel.Location = new System.Drawing.Point(3, 204);
			this.accelerationLimitLabel.Name = "accelerationLimitLabel";
			this.accelerationLimitLabel.Size = new System.Drawing.Size(132, 51);
			this.accelerationLimitLabel.TabIndex = 5;
			this.accelerationLimitLabel.Text = "Accel Limit";
			this.accelerationLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.accelerationLimitLabel, "The upper end acceleration when calculating the throttle resistance. Any accelera" +
        "tion above this will be counted as this value when determining the throttle resi" +
        "stance.");
			// 
			// forwardAccelLabel
			// 
			this.forwardAccelLabel.AutoSize = true;
			this.forwardAccelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.forwardAccelLabel.Location = new System.Drawing.Point(3, 153);
			this.forwardAccelLabel.Name = "forwardAccelLabel";
			this.forwardAccelLabel.Size = new System.Drawing.Size(132, 51);
			this.forwardAccelLabel.TabIndex = 6;
			this.forwardAccelLabel.Text = "Forward Accel Scale";
			this.forwardAccelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.forwardAccelLabel, "How to scale Forward acceleration in determining throttle stiffness.");
			// 
			// turnAccelLabel
			// 
			this.turnAccelLabel.AutoSize = true;
			this.turnAccelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.turnAccelLabel.Location = new System.Drawing.Point(3, 102);
			this.turnAccelLabel.Name = "turnAccelLabel";
			this.turnAccelLabel.Size = new System.Drawing.Size(132, 51);
			this.turnAccelLabel.TabIndex = 4;
			this.turnAccelLabel.Text = "Turn Accel Scale";
			this.turnAccelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.turnAccelLabel, "How to scale turning acceleration in determining throttle stiffness.");
			// 
			// throttleGripLossLabel
			// 
			this.throttleGripLossLabel.AutoSize = true;
			this.throttleGripLossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleGripLossLabel.Location = new System.Drawing.Point(3, 51);
			this.throttleGripLossLabel.Name = "throttleGripLossLabel";
			this.throttleGripLossLabel.Size = new System.Drawing.Size(132, 51);
			this.throttleGripLossLabel.TabIndex = 3;
			this.throttleGripLossLabel.Text = "Grip Loss Value";
			this.throttleGripLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.throttleGripLossLabel, "The point at which the throttle will begin to become choppy (0 = full grip, 100 =" +
        " no grip)");
			// 
			// throttleIntensityLabel
			// 
			this.throttleIntensityLabel.AutoSize = true;
			this.throttleIntensityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.throttleIntensityLabel.Location = new System.Drawing.Point(3, 0);
			this.throttleIntensityLabel.Name = "throttleIntensityLabel";
			this.throttleIntensityLabel.Size = new System.Drawing.Size(132, 51);
			this.throttleIntensityLabel.TabIndex = 1;
			this.throttleIntensityLabel.Text = "Effect Intensity";
			this.throttleIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.throttleIntensityLabel, "The percentage of the trigger effects");
			// 
			// buttonApply_Throttle
			// 
			this.buttonApply_Throttle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply_Throttle.Location = new System.Drawing.Point(141, 717);
			this.buttonApply_Throttle.Name = "buttonApply_Throttle";
			this.buttonApply_Throttle.Size = new System.Drawing.Size(402, 23);
			this.buttonApply_Throttle.TabIndex = 43;
			this.buttonApply_Throttle.Text = "Apply";
			this.buttonApply_Throttle.UseVisualStyleBackColor = true;
			this.buttonApply_Throttle.Click += new System.EventHandler(this.buttonApply_Throttle_Click);
			// 
			// outputTabPage
			// 
			this.outputTabPage.Controls.Add(this.raceGroupBox);
			this.outputTabPage.Controls.Add(this.noRaceGroupBox);
			this.outputTabPage.Controls.Add(this.outputListBox);
			this.outputTabPage.Location = new System.Drawing.Point(4, 24);
			this.outputTabPage.Name = "outputTabPage";
			this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.outputTabPage.Size = new System.Drawing.Size(713, 733);
			this.outputTabPage.TabIndex = 1;
			this.outputTabPage.Text = "Output";
			this.outputTabPage.UseVisualStyleBackColor = true;
			// 
			// raceGroupBox
			// 
			this.raceGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.raceGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.raceGroupBox.Location = new System.Drawing.Point(3, 530);
			this.raceGroupBox.Name = "raceGroupBox";
			this.raceGroupBox.Size = new System.Drawing.Size(707, 100);
			this.raceGroupBox.TabIndex = 3;
			this.raceGroupBox.TabStop = false;
			this.raceGroupBox.Text = "Racing";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.brakeMsg, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.brakeVibrationMsg, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.throttleMsg, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.throttleVibrationMsg, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 78);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// brakeMsg
			// 
			this.brakeMsg.AutoSize = true;
			this.brakeMsg.Location = new System.Drawing.Point(3, 45);
			this.brakeMsg.Name = "brakeMsg";
			this.brakeMsg.Size = new System.Drawing.Size(38, 15);
			this.brakeMsg.TabIndex = 3;
			this.brakeMsg.Text = "label1";
			// 
			// brakeVibrationMsg
			// 
			this.brakeVibrationMsg.AutoSize = true;
			this.brakeVibrationMsg.Location = new System.Drawing.Point(3, 30);
			this.brakeVibrationMsg.Name = "brakeVibrationMsg";
			this.brakeVibrationMsg.Size = new System.Drawing.Size(38, 15);
			this.brakeVibrationMsg.TabIndex = 2;
			this.brakeVibrationMsg.Text = "label1";
			// 
			// throttleMsg
			// 
			this.throttleMsg.AutoSize = true;
			this.throttleMsg.Location = new System.Drawing.Point(3, 15);
			this.throttleMsg.Name = "throttleMsg";
			this.throttleMsg.Size = new System.Drawing.Size(38, 15);
			this.throttleMsg.TabIndex = 1;
			this.throttleMsg.Text = "label1";
			// 
			// throttleVibrationMsg
			// 
			this.throttleVibrationMsg.AutoSize = true;
			this.throttleVibrationMsg.Location = new System.Drawing.Point(3, 0);
			this.throttleVibrationMsg.Name = "throttleVibrationMsg";
			this.throttleVibrationMsg.Size = new System.Drawing.Size(38, 15);
			this.throttleVibrationMsg.TabIndex = 0;
			this.throttleVibrationMsg.Text = "label1";
			// 
			// noRaceGroupBox
			// 
			this.noRaceGroupBox.Controls.Add(this.noRaceText);
			this.noRaceGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.noRaceGroupBox.Location = new System.Drawing.Point(3, 630);
			this.noRaceGroupBox.Name = "noRaceGroupBox";
			this.noRaceGroupBox.Size = new System.Drawing.Size(707, 100);
			this.noRaceGroupBox.TabIndex = 2;
			this.noRaceGroupBox.TabStop = false;
			this.noRaceGroupBox.Text = "Menus";
			// 
			// noRaceText
			// 
			this.noRaceText.AutoSize = true;
			this.noRaceText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.noRaceText.Location = new System.Drawing.Point(3, 19);
			this.noRaceText.Name = "noRaceText";
			this.noRaceText.Size = new System.Drawing.Size(38, 15);
			this.noRaceText.TabIndex = 1;
			this.noRaceText.Text = "label1";
			// 
			// outputListBox
			// 
			this.outputListBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.outputListBox.FormattingEnabled = true;
			this.outputListBox.ItemHeight = 15;
			this.outputListBox.Location = new System.Drawing.Point(3, 3);
			this.outputListBox.Name = "outputListBox";
			this.outputListBox.Size = new System.Drawing.Size(707, 634);
			this.outputListBox.TabIndex = 0;
			// 
			// toolStripStatusDSX
			// 
			this.toolStripStatusDSX.Image = global::ForzaDSX.Properties.Resources.redBtn;
			this.toolStripStatusDSX.Name = "toolStripStatusDSX";
			this.toolStripStatusDSX.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusDSX.Text = "DSX Connection:";
			this.toolStripStatusDSX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// toolStripStatusForza
			// 
			this.toolStripStatusForza.Image = global::ForzaDSX.Properties.Resources.redBtn;
			this.toolStripStatusForza.Name = "toolStripStatusForza";
			this.toolStripStatusForza.Size = new System.Drawing.Size(119, 17);
			this.toolStripStatusForza.Text = "Forza Connection:";
			this.toolStripStatusForza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// toolStripVerboseMode
			// 
			this.toolStripVerboseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripVerboseMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verboseModeOffToolStripMenuItem,
            this.verboseModeLowToolStripMenuItem,
            this.verboseModeFullToolStripMenuItem});
			this.toolStripVerboseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripVerboseMode.Name = "toolStripVerboseMode";
			this.toolStripVerboseMode.Size = new System.Drawing.Size(95, 20);
			this.toolStripVerboseMode.Text = "Verbose Mode";
			// 
			// verboseModeOffToolStripMenuItem
			// 
			this.verboseModeOffToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.verboseModeOffToolStripMenuItem.Name = "verboseModeOffToolStripMenuItem";
			this.verboseModeOffToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.verboseModeOffToolStripMenuItem.Text = "Off";
			this.verboseModeOffToolStripMenuItem.Click += new System.EventHandler(this.verboseModeOffToolStripMenuItem_Click);
			// 
			// verboseModeLowToolStripMenuItem
			// 
			this.verboseModeLowToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.verboseModeLowToolStripMenuItem.Name = "verboseModeLowToolStripMenuItem";
			this.verboseModeLowToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.verboseModeLowToolStripMenuItem.Text = "Low Verbose";
			this.verboseModeLowToolStripMenuItem.Click += new System.EventHandler(this.verboseModeLowToolStripMenuItem_Click);
			// 
			// verboseModeFullToolStripMenuItem
			// 
			this.verboseModeFullToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.verboseModeFullToolStripMenuItem.Name = "verboseModeFullToolStripMenuItem";
			this.verboseModeFullToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.verboseModeFullToolStripMenuItem.Text = "Full Verbose";
			this.verboseModeFullToolStripMenuItem.Click += new System.EventHandler(this.verboseModeFullToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusDSX,
            this.toolStripStatusForza,
            this.toolStripVerboseMode});
			this.statusStrip1.Location = new System.Drawing.Point(0, 761);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(721, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// UI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 783);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.statusStrip1);
			this.DoubleBuffered = true;
			this.MinimumSize = new System.Drawing.Size(350, 200);
			this.Name = "UI";
			this.Text = "UI";
			this.Load += new System.EventHandler(this.UI_Load);
			this.mainPanel.ResumeLayout(false);
			this.mainTabControl.ResumeLayout(false);
			this.miscTabPage.ResumeLayout(false);
			this.miscTabPage.PerformLayout();
			this.miscTableLayoutPanel.ResumeLayout(false);
			this.miscTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.forzaPortNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpmTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsxNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpmValueNumericUpDown)).EndInit();
			this.brakeConfigTabPage.ResumeLayout(false);
			this.brakeConfigTabPage.PerformLayout();
			this.brakeTableLayoutPanel.ResumeLayout(false);
			this.brakeTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.brakeResistanceSmoothNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeResistanceNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeResistanceNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeStifnessNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeStifnessNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationSmoothNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeVibrationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeVibrationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationModeNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationStartNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gripLossNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeEffectNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeResistanceSmoothingTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeResistanceTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeResistanceTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeStiffnessTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeStiffnessTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vibrationSmoothingTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeVibrationTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeVibrationTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationModeTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationStartTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gripLossTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeEffectIntensityTrackBar)).EndInit();
			this.throttleConfigTabPage.ResumeLayout(false);
			this.throttleTableLayoutPanel.ResumeLayout(false);
			this.throttleTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.throttleResistanceSmoothNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxResistanceNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinResistanceNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxStiffnessNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinStiffnessNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleVibrationSmoothNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxVibrationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinVibrationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleVibrationStartNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleAccelLimitNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleForwardAccelScaleNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleTurnAccelScaleNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleGripLossNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleIntensityNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleResistanceSmoothTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxResistanceTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinResistanceTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxStiffnessTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinStiffnessTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleVibrationSmoothTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMaxVibrationTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleMinVibrationTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleVibrationModeStartTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleAccelLimitTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleForwardAccelScaleTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleTurnAccelScaleTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleGripLossTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.throttleIntensityTrackBar)).EndInit();
			this.outputTabPage.ResumeLayout(false);
			this.raceGroupBox.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.noRaceGroupBox.ResumeLayout(false);
			this.noRaceGroupBox.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		//private System.ComponentModel.BackgroundWorker mainWorker;
		//private System.ComponentModel.BackgroundWorker connectionWorker;
        private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage brakeConfigTabPage;
		private System.Windows.Forms.TabPage outputTabPage;
		private System.Windows.Forms.ListBox outputListBox;
		private System.Windows.Forms.TabPage throttleConfigTabPage;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDSX;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusForza;
		private System.Windows.Forms.ToolStripDropDownButton toolStripVerboseMode;
		private System.Windows.Forms.ToolStripMenuItem verboseModeOffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verboseModeLowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verboseModeFullToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TableLayoutPanel brakeTableLayoutPanel;
		private System.Windows.Forms.Label brakeEffectIntensityLabel;
		private System.Windows.Forms.TrackBar brakeEffectIntensityTrackBar;
		private System.Windows.Forms.TabPage miscTabPage;
		private System.Windows.Forms.TableLayoutPanel miscTableLayoutPanel;
		private System.Windows.Forms.NumericUpDown forzaPortNumericUpDown;
		private System.Windows.Forms.Label forzaPortLabel;
		private System.Windows.Forms.Label dsxPortLabel;
		private System.Windows.Forms.Label appCheckLabel;
		private System.Windows.Forms.Label rpmLabel;
		private System.Windows.Forms.TrackBar rpmTrackBar;
		private System.Windows.Forms.CheckBox appCheckBox;
		private System.Windows.Forms.NumericUpDown dsxNumericUpDown;
		private System.Windows.Forms.Label gripLossLabel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TrackBar gripLossTrackBar;
		private System.Windows.Forms.TrackBar brakeResistanceSmoothingTrackBar;
		private System.Windows.Forms.Label brakeResistanceSmoothingLabel;
		private System.Windows.Forms.TrackBar maxBrakeResistanceTrackBar;
		private System.Windows.Forms.Label maxBrakeResistanceLabel;
		private System.Windows.Forms.TrackBar minBrakeResistanceTrackBar;
		private System.Windows.Forms.Label minBrakeResistanceLabel;
		private System.Windows.Forms.TrackBar maxBrakeStiffnessTrackBar;
		private System.Windows.Forms.Label maxBrakeStiffnessLabel;
		private System.Windows.Forms.TrackBar minBrakeStiffnessTrackBar;
		private System.Windows.Forms.Label minBrakeStiffnessLabel;
		private System.Windows.Forms.TrackBar vibrationSmoothingTrackBar;
		private System.Windows.Forms.Label vibrationSmoothingLabel;
		private System.Windows.Forms.TrackBar maxBrakeVibrationTrackBar;
		private System.Windows.Forms.Label maxBrakeVibrationLabel;
		private System.Windows.Forms.TrackBar minBrakeVibrationTrackBar;
		private System.Windows.Forms.Label minBrakeVibrationLabel;
		private System.Windows.Forms.TrackBar brakeVibrationModeTrackBar;
		private System.Windows.Forms.Label brakeVibrationModeStartLabel;
		private System.Windows.Forms.TrackBar brakeVibrationStartTrackBar;
		private System.Windows.Forms.Label brakeVibrationStartLabel;
		private System.Windows.Forms.NumericUpDown rpmValueNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeResistanceSmoothNumericUpDown;
		private System.Windows.Forms.NumericUpDown maxBrakeResistanceNumericUpDown;
		private System.Windows.Forms.NumericUpDown minBrakeResistanceNumericUpDown;
		private System.Windows.Forms.NumericUpDown maxBrakeStifnessNumericUpDown;
		private System.Windows.Forms.NumericUpDown minBrakeStifnessNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeVibrationSmoothNumericUpDown;
		private System.Windows.Forms.NumericUpDown maxBrakeVibrationNumericUpDown;
		private System.Windows.Forms.NumericUpDown minBrakeVibrationNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeVibrationModeNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeVibrationStartNumericUpDown;
		private System.Windows.Forms.NumericUpDown gripLossNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeEffectNumericUpDown;
		private System.Windows.Forms.TableLayoutPanel throttleTableLayoutPanel;
		private System.Windows.Forms.TrackBar throttleGripLossTrackBar;
		private System.Windows.Forms.Label throttleResistanceSmoothingLabel;
		private System.Windows.Forms.Label maxThrottleResistanceLabel;
		private System.Windows.Forms.Label minThrottleResistanceLabel;
		private System.Windows.Forms.Label maxThrottleStiffnessLabel;
		private System.Windows.Forms.Label minThrottleStiffnessLabel;
		private System.Windows.Forms.Label throttleVibrationSmoothingLabel;
		private System.Windows.Forms.Label maxThrottleVibrationLabel;
		private System.Windows.Forms.Label minThrottleVibrationLabel;
		private System.Windows.Forms.Label throttleVibrationStartLabel;
		private System.Windows.Forms.Label accelerationLimitLabel;
		private System.Windows.Forms.Label forwardAccelLabel;
		private System.Windows.Forms.Label turnAccelLabel;
		private System.Windows.Forms.Label throttleGripLossLabel;
		private System.Windows.Forms.TrackBar throttleIntensityTrackBar;
		private System.Windows.Forms.Label throttleIntensityLabel;
		private System.Windows.Forms.TrackBar throttleResistanceSmoothTrackBar;
		private System.Windows.Forms.TrackBar throttleMaxResistanceTrackBar;
		private System.Windows.Forms.TrackBar throttleMinResistanceTrackBar;
		private System.Windows.Forms.TrackBar throttleMaxStiffnessTrackBar;
		private System.Windows.Forms.TrackBar throttleMinStiffnessTrackBar;
		private System.Windows.Forms.TrackBar throttleVibrationSmoothTrackBar;
		private System.Windows.Forms.TrackBar throttleMaxVibrationTrackBar;
		private System.Windows.Forms.TrackBar throttleMinVibrationTrackBar;
		private System.Windows.Forms.TrackBar throttleVibrationModeStartTrackBar;
		private System.Windows.Forms.TrackBar throttleAccelLimitTrackBar;
		private System.Windows.Forms.TrackBar throttleForwardAccelScaleTrackBar;
		private System.Windows.Forms.TrackBar throttleTurnAccelScaleTrackBar;
		private System.Windows.Forms.NumericUpDown throttleTurnAccelScaleNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleGripLossNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleIntensityNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleResistanceSmoothNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleMaxResistanceNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleMinResistanceNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleMaxStiffnessNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleMinStiffnessNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleVibrationSmoothNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleMaxVibrationNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleMinVibrationNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleVibrationStartNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleAccelLimitNumericUpDown;
		private System.Windows.Forms.NumericUpDown throttleForwardAccelScaleNumericUpDown;
		private System.Windows.Forms.Label noRaceText;
		private System.Windows.Forms.GroupBox noRaceGroupBox;
		private System.Windows.Forms.GroupBox raceGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label brakeMsg;
		private System.Windows.Forms.Label brakeVibrationMsg;
		private System.Windows.Forms.Label throttleMsg;
		private System.Windows.Forms.Label throttleVibrationMsg;
		private System.Windows.Forms.Button buttonApplyMisc;
		private System.Windows.Forms.Button buttonApply_Brake;
		private System.Windows.Forms.Button buttonApply_Throttle;
	}
}