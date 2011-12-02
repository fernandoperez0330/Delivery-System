using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using deliverywindows.models;

namespace deliverywindows
{
    using controllers;

    public partial class Login : Form
    {
        ModelUsers model;
        UserValidation validation;
        public Login()
        {
            //view
            InitializeComponent();
            //instance model
            model = new ModelUsers();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.textBox1.Text;
            String password = this.textBox2.Text;
            Boolean error = false;
            Boolean isLogged = false;

            if (username == "") {
                error = true;
            }
            else if (password == "") {
                error = true;
            }

            //all it's OK
            if (!error) {
                model.User.Username = username;
                model.User.Password = password;
                if (model.login()) isLogged = true;
            }

            //verify if this user has been logged
            if (isLogged)
            {
                this.Visible = false;
                new Home().Show();
            }
            else {
                MessageBox.Show(this, "Nombre de usuario o contraseña incorrecta", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
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

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
