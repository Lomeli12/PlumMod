namespace PlumMod {
    partial class MainForm {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CustomTabControl mainTab;
        private System.Windows.Forms.TabPage modTab;
        private System.Windows.Forms.TabPage configTab;
        private System.Windows.Forms.TabPage utilTab;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.Panel modListPanel;
        private System.Windows.Forms.ListView mainModList;
        private System.Windows.Forms.Panel manageModBtnPanel;
        private System.Windows.Forms.ColumnHeader modColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
        private System.Windows.Forms.FolderBrowserDialog simsFolderDialog;
        private JCS.ToggleSwitch scriptModToggle;
        private JCS.ToggleSwitch packageModToggle;
        private PlumMod.GrowLabel packageModLabel;
        private PlumMod.GrowLabel scriptModLabel;
        private PlumMod.GrowLabel fullScreenLabel;
        private JCS.ToggleSwitch fullScreenToggle;
        private PlumMod.GrowLabel showModsLabel;
        private JCS.ToggleSwitch showModsToggle;
        private PlumMod.GrowLabel heightLabel;
        private System.Windows.Forms.NumericUpDown resHeight;
        private PlumMod.GrowLabel widthLabel;
        private System.Windows.Forms.NumericUpDown resWidth;
        private PlumMod.GrowLabel cacheLabel;
        private System.Windows.Forms.Button clearCacheBtn;
        private PlumMod.GrowLabel tuneLabel;
        private System.Windows.Forms.Button tuneBtm;
        private System.Windows.Forms.PictureBox aboutLogo;
        private PlumMod.GrowLabel aboutLabel;

        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTab = new System.Windows.Forms.CustomTabControl();
            this.modTab = new System.Windows.Forms.TabPage();
            this.modListPanel = new System.Windows.Forms.Panel();
            this.mainModList = new System.Windows.Forms.ListView();
            this.modColumn = new System.Windows.Forms.ColumnHeader();
            this.typeColumn = new System.Windows.Forms.ColumnHeader();
            this.manageModBtnPanel = new System.Windows.Forms.Panel();
            this.modDescriptionLabel = new PlumMod.GrowLabel();
            this.disableModBtn = new System.Windows.Forms.Button();
            this.enableModBtn = new System.Windows.Forms.Button();
            this.refreshListBtn = new System.Windows.Forms.Button();
            this.removeModBtn = new System.Windows.Forms.Button();
            this.addModBtn = new System.Windows.Forms.Button();
            this.configTab = new System.Windows.Forms.TabPage();
            this.utilTab = new System.Windows.Forms.TabPage();
            this.tuneLabel = new PlumMod.GrowLabel();
            this.tuneBtm = new System.Windows.Forms.Button();
            this.clearCacheBtn = new System.Windows.Forms.Button();
            this.resHeight = new System.Windows.Forms.NumericUpDown();
            this.resWidth = new System.Windows.Forms.NumericUpDown();
            this.fullScreenToggle = new JCS.ToggleSwitch();
            this.showModsToggle = new JCS.ToggleSwitch();
            this.packageModToggle = new JCS.ToggleSwitch();
            this.scriptModToggle = new JCS.ToggleSwitch();
            this.cacheLabel = new PlumMod.GrowLabel();
            this.heightLabel = new PlumMod.GrowLabel();
            this.widthLabel = new PlumMod.GrowLabel();
            this.fullScreenLabel = new PlumMod.GrowLabel();
            this.showModsLabel = new PlumMod.GrowLabel();
            this.packageModLabel = new PlumMod.GrowLabel();
            this.scriptModLabel = new PlumMod.GrowLabel();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.githubBtn = new System.Windows.Forms.Button();
            this.websiteBtn = new System.Windows.Forms.Button();
            this.aboutLogo = new System.Windows.Forms.PictureBox();
            this.aboutLabel = new PlumMod.GrowLabel();
            this.simsFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addModDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTab.SuspendLayout();
            this.modTab.SuspendLayout();
            this.modListPanel.SuspendLayout();
            this.manageModBtnPanel.SuspendLayout();
            this.utilTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resWidth)).BeginInit();
            this.aboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.modTab);
            this.mainTab.Controls.Add(this.configTab);
            this.mainTab.Controls.Add(this.utilTab);
            this.mainTab.Controls.Add(this.aboutTab);
            // 
            // 
            // 
            this.mainTab.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.mainTab.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.mainTab.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.mainTab.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.mainTab.DisplayStyleProvider.FocusTrack = true;
            this.mainTab.DisplayStyleProvider.HotTrack = true;
            this.mainTab.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainTab.DisplayStyleProvider.Opacity = 1F;
            this.mainTab.DisplayStyleProvider.Overlap = 0;
            this.mainTab.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
            this.mainTab.DisplayStyleProvider.Radius = 2;
            this.mainTab.DisplayStyleProvider.ShowTabCloser = false;
            this.mainTab.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.mainTab.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.mainTab.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTab.HotTrack = true;
            this.mainTab.Location = new System.Drawing.Point(0, 0);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(912, 632);
            this.mainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTab.TabIndex = 0;
            // 
            // modTab
            // 
            this.modTab.Controls.Add(this.modListPanel);
            this.modTab.Controls.Add(this.manageModBtnPanel);
            this.modTab.Location = new System.Drawing.Point(4, 27);
            this.modTab.Name = "modTab";
            this.modTab.Padding = new System.Windows.Forms.Padding(3);
            this.modTab.Size = new System.Drawing.Size(904, 601);
            this.modTab.TabIndex = 0;
            this.modTab.Text = "Manage Mods";
            this.modTab.UseVisualStyleBackColor = true;
            // 
            // modListPanel
            // 
            this.modListPanel.Controls.Add(this.mainModList);
            this.modListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modListPanel.Location = new System.Drawing.Point(3, 3);
            this.modListPanel.Name = "modListPanel";
            this.modListPanel.Size = new System.Drawing.Size(898, 489);
            this.modListPanel.TabIndex = 2;
            // 
            // mainModList
            // 
            this.mainModList.CheckBoxes = true;
            this.mainModList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modColumn,
            this.typeColumn});
            this.mainModList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainModList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainModList.Location = new System.Drawing.Point(0, 0);
            this.mainModList.Name = "mainModList";
            this.mainModList.Size = new System.Drawing.Size(898, 489);
            this.mainModList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mainModList.TabIndex = 0;
            this.mainModList.UseCompatibleStateImageBehavior = false;
            this.mainModList.View = System.Windows.Forms.View.Details;
            this.mainModList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.MainModListItemChecked);
            this.mainModList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mainModList_ItemSelectionChanged);
            // 
            // modColumn
            // 
            this.modColumn.Text = "Mod";
            this.modColumn.Width = 467;
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            this.typeColumn.Width = 287;
            // 
            // manageModBtnPanel
            // 
            this.manageModBtnPanel.Controls.Add(this.modDescriptionLabel);
            this.manageModBtnPanel.Controls.Add(this.disableModBtn);
            this.manageModBtnPanel.Controls.Add(this.enableModBtn);
            this.manageModBtnPanel.Controls.Add(this.refreshListBtn);
            this.manageModBtnPanel.Controls.Add(this.removeModBtn);
            this.manageModBtnPanel.Controls.Add(this.addModBtn);
            this.manageModBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manageModBtnPanel.Location = new System.Drawing.Point(3, 492);
            this.manageModBtnPanel.Name = "manageModBtnPanel";
            this.manageModBtnPanel.Size = new System.Drawing.Size(898, 106);
            this.manageModBtnPanel.TabIndex = 1;
            // 
            // modDescriptionLabel
            // 
            this.modDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modDescriptionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDescriptionLabel.Location = new System.Drawing.Point(382, 3);
            this.modDescriptionLabel.Name = "modDescriptionLabel";
            this.modDescriptionLabel.Size = new System.Drawing.Size(501, 0);
            this.modDescriptionLabel.TabIndex = 5;
            // 
            // disableModBtn
            // 
            this.disableModBtn.Enabled = false;
            this.disableModBtn.FlatAppearance.BorderSize = 0;
            this.disableModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableModBtn.Image = global::PlumMod.Properties.Resources.No;
            this.disableModBtn.Location = new System.Drawing.Point(308, 21);
            this.disableModBtn.Name = "disableModBtn";
            this.disableModBtn.Size = new System.Drawing.Size(68, 64);
            this.disableModBtn.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.disableModBtn, "Disable selected mod(s).");
            this.disableModBtn.UseVisualStyleBackColor = true;
            this.disableModBtn.Click += new System.EventHandler(this.disableModBtn_Click);
            // 
            // enableModBtn
            // 
            this.enableModBtn.Enabled = false;
            this.enableModBtn.FlatAppearance.BorderSize = 0;
            this.enableModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableModBtn.Image = global::PlumMod.Properties.Resources.Ok;
            this.enableModBtn.Location = new System.Drawing.Point(234, 21);
            this.enableModBtn.Name = "enableModBtn";
            this.enableModBtn.Size = new System.Drawing.Size(68, 64);
            this.enableModBtn.TabIndex = 3;
            this.mainToolTip.SetToolTip(this.enableModBtn, "Enable selected mod(s).");
            this.enableModBtn.UseVisualStyleBackColor = true;
            this.enableModBtn.Click += new System.EventHandler(this.enableModBtn_Click);
            // 
            // refreshListBtn
            // 
            this.refreshListBtn.FlatAppearance.BorderSize = 0;
            this.refreshListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshListBtn.Image = global::PlumMod.Properties.Resources.Refresh;
            this.refreshListBtn.Location = new System.Drawing.Point(160, 21);
            this.refreshListBtn.Name = "refreshListBtn";
            this.refreshListBtn.Size = new System.Drawing.Size(68, 64);
            this.refreshListBtn.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.refreshListBtn, "Refresh mod list.");
            this.refreshListBtn.UseVisualStyleBackColor = true;
            this.refreshListBtn.Click += new System.EventHandler(this.refreshListBtn_Click);
            // 
            // removeModBtn
            // 
            this.removeModBtn.Enabled = false;
            this.removeModBtn.FlatAppearance.BorderSize = 0;
            this.removeModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeModBtn.Image = global::PlumMod.Properties.Resources.Minus;
            this.removeModBtn.Location = new System.Drawing.Point(86, 21);
            this.removeModBtn.Name = "removeModBtn";
            this.removeModBtn.Size = new System.Drawing.Size(68, 64);
            this.removeModBtn.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.removeModBtn, "Delete selected mod(s).");
            this.removeModBtn.UseVisualStyleBackColor = true;
            this.removeModBtn.Click += new System.EventHandler(this.removeModBtn_Click);
            // 
            // addModBtn
            // 
            this.addModBtn.FlatAppearance.BorderSize = 0;
            this.addModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addModBtn.Image = global::PlumMod.Properties.Resources.Plus;
            this.addModBtn.Location = new System.Drawing.Point(11, 21);
            this.addModBtn.Name = "addModBtn";
            this.addModBtn.Size = new System.Drawing.Size(68, 64);
            this.addModBtn.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.addModBtn, "Add mod(s).");
            this.addModBtn.UseVisualStyleBackColor = true;
            this.addModBtn.Click += new System.EventHandler(this.AddModBtnClick);
            // 
            // configTab
            // 
            this.configTab.Location = new System.Drawing.Point(4, 27);
            this.configTab.Name = "configTab";
            this.configTab.Padding = new System.Windows.Forms.Padding(3);
            this.configTab.Size = new System.Drawing.Size(904, 601);
            this.configTab.TabIndex = 1;
            this.configTab.Text = "Manage Configurations";
            this.configTab.UseVisualStyleBackColor = true;
            // 
            // utilTab
            // 
            this.utilTab.Controls.Add(this.tuneLabel);
            this.utilTab.Controls.Add(this.tuneBtm);
            this.utilTab.Controls.Add(this.clearCacheBtn);
            this.utilTab.Controls.Add(this.resHeight);
            this.utilTab.Controls.Add(this.resWidth);
            this.utilTab.Controls.Add(this.fullScreenToggle);
            this.utilTab.Controls.Add(this.showModsToggle);
            this.utilTab.Controls.Add(this.packageModToggle);
            this.utilTab.Controls.Add(this.scriptModToggle);
            this.utilTab.Controls.Add(this.cacheLabel);
            this.utilTab.Controls.Add(this.heightLabel);
            this.utilTab.Controls.Add(this.widthLabel);
            this.utilTab.Controls.Add(this.fullScreenLabel);
            this.utilTab.Controls.Add(this.showModsLabel);
            this.utilTab.Controls.Add(this.packageModLabel);
            this.utilTab.Controls.Add(this.scriptModLabel);
            this.utilTab.Location = new System.Drawing.Point(4, 27);
            this.utilTab.Name = "utilTab";
            this.utilTab.Size = new System.Drawing.Size(904, 601);
            this.utilTab.TabIndex = 2;
            this.utilTab.Text = "Utilities";
            this.utilTab.UseVisualStyleBackColor = true;
            // 
            // tuneLabel
            // 
            this.tuneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tuneLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuneLabel.Location = new System.Drawing.Point(165, 341);
            this.tuneLabel.Name = "tuneLabel";
            this.tuneLabel.Size = new System.Drawing.Size(721, 51);
            this.tuneLabel.TabIndex = 15;
            this.tuneLabel.Text = "As tunning is still a little messy in The Sims 4, you may need to prepare your re" +
    "source.cfg and mods folder for some tunning mods.\r\n";
            // 
            // tuneBtm
            // 
            this.tuneBtm.Location = new System.Drawing.Point(25, 341);
            this.tuneBtm.Name = "tuneBtm";
            this.tuneBtm.Size = new System.Drawing.Size(115, 39);
            this.tuneBtm.TabIndex = 14;
            this.tuneBtm.Text = "Tunning Prep";
            this.tuneBtm.UseVisualStyleBackColor = true;
            this.tuneBtm.Click += new System.EventHandler(this.tuneBtm_Click);
            // 
            // clearCacheBtn
            // 
            this.clearCacheBtn.Location = new System.Drawing.Point(25, 273);
            this.clearCacheBtn.Name = "clearCacheBtn";
            this.clearCacheBtn.Size = new System.Drawing.Size(115, 39);
            this.clearCacheBtn.TabIndex = 12;
            this.clearCacheBtn.Text = "Clear Cache";
            this.clearCacheBtn.UseVisualStyleBackColor = true;
            this.clearCacheBtn.Click += new System.EventHandler(this.clearCacheBtn_Click);
            // 
            // resHeight
            // 
            this.resHeight.Location = new System.Drawing.Point(25, 231);
            this.resHeight.Maximum = new decimal(new int[] {
            2160,
            0,
            0,
            0});
            this.resHeight.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.resHeight.Name = "resHeight";
            this.resHeight.Size = new System.Drawing.Size(75, 22);
            this.resHeight.TabIndex = 10;
            this.resHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // resWidth
            // 
            this.resWidth.Location = new System.Drawing.Point(25, 188);
            this.resWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.resWidth.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.resWidth.Name = "resWidth";
            this.resWidth.Size = new System.Drawing.Size(75, 22);
            this.resWidth.TabIndex = 8;
            this.resWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // fullScreenToggle
            // 
            this.fullScreenToggle.Location = new System.Drawing.Point(25, 146);
            this.fullScreenToggle.Name = "fullScreenToggle";
            this.fullScreenToggle.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScreenToggle.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScreenToggle.Size = new System.Drawing.Size(56, 20);
            this.fullScreenToggle.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.fullScreenToggle.TabIndex = 6;
            this.fullScreenToggle.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.fullScreenToggle_CheckedChanged);
            // 
            // showModsToggle
            // 
            this.showModsToggle.Location = new System.Drawing.Point(25, 103);
            this.showModsToggle.Name = "showModsToggle";
            this.showModsToggle.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showModsToggle.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showModsToggle.Size = new System.Drawing.Size(56, 20);
            this.showModsToggle.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.showModsToggle.TabIndex = 4;
            this.showModsToggle.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.showModsToggle_CheckedChanged);
            // 
            // packageModToggle
            // 
            this.packageModToggle.Location = new System.Drawing.Point(25, 18);
            this.packageModToggle.Name = "packageModToggle";
            this.packageModToggle.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageModToggle.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageModToggle.Size = new System.Drawing.Size(56, 20);
            this.packageModToggle.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.packageModToggle.TabIndex = 1;
            this.packageModToggle.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.PackageModToggleCheckedChanged);
            // 
            // scriptModToggle
            // 
            this.scriptModToggle.Location = new System.Drawing.Point(25, 61);
            this.scriptModToggle.Name = "scriptModToggle";
            this.scriptModToggle.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptModToggle.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptModToggle.Size = new System.Drawing.Size(56, 20);
            this.scriptModToggle.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.scriptModToggle.TabIndex = 0;
            this.scriptModToggle.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.ScriptModToggleCheckedChanged);
            // 
            // cacheLabel
            // 
            this.cacheLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cacheLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheLabel.Location = new System.Drawing.Point(165, 273);
            this.cacheLabel.Name = "cacheLabel";
            this.cacheLabel.Size = new System.Drawing.Size(721, 68);
            this.cacheLabel.TabIndex = 13;
            this.cacheLabel.Text = "Sometimes issues can occur when the game is caching. Clearing the game\'s cache ca" +
    "n sometimes fix performance and game lauching issues. It is recommended you clea" +
    "r the cache every once in a while.\r\n";
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(120, 231);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(766, 17);
            this.heightLabel.TabIndex = 11;
            this.heightLabel.Text = "Set resolution height.";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(120, 188);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(766, 17);
            this.widthLabel.TabIndex = 9;
            this.widthLabel.Text = "Set resolution width.";
            // 
            // fullScreenLabel
            // 
            this.fullScreenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreenLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScreenLabel.Location = new System.Drawing.Point(120, 146);
            this.fullScreenLabel.Name = "fullScreenLabel";
            this.fullScreenLabel.Size = new System.Drawing.Size(766, 17);
            this.fullScreenLabel.TabIndex = 7;
            this.fullScreenLabel.Text = "Enable/Disable Fullscreen mode.";
            // 
            // showModsLabel
            // 
            this.showModsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showModsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showModsLabel.Location = new System.Drawing.Point(120, 103);
            this.showModsLabel.Name = "showModsLabel";
            this.showModsLabel.Size = new System.Drawing.Size(766, 17);
            this.showModsLabel.TabIndex = 5;
            this.showModsLabel.Text = "Enable/Disable showing mods list on game startup.";
            // 
            // packageModLabel
            // 
            this.packageModLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packageModLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageModLabel.Location = new System.Drawing.Point(120, 18);
            this.packageModLabel.Name = "packageModLabel";
            this.packageModLabel.Size = new System.Drawing.Size(766, 17);
            this.packageModLabel.TabIndex = 3;
            this.packageModLabel.Text = "Enable/Disable Sims 4 mods globally. This affects both \"Package\" and \"Script\" typ" +
    "e mods.";
            // 
            // scriptModLabel
            // 
            this.scriptModLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptModLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptModLabel.Location = new System.Drawing.Point(120, 61);
            this.scriptModLabel.Name = "scriptModLabel";
            this.scriptModLabel.Size = new System.Drawing.Size(766, 17);
            this.scriptModLabel.TabIndex = 2;
            this.scriptModLabel.Text = "Enable/Disable script mods (REQUIRES mods to be ENABLED globally). This affects \"" +
    "Script\" type mods.";
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.githubBtn);
            this.aboutTab.Controls.Add(this.websiteBtn);
            this.aboutTab.Controls.Add(this.aboutLogo);
            this.aboutTab.Controls.Add(this.aboutLabel);
            this.aboutTab.Location = new System.Drawing.Point(4, 27);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(904, 601);
            this.aboutTab.TabIndex = 3;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // githubBtn
            // 
            this.githubBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.githubBtn.Location = new System.Drawing.Point(658, 518);
            this.githubBtn.Name = "githubBtn";
            this.githubBtn.Size = new System.Drawing.Size(114, 42);
            this.githubBtn.TabIndex = 3;
            this.githubBtn.Text = "GitHub Repo";
            this.mainToolTip.SetToolTip(this.githubBtn, "Open up PlumMod\'s GitHub repo.");
            this.githubBtn.UseVisualStyleBackColor = true;
            this.githubBtn.Click += new System.EventHandler(this.githubBtn_Click);
            // 
            // websiteBtn
            // 
            this.websiteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.websiteBtn.Location = new System.Drawing.Point(778, 518);
            this.websiteBtn.Name = "websiteBtn";
            this.websiteBtn.Size = new System.Drawing.Size(114, 42);
            this.websiteBtn.TabIndex = 2;
            this.websiteBtn.Text = "Website";
            this.mainToolTip.SetToolTip(this.websiteBtn, "Open up Lomeli\'s website.");
            this.websiteBtn.UseVisualStyleBackColor = true;
            this.websiteBtn.Click += new System.EventHandler(this.websiteBtn_Click);
            // 
            // aboutLogo
            // 
            this.aboutLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutLogo.Image = global::PlumMod.Properties.Resources.plummodbanner;
            this.aboutLogo.InitialImage = null;
            this.aboutLogo.Location = new System.Drawing.Point(65, 0);
            this.aboutLogo.Name = "aboutLogo";
            this.aboutLogo.Size = new System.Drawing.Size(762, 249);
            this.aboutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutLogo.TabIndex = 0;
            this.aboutLogo.TabStop = false;
            // 
            // aboutLabel
            // 
            this.aboutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(9, 266);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(879, 242);
            this.aboutLabel.TabIndex = 1;
            this.aboutLabel.Text = resources.GetString("aboutLabel.Text");
            // 
            // addModDialog
            // 
            this.addModDialog.Filter = "Valid Mod Types (*.package, *.zip, *.ts4script)|*.package;*.zip;*.ts4script|Packa" +
    "ge Mod (*.package)|*.package|Script Mod (*.zip, *.ts4script)|*.zip;*.ts4script|A" +
    "ll files|*.*";
            this.addModDialog.Multiselect = true;
            this.addModDialog.Title = "Select mod(s) to add";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 632);
            this.Controls.Add(this.mainTab);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PlumMod";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.mainTab.ResumeLayout(false);
            this.modTab.ResumeLayout(false);
            this.modListPanel.ResumeLayout(false);
            this.manageModBtnPanel.ResumeLayout(false);
            this.utilTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resWidth)).EndInit();
            this.aboutTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button removeModBtn;
        private System.Windows.Forms.Button addModBtn;
        private System.Windows.Forms.Button refreshListBtn;
        private System.Windows.Forms.Button disableModBtn;
        private System.Windows.Forms.Button enableModBtn;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Button githubBtn;
        private System.Windows.Forms.Button websiteBtn;
        private GrowLabel modDescriptionLabel;
        private System.Windows.Forms.OpenFileDialog addModDialog;
    }
}
