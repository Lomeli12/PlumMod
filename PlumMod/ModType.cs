using System;

namespace PlumMod {
    public class ModType {
        public static readonly ModType PACKAGE = new ModType("Package", false);
        public static readonly ModType SCRIPT = new ModType("Script", false);
        public static readonly ModType DISABLED_PACKAGE = new ModType("Disabled Package", true);
        public static readonly ModType DISABLED_SCRIPT = new ModType("Disabled Script", true);
        public static readonly ModType UNKNOWN = new ModType("Unknown", false);
        
        string name;
        bool disabled;
        ModType(string name, bool disabled) {
            this.name = name;
            this.disabled = disabled;
        }
        
        public String getName() {
            return name;
        }
        
        public bool isDisabled() {
            return disabled;
        }

        public static ModType getOppositeType(ModType type) {
            if (type == null) return UNKNOWN;
            if (type == SCRIPT) return DISABLED_SCRIPT;
            if (type == PACKAGE) return DISABLED_PACKAGE;
            if (type == DISABLED_SCRIPT) return SCRIPT;
            if (type == DISABLED_PACKAGE) return PACKAGE;
            return UNKNOWN;
        }
        
        public static ModType getTypeFromExtension(string fileName) {
            var type = ModType.UNKNOWN;
            if (!String.IsNullOrWhiteSpace(fileName)) {
                if (fileName.EndsWith(".package")) type = ModType.PACKAGE;
                else if (fileName.EndsWith(".zip") || fileName.EndsWith(".ts4script")) type = ModType.SCRIPT;
                else if (fileName.EndsWith(".package.disabled")) type = ModType.DISABLED_PACKAGE;
                else if (fileName.EndsWith(".zip.disabled") || fileName.EndsWith(".ts4script.disabled")) type = ModType.DISABLED_SCRIPT;
            }
            return type;
        }
    }
}
