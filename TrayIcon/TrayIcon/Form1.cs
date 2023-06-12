using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.trayIcon.Visible = false;
            ;
        }

        private void toolStripClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
            this.trayIcon.Visible = true;
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.trayIcon.Visible = false;   
        }
    }
}
