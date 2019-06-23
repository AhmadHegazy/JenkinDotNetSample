using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thank you for contacting us!");
            MessageBox.Show("you entered the following details");
            string txt = "";
            txt += "Name:" + txtname.Text+Environment.NewLine;
            txt += "email:" + txtemail.Text + Environment.NewLine; 
            txt += "address:" + txtadress.Text;
            MessageBox.Show(txt);
            string msgkey = System.Configuration.ConfigurationSettings.AppSettings.Get("showmsg").ToString();
            if(msgkey=="yes")
                MessageBox.Show("Your message is"+txtmsg.Text);
            
            
        }
    }
}
