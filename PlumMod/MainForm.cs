using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PlumMod {
    public partial class MainForm : Form {
        string sims4FolderPath, modFolderPath;
        InIFile configFile, simsConfig;
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
            showModsToggle.Checked = simsConfig.ReadBool("showmodliststartup", "options");
            fullScreenToggle.Checked = simsConfig.ReadBool("fullscreen", "options");
            resWidth.Value = simsConfig.ReadInt("resolutionwidth", "options");
            resHeight.Value = simsConfig.ReadInt("resolutionheight", "options");
            return true;
        }
        
        void listMods() {
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
        }
        
        void MainFormLoad(object sender, EventArgs e) {
            while(isSims4Running()) {
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
            if (e.Item is ListModItem) {
                ((ListModItem)e.Item).getMod().changeModState();
                ((ListModItem)e.Item).updateModStatus();
            }
        }
        
        /**
         *  Utilies Tab
         **/
        
        void ScriptModToggleCheckedChanged(object sender, EventArgs e) {
            simsConfig.WriteBool("scriptmodsenabled", scriptModToggle.Checked, "options");
        }
        
        void PackageModToggleCheckedChanged(object sender, EventArgs e) {
            simsConfig.WriteBool("modsdisabled", !packageModToggle.Checked, "options");
        }
        
    }
}
