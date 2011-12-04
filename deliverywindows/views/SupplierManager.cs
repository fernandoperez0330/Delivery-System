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
    public partial class SupplierManager : Form
    {
        SupplierEditor editor;
        SupplierManage manage;

        public SupplierManager()
        {
            InitializeComponent();
            manage = new SupplierManage();
            manage.setManager(this);
            manage.ToDGV();
            
        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            editor = new SupplierEditor(ref manage);
            manage.setEditor(ref editor);
            editor.ShowDialog(this);
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                editor = new SupplierEditor(ref manage);
                manage.setEditor(ref editor);

                int keyCiudad = editor.arrCiudades.IndexOfValue(dataGridView1.SelectedCells[2].ToString());

                manage.setUpdateFieldData(
                        Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()),
                        dataGridView1.SelectedCells[1].Value.ToString(),
                        keyCiudad,
                        dataGridView1.SelectedCells[3].Value.ToString(),
                        dataGridView1.SelectedCells[4].Value.ToString(),
                        dataGridView1.SelectedCells[5].Value.ToString(),
                        dataGridView1.SelectedCells[6].Value.ToString()
                    );

                editor.ShowDialog(this);
            }
            else { MessageBox.Show("No Hay Nada Seleccionado..."); }
        }

        public DataGridView DGV 
        {
            set { dataGridView1 = value; }
            get { return dataGridView1;}
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(this, "Seguro Desea Borrar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    manage.Borrar();
                }
            }
        }

    }
}
