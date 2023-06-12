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

namespace StreamEx
{
    public partial class Form1 : Form
    {
        byte[] data;
        public Form1()
        {
            InitializeComponent();
            data = new byte[26];
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"d:\fs.txt", FileMode.Create, FileAccess.Write);

            for (int i = 0; i < 26; i++)
            {
                data[i] = (byte)(65 + i);
            }

            fs.Write(data, 0, data.Length);
            fs.Close();
            MessageBox.Show("파일에 데이터를 기록했습니다.");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"d:\fs.txt", FileMode.Open, FileAccess.Read);

                fs.Read(data, 0, data.Length);
                fs.Close();

                string result = "";
                for (int i = 0; i < data.Length; i++)
                {
                    result += data[i].ToString() + ", ";
                }
                tbRead.Text = result.ToString();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("파일을 찾을 수 없습니다.");
            }
        }
    }
}
