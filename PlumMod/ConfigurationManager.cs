using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace PlumMod {
    class ConfigurationManager {
        public static List<string> configurationNames = new List<string>();
        public static string savedConfigFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PlumMod";

        static void createConfigFolder() {
            if (!Directory.Exists(savedConfigFolder)) Directory.CreateDirectory(savedConfigFolder);
        }

        public static void getModConfigList() {
            createConfigFolder();
            var files = Directory.GetFiles(savedConfigFolder);
            configurationNames.Clear();
            if (files != null && files.Length > 0) {
                foreach (string file in files) {
                    if (File.Exists(file) && file.EndsWith(".zip"))
                        configurationNames.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
        }

        public static bool saveCurrentConfig(string modFolder, string configName) {
            createConfigFolder();
            if (!Directory.Exists(modFolder)) return false;
            var files = Directory.GetFiles(modFolder);
            if (files == null || files.Length <= 0) return false;
            var zipFile = savedConfigFolder + "\\" + configName + ".zip";
            if (File.Exists(zipFile)) {
                var result = MessageBox.Show("Config '" + configName + "' already exists!\nWould you like to overwrite it?", "Configuration Duplicate!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) File.Delete(zipFile);
                else return false;
            }
            var destination = File.Create(zipFile);
            var zipStream = new ZipOutputStream(destination);
            zipStream.SetLevel(3);
            var folderOffset = modFolder.Length + (modFolder.EndsWith("\\") ? 0 : 1);
            var current = 0l;
            var progressBar = new ZipProgressBar((int)getTotalSize(files));
            progressBar.Show();
            foreach (string modFile in files) {
                if (File.Exists(modFile) && (ModFile.isModFile(modFile) || modFile.EndsWith(".desc"))) {
                    var info = new FileInfo(modFile);
                    var entryName = modFile.Substring(folderOffset);
                    entryName = ZipEntry.CleanName(entryName);
                    var newEntry = new ZipEntry(entryName);
                    newEntry.DateTime = info.LastWriteTime;
                    newEntry.Size = info.Length;
                    zipStream.PutNextEntry(newEntry);
                    var buffer = new byte[4096];
                    using (var streamReader = File.OpenRead(modFile)) {
                        StreamUtils.Copy(streamReader, zipStream, buffer);
                    }
                    zipStream.CloseEntry();
                    current += info.Length;
                    progressBar.progressBar.Value = (int)min(progressBar.progressBar.Maximum, (progressBar.progressBar.Value + info.Length));
                }
            }
            progressBar.Close();
            zipStream.IsStreamOwner = true;
            zipStream.Close();
            return true;
        }

        public static void deleteConfig(string configName) {
            var path = savedConfigFolder + "\\" + configName + ".zip";
            if (!Directory.Exists(savedConfigFolder) || !File.Exists(path))
                MessageBox.Show(configName + " does not exist!");
            var result = MessageBox.Show("Are you sure you want to delte '" + configName + "'?\nOnce it's gone, it's gone forever!", "Configuration Deletion!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                File.Delete(path);
                MessageBox.Show("'" + configName + "' deleted!", "Configuration Deleted!");
            }
        }

        public static void loadConfiguration(string modFolder, string configName) {
            createConfigFolder();
            if (Directory.Exists(modFolder)) Directory.CreateDirectory(modFolder);
            var zippedConfig = savedConfigFolder + "\\" + configName + ".zip";
            if (!File.Exists(zippedConfig)) {
                MessageBox.Show("'" + configName + "' does not exist!", "No Configuration Exist!");
                return;
            }
            var files = Directory.GetFiles(modFolder);
            if (files != null && files.Length > 0) {
                var hasMods = false;
                foreach(var file in files) {
                    if (ModFile.isModFile(file)) {
                        hasMods = true;
                        break;
                    }
                }
                if (hasMods) {
                    var result = MessageBox.Show("You currently already have some mods installed.\nPlumMod will overwrite any duplicate mods!\nWould you like to continue?", "Possible Duplicates", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;
                }
            }
            var progress = new ZipProgressBar((int)new FileInfo(zippedConfig).Length);
            progress.Show();
            ZipFile configZip = null;
            try {
                var fStream = File.OpenRead(zippedConfig);
                configZip = new ZipFile(fStream);
                foreach (ZipEntry zipEntry in configZip) {
                    if (!zipEntry.IsFile)
                        continue;
                    var fileName = zipEntry.Name;
                    var buffer = new byte[4096];
                    var stream = configZip.GetInputStream(zipEntry);
                    var fullZipToPath = Path.Combine(modFolder, fileName);
                    if (File.Exists(fullZipToPath)) File.Delete(fullZipToPath);
                    var directoryName = Path.GetDirectoryName(fullZipToPath);
                    if (directoryName.Length > 0 && !Directory.Exists(directoryName))
                        Directory.CreateDirectory(directoryName);
                    using (var streamWriter = File.Create(fullZipToPath)) {
                        StreamUtils.Copy(stream, streamWriter, buffer);
                    }
                    progress.progressBar.Value = (int)min(progress.progressBar.Maximum, (progress.progressBar.Value + new FileInfo(fullZipToPath).Length));
                }
            } finally {
                if (configZip != null) {
                    configZip.IsStreamOwner = true;
                    configZip.Close();
                }
                progress.Close();
            }
        }

        static long min(long v0, long v1) {
            return v0 < v1 ? v0 : v1;
        }

        static long getTotalSize(string[] files) {
            var size = 0L;
            foreach (string file in files) {
                if (File.Exists(file) && (ModFile.isModFile(file) || file.EndsWith(".desc")))
                    size += new FileInfo(file).Length;
            }
            return size;
        }
    }
}
