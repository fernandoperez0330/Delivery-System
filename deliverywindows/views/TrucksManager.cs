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

    public partial class TrucksManager : Form
    {
        TrucksEditor editor;
        CamionManage manage;

        public TrucksManager()
        {
            InitializeComponent();
            manage = new CamionManage(this);
            manage.toDGV();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            editor = new TrucksEditor(ref manage);
            manage.setEditor(editor);
            editor.ShowDialog(this);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                editor = new TrucksEditor(ref manage);
                manage.setEditor(editor);
                manage.setModifyFieldData();
                editor.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("No Hay Nada Seleccionado...");
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(this, "Esta Seguro?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    manage.Borrar();
                    manage.toDGV();
                }
            }
            else
            {
                MessageBox.Show("No Hay Nada Seleccionado...");
            }
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public DataGridView DGV
        {
            set { dataGridView1 = value; }
            get { return dataGridView1; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
