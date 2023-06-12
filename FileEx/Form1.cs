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

namespace FileEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileCopy_Click(object sender, EventArgs e)
        {
            string path = @"D:\fs.txt";

            try
            {
                if (File.Exists(path))
                {
                    File.Copy(path, @"D:\fs_복사.txt");
                    lbFileInfo.Items.Clear();
                    lbFileInfo.Items.Add("복사가 완료되었습니다.");
                }
            }

            catch (Exception)
            {
                lbFileInfo.Items.Clear();
                lbFileInfo.Items.Add("이미 파일이 있습니다.");
            }
        }

        private void btnFileInfo_Click(object sender, EventArgs e)
        {
            FileInfo fInfo = new FileInfo(@"D:\fs.txt");

            if (fInfo.Exists) 
            {
                lbFileInfo.Items.Clear();
                lbFileInfo.Items.Add("폴더 이름: " + fInfo.Directory);
                lbFileInfo.Items.Add("파일 이름: " + fInfo.Name);
                lbFileInfo.Items.Add("확장자: " + fInfo.Extension);
                lbFileInfo.Items.Add("생성자: " + fInfo.CreationTime);
                lbFileInfo.Items.Add("파일 크기: " + fInfo.Length);
            }
        }
    }
}
