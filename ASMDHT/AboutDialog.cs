using System;
using System.Windows.Forms;

namespace ASMDHT {
    public partial class AboutDialog : Form {
        public AboutDialog() {
            InitializeComponent();
        }
        
        void LogoImageClick(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/Lomeli12/ASMDHT");
        }
    }
}
