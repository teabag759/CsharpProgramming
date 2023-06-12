using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeEx
{
    public partial class Form1 : Form
    {
        private ArrayList arrlist;
        public Form1()
        {
            InitializeComponent();
            arrlist = new ArrayList();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\fs.bin", FileMode.Create);
            Person p = new Person(tbName.Text,
                tbMobile.Text,
                tbEmail.Text,
                tbAddress.Text);

            arrlist.Add(p);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, arrlist);
            fs.Close();
            arrlist.Clear();
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            FileStream fs = new FileStream(@"D:\fs.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            arrlist = (ArrayList)bf.Deserialize(fs);

            foreach (Person p in arrlist)
            {
                tbResult.Text += p.GetName() + "\n" +
                    p.GetMobile() + "\n" +
                    p.GetEmail() + "\n" +
                    p.GetAddress() + "\n";
            }
            
            fs.Close();
        }
    }

    [Serializable]
    class Person
    {
        string name;
        string mobile;
        string email;
        [NonSerialized]
        string address;

        public Person (string aName, string aMobile, string aEmail, string aAddress)
        {
            name = aName;
            mobile = aMobile;
            email = aEmail;
            address = aAddress;
        }

        public string GetName() { return name; }
        public string GetMobile() { return mobile; }
        public string GetEmail() { return email; }
        public string GetAddress() { return address; }
    }
}
