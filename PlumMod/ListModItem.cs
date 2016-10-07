using System.Windows.Forms;

namespace PlumMod {
    public class ListModItem : ListViewItem {
        ModFile mod;
        public ListModItem(ModFile mod)
            : base() {
            this.mod = mod;
            updateModStatus();
        }
        
        public void updateModStatus() {
            SubItems.Clear();
            Checked = !mod.isDisabled();
            Text = mod.getModName();
            SubItems.Add(mod.getModType().getName());
        }
        
        public ModFile getMod() {
            return mod;
        }
    }
}
