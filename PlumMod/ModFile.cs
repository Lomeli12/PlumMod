using System;
using System.IO;

namespace PlumMod {
    public class ModFile {
        string fileName, name, desc, path;
        bool hasDescription;
        ModType type;
        
        public ModFile(string filePath) {
            path = filePath;
            fileName = Path.GetFileNameWithoutExtension(filePath);
            type = ModType.getTypeFromExtension(filePath);
            var dir = Path.GetDirectoryName(filePath);
            var descFile = dir + "\\" + fileName + ".desc";
            if (File.Exists(descFile)) readDescriptionFile(descFile);
        }
        
        public string getModName() {
            return String.IsNullOrWhiteSpace(name) ? fileName : name;
        }

        public string getModDescription() {
            return hasDescription ? desc : "";
        }

        public string getModPath() {
            return path;
        }
        
        public ModType getModType() {
            return type;
        }
        
        public bool isDisabled() {
            return type == ModType.DISABLED_PACKAGE || type == ModType.DISABLED_SCRIPT;
        }

        public bool hasModDescription() {
            return hasDescription;
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

        void readDescriptionFile(string file) {
            var text = File.ReadAllLines(file);
            if (text != null && text.Length > 0) {
                if (!String.IsNullOrWhiteSpace(text[0])) name = text[0];
                if (text.Length > 1) {
                    for (int i = 1; i < text.Length; i++) {
                        desc += text[i];
                        if (i != text.Length - 1) desc += "\n";
                    }
                    hasDescription = true;
                }
            }
        }
        
        public static bool isModFile(string filePath) {
            return !String.IsNullOrWhiteSpace(filePath) && File.Exists(filePath) &&
            (filePath.EndsWith(".package") || filePath.EndsWith(".zip") || filePath.EndsWith(".ts4script") || filePath.EndsWith(".package.disabled") || filePath.EndsWith(".zip.disabled") || filePath.EndsWith(".ts4script.disabled"));
        }
    }
}
