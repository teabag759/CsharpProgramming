using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEvent_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("버튼을 클릭하였습니다.");
            string strOrder = "";
            if (ckbSoon.Checked == true)
            {
                strOrder += ckbSoon.Text + "\n";
            }
            if (ckbPasta.Checked == true)
            {
                strOrder += ckbPasta.Text + "\n";
            }
            if (ckbSteak.Checked == true)
            {
                strOrder += ckbSteak.Text + "\n";
            }
            if (ckbTang.Checked == true)
            {
                strOrder += ckbTang.Text + "\n";
            }
            lblOrder.Text = strOrder + "메뉴를 요청하였습니다.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked == true)
            {
                MessageBox.Show("개인정보 동의 하셨습니다.");
            }
            else
            {
                MessageBox.Show("개인정보 동의하지 않으셨습니다.");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 요구 사항이 접수되었습니다.";
            MessageBox.Show(strText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbArea.Items.Clear();
            if (cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 할부");
                lbArea.Items.Add("6개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("하루은행");
                lbArea.Items.Add("신전은행");
                lbArea.Items.Add("국물은행");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("N포인트");
                lbArea.Items.Add("주유포인트");
                lbArea.Items.Add("레이저포인트");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string strText = cbPay.Text + "(으)로 " + lbArea.Text + " 결제 방법을" + "\n선택하셨습니다.";
            MessageBox.Show(strText);
        }
    }
}
