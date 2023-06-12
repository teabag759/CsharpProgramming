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

namespace BinaryIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\fs.bin", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(tbText.Text);
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            tbText.Text = "";
            FileStream fs = new FileStream(@"C:\fs.bin", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs); 
            tbText.Text = br.ReadString();
            fs.Close();
        }
    }
}
