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
    using deliverywindows.models;
    using deliverywindows.entities;

    public partial class CartersManager : Form
    {
        CarreroManage manage;
        CartersEditor editor;
       
        public CartersManager()
        {
            InitializeComponent();
            manage = new CarreroManage(this);           
            manage.toDGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           editor =  new CartersEditor(manage);
           editor.ShowDialog(this);
           this.dataGridView1.ClearSelection();
        }

        /// <summary>
        /// metodo del evento click de modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedCells.Count > 0)
            {               
               editor =  new CartersEditor(manage);
               manage.setModifyFieldData();
               editor.ShowDialog(this);
            }
            else MessageBox.Show("No hay ningun carrero seleccionado para actualizar");
        }
        private void borrar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedCells.Count > 0)
            {
                if(MessageBox.Show(this,"Esta seguro?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    manage.Borrar();
                    manage.toDGV();
                }
            }
            else MessageBox.Show("No hay Nada Selecionado...");
       
        }
        public DataGridView DGV
        {
            set { dataGridView1 = value; }
            get { return dataGridView1; }
        }

        void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Do something on double click, except when on the header.
            //
            if (e.RowIndex == -1)
            {
                return;
            }

            this.modificar_Click(sender, e);
        }

        private void CartersManager_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
            ModelSupplier model = new ModelSupplier();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CartersManager_KeyPress(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.button1_Click_1(sender,e);
            }
        }

        private void dataGridView1_CellClick(object sender, EventArgs e) {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                this.btnModificar.Enabled = true;
                this.btnBorrar.Enabled = true;
            }
            else {
                this.btnModificar.Enabled = false;
                this.btnBorrar.Enabled = false;
            }
        }

    }
}
