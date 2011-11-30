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
    using models;

    public partial class TravelsManager : Form
    {
        DATABASEDataContext data;
        ViajesManage manage;
        public TravelsManager()
        {
            InitializeComponent();
            data = DataConexion.getInstance();
            manage = new ViajesManage(this);
        }

        private void agregar_Click(object sender, EventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {

        }

        private void borrar_Click(object sender, EventArgs e)
        {

        }
        public DataGridView DGV
        {
            set { dataGridView1 = value; }
            get { return dataGridView1; }
        }
    }
}
