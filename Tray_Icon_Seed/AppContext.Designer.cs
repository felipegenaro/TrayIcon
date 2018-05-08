using System;
using System.Windows.Forms;
using Tray_Icon_Seed.Properties;

namespace Tray_Icon_Seed
{
    partial class AppContext
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                MainIcon.Visible = false;
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainIcon = new NotifyIcon(this.components);
            this.MainIcon.ContextMenuStrip = new ContextMenuStrip();
            // 
            // notifyIcon1
            // 
            this.MainIcon.Text = "myapp";
            this.MainIcon.Visible = true;
            this.MainIcon.Icon = Resources.icon;
            this.MainIcon.DoubleClick += MainIconOnDoubleClick;
            // 
            // MenuItem
            // 
            var showMenuItem = new ToolStripMenuItem
            {
                Text = "Abrir",
                Name = "abrirMenuItem",
            };
            MainIcon.ContextMenuStrip.Items.Add(showMenuItem);
            MainIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());


            // 
            // MenuItem
            // 
            //var showMenuItem = new ToolStripMenuItem
            //{
            //    Text = "Abrir",
            //    Name = "abrirMenuItem",
            //};
            //MainIcon.ContextMenuStrip.Items.Add(showMenuItem);

            MainIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            // 
            // MenuItem
            // 
            var exitMenuItem = new ToolStripMenuItem
            {
                Text = "Sair",
                Name = "exitMenuItem",
            };
            exitMenuItem.Click += CloseMenuItem_Click;
            MainIcon.ContextMenuStrip.Items.Add(exitMenuItem);
        }

        private void MainIconOnDoubleClick(object sender, EventArgs eventArgs)
        {
            var form = new Form1();
            form.ShowDialog();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private NotifyIcon MainIcon;

        #endregion
    }
}
