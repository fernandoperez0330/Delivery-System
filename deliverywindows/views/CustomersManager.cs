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
    using deliverywindows.utils;

    public partial class CustomersManager : Form
    {
        ModelCustomer model;

        /// <summary>
        /// constructor para abrir customermanager
        /// </summary>
        public CustomersManager()
        {
            InitializeComponent();
            model = new ModelCustomer();
            //rellenar datagrid de los clientes
            this.toDGV();
        }

        /// <summary>
        /// metodo para evento click del boton salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// metodo para abrir formulario para agregar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            new CustomersEditor(this).ShowDialog(this);
        }

        /// <summary>
        /// metodo para rellenar el datagrid principal
        /// </summary>
        public void toDGV() {
            this.dataGridView1.DataSource = new ModelCustomer().findAll();
        }


        /// <summary>
        /// metodo para evento click para modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) { 
                int codigoCliente = Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value.ToString());
                new CustomersEditor(codigoCliente, this).ShowDialog(this);
            }
            else MessageBox.Show("No hay ningun cliente seleccionado");
        }

        /// <summary>
        /// metodod para evento click del boton de eliminar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrar_Click(object sender, EventArgs e)
        {
           if (dataGridView1.SelectedRows != null) 
            { 
               if (UtilsViews.showMsgConfirm("¿Desea eliminar este cliente?",this.Text) == DialogResult.Yes){
                   model.customer.Codigo = (int) this.dataGridView1.SelectedCells[0].Value;
                   if (model.delete())
                   {
                       UtilsViews.showMsgSuccess("El cliente ha sido eliminado correctamente", this.Text);
                       this.toDGV();
                   }
                   else
                       UtilsViews.showMsgError("El cliente no pudo ser eliminado, intentelo de nuevo. Si el problema persiste favor reportar", this.Text);
               }
            }
            else MessageBox.Show("No hay ningun cliente seleccionado");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /// <summary>
        /// metodo para evento click de una celda del datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dataGridView1_CellClick (object sender,EventArgs e){
            Boolean ret;
            if (this.dataGridView1.SelectedRows.Count > 0) ret = true;
            else ret = false;
            this.btnModificar.Enabled = ret;
            this.btnBorrar.Enabled = ret;
        }

        private void CustomersManager_Load(object sender, EventArgs e)
        {
            //limpiar seleecion del datagrid principal
            this.dataGridView1.ClearSelection();

        }
    }
}
