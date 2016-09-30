using System;
using System.IO;

namespace PlumMod {
    public class ModFile {
        string fileName, name, path;
        ModType type;
        
        public ModFile(string filePath) {
            this.path = filePath;
            this.fileName = Path.GetFileNameWithoutExtension(filePath);
            this.type = ModType.getTypeFromExtension(filePath);
            var dir = Path.GetDirectoryName(filePath);
            var descFile = dir + "\\" + this.fileName + ".desc";
            if (File.Exists(descFile)) this.name = getModName(descFile);
        }
        
        public string getModName() {
            return String.IsNullOrWhiteSpace(name) ? fileName : name;
        }
        
        public ModType getModType() {
            return type;
        }
        
        public bool isDisabled() {
            return type == ModType.DISABLED_PACKAGE || type == ModType.DISABLED_SCRIPT;
        }
        
        public void changeModState() {
            type = ModType.getOppositeType(type);
            if (isDisabled()) {
                File.Move(path, path + ".disabled");
                path += ".disabled";
            } else {
                var newPath = path.Substring(0, path.Length - ".disabled".Length);
                File.Move(path, newPath);
                path = newPath;
            }
        }
        
        public static bool isModFile(string filePath) {
            return !String.IsNullOrWhiteSpace(filePath) && File.Exists(filePath) && 
                (filePath.EndsWith(".package") || filePath.EndsWith(".zip") || filePath.EndsWith(".ts4script") || filePath.EndsWith(".package.disabled") || filePath.EndsWith(".zip.disabled") || filePath.EndsWith(".ts4script.disabled"));
        }
        
        static string getModName(string file) {
            string name = null;
            var names = File.ReadAllLines(file);
            if (names != null && names.Length > 0) name = names[0];
            return name;
        }
    }
}
