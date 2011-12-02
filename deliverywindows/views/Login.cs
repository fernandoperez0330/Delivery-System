using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deliverywindows
{
    using controllers;

    public partial class Login : Form
    {
        UserValidation validation;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           //validation = new UserValidation(textBox1.Text,textBox2.Text);
            this.Visible = false;
            new Home().Show();
        }
        bool validate()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) return false;
            else if (string.IsNullOrWhiteSpace(textBox2.Text)) return false;
            else return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
