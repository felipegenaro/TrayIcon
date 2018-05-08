using System;
using System.Windows.Forms;
using Tray_Icon_Seed.Config;

namespace Tray_Icon_Seed
{
    public partial class AppContext : ApplicationContext
    {
        public AppContext()
        {
            InitializeComponent();
            AppConfig.Config = AppConfig.Load();
        }

        public void CloseMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja Realmente sair ??",
                                @"Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MainIcon.Visible = false;
                Application.Exit();
            }
        }
    }
}
