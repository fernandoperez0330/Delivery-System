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
using deliverywindows.models;
    using deliverywindows.utils;

    public partial class Login : Form
    {
        ModelUsers model;


        public Login()
        {
            model = new ModelUsers();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            if (this.textBox1.Text == "")
            {
                UtilsViews.showMsgError("El usuario es requerido", this.Text);
                this.textBox1.Focus();
                error = true;
            }
            else if (this.textBox2.Text == "")
            {
                UtilsViews.showMsgError("La clave es requerida", this.Text);
                this.textBox2.Focus();
                error = true;
            }

            if (!error) { 
                //determinar si este usuario y clave son validos
                if (model.login(this.textBox1.Text, this.textBox2.Text))
                {
                    this.Visible = false;
                    new Home().Show();
                }
                else {
                    UtilsViews.showMsgError("Nombre de usuario o clave incorrecta",this.Text);
                    this.textBox1.Focus();
                }   
            }
            
            
        }

        /// <summary>
        /// metodo para evento click del boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        /// <summary>
        /// metodo para evento keypress de los campos usuario y clave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                button1_Click(sender, e);
            }
        }
    }
}
