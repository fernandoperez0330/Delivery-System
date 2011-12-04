using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using deliverywindows.models;
using deliverywindows.utils;
namespace deliverywindows
{
    public partial class OrdersManager : Form
    {
        ModelOrder model;
        
        public OrdersManager()
        {
            InitializeComponent();
            model = new ModelOrder();
            toDGV();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// funcion para actualizar el data grd view principal
        /// </summary>
        public void toDGV()
        {
            this.dataGridView1.DataSource = model.findtoDataSource();
        }

        

        private void agregar_Click(object sender, EventArgs e)
        {
            new OrdersEditor(this).ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int keyOrder = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                new OrdersEditor(keyOrder,this).ShowDialog(this);
            }
            else { MessageBox.Show("No Hay Nada Seleccionado..."); }
        }

        private void dataGridView1_CellClick(object sender, EventArgs e) {
            Boolean ret;
            //determinar si hay un elemento seleccionado para habilitar los botones de eliminar y modificar
            ret = (this.dataGridView1.SelectedRows.Count > 0);
            this.btnModificar.Enabled = ret;
            this.btnBorrar.Enabled = ret;
        }

        private void dataGridView1_CellDoubleClick(object sender, EventArgs e) {
            btnModificar_Click(sender, e);
        }

        private void OrdersManager_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //acccion para borrar orden
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int keyOrder = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                model.order.Codigo = keyOrder;
                if (model.delete())
                    UtilsViews.showMsgSuccess("La orden ha sido eliminada correctamente", this.Text);
                else
                    UtilsViews.showMsgError("La orden no pudo ser eliminada, intentelo de nuevo, si el problema persiste favor reportar");
            }
            else
                UtilsViews.showMsgAlert("No hay ninguna orden seleccionada");
        }
    }
}
