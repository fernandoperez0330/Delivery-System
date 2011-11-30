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

    public partial class CustomersManager : Form
    {
        ClientesManage manage;
        CustomersEditor editor;

        public CustomersManager()
        {
            InitializeComponent();
            manage = new ClientesManage();
            manage.setManager(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editor = new CustomersEditor(ref manage);
            manage.setEditor(ref editor);
            editor.ShowDialog();
        }
        public  DataGridView DGV 
        {
            set { dataGridView1 = value; }
            get { return (this.dataGridView1);}
        }

        public void showEditor()
        {
            editor = new CustomersEditor(ref manage);
            editor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null) MessageBox.Show("NO hay Nada seleccionado");
            else
            {
               
                MessageBox.Show(dataGridView1.SelectedCells[1].Value.ToString());
                editor = new CustomersEditor(ref manage);
                manage.setEditor(ref editor);
                editor.setUpdateFieldData(Convert.ToInt32(dataGridView1.SelectedCells[0].Value),
                    dataGridView1.SelectedCells[1].Value.ToString(),
                    dataGridView1.SelectedCells[2].Value.ToString(),
                    dataGridView1.SelectedCells[3].Value.ToString(),
                    dataGridView1.SelectedCells[4].Value.ToString(),
                    dataGridView1.SelectedCells[5].Value.ToString()
                );
                editor.ShowDialog();
            }
        }
    }
}
