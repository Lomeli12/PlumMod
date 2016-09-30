using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace PlumMod {
    public class InIFile {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public InIFile(string IniPath = null) {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null) {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
        
        public bool ReadBool(string Key, string Section = null) {
            var val = ReadInt(Key, Section);
            return val >= 1;
        }
        
        public int ReadInt(string Key, string Section = null) {
            var value = Read(Key, Section);
            return int.Parse(value);
        }

        public void Write(string Key, string Value, string Section = null) {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }
        
        public void WriteBool(string Key, bool Value, string Section = null) {
            var v = Value ? 1 : 0;
            Write(Key, v.ToString(), Section);
        }
        
        public void WriteInt(string Key, int Value, string Section = null) {
            Write(Key, Value.ToString(), Section);
        }

        public void DeleteKey(string Key, string Section = null) {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null) {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null) {
            return Read(Key, Section).Length > 0;
        }
    }
}
