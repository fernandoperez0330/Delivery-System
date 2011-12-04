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
        TravelsEditor editor;

        public TravelsManager()
        {
            InitializeComponent();
            data = DataConexion.getInstance();
            manage = new ViajesManage(this);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            editor = new TravelsEditor(ref manage);
            manage.setEditor( editor);
            editor.ShowDialog(this);
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

        private void salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"Seguro Desea Salir?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==  DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click_1(object sender, EventArgs e)
        {
            editor = new TravelsEditor(ref manage);
            editor.ShowDialog(this);
        }
    }
}
