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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion?", "Delivery System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                base.OnClosed(e);
            }

        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //deshabilitar el boton de siguiente hasta que haya una lista de viaje para este operador
            this.button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SyncManager().Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Visible = true;
        }
    }
}