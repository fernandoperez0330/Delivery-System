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
    

    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea salir del sistema?", "Salir del Sistema Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Environment.Exit(Environment.ExitCode);   
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new SupplierManager().ShowDialog(this);
        }

        private void home_Load(object sender, EventArgs e)
        {
            //this.menuStrip1.Visible = false;

        }

        private void togglemenustripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.menuStrip1.Visible)
            {
                this.menuStrip1.Visible = false;
            }
            else this.menuStrip1.Visible = true;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delivery windows version 1.0 ITLA 2011");
        }

        private void carrerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CartersManager().ShowDialog(this);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new CustomersManager().ShowDialog(this);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UsersManager().ShowDialog(this);
        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TrucksManager().ShowDialog();
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdersManager().ShowDialog(this);
        }

        private void viajesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new TravelsManager().ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new CartersManager().ShowDialog(this);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            new CustomersManager().ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OnClosed(e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new SupplierManager().ShowDialog(this);
        }
        //usuario
        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
        //camion
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            new TrucksManager().ShowDialog();
        }
        //orden
        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }
        //viaje
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            new TravelsManager().ShowDialog(this);
<<<<<<< HEAD
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

=======
>>>>>>> 8f061a0cdd1796a40c5941f2a0c0d1c32cbe3aa7
        }
    }
}
