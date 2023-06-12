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

namespace TextIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"d:\fs.txt");
            sw.Write(tbText.Text);
            sw.Close();
            MessageBox.Show("텍스트가 파일에 저장되었습니다.");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            char[] buf = new char[1024];
            int retCnt = 0;
            StreamReader sr = new StreamReader(@"d:\fs.txt");
            tbText.Text = "";
            for (; ; )
            {
                retCnt = sr.Read(buf, 0, 1024);
                tbText.Text += new string(buf, 0, 1024);
                if (retCnt < 1024)
                {
                    break;
                }
            }
            sr.Close();
        }
    }
}
