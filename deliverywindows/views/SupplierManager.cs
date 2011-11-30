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
            editor.ShowDialog();
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
                manage.setUpdateFieldData
                        (
                            Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()),
                            dataGridView1.SelectedCells[1].Value.ToString(),
                             dataGridView1.SelectedCells[2].Value.ToString(),
                             dataGridView1.SelectedCells[3].Value.ToString(),
                             dataGridView1.SelectedCells[4].Value.ToString(),
                             dataGridView1.SelectedCells[5].Value.ToString(),
                             dataGridView1.SelectedCells[6].Value.ToString()
                        );
            editor.ShowDialog();
            }
            else { MessageBox.Show("No Hay Nada Seleccionado..."); }
        }

        public DataGridView DGV 
        {
            set { dataGridView1 = value; }
            get { return dataGridView1;}
        }

    }
}
