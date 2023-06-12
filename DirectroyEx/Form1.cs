using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectroyEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirList_Click(object sender, EventArgs e)
        {
            lbDir.Items.Clear();
            string[] apaths = Directory.GetDirectories(Environment.SystemDirectory);

            foreach (string dirPath in apaths)
            { 
                lbDir.Items.Add(dirPath);
            }
        }

        private void btnFileList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            string[] afiles = Directory.GetFiles(Environment.SystemDirectory, "*.exe");

            foreach (string file in afiles)
            {
                lbFiles.Items.Add(file);
            }
        }
    }
}
