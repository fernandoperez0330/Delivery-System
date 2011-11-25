using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace deliverymobile.views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion?", "Delivery System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                base.OnClosed(e);
            }
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            //confirmar la salida del programa
            if (MessageBox.Show("Desea salir del programa?", "Delivery System", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Menu().Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}