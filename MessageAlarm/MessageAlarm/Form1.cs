using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MessageAlarm
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;
        private int h = 0;
        private MsgForm msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            x = Screen.PrimaryScreen.Bounds.Width - 250;
            y = Screen.PrimaryScreen.Bounds.Height;
            msg = new MsgForm();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (h > 200)
            {
                h = 0;
                timer1.Stop();
                Thread.Sleep(1000);
                msg.Close();
            }
            else
            { 
                msg.Location = new Point(x, y - h);
                msg.Show();
                h += 10;
            }
        }
    }
}
