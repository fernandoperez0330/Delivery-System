using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using deliverywindows.controllers;
using deliverywindows.models;
using deliverywindows.entities;
using deliverywindows.utils;


namespace deliverywindows
{
    

    public partial class CartersManager : Form
    {
        CarreroManage manage;
        CartersEditor editor;
        ModelCarters model;
        /// <summary>
        /// constructor
        /// </summary>
        public CartersManager()
        {
            InitializeComponent();
            manage = new CarreroManage(this);
            model = new ModelCarters();
            toDGV();
        }

        /// <summary>
        /// metodo para rellenar data grid general de carreross
        /// </summary>
        public void toDGV()
        {
            try {
                this.dataGridView1.DataSource = model.findAlltoDataSource();
            }catch(Exception exc){
                Utils.logExceptionError(exc);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// metodo del evento click para abrir formualrio de agregar carrero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    int codigoCarrero = Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value);
                    new CartersEditor(codigoCarrero, this).ShowDialog(this);
                }catch(Exception exc){
                    UtilsViews.showMsgError("Hubo problemas al abrir el carrero, favor intente de nuevo. Si el problema persiste, favor reportar",this.Text);
                    Utils.logExceptionError(exc);
                }
            }
            else MessageBox.Show("No hay ningun carrero seleccionado para actualizar");
        }

        /// <summary>
        /// metodo para evento click de borrar carrero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                DialogResult msgresult = UtilsViews.showMsgConfirm("¿Esta seguro de eliminar este carrero", this.Text);
                if (msgresult == DialogResult.Yes)
                {
                    model.carter.Codigo = Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value);
                    if (model.delete()) {
                        UtilsViews.showMsgSuccess("El carrero se ha eliminado correctamente", this.Text);
                        toDGV();
                    }else
                        UtilsViews.showMsgError("El carrero no se puedo eliminar, intente nuevamente. Si el problema persiste favor reportar");
                    
                }
            }
            else
                UtilsViews.showMsgError("No hay ningun carrero seleccionado", this.Text);
        }

        /// <summary>
        /// metodo para evento doble click del datagrid (se utilizara para abrir formulario de actualizar carrero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modificar_Click(sender, e);
        }


        private void CartersManager_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
            ModelSupplier model = new ModelSupplier();
        }

        /// <summary>
        /// metodo para evento click de boton cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            Boolean ret = (this.dataGridView1.SelectedRows.Count > 0);
            this.btnModificar.Enabled = ret;
            this.btnBorrar.Enabled = ret;
        }
        private DataGridView dgv;

        public DataGridView DGV
        {
            get { return this.dataGridView1; }
            set { this.dataGridView1 = value; }
        }


    }
}
