using System.Windows.Forms;

namespace PlumMod {
    public partial class ZipProgressBar : Form {
        public ZipProgressBar(int max) {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Maximum = max;
        }
    }
}
