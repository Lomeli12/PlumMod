using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PlumMod {
    public partial class MainForm : Form {
        string sims4FolderPath, modFolderPath;
        InIFile configFile, simsConfig;
        bool initialized;
        public MainForm() {
            InitializeComponent();
        }
        
        bool getConfig() {
            configFile = new InIFile("config.cfg");
            string path = configFile.Read("Sims4FolderPath", "Main");
            if (String.IsNullOrWhiteSpace(path)) {
                MessageBox.Show("Please point to the mods folder for the Sims 4\n(usually located in \"My Documents\\Electronic Arts\\The Sims 4\")");
                simsFolderDialog.ShowDialog();
                path = simsFolderDialog.SelectedPath;
                if (!String.IsNullOrWhiteSpace(path)) configFile.Write("Sims4FolderPath", path, "Main");
                else return false;
            }
            sims4FolderPath = path;
            modFolderPath = path + "\\Mods";
            if (!File.Exists(sims4FolderPath + "\\Options.ini")) return false;
            simsConfig = new InIFile(sims4FolderPath + "\\Options.ini");
            if (simsConfig == null) return false;
            // Set utilies stuff
            scriptModToggle.Checked = simsConfig.ReadBool("scriptmodsenabled", "options");
            packageModToggle.Checked = !simsConfig.ReadBool("modsdisabled", "options");
            scriptModToggle.Enabled = packageModToggle.Checked;
            if (simsConfig.ReadBool("modsdisabled", "options")) MessageBox.Show("Mods are currently disabled. Please enabled them in the Utilities tab before loading the game.");
            showModsToggle.Checked = simsConfig.ReadBool("showmodliststartup", "options");
            fullScreenToggle.Checked = simsConfig.ReadBool("fullscreen", "options");
            resWidth.Value = simsConfig.ReadInt("resolutionwidth", "options");
            resHeight.Value = simsConfig.ReadInt("resolutionheight", "options");
            return true;
        }
        
        void listMods() {
            modDescriptionLabel.Text = "";
            mainModList.Items.Clear();
            if (!Directory.Exists(modFolderPath)) Directory.CreateDirectory(modFolderPath);
            var files = Directory.GetFiles(modFolderPath);
            if (files != null && files.Length > 0) {
                foreach (string modPath in files) {
                    if (ModFile.isModFile(modPath)) {
                        var mod = new ModFile(modPath);
                        if (mod != null) mainModList.Items.Add(new ListModItem(mod));
                    }
                }
            }
            initialized = true;
        }
        
        void MainFormLoad(object sender, EventArgs e) {
            while (isSims4Running()) {
                MessageBox.Show("PlumMod has detected that The Sims 4™ is running. As PlumMod can edit The Sims 4™'s config file, please close the game to avoid any potential errors and ensure changes take effect.");
            }
            if (getConfig()) listMods();
            else Application.Exit();
        }
        
        bool isSims4Running() {
            var pname = Process.GetProcessesByName("TS4");
            if (pname == null || pname.Length == 0) {
                pname = Process.GetProcessesByName("TS4_x64");
                return pname != null && pname.Length > 0;
            }
            return true;
        }
        
        /**
         *  Manage Mods Tab
         **/
        
        void MainModListItemChecked(object sender, ItemCheckedEventArgs e) {
            if (initialized && e.Item is ListModItem) {
                ((ListModItem)e.Item).getMod().changeModState();
                ((ListModItem)e.Item).updateModStatus();
            }
        }

        void refreshListBtn_Click(object sender, EventArgs e) {
            initialized = false;
            listMods();
        }

        void mainModList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (!initialized) return;
            var selectedItems = mainModList.SelectedItems;
            removeModBtn.Enabled = (selectedItems != null && selectedItems.Count > 0);
            updateButtonStates();
            if (e.Item is ListModItem) getModDescription((ListModItem)e.Item);
        }

        void updateButtonStates() {
            var selectedItems = mainModList.SelectedItems;
            if (selectedItems != null && selectedItems.Count > 0) {
                var enabledMods = false;
                var disabledMods = false;
                for (int i = 0; i < selectedItems.Count; i++) {
                    var item = selectedItems[i];
                    if (item.Checked) disabledMods = true;
                    else enabledMods = true;
                    if (enabledMods && disabledMods) break;
                }
                disableModBtn.Enabled = disabledMods;
                enableModBtn.Enabled = enabledMods;
            }
        }

        void getModDescription(ListModItem item) {
            var text = item.getMod().getModName();
            if (item.getMod().hasModDescription()) text += "\n\n" + item.getMod().getModDescription();
            modDescriptionLabel.Text = text;
        }

        void removeModBtn_Click(object sender, EventArgs e) {
            var selectedItems = mainModList.SelectedItems;
            if (selectedItems != null && selectedItems.Count > 0) {
                for (int i = 0; i < selectedItems.Count; i++) {
                    var item = selectedItems[i];
                    if (item is ListModItem) {
                        var modPath = ((ListModItem)item).getMod().getModPath();
                        var modDesc = modPath.Substring(0, modPath.Length - Path.GetExtension(modPath).Length) + ".desc";
                        File.Delete(modPath);
                        if (File.Exists(modDesc)) File.Delete(modDesc);
                    }
                }
            }
            listMods();
        }
        
        void setSelectedModStates(bool enabled) {
            var selectedItems = mainModList.SelectedItems;
            if (selectedItems != null && selectedItems.Count > 0) {
                for (int i = 0; i < selectedItems.Count; i++) {
                    var item = selectedItems[i];
                    item.Checked = enabled;
                }
            }
            updateButtonStates();
        }

        void disableModBtn_Click(object sender, EventArgs e) {
            setSelectedModStates(false);
        }

        void enableModBtn_Click(object sender, EventArgs e) {
            setSelectedModStates(true);
        }
        
        void AddModBtnClick(object sender, EventArgs e) {
            addModDialog.ShowDialog();
            var fileNames = addModDialog.FileNames;
            if (fileNames != null && fileNames.Length > 0) {
                for (int i = 0; i < fileNames.Length; i++) {
                    var file = fileNames[i];
                    var noPath = Path.GetFileName(file);
                    var descFile = file.Substring(0, file.Length - Path.GetExtension(file).Length) + ".desc";
                    var mod = new ModFile(file);
                    if (File.Exists(file)) {
                        if (File.Exists(modFolderPath + "\\" + noPath)) {
                            var result = MessageBox.Show("A mod called " + mod.getModName() + " already exists! Do you want to overwrite it?", "Duplicate Mod", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No) return;                                 
                            File.Delete(modFolderPath + "\\" + noPath);
                        }
                        File.Copy(file, modFolderPath + "\\" + noPath);
                        if (File.Exists(descFile)) {
                            if (File.Exists(modFolderPath + "\\" + Path.GetFileName(descFile))) File.Delete(modFolderPath + "\\" + Path.GetFileName(descFile));
                            File.Copy(descFile, modFolderPath + "\\" + Path.GetFileName(descFile));
                        }
                    }
                }
            }
            listMods();
        }

        /**
         *  Utilies Tab
         **/

        void ScriptModToggleCheckedChanged(object sender, EventArgs e) {
            simsConfig.WriteBool("scriptmodsenabled", scriptModToggle.Checked, "options");
        }

        void PackageModToggleCheckedChanged(object sender, EventArgs e) {
            scriptModToggle.Enabled = packageModToggle.Checked;
            simsConfig.WriteBool("modsdisabled", !packageModToggle.Checked, "options");
        }

        void showModsToggle_CheckedChanged(object sender, EventArgs e) {
            simsConfig.WriteBool("showmodliststartup", showModsToggle.Checked, "options");
        }

        void fullScreenToggle_CheckedChanged(object sender, EventArgs e) {
            simsConfig.WriteBool("fullscreen", fullScreenToggle.Checked, "options");
        }

        void clearCacheBtn_Click(object sender, EventArgs e) {
            var dataCleared = 0l;
            if (File.Exists(sims4FolderPath + "\\localthumbcache.package")) {
                dataCleared += new FileInfo(sims4FolderPath + "\\localthumbcache.package").Length;
                File.Delete(sims4FolderPath + "\\localthumbcache.package");
            }
            if (Directory.Exists(sims4FolderPath + "\\cache")) {
                var fileNames = Directory.GetFiles(sims4FolderPath + "\\cache");
                if (fileNames != null && fileNames.Length > 0) {
                    for (int i = 0; i < fileNames.Length; i++) {
                        var filename = fileNames[i];
                        if (File.Exists(filename)) {
                            if (filename.EndsWith("FileCache.cfg") || filename.EndsWith("FileCache.ini")) continue;
                            else {
                                dataCleared += new FileInfo(filename).Length;
                                File.Delete(filename);
                            }
                        }
                    }
                }
                dataCleared /= 1000;
                MessageBox.Show(dataCleared + "KB cleared.");
            }
        }

        void tuneBtm_Click(object sender, EventArgs e) {
            if (!Directory.Exists(modFolderPath)) {
                Directory.CreateDirectory(modFolderPath);
                Directory.CreateDirectory(modFolderPath + "\\unpackedmod");
            } else {
                if (!Directory.Exists(modFolderPath + "\\unpackedmod")) Directory.CreateDirectory(modFolderPath + "\\unpackedmod");
                if (File.Exists(modFolderPath + "\\Resource.cfg")) {
                    var backupPath = modFolderPath + "\\Resource.cfg.bak";
                    var counter = 0;
                    while (File.Exists(backupPath)) {
                        backupPath = modFolderPath + "\\Resource.cfg." + counter + ".bak";
                        counter++;
                    }
                    File.Copy(modFolderPath + "\\Resource.cfg", backupPath);
                    File.WriteAllLines(modFolderPath + "\\Resource.cfg", new string[] {
                        "Priority 500",
                        "PackedFile *.package",
                        "PackedFile *\\*.package",
                        "",
                        "DirectoryFiles unpackedmod autoupdate"
                    });
                }
                MessageBox.Show("Finished Tunning Prep.");
            }
        }
        
        void ResWidthValueChanged(object sender, EventArgs e) {
            simsConfig.WriteInt("resolutionwidth", (int)resWidth.Value, "options");
        }
        
        void ResHeightValueChanged(object sender, EventArgs e) {
            simsConfig.WriteInt("resolutionheight", (int)resHeight.Value, "options");
        }

        /**
         * Config Tab
         **/
        
        void updateConfigList() {
            ConfigurationManager.getModConfigList();
            configListBox.Items.Clear();
            foreach (var name in ConfigurationManager.configurationNames)
                configListBox.Items.Add(name);
        }
        void saveConfigBtn_Click(object sender, EventArgs e) {
            var form = new NameInputForm("");
            form.ShowDialog();
            if (!form.Canceled) {
                ConfigurationManager.saveCurrentConfig(modFolderPath, form.Name);
                updateConfigList();
            }
        }

        void configTab_Enter(object sender, EventArgs e) {
            updateConfigList();
        }

        void deleteModConfigBtn_Click(object sender, EventArgs e) {
            var itemName = configListBox.SelectedItem;
            if (itemName != null && !String.IsNullOrWhiteSpace(itemName.ToString())) {
                ConfigurationManager.deleteConfig(itemName.ToString());
                updateConfigList();
            }
        }

        void loadConfigBtn_Click(object sender, EventArgs e) {
            var itemName = configListBox.SelectedItem;
            if (itemName != null && !String.IsNullOrWhiteSpace(itemName.ToString())) {
                ConfigurationManager.loadConfiguration(modFolderPath, itemName.ToString());
                initialized = false;
                listMods();
            }
        }
       

        /**
         * About Tab
         **/
        void githubBtn_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/Lomeli12/PlumMod");
        }

        void websiteBtn_Click(object sender, EventArgs e) {
            Process.Start("https://lomeli12.net/");
        }
    }
}
