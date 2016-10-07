using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PlumMod {
    public partial class NameInputForm : Form {
        private static List<char> invalidChars;
        public NameInputForm(string name) {
            if (invalidChars == null) initiateList();
            InitializeComponent();
            Canceled = true;
            Name = nameInputBox.Text = name;
        }

        void initiateList() {
            invalidChars = new List<char>();
            invalidChars.AddRange(Path.GetInvalidFileNameChars());
        }

        void okBtn_Click(object sender, EventArgs e) {
            Name = nameInputBox.Text;
            Canceled = String.IsNullOrWhiteSpace(Name);
            Close();
        }

        void cancelBtn_Click(object sender, EventArgs e) {
            Canceled = true;
            Close();
        }

        public string Name {
            get; set;
        }

        public bool Canceled {
            get; set;
        }

        void nameInputBox_TextChanged(object sender, EventArgs e) {
            var sb = new StringBuilder();
            foreach (var c in nameInputBox.Text) {
                if (!invalidChars.Contains(c)) sb.Append(c);
            }
            nameInputBox.Text = sb.ToString();
        }

        void nameInputBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Name = nameInputBox.Text;
                Canceled = String.IsNullOrWhiteSpace(Name);
                Close();
            }
        }
    }
}
