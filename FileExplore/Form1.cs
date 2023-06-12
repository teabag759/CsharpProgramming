﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplore
{
    public partial class Form1 : Form
    {
        public DirectoryInfo dirInfo;
        public DirectoryInfo[] dirsubInfo;
        public int dirCount;

        public Form1()
        {
            InitializeComponent();
            dirCount = 0;
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            dirInfo = new DirectoryInfo(openFileDialog.FileName);
            dirInfo = dirInfo.Parent;
            dirsubInfo = dirInfo.GetDirectories();
            dirCount = dirsubInfo.Length + 1;

            listView.Items.Clear();
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView.Items.Add(item);

            foreach (DirectoryInfo d in dirsubInfo)
            {
                item = new ListViewItem(d.Name.ToString(), 0);
                item.SubItems.Add(d.Attributes.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(d.CreationTime.ToString());
                listView.Items.Add(item);
            }

            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo f in files)
            { 
                item = new ListViewItem(f.Name.ToString(), 1);
                item.SubItems.Add(f.Attributes.ToString());
                item.SubItems.Add(f.Length.ToString());
                item.SubItems.Add(f.CreationTime.ToString());
                listView.Items.Add(item);
            }
        }

        private void listView_Click(object sender, EventArgs e)
        {
            int index = listView.FocusedItem.Index;
            if (index >= dirCount)
            {
                MessageBox.Show("파일을 선택했습니다.");
                return;
            }

            if (index != 0)
            {
                dirInfo = dirsubInfo[index - 1];
            }
            else
            {
                if (dirInfo.Parent == null)
                {
                    MessageBox.Show("루트 디렉토리입니다.");
                    return;
                }
                dirInfo = dirInfo.Parent;
            }

            listView.Items.Clear();
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView.Items.Add(item);

            dirsubInfo = dirInfo.GetDirectories();
            dirCount = dirsubInfo.Length + 1;
            foreach (DirectoryInfo d in dirsubInfo)
            {
                item = new ListViewItem(d.Name.ToString(), 1);
                item.SubItems.Add(d.Attributes.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(d.CreationTime.ToString());
                listView.Items.Add(item);
            }

            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo f in files) 
            {
                item = new ListViewItem(f.Name.ToString(), 1);
                item.SubItems.Add(f.Attributes.ToString());
                item.SubItems.Add(f.Length.ToString());
                item.SubItems.Add(f.CreationTime.ToString());
                listView.Items.Add(item);
            }
        }
    }
}
