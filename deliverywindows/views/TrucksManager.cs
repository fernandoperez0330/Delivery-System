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
            editor.ShowDialog();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                editor = new TrucksEditor(ref manage);
                manage.setEditor(editor);
                manage.setModifyFieldData();
                editor.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Hay Nada Seleccionado...");
            }
<<<<<<< HEAD
=======
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
>>>>>>> 8f061a0cdd1796a40c5941f2a0c0d1c32cbe3aa7
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrucksManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deliverydataDataSet.Camiones' table. You can move, or remove it, as needed.
            this.camionesTableAdapter.Fill(this.deliverydataDataSet.Camiones);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, EventArgs  e)
        {
            Boolean enabled = (this.dataGridView1.SelectedRows.Count > 0);
            this.toolStripButton2.Enabled = enabled;
            this.toolStripButton3.Enabled = enabled;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new TrucksEditor().ShowDialog(this);
        }

    }
}
