﻿namespace ACT.FoxTTS
{
    partial class FoxTTSTabControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneralSettings = new System.Windows.Forms.TabPage();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.groupBoxTTSEngine = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTTSEngine = new System.Windows.Forms.Label();
            this.comboBoxTTSEngine = new System.Windows.Forms.ComboBox();
            this.checkBoxClearCacheExit = new System.Windows.Forms.CheckBox();
            this.linkLabelClearCache = new System.Windows.Forms.LinkLabel();
            this.linkLabelOpenCacheDir = new System.Windows.Forms.LinkLabel();
            this.panelTTSEngineSettings = new System.Windows.Forms.Panel();
            this.groupBoxPlayback = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPlayback = new System.Windows.Forms.TableLayoutPanel();
            this.labelMasterVolume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelCurrentVolume = new System.Windows.Forms.Label();
            this.labelPlaybackMethod = new System.Windows.Forms.Label();
            this.comboBoxPlaybackMethod = new System.Windows.Forms.ComboBox();
            this.labelPlaybackDevice = new System.Windows.Forms.Label();
            this.comboBoxPlaybackDevice = new System.Windows.Forms.ComboBox();
            this.checkBoxPlaybackYukkuri = new System.Windows.Forms.CheckBox();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCurrentVersion = new System.Windows.Forms.Label();
            this.labelCurrentVersionValue = new System.Windows.Forms.Label();
            this.labelLatestStableVersion = new System.Windows.Forms.Label();
            this.labelLatestVersion = new System.Windows.Forms.Label();
            this.labelLatestStableVersionValue = new System.Windows.Forms.Label();
            this.labelLatestVersionValue = new System.Windows.Forms.Label();
            this.checkBoxCheckUpdate = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifyStableOnly = new System.Windows.Forms.CheckBox();
            this.buttonCheckUpdate = new System.Windows.Forms.Button();
            this.buttonDownloadUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanelMainLanguage = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelMainLanguage = new System.Windows.Forms.Label();
            this.labelNeedToRestart = new System.Windows.Forms.Label();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneralSettings.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxTTSEngine.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxPlayback.SuspendLayout();
            this.tableLayoutPanelPlayback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBoxUpdate.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanelMainLanguage.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneralSettings);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 767);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageGeneralSettings
            // 
            this.tabPageGeneralSettings.AutoScroll = true;
            this.tabPageGeneralSettings.Controls.Add(this.groupBoxPreview);
            this.tabPageGeneralSettings.Controls.Add(this.groupBoxTTSEngine);
            this.tabPageGeneralSettings.Controls.Add(this.panelTTSEngineSettings);
            this.tabPageGeneralSettings.Controls.Add(this.groupBoxPlayback);
            this.tabPageGeneralSettings.Controls.Add(this.groupBoxUpdate);
            this.tabPageGeneralSettings.Controls.Add(this.tableLayoutPanelMainLanguage);
            this.tabPageGeneralSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageGeneralSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGeneralSettings.Name = "tabPageGeneralSettings";
            this.tabPageGeneralSettings.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageGeneralSettings.Size = new System.Drawing.Size(981, 738);
            this.tabPageGeneralSettings.TabIndex = 0;
            this.tabPageGeneralSettings.Text = "General Settings";
            this.tabPageGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxPreview.Location = new System.Drawing.Point(8, 420);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(347, 64);
            this.groupBoxPreview.TabIndex = 8;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.textBoxPreview, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonPreview, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreview.Location = new System.Drawing.Point(3, 3);
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.Size = new System.Drawing.Size(254, 25);
            this.textBoxPreview.TabIndex = 0;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.AutoSize = true;
            this.buttonPreview.Location = new System.Drawing.Point(263, 3);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 25);
            this.buttonPreview.TabIndex = 1;
            this.buttonPreview.Text = "Say!";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // groupBoxTTSEngine
            // 
            this.groupBoxTTSEngine.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxTTSEngine.Location = new System.Drawing.Point(8, 247);
            this.groupBoxTTSEngine.Name = "groupBoxTTSEngine";
            this.groupBoxTTSEngine.Size = new System.Drawing.Size(347, 166);
            this.groupBoxTTSEngine.TabIndex = 7;
            this.groupBoxTTSEngine.TabStop = false;
            this.groupBoxTTSEngine.Text = "TTS Engine";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelTTSEngine, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxTTSEngine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxClearCacheExit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelClearCache, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelOpenCacheDir, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelTTSEngine
            // 
            this.labelTTSEngine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTTSEngine.AutoSize = true;
            this.labelTTSEngine.Location = new System.Drawing.Point(3, 7);
            this.labelTTSEngine.Name = "labelTTSEngine";
            this.labelTTSEngine.Size = new System.Drawing.Size(63, 15);
            this.labelTTSEngine.TabIndex = 0;
            this.labelTTSEngine.Text = "Engine:";
            // 
            // comboBoxTTSEngine
            // 
            this.comboBoxTTSEngine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTTSEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTTSEngine.FormattingEnabled = true;
            this.comboBoxTTSEngine.Location = new System.Drawing.Point(72, 3);
            this.comboBoxTTSEngine.Name = "comboBoxTTSEngine";
            this.comboBoxTTSEngine.Size = new System.Drawing.Size(266, 23);
            this.comboBoxTTSEngine.TabIndex = 1;
            this.comboBoxTTSEngine.SelectedIndexChanged += new System.EventHandler(this.comboBoxTTSEngine_SelectedIndexChanged);
            // 
            // checkBoxClearCacheExit
            // 
            this.checkBoxClearCacheExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxClearCacheExit.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxClearCacheExit, 2);
            this.checkBoxClearCacheExit.Enabled = false;
            this.checkBoxClearCacheExit.Location = new System.Drawing.Point(3, 32);
            this.checkBoxClearCacheExit.Name = "checkBoxClearCacheExit";
            this.checkBoxClearCacheExit.Size = new System.Drawing.Size(335, 19);
            this.checkBoxClearCacheExit.TabIndex = 2;
            this.checkBoxClearCacheExit.Text = "Clear Cache on Exit";
            this.checkBoxClearCacheExit.UseVisualStyleBackColor = true;
            // 
            // linkLabelClearCache
            // 
            this.linkLabelClearCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelClearCache.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linkLabelClearCache, 2);
            this.linkLabelClearCache.Location = new System.Drawing.Point(3, 107);
            this.linkLabelClearCache.Name = "linkLabelClearCache";
            this.linkLabelClearCache.Size = new System.Drawing.Size(335, 15);
            this.linkLabelClearCache.TabIndex = 4;
            this.linkLabelClearCache.TabStop = true;
            this.linkLabelClearCache.Text = "Clear Cache Right Now";
            this.linkLabelClearCache.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearCache_LinkClicked);
            // 
            // linkLabelOpenCacheDir
            // 
            this.linkLabelOpenCacheDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelOpenCacheDir.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linkLabelOpenCacheDir, 2);
            this.linkLabelOpenCacheDir.Location = new System.Drawing.Point(3, 92);
            this.linkLabelOpenCacheDir.Name = "linkLabelOpenCacheDir";
            this.linkLabelOpenCacheDir.Size = new System.Drawing.Size(335, 15);
            this.linkLabelOpenCacheDir.TabIndex = 3;
            this.linkLabelOpenCacheDir.TabStop = true;
            this.linkLabelOpenCacheDir.Text = "Open Cache Directory";
            this.linkLabelOpenCacheDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenCacheDir_LinkClicked);
            // 
            // panelTTSEngineSettings
            // 
            this.panelTTSEngineSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTTSEngineSettings.Location = new System.Drawing.Point(361, 54);
            this.panelTTSEngineSettings.Name = "panelTTSEngineSettings";
            this.panelTTSEngineSettings.Size = new System.Drawing.Size(613, 677);
            this.panelTTSEngineSettings.TabIndex = 6;
            // 
            // groupBoxPlayback
            // 
            this.groupBoxPlayback.Controls.Add(this.tableLayoutPanelPlayback);
            this.groupBoxPlayback.Controls.Add(this.checkBoxPlaybackYukkuri);
            this.groupBoxPlayback.Location = new System.Drawing.Point(8, 54);
            this.groupBoxPlayback.Name = "groupBoxPlayback";
            this.groupBoxPlayback.Size = new System.Drawing.Size(347, 186);
            this.groupBoxPlayback.TabIndex = 5;
            this.groupBoxPlayback.TabStop = false;
            this.groupBoxPlayback.Text = "Playback";
            // 
            // tableLayoutPanelPlayback
            // 
            this.tableLayoutPanelPlayback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPlayback.ColumnCount = 3;
            this.tableLayoutPanelPlayback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPlayback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPlayback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPlayback.Controls.Add(this.labelMasterVolume, 0, 0);
            this.tableLayoutPanelPlayback.Controls.Add(this.trackBar1, 1, 0);
            this.tableLayoutPanelPlayback.Controls.Add(this.labelCurrentVolume, 2, 0);
            this.tableLayoutPanelPlayback.Controls.Add(this.labelPlaybackMethod, 0, 1);
            this.tableLayoutPanelPlayback.Controls.Add(this.comboBoxPlaybackMethod, 1, 1);
            this.tableLayoutPanelPlayback.Controls.Add(this.labelPlaybackDevice, 0, 2);
            this.tableLayoutPanelPlayback.Controls.Add(this.comboBoxPlaybackDevice, 1, 2);
            this.tableLayoutPanelPlayback.Location = new System.Drawing.Point(7, 49);
            this.tableLayoutPanelPlayback.Name = "tableLayoutPanelPlayback";
            this.tableLayoutPanelPlayback.RowCount = 4;
            this.tableLayoutPanelPlayback.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayback.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayback.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayback.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPlayback.Size = new System.Drawing.Size(334, 131);
            this.tableLayoutPanelPlayback.TabIndex = 1;
            // 
            // labelMasterVolume
            // 
            this.labelMasterVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMasterVolume.AutoSize = true;
            this.labelMasterVolume.Location = new System.Drawing.Point(3, 0);
            this.labelMasterVolume.Name = "labelMasterVolume";
            this.labelMasterVolume.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.labelMasterVolume.Size = new System.Drawing.Size(103, 22);
            this.labelMasterVolume.TabIndex = 0;
            this.labelMasterVolume.Text = "Master Vol.:";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(112, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(173, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // labelCurrentVolume
            // 
            this.labelCurrentVolume.AutoSize = true;
            this.labelCurrentVolume.Location = new System.Drawing.Point(291, 0);
            this.labelCurrentVolume.MinimumSize = new System.Drawing.Size(40, 0);
            this.labelCurrentVolume.Name = "labelCurrentVolume";
            this.labelCurrentVolume.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.labelCurrentVolume.Size = new System.Drawing.Size(40, 22);
            this.labelCurrentVolume.TabIndex = 2;
            this.labelCurrentVolume.Text = "100";
            // 
            // labelPlaybackMethod
            // 
            this.labelPlaybackMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlaybackMethod.AutoSize = true;
            this.labelPlaybackMethod.Location = new System.Drawing.Point(3, 69);
            this.labelPlaybackMethod.Name = "labelPlaybackMethod";
            this.labelPlaybackMethod.Size = new System.Drawing.Size(103, 15);
            this.labelPlaybackMethod.TabIndex = 3;
            this.labelPlaybackMethod.Text = "Method:";
            // 
            // comboBoxPlaybackMethod
            // 
            this.comboBoxPlaybackMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPlayback.SetColumnSpan(this.comboBoxPlaybackMethod, 2);
            this.comboBoxPlaybackMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlaybackMethod.FormattingEnabled = true;
            this.comboBoxPlaybackMethod.Location = new System.Drawing.Point(112, 65);
            this.comboBoxPlaybackMethod.Name = "comboBoxPlaybackMethod";
            this.comboBoxPlaybackMethod.Size = new System.Drawing.Size(219, 23);
            this.comboBoxPlaybackMethod.TabIndex = 4;
            // 
            // labelPlaybackDevice
            // 
            this.labelPlaybackDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlaybackDevice.AutoSize = true;
            this.labelPlaybackDevice.Location = new System.Drawing.Point(3, 98);
            this.labelPlaybackDevice.Name = "labelPlaybackDevice";
            this.labelPlaybackDevice.Size = new System.Drawing.Size(103, 15);
            this.labelPlaybackDevice.TabIndex = 5;
            this.labelPlaybackDevice.Text = "Device:";
            // 
            // comboBoxPlaybackDevice
            // 
            this.comboBoxPlaybackDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPlayback.SetColumnSpan(this.comboBoxPlaybackDevice, 2);
            this.comboBoxPlaybackDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlaybackDevice.FormattingEnabled = true;
            this.comboBoxPlaybackDevice.Location = new System.Drawing.Point(112, 94);
            this.comboBoxPlaybackDevice.Name = "comboBoxPlaybackDevice";
            this.comboBoxPlaybackDevice.Size = new System.Drawing.Size(219, 23);
            this.comboBoxPlaybackDevice.TabIndex = 6;
            // 
            // checkBoxPlaybackYukkuri
            // 
            this.checkBoxPlaybackYukkuri.AutoSize = true;
            this.checkBoxPlaybackYukkuri.Checked = true;
            this.checkBoxPlaybackYukkuri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlaybackYukkuri.Location = new System.Drawing.Point(6, 24);
            this.checkBoxPlaybackYukkuri.Name = "checkBoxPlaybackYukkuri";
            this.checkBoxPlaybackYukkuri.Size = new System.Drawing.Size(293, 19);
            this.checkBoxPlaybackYukkuri.TabIndex = 0;
            this.checkBoxPlaybackYukkuri.Text = "Use TTSYukkuri for Sound Playback";
            this.checkBoxPlaybackYukkuri.UseVisualStyleBackColor = true;
            this.checkBoxPlaybackYukkuri.CheckedChanged += new System.EventHandler(this.checkBoxPlaybackYukkuri_CheckedChanged);
            this.checkBoxPlaybackYukkuri.EnabledChanged += new System.EventHandler(this.checkBoxPlaybackYukkuri_EnabledChanged);
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxUpdate.Location = new System.Drawing.Point(8, 491);
            this.groupBoxUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUpdate.Size = new System.Drawing.Size(351, 238);
            this.groupBoxUpdate.TabIndex = 4;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Update";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelCurrentVersion, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelCurrentVersionValue, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelLatestStableVersion, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelLatestVersion, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelLatestStableVersionValue, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelLatestVersionValue, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxCheckUpdate, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxNotifyStableOnly, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.buttonCheckUpdate, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.buttonDownloadUpdate, 0, 6);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 22);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(343, 212);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // labelCurrentVersion
            // 
            this.labelCurrentVersion.AutoSize = true;
            this.labelCurrentVersion.Location = new System.Drawing.Point(4, 0);
            this.labelCurrentVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentVersion.Name = "labelCurrentVersion";
            this.labelCurrentVersion.Size = new System.Drawing.Size(135, 15);
            this.labelCurrentVersion.TabIndex = 0;
            this.labelCurrentVersion.Text = "Current Version:";
            // 
            // labelCurrentVersionValue
            // 
            this.labelCurrentVersionValue.AutoSize = true;
            this.labelCurrentVersionValue.Location = new System.Drawing.Point(195, 0);
            this.labelCurrentVersionValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentVersionValue.Name = "labelCurrentVersionValue";
            this.labelCurrentVersionValue.Size = new System.Drawing.Size(55, 15);
            this.labelCurrentVersionValue.TabIndex = 1;
            this.labelCurrentVersionValue.Text = "label2";
            // 
            // labelLatestStableVersion
            // 
            this.labelLatestStableVersion.AutoSize = true;
            this.labelLatestStableVersion.Location = new System.Drawing.Point(4, 15);
            this.labelLatestStableVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLatestStableVersion.Name = "labelLatestStableVersion";
            this.labelLatestStableVersion.Size = new System.Drawing.Size(183, 15);
            this.labelLatestStableVersion.TabIndex = 2;
            this.labelLatestStableVersion.Text = "Latest Stable Version:";
            // 
            // labelLatestVersion
            // 
            this.labelLatestVersion.AutoSize = true;
            this.labelLatestVersion.Location = new System.Drawing.Point(4, 30);
            this.labelLatestVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLatestVersion.Name = "labelLatestVersion";
            this.labelLatestVersion.Size = new System.Drawing.Size(127, 15);
            this.labelLatestVersion.TabIndex = 3;
            this.labelLatestVersion.Text = "Latest Version:";
            // 
            // labelLatestStableVersionValue
            // 
            this.labelLatestStableVersionValue.AutoSize = true;
            this.labelLatestStableVersionValue.Location = new System.Drawing.Point(195, 15);
            this.labelLatestStableVersionValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLatestStableVersionValue.Name = "labelLatestStableVersionValue";
            this.labelLatestStableVersionValue.Size = new System.Drawing.Size(55, 15);
            this.labelLatestStableVersionValue.TabIndex = 4;
            this.labelLatestStableVersionValue.Text = "label5";
            // 
            // labelLatestVersionValue
            // 
            this.labelLatestVersionValue.AutoSize = true;
            this.labelLatestVersionValue.Location = new System.Drawing.Point(195, 30);
            this.labelLatestVersionValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLatestVersionValue.Name = "labelLatestVersionValue";
            this.labelLatestVersionValue.Size = new System.Drawing.Size(55, 15);
            this.labelLatestVersionValue.TabIndex = 5;
            this.labelLatestVersionValue.Text = "label6";
            // 
            // checkBoxCheckUpdate
            // 
            this.checkBoxCheckUpdate.AutoSize = true;
            this.checkBoxCheckUpdate.Checked = true;
            this.checkBoxCheckUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel4.SetColumnSpan(this.checkBoxCheckUpdate, 2);
            this.checkBoxCheckUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxCheckUpdate.Location = new System.Drawing.Point(4, 49);
            this.checkBoxCheckUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCheckUpdate.Name = "checkBoxCheckUpdate";
            this.checkBoxCheckUpdate.Size = new System.Drawing.Size(335, 19);
            this.checkBoxCheckUpdate.TabIndex = 6;
            this.checkBoxCheckUpdate.Text = "Check Update on Startup";
            this.checkBoxCheckUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifyStableOnly
            // 
            this.checkBoxNotifyStableOnly.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.checkBoxNotifyStableOnly, 2);
            this.checkBoxNotifyStableOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxNotifyStableOnly.Location = new System.Drawing.Point(4, 76);
            this.checkBoxNotifyStableOnly.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNotifyStableOnly.Name = "checkBoxNotifyStableOnly";
            this.checkBoxNotifyStableOnly.Size = new System.Drawing.Size(335, 19);
            this.checkBoxNotifyStableOnly.TabIndex = 7;
            this.checkBoxNotifyStableOnly.Text = "Check for Stable Version Only";
            this.checkBoxNotifyStableOnly.UseVisualStyleBackColor = true;
            // 
            // buttonCheckUpdate
            // 
            this.buttonCheckUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckUpdate.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.buttonCheckUpdate, 2);
            this.buttonCheckUpdate.Location = new System.Drawing.Point(146, 103);
            this.buttonCheckUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheckUpdate.Name = "buttonCheckUpdate";
            this.buttonCheckUpdate.Size = new System.Drawing.Size(193, 31);
            this.buttonCheckUpdate.TabIndex = 8;
            this.buttonCheckUpdate.Text = "Check Update Now";
            this.buttonCheckUpdate.UseVisualStyleBackColor = true;
            this.buttonCheckUpdate.Click += new System.EventHandler(this.buttonCheckUpdate_Click);
            // 
            // buttonDownloadUpdate
            // 
            this.buttonDownloadUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadUpdate.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.buttonDownloadUpdate, 2);
            this.buttonDownloadUpdate.Location = new System.Drawing.Point(92, 142);
            this.buttonDownloadUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDownloadUpdate.Name = "buttonDownloadUpdate";
            this.buttonDownloadUpdate.Size = new System.Drawing.Size(247, 31);
            this.buttonDownloadUpdate.TabIndex = 9;
            this.buttonDownloadUpdate.Text = "Open Download Website";
            this.buttonDownloadUpdate.UseVisualStyleBackColor = true;
            this.buttonDownloadUpdate.Click += new System.EventHandler(this.buttonDownloadUpdate_Click);
            // 
            // tableLayoutPanelMainLanguage
            // 
            this.tableLayoutPanelMainLanguage.ColumnCount = 3;
            this.tableLayoutPanelMainLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMainLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMainLanguage.Controls.Add(this.comboBoxLanguage, 1, 0);
            this.tableLayoutPanelMainLanguage.Controls.Add(this.labelMainLanguage, 0, 0);
            this.tableLayoutPanelMainLanguage.Controls.Add(this.labelNeedToRestart, 2, 0);
            this.tableLayoutPanelMainLanguage.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanelMainLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelMainLanguage.Name = "tableLayoutPanelMainLanguage";
            this.tableLayoutPanelMainLanguage.RowCount = 1;
            this.tableLayoutPanelMainLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainLanguage.Size = new System.Drawing.Size(673, 39);
            this.tableLayoutPanelMainLanguage.TabIndex = 0;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(91, 8);
            this.comboBoxLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(363, 23);
            this.comboBoxLanguage.TabIndex = 3;
            // 
            // labelMainLanguage
            // 
            this.labelMainLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMainLanguage.AutoSize = true;
            this.labelMainLanguage.Location = new System.Drawing.Point(4, 12);
            this.labelMainLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMainLanguage.Name = "labelMainLanguage";
            this.labelMainLanguage.Size = new System.Drawing.Size(79, 15);
            this.labelMainLanguage.TabIndex = 4;
            this.labelMainLanguage.Text = "Language:";
            // 
            // labelNeedToRestart
            // 
            this.labelNeedToRestart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNeedToRestart.AutoSize = true;
            this.labelNeedToRestart.Enabled = false;
            this.labelNeedToRestart.Location = new System.Drawing.Point(462, 12);
            this.labelNeedToRestart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNeedToRestart.Name = "labelNeedToRestart";
            this.labelNeedToRestart.Size = new System.Drawing.Size(207, 15);
            this.labelNeedToRestart.TabIndex = 5;
            this.labelNeedToRestart.Text = "*Need to restart the ACT.";
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.richTextBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Size = new System.Drawing.Size(981, 738);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(973, 730);
            this.richTextBoxLog.TabIndex = 6;
            this.richTextBoxLog.Text = "";
            // 
            // FoxTTSTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FoxTTSTabControl";
            this.Size = new System.Drawing.Size(989, 767);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneralSettings.ResumeLayout(false);
            this.groupBoxPreview.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxTTSEngine.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxPlayback.ResumeLayout(false);
            this.groupBoxPlayback.PerformLayout();
            this.tableLayoutPanelPlayback.ResumeLayout(false);
            this.tableLayoutPanelPlayback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBoxUpdate.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanelMainLanguage.ResumeLayout(false);
            this.tableLayoutPanelMainLanguage.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneralSettings;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelCurrentVersion;
        private System.Windows.Forms.Label labelCurrentVersionValue;
        private System.Windows.Forms.Label labelLatestStableVersion;
        private System.Windows.Forms.Label labelLatestVersion;
        private System.Windows.Forms.Label labelLatestStableVersionValue;
        private System.Windows.Forms.Label labelLatestVersionValue;
        private System.Windows.Forms.CheckBox checkBoxCheckUpdate;
        private System.Windows.Forms.CheckBox checkBoxNotifyStableOnly;
        private System.Windows.Forms.Button buttonCheckUpdate;
        private System.Windows.Forms.Button buttonDownloadUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelMainLanguage;
        private System.Windows.Forms.Label labelNeedToRestart;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.GroupBox groupBoxPlayback;
        private System.Windows.Forms.CheckBox checkBoxPlaybackYukkuri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayback;
        private System.Windows.Forms.Label labelMasterVolume;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelCurrentVolume;
        private System.Windows.Forms.Label labelPlaybackMethod;
        private System.Windows.Forms.ComboBox comboBoxPlaybackMethod;
        private System.Windows.Forms.Label labelPlaybackDevice;
        private System.Windows.Forms.ComboBox comboBoxPlaybackDevice;
        public System.Windows.Forms.Panel panelTTSEngineSettings;
        private System.Windows.Forms.GroupBox groupBoxTTSEngine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTTSEngine;
        private System.Windows.Forms.ComboBox comboBoxTTSEngine;
        private System.Windows.Forms.CheckBox checkBoxClearCacheExit;
        private System.Windows.Forms.LinkLabel linkLabelClearCache;
        private System.Windows.Forms.LinkLabel linkLabelOpenCacheDir;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.Button buttonPreview;
    }
}
