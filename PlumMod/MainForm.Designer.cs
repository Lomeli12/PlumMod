namespace PlumMod
{
    partial class MainForm
    {
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
        private System.Windows.Forms.Label packageModLabel;
        private System.Windows.Forms.Label scriptModLabel;
        private System.Windows.Forms.Label fullScreenLabel;
        private JCS.ToggleSwitch fullScreenToggle;
        private System.Windows.Forms.Label showModsLabel;
        private JCS.ToggleSwitch showModsToggle;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown resHeight;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown resWidth;

        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTab = new System.Windows.Forms.CustomTabControl();
            this.modTab = new System.Windows.Forms.TabPage();
            this.modListPanel = new System.Windows.Forms.Panel();
            this.mainModList = new System.Windows.Forms.ListView();
            this.modColumn = new System.Windows.Forms.ColumnHeader();
            this.typeColumn = new System.Windows.Forms.ColumnHeader();
            this.manageModBtnPanel = new System.Windows.Forms.Panel();
            this.configTab = new System.Windows.Forms.TabPage();
            this.utilTab = new System.Windows.Forms.TabPage();
            this.heightLabel = new System.Windows.Forms.Label();
            this.resHeight = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            this.resWidth = new System.Windows.Forms.NumericUpDown();
            this.fullScreenLabel = new System.Windows.Forms.Label();
            this.fullScreenToggle = new JCS.ToggleSwitch();
            this.showModsLabel = new System.Windows.Forms.Label();
            this.showModsToggle = new JCS.ToggleSwitch();
            this.packageModLabel = new System.Windows.Forms.Label();
            this.scriptModLabel = new System.Windows.Forms.Label();
            this.packageModToggle = new JCS.ToggleSwitch();
            this.scriptModToggle = new JCS.ToggleSwitch();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.simsFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTab.SuspendLayout();
            this.modTab.SuspendLayout();
            this.modListPanel.SuspendLayout();
            this.utilTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.modTab);
            this.mainTab.Controls.Add(this.configTab);
            this.mainTab.Controls.Add(this.utilTab);
            this.mainTab.Controls.Add(this.aboutTab);
            this.mainTab.DisplayStyle = System.Windows.Forms.TabStyle.Rounded;
            // 
            // 
            // 
            this.mainTab.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.mainTab.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.mainTab.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.mainTab.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.mainTab.DisplayStyleProvider.FocusTrack = false;
            this.mainTab.DisplayStyleProvider.HotTrack = true;
            this.mainTab.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainTab.DisplayStyleProvider.Opacity = 1F;
            this.mainTab.DisplayStyleProvider.Overlap = 0;
            this.mainTab.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
            this.mainTab.DisplayStyleProvider.Radius = 10;
            this.mainTab.DisplayStyleProvider.ShowTabCloser = false;
            this.mainTab.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.mainTab.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.mainTab.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.HotTrack = true;
            this.mainTab.Location = new System.Drawing.Point(0, 0);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(811, 549);
            this.mainTab.TabIndex = 0;
            // 
            // modTab
            // 
            this.modTab.Controls.Add(this.modListPanel);
            this.modTab.Controls.Add(this.manageModBtnPanel);
            this.modTab.Location = new System.Drawing.Point(4, 26);
            this.modTab.Name = "modTab";
            this.modTab.Padding = new System.Windows.Forms.Padding(3);
            this.modTab.Size = new System.Drawing.Size(803, 519);
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
            this.modListPanel.Size = new System.Drawing.Size(797, 413);
            this.modListPanel.TabIndex = 2;
            // 
            // mainModList
            // 
            this.mainModList.CheckBoxes = true;
            this.mainModList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modColumn,
            this.typeColumn});
            this.mainModList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainModList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainModList.Location = new System.Drawing.Point(0, 0);
            this.mainModList.Name = "mainModList";
            this.mainModList.Size = new System.Drawing.Size(797, 413);
            this.mainModList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mainModList.TabIndex = 0;
            this.mainModList.UseCompatibleStateImageBehavior = false;
            this.mainModList.View = System.Windows.Forms.View.Details;
            this.mainModList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.MainModListItemChecked);
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
            this.manageModBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manageModBtnPanel.Location = new System.Drawing.Point(3, 416);
            this.manageModBtnPanel.Name = "manageModBtnPanel";
            this.manageModBtnPanel.Size = new System.Drawing.Size(797, 100);
            this.manageModBtnPanel.TabIndex = 1;
            // 
            // configTab
            // 
            this.configTab.Location = new System.Drawing.Point(4, 26);
            this.configTab.Name = "configTab";
            this.configTab.Padding = new System.Windows.Forms.Padding(3);
            this.configTab.Size = new System.Drawing.Size(803, 519);
            this.configTab.TabIndex = 1;
            this.configTab.Text = "Manage Configurations";
            this.configTab.UseVisualStyleBackColor = true;
            // 
            // utilTab
            // 
            this.utilTab.Controls.Add(this.heightLabel);
            this.utilTab.Controls.Add(this.resHeight);
            this.utilTab.Controls.Add(this.widthLabel);
            this.utilTab.Controls.Add(this.resWidth);
            this.utilTab.Controls.Add(this.fullScreenLabel);
            this.utilTab.Controls.Add(this.fullScreenToggle);
            this.utilTab.Controls.Add(this.showModsLabel);
            this.utilTab.Controls.Add(this.showModsToggle);
            this.utilTab.Controls.Add(this.packageModLabel);
            this.utilTab.Controls.Add(this.scriptModLabel);
            this.utilTab.Controls.Add(this.packageModToggle);
            this.utilTab.Controls.Add(this.scriptModToggle);
            this.utilTab.Location = new System.Drawing.Point(4, 26);
            this.utilTab.Name = "utilTab";
            this.utilTab.Size = new System.Drawing.Size(803, 519);
            this.utilTab.TabIndex = 2;
            this.utilTab.Text = "Utilities";
            this.utilTab.UseVisualStyleBackColor = true;
            // 
            // heightLabel
            // 
            this.heightLabel.Location = new System.Drawing.Point(107, 217);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(688, 23);
            this.heightLabel.TabIndex = 11;
            this.heightLabel.Text = "Set resolution height.";
            // 
            // resHeight
            // 
            this.resHeight.Location = new System.Drawing.Point(22, 217);
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
            this.resHeight.Size = new System.Drawing.Size(67, 22);
            this.resHeight.TabIndex = 10;
            this.resHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(107, 177);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(688, 23);
            this.widthLabel.TabIndex = 9;
            this.widthLabel.Text = "Set resolution width.";
            // 
            // resWidth
            // 
            this.resWidth.Location = new System.Drawing.Point(22, 177);
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
            this.resWidth.Size = new System.Drawing.Size(67, 22);
            this.resWidth.TabIndex = 8;
            this.resWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // fullScreenLabel
            // 
            this.fullScreenLabel.Location = new System.Drawing.Point(107, 137);
            this.fullScreenLabel.Name = "fullScreenLabel";
            this.fullScreenLabel.Size = new System.Drawing.Size(688, 23);
            this.fullScreenLabel.TabIndex = 7;
            this.fullScreenLabel.Text = "Enable/Disable Fullscreen mode.";
            // 
            // fullScreenToggle
            // 
            this.fullScreenToggle.Location = new System.Drawing.Point(22, 137);
            this.fullScreenToggle.Name = "fullScreenToggle";
            this.fullScreenToggle.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScreenToggle.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScreenToggle.Size = new System.Drawing.Size(50, 19);
            this.fullScreenToggle.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.fullScreenToggle.TabIndex = 6;
            // 
            // showModsLabel
            // 
            this.showModsLabel.Location = new System.Drawing.Point(107, 97);
            this.showModsLabel.Name = "showModsLabel";
            this.showModsLabel.Size = new System.Drawing.Size(688, 23);
            this.showModsLabel.TabIndex = 5;
            this.showModsLabel.Text = "Enable/Disable showing mods list on game startup.";
            // 
            // showModsToggle
            // 
            this.showModsToggle.Location = new System.Drawing.Point(22, 97);
            this.showModsToggle.Name = "showModsToggle";
            this.showModsToggle.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showModsToggle.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showModsToggle.Size = new System.Drawing.Size(50, 19);
            this.showModsToggle.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.showModsToggle.TabIndex = 4;
            // 
            // packageModLabel
            // 
            this.packageModLabel.Location = new System.Drawing.Point(107, 17);
            this.packageModLabel.Name = "packageModLabel";
            this.packageModLabel.Size = new System.Drawing.Size(688, 23);
            this.packageModLabel.TabIndex = 3;
            this.packageModLabel.Text = "Enable/Disable Sims 4 mods globally. This affects both \"Package\" and \"Script\" typ" +
    "e mods.";
            // 
            // scriptModLabel
            // 
            this.scriptModLabel.Location = new System.Drawing.Point(107, 57);
            this.scriptModLabel.Name = "scriptModLabel";
            this.scriptModLabel.Size = new System.Drawing.Size(688, 23);
            this.scriptModLabel.TabIndex = 2;
            this.scriptModLabel.Text = "Enable/Disable script mods (REQUIRES mods to be ENABLED globally). This affects \"" +
    "Script\" type mods.";
            // 
            // packageModToggle
            // 
            this.packageModToggle.Location = new System.Drawing.Point(22, 17);
            this.packageModToggle.Name = "packageModToggle";
            this.packageModToggle.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageModToggle.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageModToggle.Size = new System.Drawing.Size(50, 19);
            this.packageModToggle.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.packageModToggle.TabIndex = 1;
            this.packageModToggle.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.PackageModToggleCheckedChanged);
            // 
            // scriptModToggle
            // 
            this.scriptModToggle.Location = new System.Drawing.Point(22, 57);
            this.scriptModToggle.Name = "scriptModToggle";
            this.scriptModToggle.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptModToggle.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptModToggle.Size = new System.Drawing.Size(50, 19);
            this.scriptModToggle.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.scriptModToggle.TabIndex = 0;
            this.scriptModToggle.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.ScriptModToggleCheckedChanged);
            // 
            // aboutTab
            // 
            this.aboutTab.Location = new System.Drawing.Point(4, 26);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(803, 519);
            this.aboutTab.TabIndex = 3;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 549);
            this.Controls.Add(this.mainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PlumMod";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.mainTab.ResumeLayout(false);
            this.modTab.ResumeLayout(false);
            this.modListPanel.ResumeLayout(false);
            this.utilTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resWidth)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
