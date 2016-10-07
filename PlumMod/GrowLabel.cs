using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlumMod {
    public class GrowLabel : Label {
        private bool growing;
        
        public GrowLabel() {
            this.AutoSize = false;
        }
        
        private void resizeLabel() {
            if (growing) return;
            try {
                growing = true;
                Size sz = new Size(this.Width, Int32.MaxValue);
                sz = TextRenderer.MeasureText(this.Text, this.Font, sz, TextFormatFlags.WordBreak);
                this.Height = sz.Height;
            } finally {
                growing = false;
            }
        }
        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);
            resizeLabel();
        }
        protected override void OnFontChanged(EventArgs e) {
            base.OnFontChanged(e);
            resizeLabel();
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            resizeLabel();
        }
    }
}
