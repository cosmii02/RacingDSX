﻿using System;
using System.ComponentModel;

namespace RacingDSX
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
            components = new Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("test");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("test2");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(UI));
            mainPanel = new System.Windows.Forms.Panel();
            mainSplitContainer = new System.Windows.Forms.SplitContainer();
            profilesGroupBox = new System.Windows.Forms.GroupBox();
            profilesListView = new System.Windows.Forms.ListView();
            mainTabControl = new System.Windows.Forms.TabControl();
            miscTabPage = new System.Windows.Forms.TabPage();
            miscTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            forzaPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            forzaPortLabel = new System.Windows.Forms.Label();
            rpmLabel = new System.Windows.Forms.Label();
            rpmTrackBar = new System.Windows.Forms.TrackBar();
            rpmValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            buttonApplyMisc = new System.Windows.Forms.Button();
            miscDefaultsButton = new System.Windows.Forms.Button();
            ExecutableListLabel = new System.Windows.Forms.Label();
            ExecutableListBox = new System.Windows.Forms.ListBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            AddExecutableButton = new System.Windows.Forms.Button();
            EditExecutableButton = new System.Windows.Forms.Button();
            RemoveExecutableButton = new System.Windows.Forms.Button();
            GameModeLabel = new System.Windows.Forms.Label();
            GameModeComboBox = new System.Windows.Forms.ComboBox();
            brakeConfigTabPage = new System.Windows.Forms.TabPage();
            brakeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            brakeResistanceSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
            maxBrakeResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            minBrakeResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            maxBrakeStifnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            minBrakeStifnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            brakeVibrationSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
            maxBrakeVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            minBrakeVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            brakeVibrationModeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            brakeVibrationStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            gripLossNumericUpDown = new System.Windows.Forms.NumericUpDown();
            brakeEffectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            brakeResistanceSmoothingTrackBar = new System.Windows.Forms.TrackBar();
            brakeResistanceSmoothingLabel = new System.Windows.Forms.Label();
            maxBrakeResistanceTrackBar = new System.Windows.Forms.TrackBar();
            maxBrakeResistanceLabel = new System.Windows.Forms.Label();
            minBrakeResistanceTrackBar = new System.Windows.Forms.TrackBar();
            minBrakeResistanceLabel = new System.Windows.Forms.Label();
            maxBrakeStiffnessTrackBar = new System.Windows.Forms.TrackBar();
            maxBrakeStiffnessLabel = new System.Windows.Forms.Label();
            minBrakeStiffnessTrackBar = new System.Windows.Forms.TrackBar();
            minBrakeStiffnessLabel = new System.Windows.Forms.Label();
            vibrationSmoothingTrackBar = new System.Windows.Forms.TrackBar();
            vibrationSmoothingLabel = new System.Windows.Forms.Label();
            maxBrakeVibrationTrackBar = new System.Windows.Forms.TrackBar();
            maxBrakeVibrationLabel = new System.Windows.Forms.Label();
            minBrakeVibrationTrackBar = new System.Windows.Forms.TrackBar();
            minBrakeVibrationLabel = new System.Windows.Forms.Label();
            brakeVibrationModeTrackBar = new System.Windows.Forms.TrackBar();
            brakeVibrationModeStartLabel = new System.Windows.Forms.Label();
            brakeVibrationStartTrackBar = new System.Windows.Forms.TrackBar();
            brakeVibrationStartLabel = new System.Windows.Forms.Label();
            gripLossTrackBar = new System.Windows.Forms.TrackBar();
            gripLossLabel = new System.Windows.Forms.Label();
            brakeEffectIntensityLabel = new System.Windows.Forms.Label();
            brakeEffectIntensityTrackBar = new System.Windows.Forms.TrackBar();
            buttonApply_Brake = new System.Windows.Forms.Button();
            brakeDefaultsButton = new System.Windows.Forms.Button();
            brakeTriggerMode = new System.Windows.Forms.Label();
            brakeTriggerModeComboBox = new System.Windows.Forms.ComboBox();
            throttleConfigTabPage = new System.Windows.Forms.TabPage();
            throttleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            throttleTriggerModeComboBox = new System.Windows.Forms.ComboBox();
            throttleTriggerMode = new System.Windows.Forms.Label();
            throttleResistanceSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleMaxResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleMinResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleMaxStiffnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleMinStiffnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleVibrationSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleMaxVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleMinVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleVibrationStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleAccelLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleForwardAccelScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleTurnAccelScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleGripLossNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleIntensityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            throttleResistanceSmoothTrackBar = new System.Windows.Forms.TrackBar();
            throttleMaxResistanceTrackBar = new System.Windows.Forms.TrackBar();
            throttleMinResistanceTrackBar = new System.Windows.Forms.TrackBar();
            throttleMaxStiffnessTrackBar = new System.Windows.Forms.TrackBar();
            throttleMinStiffnessTrackBar = new System.Windows.Forms.TrackBar();
            throttleVibrationSmoothTrackBar = new System.Windows.Forms.TrackBar();
            throttleMaxVibrationTrackBar = new System.Windows.Forms.TrackBar();
            throttleMinVibrationTrackBar = new System.Windows.Forms.TrackBar();
            throttleVibrationModeStartTrackBar = new System.Windows.Forms.TrackBar();
            throttleAccelLimitTrackBar = new System.Windows.Forms.TrackBar();
            throttleForwardAccelScaleTrackBar = new System.Windows.Forms.TrackBar();
            throttleTurnAccelScaleTrackBar = new System.Windows.Forms.TrackBar();
            throttleGripLossTrackBar = new System.Windows.Forms.TrackBar();
            throttleIntensityTrackBar = new System.Windows.Forms.TrackBar();
            throttleResistanceSmoothingLabel = new System.Windows.Forms.Label();
            maxThrottleResistanceLabel = new System.Windows.Forms.Label();
            minThrottleResistanceLabel = new System.Windows.Forms.Label();
            maxThrottleStiffnessLabel = new System.Windows.Forms.Label();
            minThrottleStiffnessLabel = new System.Windows.Forms.Label();
            throttleVibrationSmoothingLabel = new System.Windows.Forms.Label();
            maxThrottleVibrationLabel = new System.Windows.Forms.Label();
            minThrottleVibrationLabel = new System.Windows.Forms.Label();
            throttleVibrationStartLabel = new System.Windows.Forms.Label();
            accelerationLimitLabel = new System.Windows.Forms.Label();
            forwardAccelLabel = new System.Windows.Forms.Label();
            turnAccelLabel = new System.Windows.Forms.Label();
            throttleGripLossLabel = new System.Windows.Forms.Label();
            throttleIntensityLabel = new System.Windows.Forms.Label();
            buttonApply_Throttle = new System.Windows.Forms.Button();
            throttleDefaultsButton = new System.Windows.Forms.Button();
            outputTabPage = new System.Windows.Forms.TabPage();
            raceGroupBox = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            brakeMsg = new System.Windows.Forms.Label();
            brakeVibrationMsg = new System.Windows.Forms.Label();
            throttleMsg = new System.Windows.Forms.Label();
            throttleVibrationMsg = new System.Windows.Forms.Label();
            noRaceGroupBox = new System.Windows.Forms.GroupBox();
            noRaceText = new System.Windows.Forms.Label();
            outputListBox = new System.Windows.Forms.ListBox();
            toolStripStatusDSX = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusForza = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripVerboseMode = new System.Windows.Forms.ToolStripDropDownButton();
            verboseModeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            verboseModeLowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            verboseModeFullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripDSXPortButton = new System.Windows.Forms.ToolStripDropDownButton();
            toolStripDSXPortTextBox = new System.Windows.Forms.ToolStripTextBox();
            toolStripAppCheckButton = new System.Windows.Forms.ToolStripDropDownButton();
            toolStripAppCheckOffItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripAppCheckOnItem = new System.Windows.Forms.ToolStripMenuItem();
            toolTip = new System.Windows.Forms.ToolTip(components);
            ProfilesContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            setActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainPanel.SuspendLayout();
            ((ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            profilesGroupBox.SuspendLayout();
            mainTabControl.SuspendLayout();
            miscTabPage.SuspendLayout();
            miscTableLayoutPanel.SuspendLayout();
            ((ISupportInitialize)forzaPortNumericUpDown).BeginInit();
            ((ISupportInitialize)rpmTrackBar).BeginInit();
            ((ISupportInitialize)rpmValueNumericUpDown).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            brakeConfigTabPage.SuspendLayout();
            brakeTableLayoutPanel.SuspendLayout();
            ((ISupportInitialize)brakeResistanceSmoothNumericUpDown).BeginInit();
            ((ISupportInitialize)maxBrakeResistanceNumericUpDown).BeginInit();
            ((ISupportInitialize)minBrakeResistanceNumericUpDown).BeginInit();
            ((ISupportInitialize)maxBrakeStifnessNumericUpDown).BeginInit();
            ((ISupportInitialize)minBrakeStifnessNumericUpDown).BeginInit();
            ((ISupportInitialize)brakeVibrationSmoothNumericUpDown).BeginInit();
            ((ISupportInitialize)maxBrakeVibrationNumericUpDown).BeginInit();
            ((ISupportInitialize)minBrakeVibrationNumericUpDown).BeginInit();
            ((ISupportInitialize)brakeVibrationModeNumericUpDown).BeginInit();
            ((ISupportInitialize)brakeVibrationStartNumericUpDown).BeginInit();
            ((ISupportInitialize)gripLossNumericUpDown).BeginInit();
            ((ISupportInitialize)brakeEffectNumericUpDown).BeginInit();
            ((ISupportInitialize)brakeResistanceSmoothingTrackBar).BeginInit();
            ((ISupportInitialize)maxBrakeResistanceTrackBar).BeginInit();
            ((ISupportInitialize)minBrakeResistanceTrackBar).BeginInit();
            ((ISupportInitialize)maxBrakeStiffnessTrackBar).BeginInit();
            ((ISupportInitialize)minBrakeStiffnessTrackBar).BeginInit();
            ((ISupportInitialize)vibrationSmoothingTrackBar).BeginInit();
            ((ISupportInitialize)maxBrakeVibrationTrackBar).BeginInit();
            ((ISupportInitialize)minBrakeVibrationTrackBar).BeginInit();
            ((ISupportInitialize)brakeVibrationModeTrackBar).BeginInit();
            ((ISupportInitialize)brakeVibrationStartTrackBar).BeginInit();
            ((ISupportInitialize)gripLossTrackBar).BeginInit();
            ((ISupportInitialize)brakeEffectIntensityTrackBar).BeginInit();
            throttleConfigTabPage.SuspendLayout();
            throttleTableLayoutPanel.SuspendLayout();
            ((ISupportInitialize)throttleResistanceSmoothNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleMaxResistanceNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleMinResistanceNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleMaxStiffnessNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleMinStiffnessNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleVibrationSmoothNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleMaxVibrationNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleMinVibrationNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleVibrationStartNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleAccelLimitNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleForwardAccelScaleNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleTurnAccelScaleNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleGripLossNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleIntensityNumericUpDown).BeginInit();
            ((ISupportInitialize)throttleResistanceSmoothTrackBar).BeginInit();
            ((ISupportInitialize)throttleMaxResistanceTrackBar).BeginInit();
            ((ISupportInitialize)throttleMinResistanceTrackBar).BeginInit();
            ((ISupportInitialize)throttleMaxStiffnessTrackBar).BeginInit();
            ((ISupportInitialize)throttleMinStiffnessTrackBar).BeginInit();
            ((ISupportInitialize)throttleVibrationSmoothTrackBar).BeginInit();
            ((ISupportInitialize)throttleMaxVibrationTrackBar).BeginInit();
            ((ISupportInitialize)throttleMinVibrationTrackBar).BeginInit();
            ((ISupportInitialize)throttleVibrationModeStartTrackBar).BeginInit();
            ((ISupportInitialize)throttleAccelLimitTrackBar).BeginInit();
            ((ISupportInitialize)throttleForwardAccelScaleTrackBar).BeginInit();
            ((ISupportInitialize)throttleTurnAccelScaleTrackBar).BeginInit();
            ((ISupportInitialize)throttleGripLossTrackBar).BeginInit();
            ((ISupportInitialize)throttleIntensityTrackBar).BeginInit();
            outputTabPage.SuspendLayout();
            raceGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            noRaceGroupBox.SuspendLayout();
            statusStrip1.SuspendLayout();
            ProfilesContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(mainSplitContainer);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(1478, 814);
            mainPanel.TabIndex = 0;
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            mainSplitContainer.Margin = new System.Windows.Forms.Padding(2);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(profilesGroupBox);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(mainTabControl);
            mainSplitContainer.Size = new System.Drawing.Size(1478, 814);
            mainSplitContainer.SplitterDistance = 188;
            mainSplitContainer.SplitterWidth = 3;
            mainSplitContainer.TabIndex = 1;
            // 
            // profilesGroupBox
            // 
            profilesGroupBox.Controls.Add(profilesListView);
            profilesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            profilesGroupBox.Location = new System.Drawing.Point(0, 0);
            profilesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            profilesGroupBox.Name = "profilesGroupBox";
            profilesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            profilesGroupBox.Size = new System.Drawing.Size(188, 814);
            profilesGroupBox.TabIndex = 3;
            profilesGroupBox.TabStop = false;
            profilesGroupBox.Text = "Profiles";
            // 
            // profilesListView
            // 
            profilesListView.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            profilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            profilesListView.ForeColor = System.Drawing.Color.White;
            profilesListView.FullRowSelect = true;
            profilesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2 });
            profilesListView.Location = new System.Drawing.Point(2, 22);
            profilesListView.Margin = new System.Windows.Forms.Padding(2);
            profilesListView.MultiSelect = false;
            profilesListView.Name = "profilesListView";
            profilesListView.Size = new System.Drawing.Size(184, 790);
            profilesListView.TabIndex = 0;
            profilesListView.UseCompatibleStateImageBehavior = false;
            profilesListView.View = System.Windows.Forms.View.List;
            profilesListView.SelectedIndexChanged += profilesListView_SelectedIndexChanged_1;
            profilesListView.MouseDown += profilesListView_MouseDown;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(miscTabPage);
            mainTabControl.Controls.Add(brakeConfigTabPage);
            mainTabControl.Controls.Add(throttleConfigTabPage);
            mainTabControl.Controls.Add(outputTabPage);
            mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            mainTabControl.Location = new System.Drawing.Point(0, 0);
            mainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new System.Drawing.Size(1287, 814);
            mainTabControl.TabIndex = 0;
            // 
            // miscTabPage
            // 
            miscTabPage.Controls.Add(miscTableLayoutPanel);
            miscTabPage.Location = new System.Drawing.Point(4, 29);
            miscTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            miscTabPage.Name = "miscTabPage";
            miscTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            miscTabPage.Size = new System.Drawing.Size(1279, 781);
            miscTabPage.TabIndex = 3;
            miscTabPage.Text = "Misc";
            miscTabPage.UseVisualStyleBackColor = true;
            // 
            // miscTableLayoutPanel
            // 
            miscTableLayoutPanel.AutoScroll = true;
            miscTableLayoutPanel.AutoSize = true;
            miscTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            miscTableLayoutPanel.ColumnCount = 3;
            miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            miscTableLayoutPanel.Controls.Add(forzaPortNumericUpDown, 1, 4);
            miscTableLayoutPanel.Controls.Add(forzaPortLabel, 0, 4);
            miscTableLayoutPanel.Controls.Add(rpmLabel, 0, 0);
            miscTableLayoutPanel.Controls.Add(rpmTrackBar, 1, 0);
            miscTableLayoutPanel.Controls.Add(rpmValueNumericUpDown, 2, 0);
            miscTableLayoutPanel.Controls.Add(buttonApplyMisc, 1, 7);
            miscTableLayoutPanel.Controls.Add(miscDefaultsButton, 2, 7);
            miscTableLayoutPanel.Controls.Add(ExecutableListLabel, 0, 6);
            miscTableLayoutPanel.Controls.Add(ExecutableListBox, 1, 6);
            miscTableLayoutPanel.Controls.Add(flowLayoutPanel1, 2, 6);
            miscTableLayoutPanel.Controls.Add(GameModeLabel, 0, 5);
            miscTableLayoutPanel.Controls.Add(GameModeComboBox, 1, 5);
            miscTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            miscTableLayoutPanel.ForeColor = System.Drawing.Color.White;
            miscTableLayoutPanel.Location = new System.Drawing.Point(3, 4);
            miscTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            miscTableLayoutPanel.Name = "miscTableLayoutPanel";
            miscTableLayoutPanel.RowCount = 8;
            miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            miscTableLayoutPanel.Size = new System.Drawing.Size(1273, 773);
            miscTableLayoutPanel.TabIndex = 0;
            // 
            // forzaPortNumericUpDown
            // 
            forzaPortNumericUpDown.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            forzaPortNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            forzaPortNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            forzaPortNumericUpDown.ForeColor = System.Drawing.Color.White;
            forzaPortNumericUpDown.Location = new System.Drawing.Point(159, 68);
            forzaPortNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            forzaPortNumericUpDown.Maximum = new decimal(new int[] { 65353, 0, 0, 0 });
            forzaPortNumericUpDown.Name = "forzaPortNumericUpDown";
            forzaPortNumericUpDown.Size = new System.Drawing.Size(475, 27);
            forzaPortNumericUpDown.TabIndex = 7;
            toolTip.SetToolTip(forzaPortNumericUpDown, "Port for Forza UDP server");
            forzaPortNumericUpDown.ValueChanged += forzaPortNumericUpDown_ValueChanged;
            // 
            // forzaPortLabel
            // 
            forzaPortLabel.AutoSize = true;
            forzaPortLabel.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            forzaPortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            forzaPortLabel.ForeColor = System.Drawing.Color.White;
            forzaPortLabel.Location = new System.Drawing.Point(3, 64);
            forzaPortLabel.Name = "forzaPortLabel";
            forzaPortLabel.Size = new System.Drawing.Size(150, 35);
            forzaPortLabel.TabIndex = 6;
            forzaPortLabel.Text = "Game Port";
            forzaPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(forzaPortLabel, "Port for Game's UDP Server");
            forzaPortLabel.Click += forzaPortLabel_Click;
            // 
            // rpmLabel
            // 
            rpmLabel.AutoSize = true;
            rpmLabel.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            rpmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            rpmLabel.ForeColor = System.Drawing.Color.White;
            rpmLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            rpmLabel.Location = new System.Drawing.Point(3, 0);
            rpmLabel.Name = "rpmLabel";
            rpmLabel.Size = new System.Drawing.Size(150, 64);
            rpmLabel.TabIndex = 0;
            rpmLabel.Text = "RPM Redline Ratio";
            rpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(rpmLabel, "The percentage of the current RPM when we are in the \"redline\" of the engine");
            rpmLabel.Click += rpmLabel_Click;
            // 
            // rpmTrackBar
            // 
            rpmTrackBar.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            rpmTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            rpmTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            rpmTrackBar.LargeChange = 50;
            rpmTrackBar.Location = new System.Drawing.Point(159, 4);
            rpmTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rpmTrackBar.Maximum = 100;
            rpmTrackBar.Name = "rpmTrackBar";
            rpmTrackBar.Size = new System.Drawing.Size(475, 56);
            rpmTrackBar.TabIndex = 1;
            rpmTrackBar.TickFrequency = 5;
            rpmTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(rpmTrackBar, "The percentage of the current RPM when we are in the \"redline\" of the engine");
            rpmTrackBar.Scroll += rpmTrackBar_Scroll;
            // 
            // rpmValueNumericUpDown
            // 
            rpmValueNumericUpDown.AutoSize = true;
            rpmValueNumericUpDown.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            rpmValueNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            rpmValueNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            rpmValueNumericUpDown.ForeColor = System.Drawing.Color.White;
            rpmValueNumericUpDown.Location = new System.Drawing.Point(640, 4);
            rpmValueNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rpmValueNumericUpDown.Name = "rpmValueNumericUpDown";
            rpmValueNumericUpDown.Size = new System.Drawing.Size(660, 27);
            rpmValueNumericUpDown.TabIndex = 8;
            toolTip.SetToolTip(rpmValueNumericUpDown, "The percentage of the current RPM when we are in the \"redline\" of the engine");
            rpmValueNumericUpDown.ValueChanged += rpmValueNumericUpDown_ValueChanged;
            // 
            // buttonApplyMisc
            // 
            buttonApplyMisc.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            buttonApplyMisc.Dock = System.Windows.Forms.DockStyle.Top;
            buttonApplyMisc.ForeColor = System.Drawing.Color.White;
            buttonApplyMisc.Location = new System.Drawing.Point(159, 260);
            buttonApplyMisc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonApplyMisc.MaximumSize = new System.Drawing.Size(343, 40);
            buttonApplyMisc.MinimumSize = new System.Drawing.Size(229, 34);
            buttonApplyMisc.Name = "buttonApplyMisc";
            buttonApplyMisc.Size = new System.Drawing.Size(343, 34);
            buttonApplyMisc.TabIndex = 9;
            buttonApplyMisc.Text = "Apply";
            buttonApplyMisc.UseVisualStyleBackColor = false;
            buttonApplyMisc.Click += buttonApplyMisc_Click;
            // 
            // miscDefaultsButton
            // 
            miscDefaultsButton.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            miscDefaultsButton.ForeColor = System.Drawing.Color.White;
            miscDefaultsButton.Location = new System.Drawing.Point(640, 260);
            miscDefaultsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            miscDefaultsButton.Name = "miscDefaultsButton";
            miscDefaultsButton.Size = new System.Drawing.Size(86, 30);
            miscDefaultsButton.TabIndex = 39;
            miscDefaultsButton.Text = "Defaults";
            miscDefaultsButton.UseVisualStyleBackColor = false;
            miscDefaultsButton.Click += miscDefaultsButton_Click;
            // 
            // ExecutableListLabel
            // 
            ExecutableListLabel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ExecutableListLabel.AutoSize = true;
            ExecutableListLabel.Location = new System.Drawing.Point(2, 183);
            ExecutableListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ExecutableListLabel.Name = "ExecutableListLabel";
            ExecutableListLabel.Size = new System.Drawing.Size(152, 20);
            ExecutableListLabel.TabIndex = 40;
            ExecutableListLabel.Text = "Executables To Match";
            ExecutableListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(ExecutableListLabel, "This is the list of executable names that will be used to activate this profile");
            // 
            // ExecutableListBox
            // 
            ExecutableListBox.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ExecutableListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ExecutableListBox.ForeColor = System.Drawing.Color.White;
            ExecutableListBox.FormattingEnabled = true;
            ExecutableListBox.Location = new System.Drawing.Point(158, 133);
            ExecutableListBox.Margin = new System.Windows.Forms.Padding(2);
            ExecutableListBox.Name = "ExecutableListBox";
            ExecutableListBox.Size = new System.Drawing.Size(477, 121);
            ExecutableListBox.TabIndex = 41;
            ExecutableListBox.SelectedIndexChanged += ExecutableListBox_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(AddExecutableButton);
            flowLayoutPanel1.Controls.Add(EditExecutableButton);
            flowLayoutPanel1.Controls.Add(RemoveExecutableButton);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(639, 133);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(662, 121);
            flowLayoutPanel1.TabIndex = 42;
            // 
            // AddExecutableButton
            // 
            AddExecutableButton.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            AddExecutableButton.ForeColor = System.Drawing.Color.White;
            AddExecutableButton.Location = new System.Drawing.Point(2, 2);
            AddExecutableButton.Margin = new System.Windows.Forms.Padding(2);
            AddExecutableButton.Name = "AddExecutableButton";
            AddExecutableButton.Size = new System.Drawing.Size(90, 27);
            AddExecutableButton.TabIndex = 0;
            AddExecutableButton.Text = "Add";
            AddExecutableButton.UseVisualStyleBackColor = false;
            AddExecutableButton.Click += AddExecutableButton_Click;
            // 
            // EditExecutableButton
            // 
            EditExecutableButton.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            EditExecutableButton.Location = new System.Drawing.Point(2, 33);
            EditExecutableButton.Margin = new System.Windows.Forms.Padding(2);
            EditExecutableButton.Name = "EditExecutableButton";
            EditExecutableButton.Size = new System.Drawing.Size(90, 27);
            EditExecutableButton.TabIndex = 1;
            EditExecutableButton.Text = "Edit";
            EditExecutableButton.UseVisualStyleBackColor = false;
            EditExecutableButton.Click += EditExecutableButton_Click;
            // 
            // RemoveExecutableButton
            // 
            RemoveExecutableButton.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            RemoveExecutableButton.ForeColor = System.Drawing.Color.White;
            RemoveExecutableButton.Location = new System.Drawing.Point(2, 64);
            RemoveExecutableButton.Margin = new System.Windows.Forms.Padding(2);
            RemoveExecutableButton.Name = "RemoveExecutableButton";
            RemoveExecutableButton.Size = new System.Drawing.Size(90, 27);
            RemoveExecutableButton.TabIndex = 2;
            RemoveExecutableButton.Text = "Remove";
            RemoveExecutableButton.UseVisualStyleBackColor = false;
            RemoveExecutableButton.Click += RemoveExecutableButton_Click;
            // 
            // GameModeLabel
            // 
            GameModeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            GameModeLabel.AutoSize = true;
            GameModeLabel.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            GameModeLabel.ForeColor = System.Drawing.Color.White;
            GameModeLabel.Location = new System.Drawing.Point(73, 105);
            GameModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            GameModeLabel.Name = "GameModeLabel";
            GameModeLabel.Size = new System.Drawing.Size(81, 20);
            GameModeLabel.TabIndex = 43;
            GameModeLabel.Text = "UDP Mode";
            GameModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(GameModeLabel, "The Parser and backend to use to conver the game UDP to the DSX Commands");
            // 
            // GameModeComboBox
            // 
            GameModeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            GameModeComboBox.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            GameModeComboBox.ForeColor = System.Drawing.Color.White;
            GameModeComboBox.FormattingEnabled = true;
            GameModeComboBox.Items.AddRange(new object[] { "(None)", "Forza", "Dirt" });
            GameModeComboBox.Location = new System.Drawing.Point(158, 101);
            GameModeComboBox.Margin = new System.Windows.Forms.Padding(2);
            GameModeComboBox.Name = "GameModeComboBox";
            GameModeComboBox.Size = new System.Drawing.Size(146, 28);
            GameModeComboBox.TabIndex = 44;
            GameModeComboBox.SelectedIndexChanged += GameModeComboBox_SelectedIndexChanged;
            // 
            // brakeConfigTabPage
            // 
            brakeConfigTabPage.Controls.Add(brakeTableLayoutPanel);
            brakeConfigTabPage.Location = new System.Drawing.Point(4, 29);
            brakeConfigTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeConfigTabPage.Name = "brakeConfigTabPage";
            brakeConfigTabPage.Size = new System.Drawing.Size(1279, 781);
            brakeConfigTabPage.TabIndex = 4;
            brakeConfigTabPage.Text = "Brake Trigger";
            // 
            // brakeTableLayoutPanel
            // 
            brakeTableLayoutPanel.AutoScroll = true;
            brakeTableLayoutPanel.AutoSize = true;
            brakeTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            brakeTableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            brakeTableLayoutPanel.ColumnCount = 3;
            brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            brakeTableLayoutPanel.Controls.Add(brakeResistanceSmoothNumericUpDown, 2, 12);
            brakeTableLayoutPanel.Controls.Add(maxBrakeResistanceNumericUpDown, 2, 11);
            brakeTableLayoutPanel.Controls.Add(minBrakeResistanceNumericUpDown, 2, 10);
            brakeTableLayoutPanel.Controls.Add(maxBrakeStifnessNumericUpDown, 2, 9);
            brakeTableLayoutPanel.Controls.Add(minBrakeStifnessNumericUpDown, 2, 8);
            brakeTableLayoutPanel.Controls.Add(brakeVibrationSmoothNumericUpDown, 2, 7);
            brakeTableLayoutPanel.Controls.Add(maxBrakeVibrationNumericUpDown, 2, 6);
            brakeTableLayoutPanel.Controls.Add(minBrakeVibrationNumericUpDown, 2, 5);
            brakeTableLayoutPanel.Controls.Add(brakeVibrationModeNumericUpDown, 2, 4);
            brakeTableLayoutPanel.Controls.Add(brakeVibrationStartNumericUpDown, 2, 3);
            brakeTableLayoutPanel.Controls.Add(gripLossNumericUpDown, 2, 2);
            brakeTableLayoutPanel.Controls.Add(brakeEffectNumericUpDown, 2, 1);
            brakeTableLayoutPanel.Controls.Add(brakeResistanceSmoothingTrackBar, 1, 12);
            brakeTableLayoutPanel.Controls.Add(brakeResistanceSmoothingLabel, 0, 12);
            brakeTableLayoutPanel.Controls.Add(maxBrakeResistanceTrackBar, 1, 11);
            brakeTableLayoutPanel.Controls.Add(maxBrakeResistanceLabel, 0, 11);
            brakeTableLayoutPanel.Controls.Add(minBrakeResistanceTrackBar, 1, 10);
            brakeTableLayoutPanel.Controls.Add(minBrakeResistanceLabel, 0, 10);
            brakeTableLayoutPanel.Controls.Add(maxBrakeStiffnessTrackBar, 1, 9);
            brakeTableLayoutPanel.Controls.Add(maxBrakeStiffnessLabel, 0, 9);
            brakeTableLayoutPanel.Controls.Add(minBrakeStiffnessTrackBar, 1, 8);
            brakeTableLayoutPanel.Controls.Add(minBrakeStiffnessLabel, 0, 8);
            brakeTableLayoutPanel.Controls.Add(vibrationSmoothingTrackBar, 1, 7);
            brakeTableLayoutPanel.Controls.Add(vibrationSmoothingLabel, 0, 7);
            brakeTableLayoutPanel.Controls.Add(maxBrakeVibrationTrackBar, 1, 6);
            brakeTableLayoutPanel.Controls.Add(maxBrakeVibrationLabel, 0, 6);
            brakeTableLayoutPanel.Controls.Add(minBrakeVibrationTrackBar, 1, 5);
            brakeTableLayoutPanel.Controls.Add(minBrakeVibrationLabel, 0, 5);
            brakeTableLayoutPanel.Controls.Add(brakeVibrationModeTrackBar, 1, 4);
            brakeTableLayoutPanel.Controls.Add(brakeVibrationModeStartLabel, 0, 4);
            brakeTableLayoutPanel.Controls.Add(brakeVibrationStartTrackBar, 1, 3);
            brakeTableLayoutPanel.Controls.Add(brakeVibrationStartLabel, 0, 3);
            brakeTableLayoutPanel.Controls.Add(gripLossTrackBar, 1, 2);
            brakeTableLayoutPanel.Controls.Add(gripLossLabel, 0, 2);
            brakeTableLayoutPanel.Controls.Add(brakeEffectIntensityLabel, 0, 1);
            brakeTableLayoutPanel.Controls.Add(brakeEffectIntensityTrackBar, 1, 1);
            brakeTableLayoutPanel.Controls.Add(buttonApply_Brake, 1, 13);
            brakeTableLayoutPanel.Controls.Add(brakeDefaultsButton, 2, 13);
            brakeTableLayoutPanel.Controls.Add(brakeTriggerMode, 0, 0);
            brakeTableLayoutPanel.Controls.Add(brakeTriggerModeComboBox, 1, 0);
            brakeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            brakeTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeTableLayoutPanel.Name = "brakeTableLayoutPanel";
            brakeTableLayoutPanel.RowCount = 15;
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            brakeTableLayoutPanel.Size = new System.Drawing.Size(1279, 781);
            brakeTableLayoutPanel.TabIndex = 0;
            // 
            // brakeResistanceSmoothNumericUpDown
            // 
            brakeResistanceSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            brakeResistanceSmoothNumericUpDown.AutoSize = true;
            brakeResistanceSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            brakeResistanceSmoothNumericUpDown.Location = new System.Drawing.Point(630, 758);
            brakeResistanceSmoothNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeResistanceSmoothNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            brakeResistanceSmoothNumericUpDown.Name = "brakeResistanceSmoothNumericUpDown";
            brakeResistanceSmoothNumericUpDown.Size = new System.Drawing.Size(53, 27);
            brakeResistanceSmoothNumericUpDown.TabIndex = 36;
            toolTip.SetToolTip(brakeResistanceSmoothNumericUpDown, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
            brakeResistanceSmoothNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            brakeResistanceSmoothNumericUpDown.ValueChanged += brakeResistanceSmoothNumericUpDown_ValueChanged;
            // 
            // maxBrakeResistanceNumericUpDown
            // 
            maxBrakeResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            maxBrakeResistanceNumericUpDown.AutoSize = true;
            maxBrakeResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            maxBrakeResistanceNumericUpDown.Location = new System.Drawing.Point(630, 694);
            maxBrakeResistanceNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            maxBrakeResistanceNumericUpDown.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            maxBrakeResistanceNumericUpDown.Name = "maxBrakeResistanceNumericUpDown";
            maxBrakeResistanceNumericUpDown.Size = new System.Drawing.Size(37, 27);
            maxBrakeResistanceNumericUpDown.TabIndex = 35;
            toolTip.SetToolTip(maxBrakeResistanceNumericUpDown, "The Maximum resistance on the Brake (0-7)");
            maxBrakeResistanceNumericUpDown.ValueChanged += maxBrakeResistanceNumericUpDown_ValueChanged;
            // 
            // minBrakeResistanceNumericUpDown
            // 
            minBrakeResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            minBrakeResistanceNumericUpDown.AutoSize = true;
            minBrakeResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            minBrakeResistanceNumericUpDown.Location = new System.Drawing.Point(630, 630);
            minBrakeResistanceNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            minBrakeResistanceNumericUpDown.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            minBrakeResistanceNumericUpDown.Name = "minBrakeResistanceNumericUpDown";
            minBrakeResistanceNumericUpDown.Size = new System.Drawing.Size(37, 27);
            minBrakeResistanceNumericUpDown.TabIndex = 34;
            toolTip.SetToolTip(minBrakeResistanceNumericUpDown, "The Minimum resistance on the Brake (0-7)");
            minBrakeResistanceNumericUpDown.ValueChanged += minBrakeResistanceNumericUpDown_ValueChanged;
            // 
            // maxBrakeStifnessNumericUpDown
            // 
            maxBrakeStifnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            maxBrakeStifnessNumericUpDown.AutoSize = true;
            maxBrakeStifnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            maxBrakeStifnessNumericUpDown.Location = new System.Drawing.Point(630, 566);
            maxBrakeStifnessNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            maxBrakeStifnessNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            maxBrakeStifnessNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            maxBrakeStifnessNumericUpDown.Name = "maxBrakeStifnessNumericUpDown";
            maxBrakeStifnessNumericUpDown.Size = new System.Drawing.Size(53, 27);
            maxBrakeStifnessNumericUpDown.TabIndex = 33;
            toolTip.SetToolTip(maxBrakeStifnessNumericUpDown, "On a scale of 1-255 with 1 being most stiff");
            maxBrakeStifnessNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            maxBrakeStifnessNumericUpDown.ValueChanged += maxBrakeStifnessNumericUpDown_ValueChanged;
            // 
            // minBrakeStifnessNumericUpDown
            // 
            minBrakeStifnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            minBrakeStifnessNumericUpDown.AutoSize = true;
            minBrakeStifnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            minBrakeStifnessNumericUpDown.Location = new System.Drawing.Point(630, 502);
            minBrakeStifnessNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            minBrakeStifnessNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            minBrakeStifnessNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            minBrakeStifnessNumericUpDown.Name = "minBrakeStifnessNumericUpDown";
            minBrakeStifnessNumericUpDown.Size = new System.Drawing.Size(53, 27);
            minBrakeStifnessNumericUpDown.TabIndex = 32;
            toolTip.SetToolTip(minBrakeStifnessNumericUpDown, "On a scale of 1-255 with 1 being most stiff");
            minBrakeStifnessNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            minBrakeStifnessNumericUpDown.ValueChanged += minBrakeStifnessNumericUpDown_ValueChanged;
            // 
            // brakeVibrationSmoothNumericUpDown
            // 
            brakeVibrationSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            brakeVibrationSmoothNumericUpDown.AutoSize = true;
            brakeVibrationSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            brakeVibrationSmoothNumericUpDown.Location = new System.Drawing.Point(630, 438);
            brakeVibrationSmoothNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeVibrationSmoothNumericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            brakeVibrationSmoothNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            brakeVibrationSmoothNumericUpDown.Name = "brakeVibrationSmoothNumericUpDown";
            brakeVibrationSmoothNumericUpDown.Size = new System.Drawing.Size(53, 27);
            brakeVibrationSmoothNumericUpDown.TabIndex = 31;
            toolTip.SetToolTip(brakeVibrationSmoothNumericUpDown, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
            brakeVibrationSmoothNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            brakeVibrationSmoothNumericUpDown.ValueChanged += brakeVibrationSmoothNumericUpDown_ValueChanged;
            // 
            // maxBrakeVibrationNumericUpDown
            // 
            maxBrakeVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            maxBrakeVibrationNumericUpDown.AutoSize = true;
            maxBrakeVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            maxBrakeVibrationNumericUpDown.Location = new System.Drawing.Point(630, 374);
            maxBrakeVibrationNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            maxBrakeVibrationNumericUpDown.Name = "maxBrakeVibrationNumericUpDown";
            maxBrakeVibrationNumericUpDown.Size = new System.Drawing.Size(53, 27);
            maxBrakeVibrationNumericUpDown.TabIndex = 30;
            toolTip.SetToolTip(maxBrakeVibrationNumericUpDown, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
            maxBrakeVibrationNumericUpDown.ValueChanged += maxBrakeVibrationNumericUpDown_ValueChanged;
            // 
            // minBrakeVibrationNumericUpDown
            // 
            minBrakeVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            minBrakeVibrationNumericUpDown.AutoSize = true;
            minBrakeVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            minBrakeVibrationNumericUpDown.Location = new System.Drawing.Point(630, 310);
            minBrakeVibrationNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            minBrakeVibrationNumericUpDown.Name = "minBrakeVibrationNumericUpDown";
            minBrakeVibrationNumericUpDown.Size = new System.Drawing.Size(53, 27);
            minBrakeVibrationNumericUpDown.TabIndex = 29;
            toolTip.SetToolTip(minBrakeVibrationNumericUpDown, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in controller");
            minBrakeVibrationNumericUpDown.ValueChanged += minBrakeVibrationNumericUpDown_ValueChanged;
            // 
            // brakeVibrationModeNumericUpDown
            // 
            brakeVibrationModeNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            brakeVibrationModeNumericUpDown.AutoSize = true;
            brakeVibrationModeNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            brakeVibrationModeNumericUpDown.Location = new System.Drawing.Point(630, 246);
            brakeVibrationModeNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeVibrationModeNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            brakeVibrationModeNumericUpDown.Name = "brakeVibrationModeNumericUpDown";
            brakeVibrationModeNumericUpDown.Size = new System.Drawing.Size(53, 27);
            brakeVibrationModeNumericUpDown.TabIndex = 28;
            toolTip.SetToolTip(brakeVibrationModeNumericUpDown, "The depression of the brake lever at which the program should switch to vibration mode rather than smooth resistance. This helps to avoid clicking as vibration mode clicks when no force is applied. ");
            brakeVibrationModeNumericUpDown.ValueChanged += brakeVibrationModeNumericUpDown_ValueChanged;
            // 
            // brakeVibrationStartNumericUpDown
            // 
            brakeVibrationStartNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            brakeVibrationStartNumericUpDown.AutoSize = true;
            brakeVibrationStartNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            brakeVibrationStartNumericUpDown.Location = new System.Drawing.Point(630, 182);
            brakeVibrationStartNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeVibrationStartNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            brakeVibrationStartNumericUpDown.Name = "brakeVibrationStartNumericUpDown";
            brakeVibrationStartNumericUpDown.Size = new System.Drawing.Size(53, 27);
            brakeVibrationStartNumericUpDown.TabIndex = 27;
            toolTip.SetToolTip(brakeVibrationStartNumericUpDown, "The position in the Trigger (0-255) at which the brake should feel engaged with low grip surfaces");
            brakeVibrationStartNumericUpDown.ValueChanged += brakeVibrationStartNumericUpDown_ValueChanged;
            // 
            // gripLossNumericUpDown
            // 
            gripLossNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            gripLossNumericUpDown.AutoSize = true;
            gripLossNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            gripLossNumericUpDown.Location = new System.Drawing.Point(630, 118);
            gripLossNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gripLossNumericUpDown.Name = "gripLossNumericUpDown";
            gripLossNumericUpDown.Size = new System.Drawing.Size(53, 27);
            gripLossNumericUpDown.TabIndex = 26;
            toolTip.SetToolTip(gripLossNumericUpDown, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no grip)");
            gripLossNumericUpDown.ValueChanged += gripLossNumericUpDown_ValueChanged;
            // 
            // brakeEffectNumericUpDown
            // 
            brakeEffectNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            brakeEffectNumericUpDown.AutoSize = true;
            brakeEffectNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            brakeEffectNumericUpDown.Location = new System.Drawing.Point(630, 54);
            brakeEffectNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeEffectNumericUpDown.Name = "brakeEffectNumericUpDown";
            brakeEffectNumericUpDown.Size = new System.Drawing.Size(53, 27);
            brakeEffectNumericUpDown.TabIndex = 2;
            toolTip.SetToolTip(brakeEffectNumericUpDown, "The percentage of the current RPM when we are in the \"redline\" of the engine");
            brakeEffectNumericUpDown.ValueChanged += brakeEffectNumericUpDown_ValueChanged;
            // 
            // brakeResistanceSmoothingTrackBar
            // 
            brakeResistanceSmoothingTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            brakeResistanceSmoothingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeResistanceSmoothingTrackBar.LargeChange = 50;
            brakeResistanceSmoothingTrackBar.Location = new System.Drawing.Point(164, 744);
            brakeResistanceSmoothingTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeResistanceSmoothingTrackBar.Maximum = 100;
            brakeResistanceSmoothingTrackBar.Minimum = 1;
            brakeResistanceSmoothingTrackBar.Name = "brakeResistanceSmoothingTrackBar";
            brakeResistanceSmoothingTrackBar.Size = new System.Drawing.Size(460, 56);
            brakeResistanceSmoothingTrackBar.TabIndex = 23;
            brakeResistanceSmoothingTrackBar.TickFrequency = 10;
            brakeResistanceSmoothingTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(brakeResistanceSmoothingTrackBar, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
            brakeResistanceSmoothingTrackBar.Value = 1;
            brakeResistanceSmoothingTrackBar.Scroll += brakeResistanceSmoothingTrackBar_Scroll;
            // 
            // brakeResistanceSmoothingLabel
            // 
            brakeResistanceSmoothingLabel.AutoSize = true;
            brakeResistanceSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeResistanceSmoothingLabel.Location = new System.Drawing.Point(3, 740);
            brakeResistanceSmoothingLabel.Name = "brakeResistanceSmoothingLabel";
            brakeResistanceSmoothingLabel.Size = new System.Drawing.Size(155, 64);
            brakeResistanceSmoothingLabel.TabIndex = 22;
            brakeResistanceSmoothingLabel.Text = "Resistance Smoothing";
            brakeResistanceSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(brakeResistanceSmoothingLabel, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
            // 
            // maxBrakeResistanceTrackBar
            // 
            maxBrakeResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            maxBrakeResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            maxBrakeResistanceTrackBar.LargeChange = 50;
            maxBrakeResistanceTrackBar.Location = new System.Drawing.Point(164, 680);
            maxBrakeResistanceTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            maxBrakeResistanceTrackBar.Maximum = 7;
            maxBrakeResistanceTrackBar.Name = "maxBrakeResistanceTrackBar";
            maxBrakeResistanceTrackBar.Size = new System.Drawing.Size(460, 56);
            maxBrakeResistanceTrackBar.TabIndex = 21;
            maxBrakeResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(maxBrakeResistanceTrackBar, "The Maximum resistance on the Brake (0-7)");
            maxBrakeResistanceTrackBar.Scroll += maxBrakeResistanceTrackBar_Scroll;
            // 
            // maxBrakeResistanceLabel
            // 
            maxBrakeResistanceLabel.AutoSize = true;
            maxBrakeResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            maxBrakeResistanceLabel.Location = new System.Drawing.Point(3, 676);
            maxBrakeResistanceLabel.Name = "maxBrakeResistanceLabel";
            maxBrakeResistanceLabel.Size = new System.Drawing.Size(155, 64);
            maxBrakeResistanceLabel.TabIndex = 20;
            maxBrakeResistanceLabel.Text = "Max Resistance";
            maxBrakeResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(maxBrakeResistanceLabel, "The Maximum resistance on the Brake (0-7)");
            // 
            // minBrakeResistanceTrackBar
            // 
            minBrakeResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            minBrakeResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            minBrakeResistanceTrackBar.LargeChange = 50;
            minBrakeResistanceTrackBar.Location = new System.Drawing.Point(164, 616);
            minBrakeResistanceTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            minBrakeResistanceTrackBar.Maximum = 7;
            minBrakeResistanceTrackBar.Name = "minBrakeResistanceTrackBar";
            minBrakeResistanceTrackBar.Size = new System.Drawing.Size(460, 56);
            minBrakeResistanceTrackBar.TabIndex = 19;
            minBrakeResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(minBrakeResistanceTrackBar, "The Minimum resistance on the Brake (0-7)");
            minBrakeResistanceTrackBar.Scroll += minBrakeResistanceTrackBar_Scroll;
            // 
            // minBrakeResistanceLabel
            // 
            minBrakeResistanceLabel.AutoSize = true;
            minBrakeResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            minBrakeResistanceLabel.Location = new System.Drawing.Point(3, 612);
            minBrakeResistanceLabel.Name = "minBrakeResistanceLabel";
            minBrakeResistanceLabel.Size = new System.Drawing.Size(155, 64);
            minBrakeResistanceLabel.TabIndex = 18;
            minBrakeResistanceLabel.Text = "Min Resistance";
            minBrakeResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(minBrakeResistanceLabel, "The Minimum resistance on the Brake (0-7)");
            // 
            // maxBrakeStiffnessTrackBar
            // 
            maxBrakeStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            maxBrakeStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            maxBrakeStiffnessTrackBar.LargeChange = 50;
            maxBrakeStiffnessTrackBar.Location = new System.Drawing.Point(164, 552);
            maxBrakeStiffnessTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            maxBrakeStiffnessTrackBar.Maximum = 255;
            maxBrakeStiffnessTrackBar.Minimum = 1;
            maxBrakeStiffnessTrackBar.Name = "maxBrakeStiffnessTrackBar";
            maxBrakeStiffnessTrackBar.Size = new System.Drawing.Size(460, 56);
            maxBrakeStiffnessTrackBar.TabIndex = 17;
            maxBrakeStiffnessTrackBar.TickFrequency = 5;
            maxBrakeStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(maxBrakeStiffnessTrackBar, "On a scale of 1-255 with 1 being most stiff");
            maxBrakeStiffnessTrackBar.Value = 1;
            maxBrakeStiffnessTrackBar.Scroll += maxBrakeStiffnessTrackBar_Scroll;
            // 
            // maxBrakeStiffnessLabel
            // 
            maxBrakeStiffnessLabel.AutoSize = true;
            maxBrakeStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            maxBrakeStiffnessLabel.Location = new System.Drawing.Point(3, 548);
            maxBrakeStiffnessLabel.Name = "maxBrakeStiffnessLabel";
            maxBrakeStiffnessLabel.Size = new System.Drawing.Size(155, 64);
            maxBrakeStiffnessLabel.TabIndex = 16;
            maxBrakeStiffnessLabel.Text = "Max Stiffness";
            maxBrakeStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(maxBrakeStiffnessLabel, "On a scale of 1-255 with 1 being most stiff");
            // 
            // minBrakeStiffnessTrackBar
            // 
            minBrakeStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            minBrakeStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            minBrakeStiffnessTrackBar.LargeChange = 50;
            minBrakeStiffnessTrackBar.Location = new System.Drawing.Point(164, 488);
            minBrakeStiffnessTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            minBrakeStiffnessTrackBar.Maximum = 255;
            minBrakeStiffnessTrackBar.Minimum = 1;
            minBrakeStiffnessTrackBar.Name = "minBrakeStiffnessTrackBar";
            minBrakeStiffnessTrackBar.Size = new System.Drawing.Size(460, 56);
            minBrakeStiffnessTrackBar.TabIndex = 15;
            minBrakeStiffnessTrackBar.TickFrequency = 5;
            minBrakeStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(minBrakeStiffnessTrackBar, "On a scale of 1-255 with 1 being most stiff");
            minBrakeStiffnessTrackBar.Value = 1;
            minBrakeStiffnessTrackBar.Scroll += minBrakeStiffnessTrackBar_Scroll;
            // 
            // minBrakeStiffnessLabel
            // 
            minBrakeStiffnessLabel.AutoSize = true;
            minBrakeStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            minBrakeStiffnessLabel.Location = new System.Drawing.Point(3, 484);
            minBrakeStiffnessLabel.Name = "minBrakeStiffnessLabel";
            minBrakeStiffnessLabel.Size = new System.Drawing.Size(155, 64);
            minBrakeStiffnessLabel.TabIndex = 14;
            minBrakeStiffnessLabel.Text = "Min Stifness";
            minBrakeStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(minBrakeStiffnessLabel, "On a scale of 1-255 with 1 being most stiff");
            // 
            // vibrationSmoothingTrackBar
            // 
            vibrationSmoothingTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            vibrationSmoothingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            vibrationSmoothingTrackBar.LargeChange = 50;
            vibrationSmoothingTrackBar.Location = new System.Drawing.Point(164, 424);
            vibrationSmoothingTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            vibrationSmoothingTrackBar.Maximum = 100;
            vibrationSmoothingTrackBar.Minimum = 1;
            vibrationSmoothingTrackBar.Name = "vibrationSmoothingTrackBar";
            vibrationSmoothingTrackBar.Size = new System.Drawing.Size(460, 56);
            vibrationSmoothingTrackBar.TabIndex = 13;
            vibrationSmoothingTrackBar.TickFrequency = 10;
            vibrationSmoothingTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(vibrationSmoothingTrackBar, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
            vibrationSmoothingTrackBar.Value = 1;
            vibrationSmoothingTrackBar.Scroll += vibrationSmoothingTrackBar_Scroll;
            // 
            // vibrationSmoothingLabel
            // 
            vibrationSmoothingLabel.AutoSize = true;
            vibrationSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            vibrationSmoothingLabel.Location = new System.Drawing.Point(3, 420);
            vibrationSmoothingLabel.Name = "vibrationSmoothingLabel";
            vibrationSmoothingLabel.Size = new System.Drawing.Size(155, 64);
            vibrationSmoothingLabel.TabIndex = 12;
            vibrationSmoothingLabel.Text = "Vibration Smoothing";
            vibrationSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(vibrationSmoothingLabel, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
            // 
            // maxBrakeVibrationTrackBar
            // 
            maxBrakeVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            maxBrakeVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            maxBrakeVibrationTrackBar.LargeChange = 50;
            maxBrakeVibrationTrackBar.Location = new System.Drawing.Point(164, 360);
            maxBrakeVibrationTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            maxBrakeVibrationTrackBar.Maximum = 100;
            maxBrakeVibrationTrackBar.Name = "maxBrakeVibrationTrackBar";
            maxBrakeVibrationTrackBar.Size = new System.Drawing.Size(460, 56);
            maxBrakeVibrationTrackBar.TabIndex = 11;
            maxBrakeVibrationTrackBar.TickFrequency = 5;
            maxBrakeVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(maxBrakeVibrationTrackBar, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
            maxBrakeVibrationTrackBar.Scroll += maxBrakeVibrationTrackBar_Scroll;
            // 
            // maxBrakeVibrationLabel
            // 
            maxBrakeVibrationLabel.AutoSize = true;
            maxBrakeVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            maxBrakeVibrationLabel.Location = new System.Drawing.Point(3, 356);
            maxBrakeVibrationLabel.Name = "maxBrakeVibrationLabel";
            maxBrakeVibrationLabel.Size = new System.Drawing.Size(155, 64);
            maxBrakeVibrationLabel.TabIndex = 10;
            maxBrakeVibrationLabel.Text = "Max Brake Vibration";
            maxBrakeVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(maxBrakeVibrationLabel, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
            // 
            // minBrakeVibrationTrackBar
            // 
            minBrakeVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            minBrakeVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            minBrakeVibrationTrackBar.LargeChange = 50;
            minBrakeVibrationTrackBar.Location = new System.Drawing.Point(164, 296);
            minBrakeVibrationTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            minBrakeVibrationTrackBar.Maximum = 100;
            minBrakeVibrationTrackBar.Name = "minBrakeVibrationTrackBar";
            minBrakeVibrationTrackBar.Size = new System.Drawing.Size(460, 56);
            minBrakeVibrationTrackBar.TabIndex = 9;
            minBrakeVibrationTrackBar.TickFrequency = 5;
            minBrakeVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(minBrakeVibrationTrackBar, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in controller");
            minBrakeVibrationTrackBar.Scroll += minBrakeVibrationTrackBar_Scroll;
            // 
            // minBrakeVibrationLabel
            // 
            minBrakeVibrationLabel.AutoSize = true;
            minBrakeVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            minBrakeVibrationLabel.Location = new System.Drawing.Point(3, 292);
            minBrakeVibrationLabel.Name = "minBrakeVibrationLabel";
            minBrakeVibrationLabel.Size = new System.Drawing.Size(155, 64);
            minBrakeVibrationLabel.TabIndex = 8;
            minBrakeVibrationLabel.Text = "Min Brake Vibration";
            minBrakeVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(minBrakeVibrationLabel, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in controller");
            // 
            // brakeVibrationModeTrackBar
            // 
            brakeVibrationModeTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            brakeVibrationModeTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeVibrationModeTrackBar.LargeChange = 50;
            brakeVibrationModeTrackBar.Location = new System.Drawing.Point(164, 232);
            brakeVibrationModeTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeVibrationModeTrackBar.Maximum = 255;
            brakeVibrationModeTrackBar.Name = "brakeVibrationModeTrackBar";
            brakeVibrationModeTrackBar.Size = new System.Drawing.Size(460, 56);
            brakeVibrationModeTrackBar.TabIndex = 7;
            brakeVibrationModeTrackBar.TickFrequency = 5;
            brakeVibrationModeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(brakeVibrationModeTrackBar, "The depression of the brake lever at which the program should switch to vibration mode rather than smooth resistance. This helps to avoid clicking as vibration mode clicks when no force is applied. ");
            brakeVibrationModeTrackBar.Scroll += brakeVibrationModeTrackBar_Scroll;
            // 
            // brakeVibrationModeStartLabel
            // 
            brakeVibrationModeStartLabel.AutoSize = true;
            brakeVibrationModeStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeVibrationModeStartLabel.Location = new System.Drawing.Point(3, 228);
            brakeVibrationModeStartLabel.Name = "brakeVibrationModeStartLabel";
            brakeVibrationModeStartLabel.Size = new System.Drawing.Size(155, 64);
            brakeVibrationModeStartLabel.TabIndex = 6;
            brakeVibrationModeStartLabel.Text = "Vibration Mode Start";
            brakeVibrationModeStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(brakeVibrationModeStartLabel, "The depression of the brake lever at which the program should switch to vibration mode rather than smooth resistance. This helps to avoid clicking as vibration mode clicks when no force is applied. ");
            // 
            // brakeVibrationStartTrackBar
            // 
            brakeVibrationStartTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            brakeVibrationStartTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeVibrationStartTrackBar.LargeChange = 50;
            brakeVibrationStartTrackBar.Location = new System.Drawing.Point(164, 168);
            brakeVibrationStartTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeVibrationStartTrackBar.Maximum = 255;
            brakeVibrationStartTrackBar.Name = "brakeVibrationStartTrackBar";
            brakeVibrationStartTrackBar.Size = new System.Drawing.Size(460, 56);
            brakeVibrationStartTrackBar.TabIndex = 5;
            brakeVibrationStartTrackBar.TickFrequency = 5;
            brakeVibrationStartTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(brakeVibrationStartTrackBar, "The position in the Trigger (0-255) at which the brake should feel engaged with low grip surfaces");
            brakeVibrationStartTrackBar.Scroll += brakeVibrationStartTrackBar_Scroll;
            // 
            // brakeVibrationStartLabel
            // 
            brakeVibrationStartLabel.AutoSize = true;
            brakeVibrationStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeVibrationStartLabel.Location = new System.Drawing.Point(3, 164);
            brakeVibrationStartLabel.Name = "brakeVibrationStartLabel";
            brakeVibrationStartLabel.Size = new System.Drawing.Size(155, 64);
            brakeVibrationStartLabel.TabIndex = 4;
            brakeVibrationStartLabel.Text = "Vibration Start";
            brakeVibrationStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(brakeVibrationStartLabel, "The position in the Trigger (0-255) at which the brake should feel engaged with low grip surfaces");
            // 
            // gripLossTrackBar
            // 
            gripLossTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            gripLossTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            gripLossTrackBar.Location = new System.Drawing.Point(164, 104);
            gripLossTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gripLossTrackBar.Maximum = 100;
            gripLossTrackBar.Name = "gripLossTrackBar";
            gripLossTrackBar.Size = new System.Drawing.Size(460, 56);
            gripLossTrackBar.TabIndex = 3;
            gripLossTrackBar.TickFrequency = 5;
            gripLossTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(gripLossTrackBar, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no grip)");
            gripLossTrackBar.Value = 50;
            gripLossTrackBar.Scroll += gripLossTrackBar_Scroll;
            // 
            // gripLossLabel
            // 
            gripLossLabel.AutoSize = true;
            gripLossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            gripLossLabel.Location = new System.Drawing.Point(3, 100);
            gripLossLabel.Name = "gripLossLabel";
            gripLossLabel.Size = new System.Drawing.Size(155, 64);
            gripLossLabel.TabIndex = 2;
            gripLossLabel.Text = "Grip Loss Value";
            gripLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(gripLossLabel, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no grip)");
            // 
            // brakeEffectIntensityLabel
            // 
            brakeEffectIntensityLabel.AutoSize = true;
            brakeEffectIntensityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeEffectIntensityLabel.Location = new System.Drawing.Point(3, 36);
            brakeEffectIntensityLabel.Name = "brakeEffectIntensityLabel";
            brakeEffectIntensityLabel.Size = new System.Drawing.Size(155, 64);
            brakeEffectIntensityLabel.TabIndex = 0;
            brakeEffectIntensityLabel.Text = "Effect Intensity";
            brakeEffectIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(brakeEffectIntensityLabel, "The percentage of the trigger effects");
            // 
            // brakeEffectIntensityTrackBar
            // 
            brakeEffectIntensityTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            brakeEffectIntensityTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            brakeEffectIntensityTrackBar.LargeChange = 10;
            brakeEffectIntensityTrackBar.Location = new System.Drawing.Point(164, 40);
            brakeEffectIntensityTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeEffectIntensityTrackBar.Maximum = 100;
            brakeEffectIntensityTrackBar.Name = "brakeEffectIntensityTrackBar";
            brakeEffectIntensityTrackBar.Size = new System.Drawing.Size(460, 56);
            brakeEffectIntensityTrackBar.TabIndex = 1;
            brakeEffectIntensityTrackBar.TickFrequency = 5;
            brakeEffectIntensityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(brakeEffectIntensityTrackBar, "The percentage of the trigger effects");
            brakeEffectIntensityTrackBar.Value = 100;
            brakeEffectIntensityTrackBar.Scroll += brakeEffectIntensityTrackBar_Scroll;
            // 
            // buttonApply_Brake
            // 
            buttonApply_Brake.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonApply_Brake.AutoSize = true;
            buttonApply_Brake.Location = new System.Drawing.Point(164, 808);
            buttonApply_Brake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonApply_Brake.Name = "buttonApply_Brake";
            buttonApply_Brake.Size = new System.Drawing.Size(460, 46);
            buttonApply_Brake.TabIndex = 37;
            buttonApply_Brake.Text = "Apply";
            buttonApply_Brake.UseVisualStyleBackColor = true;
            buttonApply_Brake.Click += buttonApply_Brake_Click;
            // 
            // brakeDefaultsButton
            // 
            brakeDefaultsButton.AutoSize = true;
            brakeDefaultsButton.Location = new System.Drawing.Point(630, 808);
            brakeDefaultsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeDefaultsButton.Name = "brakeDefaultsButton";
            brakeDefaultsButton.Size = new System.Drawing.Size(99, 46);
            brakeDefaultsButton.TabIndex = 38;
            brakeDefaultsButton.Text = "Defaults";
            brakeDefaultsButton.UseVisualStyleBackColor = true;
            brakeDefaultsButton.Click += brakeDefaultsButton_Click;
            // 
            // brakeTriggerMode
            // 
            brakeTriggerMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            brakeTriggerMode.AutoSize = true;
            brakeTriggerMode.Location = new System.Drawing.Point(18, 0);
            brakeTriggerMode.Name = "brakeTriggerMode";
            brakeTriggerMode.Size = new System.Drawing.Size(140, 36);
            brakeTriggerMode.TabIndex = 39;
            brakeTriggerMode.Text = "Brake Trigger Mode";
            brakeTriggerMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // brakeTriggerModeComboBox
            // 
            brakeTriggerModeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            brakeTriggerModeComboBox.FormattingEnabled = true;
            brakeTriggerModeComboBox.Items.AddRange(new object[] { "Off", "Resistance", "Vibration" });
            brakeTriggerModeComboBox.Location = new System.Drawing.Point(164, 4);
            brakeTriggerModeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            brakeTriggerModeComboBox.Name = "brakeTriggerModeComboBox";
            brakeTriggerModeComboBox.Size = new System.Drawing.Size(460, 28);
            brakeTriggerModeComboBox.TabIndex = 40;
            brakeTriggerModeComboBox.SelectedIndexChanged += brakeTriggerModeComboBox_SelectedIndexChanged;
            // 
            // throttleConfigTabPage
            // 
            throttleConfigTabPage.Controls.Add(throttleTableLayoutPanel);
            throttleConfigTabPage.Location = new System.Drawing.Point(4, 29);
            throttleConfigTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleConfigTabPage.Name = "throttleConfigTabPage";
            throttleConfigTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleConfigTabPage.Size = new System.Drawing.Size(1279, 781);
            throttleConfigTabPage.TabIndex = 2;
            throttleConfigTabPage.Text = "Throttle Trigger";
            throttleConfigTabPage.UseVisualStyleBackColor = true;
            // 
            // throttleTableLayoutPanel
            // 
            throttleTableLayoutPanel.AutoScroll = true;
            throttleTableLayoutPanel.ColumnCount = 3;
            throttleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            throttleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            throttleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            throttleTableLayoutPanel.Controls.Add(throttleTriggerModeComboBox, 1, 0);
            throttleTableLayoutPanel.Controls.Add(throttleTriggerMode, 0, 0);
            throttleTableLayoutPanel.Controls.Add(throttleResistanceSmoothNumericUpDown, 2, 14);
            throttleTableLayoutPanel.Controls.Add(throttleMaxResistanceNumericUpDown, 2, 13);
            throttleTableLayoutPanel.Controls.Add(throttleMinResistanceNumericUpDown, 2, 12);
            throttleTableLayoutPanel.Controls.Add(throttleMaxStiffnessNumericUpDown, 2, 11);
            throttleTableLayoutPanel.Controls.Add(throttleMinStiffnessNumericUpDown, 2, 10);
            throttleTableLayoutPanel.Controls.Add(throttleVibrationSmoothNumericUpDown, 2, 9);
            throttleTableLayoutPanel.Controls.Add(throttleMaxVibrationNumericUpDown, 2, 8);
            throttleTableLayoutPanel.Controls.Add(throttleMinVibrationNumericUpDown, 2, 7);
            throttleTableLayoutPanel.Controls.Add(throttleVibrationStartNumericUpDown, 2, 6);
            throttleTableLayoutPanel.Controls.Add(throttleAccelLimitNumericUpDown, 2, 5);
            throttleTableLayoutPanel.Controls.Add(throttleForwardAccelScaleNumericUpDown, 2, 4);
            throttleTableLayoutPanel.Controls.Add(throttleTurnAccelScaleNumericUpDown, 2, 3);
            throttleTableLayoutPanel.Controls.Add(throttleGripLossNumericUpDown, 2, 2);
            throttleTableLayoutPanel.Controls.Add(throttleIntensityNumericUpDown, 2, 1);
            throttleTableLayoutPanel.Controls.Add(throttleResistanceSmoothTrackBar, 1, 14);
            throttleTableLayoutPanel.Controls.Add(throttleMaxResistanceTrackBar, 1, 13);
            throttleTableLayoutPanel.Controls.Add(throttleMinResistanceTrackBar, 1, 12);
            throttleTableLayoutPanel.Controls.Add(throttleMaxStiffnessTrackBar, 1, 11);
            throttleTableLayoutPanel.Controls.Add(throttleMinStiffnessTrackBar, 1, 10);
            throttleTableLayoutPanel.Controls.Add(throttleVibrationSmoothTrackBar, 1, 9);
            throttleTableLayoutPanel.Controls.Add(throttleMaxVibrationTrackBar, 1, 8);
            throttleTableLayoutPanel.Controls.Add(throttleMinVibrationTrackBar, 1, 7);
            throttleTableLayoutPanel.Controls.Add(throttleVibrationModeStartTrackBar, 1, 6);
            throttleTableLayoutPanel.Controls.Add(throttleAccelLimitTrackBar, 1, 5);
            throttleTableLayoutPanel.Controls.Add(throttleForwardAccelScaleTrackBar, 1, 4);
            throttleTableLayoutPanel.Controls.Add(throttleTurnAccelScaleTrackBar, 1, 3);
            throttleTableLayoutPanel.Controls.Add(throttleGripLossTrackBar, 1, 2);
            throttleTableLayoutPanel.Controls.Add(throttleIntensityTrackBar, 1, 1);
            throttleTableLayoutPanel.Controls.Add(throttleResistanceSmoothingLabel, 0, 14);
            throttleTableLayoutPanel.Controls.Add(maxThrottleResistanceLabel, 0, 13);
            throttleTableLayoutPanel.Controls.Add(minThrottleResistanceLabel, 0, 12);
            throttleTableLayoutPanel.Controls.Add(maxThrottleStiffnessLabel, 0, 11);
            throttleTableLayoutPanel.Controls.Add(minThrottleStiffnessLabel, 0, 10);
            throttleTableLayoutPanel.Controls.Add(throttleVibrationSmoothingLabel, 0, 9);
            throttleTableLayoutPanel.Controls.Add(maxThrottleVibrationLabel, 0, 8);
            throttleTableLayoutPanel.Controls.Add(minThrottleVibrationLabel, 0, 7);
            throttleTableLayoutPanel.Controls.Add(throttleVibrationStartLabel, 0, 6);
            throttleTableLayoutPanel.Controls.Add(accelerationLimitLabel, 0, 5);
            throttleTableLayoutPanel.Controls.Add(forwardAccelLabel, 0, 4);
            throttleTableLayoutPanel.Controls.Add(turnAccelLabel, 0, 3);
            throttleTableLayoutPanel.Controls.Add(throttleGripLossLabel, 0, 2);
            throttleTableLayoutPanel.Controls.Add(throttleIntensityLabel, 0, 1);
            throttleTableLayoutPanel.Controls.Add(buttonApply_Throttle, 1, 15);
            throttleTableLayoutPanel.Controls.Add(throttleDefaultsButton, 2, 15);
            throttleTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleTableLayoutPanel.Location = new System.Drawing.Point(3, 4);
            throttleTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleTableLayoutPanel.Name = "throttleTableLayoutPanel";
            throttleTableLayoutPanel.RowCount = 16;
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            throttleTableLayoutPanel.Size = new System.Drawing.Size(1273, 773);
            throttleTableLayoutPanel.TabIndex = 0;
            // 
            // throttleTriggerModeComboBox
            // 
            throttleTriggerModeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            throttleTriggerModeComboBox.FormattingEnabled = true;
            throttleTriggerModeComboBox.Items.AddRange(new object[] { "Off", "Resistance", "Vibration" });
            throttleTriggerModeComboBox.Location = new System.Drawing.Point(175, 4);
            throttleTriggerModeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleTriggerModeComboBox.Name = "throttleTriggerModeComboBox";
            throttleTriggerModeComboBox.Size = new System.Drawing.Size(460, 28);
            throttleTriggerModeComboBox.TabIndex = 46;
            throttleTriggerModeComboBox.SelectedIndexChanged += throttleTriggerModeComboBox_SelectedIndexChanged;
            // 
            // throttleTriggerMode
            // 
            throttleTriggerMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            throttleTriggerMode.AutoSize = true;
            throttleTriggerMode.Location = new System.Drawing.Point(14, 0);
            throttleTriggerMode.Name = "throttleTriggerMode";
            throttleTriggerMode.Size = new System.Drawing.Size(155, 36);
            throttleTriggerMode.TabIndex = 45;
            throttleTriggerMode.Text = "Throttle Trigger Mode";
            throttleTriggerMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // throttleResistanceSmoothNumericUpDown
            // 
            throttleResistanceSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleResistanceSmoothNumericUpDown.AutoSize = true;
            throttleResistanceSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleResistanceSmoothNumericUpDown.Location = new System.Drawing.Point(641, 886);
            throttleResistanceSmoothNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleResistanceSmoothNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            throttleResistanceSmoothNumericUpDown.Name = "throttleResistanceSmoothNumericUpDown";
            throttleResistanceSmoothNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleResistanceSmoothNumericUpDown.TabIndex = 42;
            toolTip.SetToolTip(throttleResistanceSmoothNumericUpDown, "Smoothing for Throttle Resistance output. Lower = smoother. Must be greater than 0");
            throttleResistanceSmoothNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            throttleResistanceSmoothNumericUpDown.ValueChanged += throttleResistanceSmoothNumericUpDown_ValueChanged;
            // 
            // throttleMaxResistanceNumericUpDown
            // 
            throttleMaxResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleMaxResistanceNumericUpDown.AutoSize = true;
            throttleMaxResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleMaxResistanceNumericUpDown.Location = new System.Drawing.Point(641, 822);
            throttleMaxResistanceNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMaxResistanceNumericUpDown.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            throttleMaxResistanceNumericUpDown.Name = "throttleMaxResistanceNumericUpDown";
            throttleMaxResistanceNumericUpDown.Size = new System.Drawing.Size(37, 27);
            throttleMaxResistanceNumericUpDown.TabIndex = 41;
            toolTip.SetToolTip(throttleMaxResistanceNumericUpDown, "The Maximum resistance on the throttle (0-7)");
            throttleMaxResistanceNumericUpDown.ValueChanged += throttleMaxResistanceNumericUpDown_ValueChanged;
            // 
            // throttleMinResistanceNumericUpDown
            // 
            throttleMinResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleMinResistanceNumericUpDown.AutoSize = true;
            throttleMinResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleMinResistanceNumericUpDown.Location = new System.Drawing.Point(641, 758);
            throttleMinResistanceNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMinResistanceNumericUpDown.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            throttleMinResistanceNumericUpDown.Name = "throttleMinResistanceNumericUpDown";
            throttleMinResistanceNumericUpDown.Size = new System.Drawing.Size(37, 27);
            throttleMinResistanceNumericUpDown.TabIndex = 40;
            toolTip.SetToolTip(throttleMinResistanceNumericUpDown, "The Minimum resistance on the throttle (0-7)");
            throttleMinResistanceNumericUpDown.ValueChanged += throttleMinResistanceNumericUpDown_ValueChanged;
            // 
            // throttleMaxStiffnessNumericUpDown
            // 
            throttleMaxStiffnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleMaxStiffnessNumericUpDown.AutoSize = true;
            throttleMaxStiffnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleMaxStiffnessNumericUpDown.Location = new System.Drawing.Point(641, 694);
            throttleMaxStiffnessNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMaxStiffnessNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            throttleMaxStiffnessNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            throttleMaxStiffnessNumericUpDown.Name = "throttleMaxStiffnessNumericUpDown";
            throttleMaxStiffnessNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleMaxStiffnessNumericUpDown.TabIndex = 39;
            toolTip.SetToolTip(throttleMaxStiffnessNumericUpDown, "On a scale of 1-255 with 1 being most stiff");
            throttleMaxStiffnessNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            throttleMaxStiffnessNumericUpDown.ValueChanged += throttleMaxStiffnessNumericUpDown_ValueChanged;
            // 
            // throttleMinStiffnessNumericUpDown
            // 
            throttleMinStiffnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleMinStiffnessNumericUpDown.AutoSize = true;
            throttleMinStiffnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleMinStiffnessNumericUpDown.Location = new System.Drawing.Point(641, 630);
            throttleMinStiffnessNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMinStiffnessNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            throttleMinStiffnessNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            throttleMinStiffnessNumericUpDown.Name = "throttleMinStiffnessNumericUpDown";
            throttleMinStiffnessNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleMinStiffnessNumericUpDown.TabIndex = 38;
            toolTip.SetToolTip(throttleMinStiffnessNumericUpDown, "On a scale of 1-255 with 1 being most stiff");
            throttleMinStiffnessNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            throttleMinStiffnessNumericUpDown.ValueChanged += throttleMinStiffnessNumericUpDown_ValueChanged;
            // 
            // throttleVibrationSmoothNumericUpDown
            // 
            throttleVibrationSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleVibrationSmoothNumericUpDown.AutoSize = true;
            throttleVibrationSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleVibrationSmoothNumericUpDown.Location = new System.Drawing.Point(641, 566);
            throttleVibrationSmoothNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleVibrationSmoothNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            throttleVibrationSmoothNumericUpDown.Name = "throttleVibrationSmoothNumericUpDown";
            throttleVibrationSmoothNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleVibrationSmoothNumericUpDown.TabIndex = 37;
            toolTip.SetToolTip(throttleVibrationSmoothNumericUpDown, "Smoothing for Throttle Vibration output. Lower = smoother. Must be greater than 0");
            throttleVibrationSmoothNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            throttleVibrationSmoothNumericUpDown.ValueChanged += throttleVibrationSmoothNumericUpDown_ValueChanged;
            // 
            // throttleMaxVibrationNumericUpDown
            // 
            throttleMaxVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleMaxVibrationNumericUpDown.AutoSize = true;
            throttleMaxVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleMaxVibrationNumericUpDown.Location = new System.Drawing.Point(641, 502);
            throttleMaxVibrationNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMaxVibrationNumericUpDown.Name = "throttleMaxVibrationNumericUpDown";
            throttleMaxVibrationNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleMaxVibrationNumericUpDown.TabIndex = 36;
            toolTip.SetToolTip(throttleMaxVibrationNumericUpDown, "The maximum acceleration frequency in Hz (avoid over 40). Correlates to better grip");
            throttleMaxVibrationNumericUpDown.ValueChanged += throttleMaxVibrationNumericUpDown_ValueChanged;
            // 
            // throttleMinVibrationNumericUpDown
            // 
            throttleMinVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleMinVibrationNumericUpDown.AutoSize = true;
            throttleMinVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleMinVibrationNumericUpDown.Location = new System.Drawing.Point(641, 438);
            throttleMinVibrationNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMinVibrationNumericUpDown.Name = "throttleMinVibrationNumericUpDown";
            throttleMinVibrationNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleMinVibrationNumericUpDown.TabIndex = 35;
            toolTip.SetToolTip(throttleMinVibrationNumericUpDown, "The minimum acceleration frequency in Hz (avoid over 40). Helps avoid clicking in controller");
            throttleMinVibrationNumericUpDown.ValueChanged += throttleMinVibrationNumericUpDown_ValueChanged;
            // 
            // throttleVibrationStartNumericUpDown
            // 
            throttleVibrationStartNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleVibrationStartNumericUpDown.AutoSize = true;
            throttleVibrationStartNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleVibrationStartNumericUpDown.Location = new System.Drawing.Point(641, 374);
            throttleVibrationStartNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleVibrationStartNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            throttleVibrationStartNumericUpDown.Name = "throttleVibrationStartNumericUpDown";
            throttleVibrationStartNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleVibrationStartNumericUpDown.TabIndex = 34;
            toolTip.SetToolTip(throttleVibrationStartNumericUpDown, "The depression of the throttle lever at which the program should switch to vibration mode rather than smooth resistance. This helps to avoid clicking as vibration mode clicks when no force is applied.");
            throttleVibrationStartNumericUpDown.ValueChanged += throttleVibrationStartNumericUpDown_ValueChanged;
            // 
            // throttleAccelLimitNumericUpDown
            // 
            throttleAccelLimitNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleAccelLimitNumericUpDown.AutoSize = true;
            throttleAccelLimitNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleAccelLimitNumericUpDown.Location = new System.Drawing.Point(641, 310);
            throttleAccelLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleAccelLimitNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            throttleAccelLimitNumericUpDown.Name = "throttleAccelLimitNumericUpDown";
            throttleAccelLimitNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleAccelLimitNumericUpDown.TabIndex = 33;
            toolTip.SetToolTip(throttleAccelLimitNumericUpDown, "The upper end acceleration when calculating the throttle resistance. Any acceleration above this will be counted as this value when determining the throttle resistance.");
            throttleAccelLimitNumericUpDown.ValueChanged += throttleAccelLimitNumericUpDown_ValueChanged;
            // 
            // throttleForwardAccelScaleNumericUpDown
            // 
            throttleForwardAccelScaleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleForwardAccelScaleNumericUpDown.AutoSize = true;
            throttleForwardAccelScaleNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleForwardAccelScaleNumericUpDown.Location = new System.Drawing.Point(641, 246);
            throttleForwardAccelScaleNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleForwardAccelScaleNumericUpDown.Name = "throttleForwardAccelScaleNumericUpDown";
            throttleForwardAccelScaleNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleForwardAccelScaleNumericUpDown.TabIndex = 32;
            toolTip.SetToolTip(throttleForwardAccelScaleNumericUpDown, "How to scale Forward acceleration in determining throttle stiffness.");
            throttleForwardAccelScaleNumericUpDown.ValueChanged += throttleForwardAccelScaleNumericUpDown_ValueChanged;
            // 
            // throttleTurnAccelScaleNumericUpDown
            // 
            throttleTurnAccelScaleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleTurnAccelScaleNumericUpDown.AutoSize = true;
            throttleTurnAccelScaleNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleTurnAccelScaleNumericUpDown.Location = new System.Drawing.Point(641, 182);
            throttleTurnAccelScaleNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleTurnAccelScaleNumericUpDown.Name = "throttleTurnAccelScaleNumericUpDown";
            throttleTurnAccelScaleNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleTurnAccelScaleNumericUpDown.TabIndex = 31;
            toolTip.SetToolTip(throttleTurnAccelScaleNumericUpDown, "How to scale turning acceleration in determining throttle stiffness.");
            throttleTurnAccelScaleNumericUpDown.ValueChanged += throttleTurnAccelScaleNumericUpDown_ValueChanged;
            // 
            // throttleGripLossNumericUpDown
            // 
            throttleGripLossNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleGripLossNumericUpDown.AutoSize = true;
            throttleGripLossNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleGripLossNumericUpDown.Location = new System.Drawing.Point(641, 118);
            throttleGripLossNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleGripLossNumericUpDown.Name = "throttleGripLossNumericUpDown";
            throttleGripLossNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleGripLossNumericUpDown.TabIndex = 30;
            toolTip.SetToolTip(throttleGripLossNumericUpDown, "The point at which the throttle will begin to become choppy (0 = full grip, 100 = no grip)");
            throttleGripLossNumericUpDown.ValueChanged += throttleGripLossNumericUpDown_ValueChanged;
            // 
            // throttleIntensityNumericUpDown
            // 
            throttleIntensityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            throttleIntensityNumericUpDown.AutoSize = true;
            throttleIntensityNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            throttleIntensityNumericUpDown.Location = new System.Drawing.Point(641, 54);
            throttleIntensityNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleIntensityNumericUpDown.Name = "throttleIntensityNumericUpDown";
            throttleIntensityNumericUpDown.Size = new System.Drawing.Size(53, 27);
            throttleIntensityNumericUpDown.TabIndex = 29;
            toolTip.SetToolTip(throttleIntensityNumericUpDown, "The percentage of the trigger effects");
            throttleIntensityNumericUpDown.ValueChanged += throttleIntensityNumericUpDown_ValueChanged;
            // 
            // throttleResistanceSmoothTrackBar
            // 
            throttleResistanceSmoothTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleResistanceSmoothTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleResistanceSmoothTrackBar.LargeChange = 50;
            throttleResistanceSmoothTrackBar.Location = new System.Drawing.Point(175, 872);
            throttleResistanceSmoothTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleResistanceSmoothTrackBar.Maximum = 100;
            throttleResistanceSmoothTrackBar.Minimum = 1;
            throttleResistanceSmoothTrackBar.Name = "throttleResistanceSmoothTrackBar";
            throttleResistanceSmoothTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleResistanceSmoothTrackBar.TabIndex = 28;
            throttleResistanceSmoothTrackBar.TickFrequency = 10;
            throttleResistanceSmoothTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleResistanceSmoothTrackBar, "Smoothing for Throttle Resistance output. Lower = smoother. Must be greater than 0");
            throttleResistanceSmoothTrackBar.Value = 1;
            throttleResistanceSmoothTrackBar.Scroll += throttleResistanceSmoothTrackBar_Scroll;
            // 
            // throttleMaxResistanceTrackBar
            // 
            throttleMaxResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleMaxResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleMaxResistanceTrackBar.LargeChange = 50;
            throttleMaxResistanceTrackBar.Location = new System.Drawing.Point(175, 808);
            throttleMaxResistanceTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMaxResistanceTrackBar.Maximum = 7;
            throttleMaxResistanceTrackBar.Name = "throttleMaxResistanceTrackBar";
            throttleMaxResistanceTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleMaxResistanceTrackBar.TabIndex = 27;
            throttleMaxResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleMaxResistanceTrackBar, "The Maximum resistance on the throttle (0-7)");
            throttleMaxResistanceTrackBar.Scroll += throttleMaxResistanceTrackBar_Scroll;
            // 
            // throttleMinResistanceTrackBar
            // 
            throttleMinResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleMinResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleMinResistanceTrackBar.LargeChange = 50;
            throttleMinResistanceTrackBar.Location = new System.Drawing.Point(175, 744);
            throttleMinResistanceTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMinResistanceTrackBar.Maximum = 7;
            throttleMinResistanceTrackBar.Name = "throttleMinResistanceTrackBar";
            throttleMinResistanceTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleMinResistanceTrackBar.TabIndex = 26;
            throttleMinResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleMinResistanceTrackBar, "The Minimum resistance on the throttle (0-7)");
            throttleMinResistanceTrackBar.Scroll += throttleMinResistanceTrackBar_Scroll;
            // 
            // throttleMaxStiffnessTrackBar
            // 
            throttleMaxStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleMaxStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleMaxStiffnessTrackBar.LargeChange = 50;
            throttleMaxStiffnessTrackBar.Location = new System.Drawing.Point(175, 680);
            throttleMaxStiffnessTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMaxStiffnessTrackBar.Maximum = 255;
            throttleMaxStiffnessTrackBar.Minimum = 1;
            throttleMaxStiffnessTrackBar.Name = "throttleMaxStiffnessTrackBar";
            throttleMaxStiffnessTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleMaxStiffnessTrackBar.TabIndex = 25;
            throttleMaxStiffnessTrackBar.TickFrequency = 5;
            throttleMaxStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleMaxStiffnessTrackBar, "On a scale of 1-255 with 1 being most stiff");
            throttleMaxStiffnessTrackBar.Value = 1;
            throttleMaxStiffnessTrackBar.Scroll += throttleMaxStiffnessTrackBar_Scroll;
            // 
            // throttleMinStiffnessTrackBar
            // 
            throttleMinStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleMinStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleMinStiffnessTrackBar.LargeChange = 50;
            throttleMinStiffnessTrackBar.Location = new System.Drawing.Point(175, 616);
            throttleMinStiffnessTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMinStiffnessTrackBar.Maximum = 255;
            throttleMinStiffnessTrackBar.Minimum = 1;
            throttleMinStiffnessTrackBar.Name = "throttleMinStiffnessTrackBar";
            throttleMinStiffnessTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleMinStiffnessTrackBar.TabIndex = 24;
            throttleMinStiffnessTrackBar.TickFrequency = 5;
            throttleMinStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleMinStiffnessTrackBar, "On a scale of 1-255 with 1 being most stiff");
            throttleMinStiffnessTrackBar.Value = 1;
            throttleMinStiffnessTrackBar.Scroll += throttleMinStiffnessTrackBar_Scroll;
            // 
            // throttleVibrationSmoothTrackBar
            // 
            throttleVibrationSmoothTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleVibrationSmoothTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleVibrationSmoothTrackBar.LargeChange = 50;
            throttleVibrationSmoothTrackBar.Location = new System.Drawing.Point(175, 552);
            throttleVibrationSmoothTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleVibrationSmoothTrackBar.Maximum = 100;
            throttleVibrationSmoothTrackBar.Minimum = 1;
            throttleVibrationSmoothTrackBar.Name = "throttleVibrationSmoothTrackBar";
            throttleVibrationSmoothTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleVibrationSmoothTrackBar.TabIndex = 23;
            throttleVibrationSmoothTrackBar.TickFrequency = 10;
            throttleVibrationSmoothTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleVibrationSmoothTrackBar, "Smoothing for Throttle Vibration output. Lower = smoother. Must be greater than 0");
            throttleVibrationSmoothTrackBar.Value = 1;
            throttleVibrationSmoothTrackBar.Scroll += throttleVibrationSmoothTrackBar_Scroll;
            // 
            // throttleMaxVibrationTrackBar
            // 
            throttleMaxVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleMaxVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleMaxVibrationTrackBar.LargeChange = 50;
            throttleMaxVibrationTrackBar.Location = new System.Drawing.Point(175, 488);
            throttleMaxVibrationTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMaxVibrationTrackBar.Maximum = 100;
            throttleMaxVibrationTrackBar.Name = "throttleMaxVibrationTrackBar";
            throttleMaxVibrationTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleMaxVibrationTrackBar.TabIndex = 22;
            throttleMaxVibrationTrackBar.TickFrequency = 5;
            throttleMaxVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleMaxVibrationTrackBar, "The maximum acceleration frequency in Hz (avoid over 40). Correlates to better grip");
            throttleMaxVibrationTrackBar.Scroll += throttleMaxVibrationTrackBar_Scroll;
            // 
            // throttleMinVibrationTrackBar
            // 
            throttleMinVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleMinVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleMinVibrationTrackBar.LargeChange = 50;
            throttleMinVibrationTrackBar.Location = new System.Drawing.Point(175, 424);
            throttleMinVibrationTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleMinVibrationTrackBar.Maximum = 100;
            throttleMinVibrationTrackBar.Name = "throttleMinVibrationTrackBar";
            throttleMinVibrationTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleMinVibrationTrackBar.TabIndex = 21;
            throttleMinVibrationTrackBar.TickFrequency = 5;
            throttleMinVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleMinVibrationTrackBar, "The minimum acceleration frequency in Hz (avoid over 40). Helps avoid clicking in controller");
            throttleMinVibrationTrackBar.Scroll += throttleMinVibrationTrackBar_Scroll;
            // 
            // throttleVibrationModeStartTrackBar
            // 
            throttleVibrationModeStartTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleVibrationModeStartTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleVibrationModeStartTrackBar.LargeChange = 50;
            throttleVibrationModeStartTrackBar.Location = new System.Drawing.Point(175, 360);
            throttleVibrationModeStartTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleVibrationModeStartTrackBar.Maximum = 255;
            throttleVibrationModeStartTrackBar.Name = "throttleVibrationModeStartTrackBar";
            throttleVibrationModeStartTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleVibrationModeStartTrackBar.TabIndex = 20;
            throttleVibrationModeStartTrackBar.TickFrequency = 5;
            throttleVibrationModeStartTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleVibrationModeStartTrackBar, "The depression of the throttle lever at which the program should switch to vibration mode rather than smooth resistance. This helps to avoid clicking as vibration mode clicks when no force is applied.");
            throttleVibrationModeStartTrackBar.Scroll += throttleVibrationModeStartTrackBar_Scroll;
            // 
            // throttleAccelLimitTrackBar
            // 
            throttleAccelLimitTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleAccelLimitTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleAccelLimitTrackBar.LargeChange = 50;
            throttleAccelLimitTrackBar.Location = new System.Drawing.Point(175, 296);
            throttleAccelLimitTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleAccelLimitTrackBar.Maximum = 255;
            throttleAccelLimitTrackBar.Name = "throttleAccelLimitTrackBar";
            throttleAccelLimitTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleAccelLimitTrackBar.TabIndex = 19;
            throttleAccelLimitTrackBar.TickFrequency = 5;
            throttleAccelLimitTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleAccelLimitTrackBar, "The upper end acceleration when calculating the throttle resistance. Any acceleration above this will be counted as this value when determining the throttle resistance.");
            throttleAccelLimitTrackBar.Scroll += throttleAccelLimitTrackBar_Scroll;
            // 
            // throttleForwardAccelScaleTrackBar
            // 
            throttleForwardAccelScaleTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleForwardAccelScaleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleForwardAccelScaleTrackBar.Location = new System.Drawing.Point(175, 232);
            throttleForwardAccelScaleTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleForwardAccelScaleTrackBar.Maximum = 100;
            throttleForwardAccelScaleTrackBar.Name = "throttleForwardAccelScaleTrackBar";
            throttleForwardAccelScaleTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleForwardAccelScaleTrackBar.TabIndex = 18;
            throttleForwardAccelScaleTrackBar.TickFrequency = 5;
            throttleForwardAccelScaleTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleForwardAccelScaleTrackBar, "How to scale Forward acceleration in determining throttle stiffness.");
            throttleForwardAccelScaleTrackBar.Value = 50;
            throttleForwardAccelScaleTrackBar.Scroll += throttleForwardAccelScaleTrackBar_Scroll;
            // 
            // throttleTurnAccelScaleTrackBar
            // 
            throttleTurnAccelScaleTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleTurnAccelScaleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleTurnAccelScaleTrackBar.Location = new System.Drawing.Point(175, 168);
            throttleTurnAccelScaleTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleTurnAccelScaleTrackBar.Maximum = 100;
            throttleTurnAccelScaleTrackBar.Name = "throttleTurnAccelScaleTrackBar";
            throttleTurnAccelScaleTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleTurnAccelScaleTrackBar.TabIndex = 17;
            throttleTurnAccelScaleTrackBar.TickFrequency = 5;
            throttleTurnAccelScaleTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleTurnAccelScaleTrackBar, "How to scale turning acceleration in determining throttle stiffness.");
            throttleTurnAccelScaleTrackBar.Value = 50;
            throttleTurnAccelScaleTrackBar.Scroll += throttleTurnAccelScaleTrackBar_Scroll;
            // 
            // throttleGripLossTrackBar
            // 
            throttleGripLossTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleGripLossTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleGripLossTrackBar.LargeChange = 50;
            throttleGripLossTrackBar.Location = new System.Drawing.Point(175, 104);
            throttleGripLossTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleGripLossTrackBar.Maximum = 100;
            throttleGripLossTrackBar.Name = "throttleGripLossTrackBar";
            throttleGripLossTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleGripLossTrackBar.TabIndex = 16;
            throttleGripLossTrackBar.TickFrequency = 5;
            throttleGripLossTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleGripLossTrackBar, "The point at which the throttle will begin to become choppy (0 = full grip, 100 = no grip)");
            throttleGripLossTrackBar.Scroll += throttleGripLossTrackBar_Scroll;
            // 
            // throttleIntensityTrackBar
            // 
            throttleIntensityTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            throttleIntensityTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleIntensityTrackBar.LargeChange = 10;
            throttleIntensityTrackBar.Location = new System.Drawing.Point(175, 40);
            throttleIntensityTrackBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleIntensityTrackBar.Maximum = 100;
            throttleIntensityTrackBar.Name = "throttleIntensityTrackBar";
            throttleIntensityTrackBar.Size = new System.Drawing.Size(460, 56);
            throttleIntensityTrackBar.TabIndex = 2;
            throttleIntensityTrackBar.TickFrequency = 5;
            throttleIntensityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            toolTip.SetToolTip(throttleIntensityTrackBar, "The percentage of the trigger effects");
            throttleIntensityTrackBar.Value = 100;
            throttleIntensityTrackBar.Scroll += throttleIntensityTrackBar_Scroll;
            // 
            // throttleResistanceSmoothingLabel
            // 
            throttleResistanceSmoothingLabel.AutoSize = true;
            throttleResistanceSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleResistanceSmoothingLabel.Location = new System.Drawing.Point(3, 868);
            throttleResistanceSmoothingLabel.Name = "throttleResistanceSmoothingLabel";
            throttleResistanceSmoothingLabel.Size = new System.Drawing.Size(166, 64);
            throttleResistanceSmoothingLabel.TabIndex = 15;
            throttleResistanceSmoothingLabel.Text = "Resistance Smoothing";
            throttleResistanceSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(throttleResistanceSmoothingLabel, "Smoothing for Throttle Resistance output. Lower = smoother. Must be greater than 0");
            // 
            // maxThrottleResistanceLabel
            // 
            maxThrottleResistanceLabel.AutoSize = true;
            maxThrottleResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            maxThrottleResistanceLabel.Location = new System.Drawing.Point(3, 804);
            maxThrottleResistanceLabel.Name = "maxThrottleResistanceLabel";
            maxThrottleResistanceLabel.Size = new System.Drawing.Size(166, 64);
            maxThrottleResistanceLabel.TabIndex = 14;
            maxThrottleResistanceLabel.Text = "Max Throttle Resistance";
            maxThrottleResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(maxThrottleResistanceLabel, "The Maximum resistance on the throttle (0-7)");
            // 
            // minThrottleResistanceLabel
            // 
            minThrottleResistanceLabel.AutoSize = true;
            minThrottleResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            minThrottleResistanceLabel.Location = new System.Drawing.Point(3, 740);
            minThrottleResistanceLabel.Name = "minThrottleResistanceLabel";
            minThrottleResistanceLabel.Size = new System.Drawing.Size(166, 64);
            minThrottleResistanceLabel.TabIndex = 13;
            minThrottleResistanceLabel.Text = "Min Throttle Resistance";
            minThrottleResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(minThrottleResistanceLabel, "The Minimum resistance on the throttle (0-7)");
            // 
            // maxThrottleStiffnessLabel
            // 
            maxThrottleStiffnessLabel.AutoSize = true;
            maxThrottleStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            maxThrottleStiffnessLabel.Location = new System.Drawing.Point(3, 676);
            maxThrottleStiffnessLabel.Name = "maxThrottleStiffnessLabel";
            maxThrottleStiffnessLabel.Size = new System.Drawing.Size(166, 64);
            maxThrottleStiffnessLabel.TabIndex = 12;
            maxThrottleStiffnessLabel.Text = "Max Throttle Stiffness";
            maxThrottleStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(maxThrottleStiffnessLabel, "On a scale of 1-255 with 1 being most stiff");
            // 
            // minThrottleStiffnessLabel
            // 
            minThrottleStiffnessLabel.AutoSize = true;
            minThrottleStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            minThrottleStiffnessLabel.Location = new System.Drawing.Point(3, 612);
            minThrottleStiffnessLabel.Name = "minThrottleStiffnessLabel";
            minThrottleStiffnessLabel.Size = new System.Drawing.Size(166, 64);
            minThrottleStiffnessLabel.TabIndex = 11;
            minThrottleStiffnessLabel.Text = "Min Throttle Stiffness";
            minThrottleStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(minThrottleStiffnessLabel, "On a scale of 1-255 with 1 being most stiff");
            // 
            // throttleVibrationSmoothingLabel
            // 
            throttleVibrationSmoothingLabel.AutoSize = true;
            throttleVibrationSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleVibrationSmoothingLabel.Location = new System.Drawing.Point(3, 548);
            throttleVibrationSmoothingLabel.Name = "throttleVibrationSmoothingLabel";
            throttleVibrationSmoothingLabel.Size = new System.Drawing.Size(166, 64);
            throttleVibrationSmoothingLabel.TabIndex = 10;
            throttleVibrationSmoothingLabel.Text = "Vibration Smoothing";
            throttleVibrationSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(throttleVibrationSmoothingLabel, "Smoothing for Throttle Vibration output. Lower = smoother. Must be greater than 0");
            // 
            // maxThrottleVibrationLabel
            // 
            maxThrottleVibrationLabel.AutoSize = true;
            maxThrottleVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            maxThrottleVibrationLabel.Location = new System.Drawing.Point(3, 484);
            maxThrottleVibrationLabel.Name = "maxThrottleVibrationLabel";
            maxThrottleVibrationLabel.Size = new System.Drawing.Size(166, 64);
            maxThrottleVibrationLabel.TabIndex = 9;
            maxThrottleVibrationLabel.Text = "Max Throttle Vibration";
            maxThrottleVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(maxThrottleVibrationLabel, "The maximum acceleration frequency in Hz (avoid over 40). Correlates to better grip");
            // 
            // minThrottleVibrationLabel
            // 
            minThrottleVibrationLabel.AutoSize = true;
            minThrottleVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            minThrottleVibrationLabel.Location = new System.Drawing.Point(3, 420);
            minThrottleVibrationLabel.Name = "minThrottleVibrationLabel";
            minThrottleVibrationLabel.Size = new System.Drawing.Size(166, 64);
            minThrottleVibrationLabel.TabIndex = 8;
            minThrottleVibrationLabel.Text = "Min Throttle Vibration";
            minThrottleVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(minThrottleVibrationLabel, "The minimum acceleration frequency in Hz (avoid over 40). Helps avoid clicking in controller");
            // 
            // throttleVibrationStartLabel
            // 
            throttleVibrationStartLabel.AutoSize = true;
            throttleVibrationStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleVibrationStartLabel.Location = new System.Drawing.Point(3, 356);
            throttleVibrationStartLabel.Name = "throttleVibrationStartLabel";
            throttleVibrationStartLabel.Size = new System.Drawing.Size(166, 64);
            throttleVibrationStartLabel.TabIndex = 7;
            throttleVibrationStartLabel.Text = "Vibration Mode Start";
            throttleVibrationStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(throttleVibrationStartLabel, "The depression of the throttle lever at which the program should switch to vibration mode rather than smooth resistance. This helps to avoid clicking as vibration mode clicks when no force is applied.");
            // 
            // accelerationLimitLabel
            // 
            accelerationLimitLabel.AutoSize = true;
            accelerationLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            accelerationLimitLabel.Location = new System.Drawing.Point(3, 292);
            accelerationLimitLabel.Name = "accelerationLimitLabel";
            accelerationLimitLabel.Size = new System.Drawing.Size(166, 64);
            accelerationLimitLabel.TabIndex = 5;
            accelerationLimitLabel.Text = "Accel Limit";
            accelerationLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(accelerationLimitLabel, "The upper end acceleration when calculating the throttle resistance. Any acceleration above this will be counted as this value when determining the throttle resistance.");
            // 
            // forwardAccelLabel
            // 
            forwardAccelLabel.AutoSize = true;
            forwardAccelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            forwardAccelLabel.Location = new System.Drawing.Point(3, 228);
            forwardAccelLabel.Name = "forwardAccelLabel";
            forwardAccelLabel.Size = new System.Drawing.Size(166, 64);
            forwardAccelLabel.TabIndex = 6;
            forwardAccelLabel.Text = "Forward Accel Scale";
            forwardAccelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(forwardAccelLabel, "How to scale Forward acceleration in determining throttle stiffness.");
            // 
            // turnAccelLabel
            // 
            turnAccelLabel.AutoSize = true;
            turnAccelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            turnAccelLabel.Location = new System.Drawing.Point(3, 164);
            turnAccelLabel.Name = "turnAccelLabel";
            turnAccelLabel.Size = new System.Drawing.Size(166, 64);
            turnAccelLabel.TabIndex = 4;
            turnAccelLabel.Text = "Turn Accel Scale";
            turnAccelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(turnAccelLabel, "How to scale turning acceleration in determining throttle stiffness.");
            // 
            // throttleGripLossLabel
            // 
            throttleGripLossLabel.AutoSize = true;
            throttleGripLossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleGripLossLabel.Location = new System.Drawing.Point(3, 100);
            throttleGripLossLabel.Name = "throttleGripLossLabel";
            throttleGripLossLabel.Size = new System.Drawing.Size(166, 64);
            throttleGripLossLabel.TabIndex = 3;
            throttleGripLossLabel.Text = "Grip Loss Value";
            throttleGripLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(throttleGripLossLabel, "The point at which the throttle will begin to become choppy (0 = full grip, 100 = no grip)");
            // 
            // throttleIntensityLabel
            // 
            throttleIntensityLabel.AutoSize = true;
            throttleIntensityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            throttleIntensityLabel.Location = new System.Drawing.Point(3, 36);
            throttleIntensityLabel.Name = "throttleIntensityLabel";
            throttleIntensityLabel.Size = new System.Drawing.Size(166, 64);
            throttleIntensityLabel.TabIndex = 1;
            throttleIntensityLabel.Text = "Effect Intensity";
            throttleIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip.SetToolTip(throttleIntensityLabel, "The percentage of the trigger effects");
            // 
            // buttonApply_Throttle
            // 
            buttonApply_Throttle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonApply_Throttle.Location = new System.Drawing.Point(175, 936);
            buttonApply_Throttle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonApply_Throttle.Name = "buttonApply_Throttle";
            buttonApply_Throttle.Size = new System.Drawing.Size(460, 30);
            buttonApply_Throttle.TabIndex = 43;
            buttonApply_Throttle.Text = "Apply";
            buttonApply_Throttle.UseVisualStyleBackColor = true;
            buttonApply_Throttle.Click += buttonApply_Throttle_Click;
            // 
            // throttleDefaultsButton
            // 
            throttleDefaultsButton.Location = new System.Drawing.Point(641, 936);
            throttleDefaultsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            throttleDefaultsButton.Name = "throttleDefaultsButton";
            throttleDefaultsButton.Size = new System.Drawing.Size(86, 30);
            throttleDefaultsButton.TabIndex = 44;
            throttleDefaultsButton.Text = "Defaults";
            throttleDefaultsButton.UseVisualStyleBackColor = true;
            throttleDefaultsButton.Click += throttleDefaultsButton_Click;
            // 
            // outputTabPage
            // 
            outputTabPage.Controls.Add(raceGroupBox);
            outputTabPage.Controls.Add(noRaceGroupBox);
            outputTabPage.Controls.Add(outputListBox);
            outputTabPage.Location = new System.Drawing.Point(4, 29);
            outputTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            outputTabPage.Name = "outputTabPage";
            outputTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            outputTabPage.Size = new System.Drawing.Size(1279, 781);
            outputTabPage.TabIndex = 1;
            outputTabPage.Text = "Output";
            outputTabPage.UseVisualStyleBackColor = true;
            // 
            // raceGroupBox
            // 
            raceGroupBox.Controls.Add(tableLayoutPanel1);
            raceGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            raceGroupBox.Location = new System.Drawing.Point(3, 280);
            raceGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            raceGroupBox.Name = "raceGroupBox";
            raceGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            raceGroupBox.Size = new System.Drawing.Size(1273, 363);
            raceGroupBox.TabIndex = 3;
            raceGroupBox.TabStop = false;
            raceGroupBox.Text = "Racing";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(brakeMsg, 0, 3);
            tableLayoutPanel1.Controls.Add(brakeVibrationMsg, 0, 2);
            tableLayoutPanel1.Controls.Add(throttleMsg, 0, 1);
            tableLayoutPanel1.Controls.Add(throttleVibrationMsg, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(1267, 335);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // brakeMsg
            // 
            brakeMsg.AutoSize = true;
            brakeMsg.Location = new System.Drawing.Point(3, 60);
            brakeMsg.Name = "brakeMsg";
            brakeMsg.Size = new System.Drawing.Size(50, 20);
            brakeMsg.TabIndex = 3;
            brakeMsg.Text = "label1";
            // 
            // brakeVibrationMsg
            // 
            brakeVibrationMsg.AutoSize = true;
            brakeVibrationMsg.Location = new System.Drawing.Point(3, 40);
            brakeVibrationMsg.Name = "brakeVibrationMsg";
            brakeVibrationMsg.Size = new System.Drawing.Size(50, 20);
            brakeVibrationMsg.TabIndex = 2;
            brakeVibrationMsg.Text = "label1";
            // 
            // throttleMsg
            // 
            throttleMsg.AutoSize = true;
            throttleMsg.Location = new System.Drawing.Point(3, 20);
            throttleMsg.Name = "throttleMsg";
            throttleMsg.Size = new System.Drawing.Size(50, 20);
            throttleMsg.TabIndex = 1;
            throttleMsg.Text = "label1";
            // 
            // throttleVibrationMsg
            // 
            throttleVibrationMsg.AutoSize = true;
            throttleVibrationMsg.Location = new System.Drawing.Point(3, 0);
            throttleVibrationMsg.Name = "throttleVibrationMsg";
            throttleVibrationMsg.Size = new System.Drawing.Size(50, 20);
            throttleVibrationMsg.TabIndex = 0;
            throttleVibrationMsg.Text = "label1";
            // 
            // noRaceGroupBox
            // 
            noRaceGroupBox.Controls.Add(noRaceText);
            noRaceGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            noRaceGroupBox.Location = new System.Drawing.Point(3, 643);
            noRaceGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            noRaceGroupBox.Name = "noRaceGroupBox";
            noRaceGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            noRaceGroupBox.Size = new System.Drawing.Size(1273, 134);
            noRaceGroupBox.TabIndex = 2;
            noRaceGroupBox.TabStop = false;
            noRaceGroupBox.Text = "Menus";
            // 
            // noRaceText
            // 
            noRaceText.AutoSize = true;
            noRaceText.Dock = System.Windows.Forms.DockStyle.Fill;
            noRaceText.Location = new System.Drawing.Point(3, 24);
            noRaceText.Name = "noRaceText";
            noRaceText.Size = new System.Drawing.Size(50, 20);
            noRaceText.TabIndex = 1;
            noRaceText.Text = "label1";
            // 
            // outputListBox
            // 
            outputListBox.Dock = System.Windows.Forms.DockStyle.Top;
            outputListBox.FormattingEnabled = true;
            outputListBox.Location = new System.Drawing.Point(3, 4);
            outputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new System.Drawing.Size(1273, 844);
            outputListBox.TabIndex = 0;
            // 
            // toolStripStatusDSX
            // 
            toolStripStatusDSX.ForeColor = System.Drawing.Color.White;
            toolStripStatusDSX.Image = Properties.Resources.redBtn;
            toolStripStatusDSX.Name = "toolStripStatusDSX";
            toolStripStatusDSX.Size = new System.Drawing.Size(143, 24);
            toolStripStatusDSX.Text = "DSX Connection:";
            toolStripStatusDSX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripStatusForza
            // 
            toolStripStatusForza.ForeColor = System.Drawing.Color.White;
            toolStripStatusForza.Image = Properties.Resources.redBtn;
            toolStripStatusForza.Name = "toolStripStatusForza";
            toolStripStatusForza.Size = new System.Drawing.Size(154, 24);
            toolStripStatusForza.Text = "Game Connection:";
            toolStripStatusForza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripVerboseMode
            // 
            toolStripVerboseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripVerboseMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { verboseModeOffToolStripMenuItem, verboseModeLowToolStripMenuItem, verboseModeFullToolStripMenuItem });
            toolStripVerboseMode.ForeColor = System.Drawing.Color.White;
            toolStripVerboseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripVerboseMode.Name = "toolStripVerboseMode";
            toolStripVerboseMode.Size = new System.Drawing.Size(119, 28);
            toolStripVerboseMode.Text = "Verbose Mode";
            // 
            // verboseModeOffToolStripMenuItem
            // 
            verboseModeOffToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            verboseModeOffToolStripMenuItem.Name = "verboseModeOffToolStripMenuItem";
            verboseModeOffToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            verboseModeOffToolStripMenuItem.Text = "Off";
            verboseModeOffToolStripMenuItem.Click += verboseModeOffToolStripMenuItem_Click;
            // 
            // verboseModeLowToolStripMenuItem
            // 
            verboseModeLowToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            verboseModeLowToolStripMenuItem.Name = "verboseModeLowToolStripMenuItem";
            verboseModeLowToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            verboseModeLowToolStripMenuItem.Text = "Low Verbose";
            verboseModeLowToolStripMenuItem.Click += verboseModeLowToolStripMenuItem_Click;
            // 
            // verboseModeFullToolStripMenuItem
            // 
            verboseModeFullToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            verboseModeFullToolStripMenuItem.Name = "verboseModeFullToolStripMenuItem";
            verboseModeFullToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            verboseModeFullToolStripMenuItem.Text = "Full Verbose";
            verboseModeFullToolStripMenuItem.Click += verboseModeFullToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusDSX, toolStripStatusForza, toolStripVerboseMode, toolStripDSXPortButton, toolStripAppCheckButton });
            statusStrip1.Location = new System.Drawing.Point(0, 814);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(1478, 30);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDSXPortButton
            // 
            toolStripDSXPortButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDSXPortButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripDSXPortTextBox });
            toolStripDSXPortButton.ForeColor = System.Drawing.Color.White;
            toolStripDSXPortButton.Image = (System.Drawing.Image)resources.GetObject("toolStripDSXPortButton.Image");
            toolStripDSXPortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDSXPortButton.Name = "toolStripDSXPortButton";
            toolStripDSXPortButton.Size = new System.Drawing.Size(81, 28);
            toolStripDSXPortButton.Text = "DSX Port";
            toolStripDSXPortButton.Click += toolStripDSXPortButton_Click;
            // 
            // toolStripDSXPortTextBox
            // 
            toolStripDSXPortTextBox.MaxLength = 5;
            toolStripDSXPortTextBox.Name = "toolStripDSXPortTextBox";
            toolStripDSXPortTextBox.Size = new System.Drawing.Size(100, 27);
            toolStripDSXPortTextBox.Text = "0";
            toolStripDSXPortTextBox.KeyDown += toolStripDSXPortTextBox_KeyDown;
            // 
            // toolStripAppCheckButton
            // 
            toolStripAppCheckButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripAppCheckButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripAppCheckOffItem, toolStripAppCheckOnItem });
            toolStripAppCheckButton.ForeColor = System.Drawing.Color.White;
            toolStripAppCheckButton.Image = (System.Drawing.Image)resources.GetObject("toolStripAppCheckButton.Image");
            toolStripAppCheckButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripAppCheckButton.Name = "toolStripAppCheckButton";
            toolStripAppCheckButton.Size = new System.Drawing.Size(152, 28);
            toolStripAppCheckButton.Text = "App Check Enabled";
            // 
            // toolStripAppCheckOffItem
            // 
            toolStripAppCheckOffItem.Name = "toolStripAppCheckOffItem";
            toolStripAppCheckOffItem.Size = new System.Drawing.Size(113, 26);
            toolStripAppCheckOffItem.Text = "Off";
            toolStripAppCheckOffItem.Click += toolStripAppCheckOffItem_Click;
            // 
            // toolStripAppCheckOnItem
            // 
            toolStripAppCheckOnItem.Name = "toolStripAppCheckOnItem";
            toolStripAppCheckOnItem.Size = new System.Drawing.Size(113, 26);
            toolStripAppCheckOnItem.Text = "On";
            toolStripAppCheckOnItem.Click += toolStripAppCheckOnItem_Click;
            // 
            // ProfilesContextMenu
            // 
            ProfilesContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            ProfilesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, renameToolStripMenuItem, disableToolStripMenuItem, deleteToolStripMenuItem, copyToolStripMenuItem, defaultToolStripMenuItem, setActiveToolStripMenuItem });
            ProfilesContextMenu.Name = "ProfilesContextMenu";
            ProfilesContextMenu.Size = new System.Drawing.Size(145, 172);
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            renameToolStripMenuItem.Text = "Rename";
            renameToolStripMenuItem.Click += renameToolStripMenuItem_Click;
            // 
            // disableToolStripMenuItem
            // 
            disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            disableToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            disableToolStripMenuItem.Text = "Disable";
            disableToolStripMenuItem.Click += disableToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // setActiveToolStripMenuItem
            // 
            setActiveToolStripMenuItem.Name = "setActiveToolStripMenuItem";
            setActiveToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            setActiveToolStripMenuItem.Text = "Set Active";
            setActiveToolStripMenuItem.Click += setActiveToolStripMenuItem_Click;
            // 
            // UI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ClientSize = new System.Drawing.Size(1478, 844);
            Controls.Add(mainPanel);
            Controls.Add(statusStrip1);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(396, 246);
            Name = "UI";
            Text = "UI";
            Load += UI_Load;
            mainPanel.ResumeLayout(false);
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            profilesGroupBox.ResumeLayout(false);
            mainTabControl.ResumeLayout(false);
            miscTabPage.ResumeLayout(false);
            miscTabPage.PerformLayout();
            miscTableLayoutPanel.ResumeLayout(false);
            miscTableLayoutPanel.PerformLayout();
            ((ISupportInitialize)forzaPortNumericUpDown).EndInit();
            ((ISupportInitialize)rpmTrackBar).EndInit();
            ((ISupportInitialize)rpmValueNumericUpDown).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            brakeConfigTabPage.ResumeLayout(false);
            brakeConfigTabPage.PerformLayout();
            brakeTableLayoutPanel.ResumeLayout(false);
            brakeTableLayoutPanel.PerformLayout();
            ((ISupportInitialize)brakeResistanceSmoothNumericUpDown).EndInit();
            ((ISupportInitialize)maxBrakeResistanceNumericUpDown).EndInit();
            ((ISupportInitialize)minBrakeResistanceNumericUpDown).EndInit();
            ((ISupportInitialize)maxBrakeStifnessNumericUpDown).EndInit();
            ((ISupportInitialize)minBrakeStifnessNumericUpDown).EndInit();
            ((ISupportInitialize)brakeVibrationSmoothNumericUpDown).EndInit();
            ((ISupportInitialize)maxBrakeVibrationNumericUpDown).EndInit();
            ((ISupportInitialize)minBrakeVibrationNumericUpDown).EndInit();
            ((ISupportInitialize)brakeVibrationModeNumericUpDown).EndInit();
            ((ISupportInitialize)brakeVibrationStartNumericUpDown).EndInit();
            ((ISupportInitialize)gripLossNumericUpDown).EndInit();
            ((ISupportInitialize)brakeEffectNumericUpDown).EndInit();
            ((ISupportInitialize)brakeResistanceSmoothingTrackBar).EndInit();
            ((ISupportInitialize)maxBrakeResistanceTrackBar).EndInit();
            ((ISupportInitialize)minBrakeResistanceTrackBar).EndInit();
            ((ISupportInitialize)maxBrakeStiffnessTrackBar).EndInit();
            ((ISupportInitialize)minBrakeStiffnessTrackBar).EndInit();
            ((ISupportInitialize)vibrationSmoothingTrackBar).EndInit();
            ((ISupportInitialize)maxBrakeVibrationTrackBar).EndInit();
            ((ISupportInitialize)minBrakeVibrationTrackBar).EndInit();
            ((ISupportInitialize)brakeVibrationModeTrackBar).EndInit();
            ((ISupportInitialize)brakeVibrationStartTrackBar).EndInit();
            ((ISupportInitialize)gripLossTrackBar).EndInit();
            ((ISupportInitialize)brakeEffectIntensityTrackBar).EndInit();
            throttleConfigTabPage.ResumeLayout(false);
            throttleTableLayoutPanel.ResumeLayout(false);
            throttleTableLayoutPanel.PerformLayout();
            ((ISupportInitialize)throttleResistanceSmoothNumericUpDown).EndInit();
            ((ISupportInitialize)throttleMaxResistanceNumericUpDown).EndInit();
            ((ISupportInitialize)throttleMinResistanceNumericUpDown).EndInit();
            ((ISupportInitialize)throttleMaxStiffnessNumericUpDown).EndInit();
            ((ISupportInitialize)throttleMinStiffnessNumericUpDown).EndInit();
            ((ISupportInitialize)throttleVibrationSmoothNumericUpDown).EndInit();
            ((ISupportInitialize)throttleMaxVibrationNumericUpDown).EndInit();
            ((ISupportInitialize)throttleMinVibrationNumericUpDown).EndInit();
            ((ISupportInitialize)throttleVibrationStartNumericUpDown).EndInit();
            ((ISupportInitialize)throttleAccelLimitNumericUpDown).EndInit();
            ((ISupportInitialize)throttleForwardAccelScaleNumericUpDown).EndInit();
            ((ISupportInitialize)throttleTurnAccelScaleNumericUpDown).EndInit();
            ((ISupportInitialize)throttleGripLossNumericUpDown).EndInit();
            ((ISupportInitialize)throttleIntensityNumericUpDown).EndInit();
            ((ISupportInitialize)throttleResistanceSmoothTrackBar).EndInit();
            ((ISupportInitialize)throttleMaxResistanceTrackBar).EndInit();
            ((ISupportInitialize)throttleMinResistanceTrackBar).EndInit();
            ((ISupportInitialize)throttleMaxStiffnessTrackBar).EndInit();
            ((ISupportInitialize)throttleMinStiffnessTrackBar).EndInit();
            ((ISupportInitialize)throttleVibrationSmoothTrackBar).EndInit();
            ((ISupportInitialize)throttleMaxVibrationTrackBar).EndInit();
            ((ISupportInitialize)throttleMinVibrationTrackBar).EndInit();
            ((ISupportInitialize)throttleVibrationModeStartTrackBar).EndInit();
            ((ISupportInitialize)throttleAccelLimitTrackBar).EndInit();
            ((ISupportInitialize)throttleForwardAccelScaleTrackBar).EndInit();
            ((ISupportInitialize)throttleTurnAccelScaleTrackBar).EndInit();
            ((ISupportInitialize)throttleGripLossTrackBar).EndInit();
            ((ISupportInitialize)throttleIntensityTrackBar).EndInit();
            outputTabPage.ResumeLayout(false);
            raceGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            noRaceGroupBox.ResumeLayout(false);
            noRaceGroupBox.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ProfilesContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
		private System.Windows.Forms.Label rpmLabel;
		private System.Windows.Forms.TrackBar rpmTrackBar;
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
		private System.Windows.Forms.Button buttonApply_Brake;
		private System.Windows.Forms.Button buttonApply_Throttle;
		private System.Windows.Forms.Button brakeDefaultsButton;
		private System.Windows.Forms.Button throttleDefaultsButton;
		private System.Windows.Forms.Label brakeTriggerMode;
		private System.Windows.Forms.ComboBox brakeTriggerModeComboBox;
		private System.Windows.Forms.Label throttleTriggerMode;
		private System.Windows.Forms.ComboBox throttleTriggerModeComboBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ListView profilesListView;
        private System.Windows.Forms.GroupBox profilesGroupBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDSXPortButton;
        private System.Windows.Forms.ToolStripTextBox toolStripDSXPortTextBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripAppCheckButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripAppCheckOffItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripAppCheckOnItem;
        private System.Windows.Forms.ContextMenuStrip ProfilesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setActiveToolStripMenuItem;
        private System.Windows.Forms.Button buttonApplyMisc;
        private System.Windows.Forms.Button miscDefaultsButton;
        private System.Windows.Forms.Label ExecutableListLabel;
        private System.Windows.Forms.ListBox ExecutableListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddExecutableButton;
        private System.Windows.Forms.Button EditExecutableButton;
        private System.Windows.Forms.Button RemoveExecutableButton;
        private System.Windows.Forms.Label GameModeLabel;
        private System.Windows.Forms.ComboBox GameModeComboBox;
    }
}