using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//importando los controladores
using deliverywindows.controllers;
using deliverywindows.models;
using deliverywindows.utils;

namespace deliverywindows
{
    public partial class CustomersEditor : Form
    {
        CustomersManager manager;

        ModelCustomer model;

        /// <summary>
        /// constructor por defecto para abrir formualrio de agregar cliente
        /// </summary>
        public CustomersEditor()
        {
            InitializeComponent();
            this.manager = ((CustomersManager)this.Owner);
            model = new ModelCustomer();
            //llenar el combo de las ciudades
            this.ciudad.DataSource = new ModelCountry().getAlltoSortedList().GetValueList();
        }

        /// <summary>
        /// constructor para formulario nuevo
        /// </summary>
        /// <param name="manager"></param>
        public CustomersEditor(CustomersManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            model = new ModelCustomer();
            //llenar el combo de las ciudades
            this.ciudad.DataSource = new ModelCountry().getAlltoSortedList().GetValueList();
        }

        /// <summary>
        /// constructor para editar el cliente
        /// </summary>
        /// <param name="Codigocliente"></param>
        /// <param name="manager"></param>
        public CustomersEditor(int Codigocliente,CustomersManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            //llenar el combo de las ciudades
            this.ciudad.DataSource = new ModelCountry().getAlltoSortedList().GetValueList();
            
            model = new ModelCustomer();            
            model.find(Codigocliente);
            if (model.customer.Codigo != 0) {
                fillForm();
            }

        }

        /// <summary>
        /// metodo para rellenar los campos del formulario
        /// </summary>
        private void fillForm() {
            //rellenar el nombre
            this.nombre.Text = this.model.customer.Nombre;
            //rellenar la direccion
            this.direccion.Text = this.model.customer.Direccion1;
            //seleccionar la ciudad 
            int keyCiudad = new ModelCountry().getAlltoSortedList().IndexOfValue(this.model.customer.NombreCiudad);
            this.ciudad.SelectedIndex = keyCiudad;
            //rellenar la direccion 2
            this.direccion2.Text = this.model.customer.Direccion2;
            //rellenar el telefono
            this.telefono.Text = this.model.customer.Telefono;
        }
       

        /// <summary>
        /// meotodo para evento click del boton cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (UtilsViews.showMsgConfirm("¿Desea cancelar la solicitud?", this.Text) == DialogResult.Yes) {
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validar los campos
            Boolean error = false;
            if (this.nombre.Text == "")
            {
                this.errorNombre.SetError(this.nombre, "El nombre es requerido");
                error = true;
            }
            else if (this.ciudad.Text == "")
            {
                this.errorCiudad.SetError(this.nombre, "La ciudad es requerida");
                error = true;
            }
            else if (this.direccion.Text == "")
            {
                this.errorDireccion.SetError(this.nombre, "La direccion es requerida");
                error = true;
            }
            else if (this.telefono.Text == "")
            {
                this.errorTelefono.SetError(this.nombre, "El telefono es requerido");
                error = true;
            }

            //no se encontro ningun error en la validaciones
            if (!error) {
                if (model.customer.Codigo != 0)//cuando es para editar
                {
                    if (model.update())
                    {
                        UtilsViews.showMsgSuccess("El cliente ha sido actualizado correctamente", this.Text);
                        this.Close();
                    }
                    else
                        UtilsViews.showMsgError("El cliente no pudo ser actualizado correctamente, intente de nuevo. Si el problema persiste favor reportar", this.Text);
                }
                else //cuando es para agregar
                {
                    if (model.add() == 1)
                    {
                        UtilsViews.showMsgSuccess("El cliente ha sido agregado correctamente",this.Text);
                        this.Close();
                    }
                    else
                        UtilsViews.showMsgError("El cliente no pudo ser agregado correctamente, intente de nuevo. Si el problema persiste favor reportar", this.Text);
                }
                
            }
            
        }
    }
}
