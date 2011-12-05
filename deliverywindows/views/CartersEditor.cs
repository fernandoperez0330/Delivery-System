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
    using deliverywindows.utils;

    public partial class CartersEditor : Form
    {
        int id = -1;
        CarreroManage manage;
        CartersManager manager;
        ModelCarters model;

        public CartersEditor(CarreroManage mgr)
        {
            InitializeComponent();
            manage = mgr;
            model = new ModelCarters();
            manage.setEditor(this);
            this.selectCiudad.DataSource = new ModelCountry().getAlltoSortedList().GetValueList();
        }

        public CartersEditor(int codigo, CartersManager manager) {
            InitializeComponent();
            model = new ModelCarters();
            model.find(codigo);
            this.selectCiudad.DataSource = new ModelCountry().getAlltoSortedList().GetValueList();
            if (model.carter.Codigo != 0) {
                this.manager = manager;
                this.ID = model.carter.Codigo;
                this.Nombre = model.carter.Nombre;
                this.Telefono = model.carter.Telefono;
                this.Direccion = model.carter.Direccion;
                this.Ciudad = model.carter.Ciudad;
                this.txtUsuario.Text = model.carter.Usuario.Usuario;
                this.txtClave.Text = model.carter.Usuario.Clave;
                //cambiar el titulo de la ventana
                this.Text = "Actualizar Carrero";
            }else{
                UtilsViews.showMsgError("Este carrero no pudo ser encontrado",this.Text);
                this.Dispose();
            }
        }

        public void setCityData(ref string[] ciudades)
        {
            try
            {
                selectCiudad.Items.AddRange(ciudades);
                selectCiudad.SelectedIndex = 0;
            }catch(Exception exc){
                Utils.logExceptionError(exc);
            }

        }

        /// <summary>
        /// metodo para evento click para cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            DialogResult messageBoxResult = UtilsViews.showMsgConfirm("¿Desea cancelar esta solicitud?", this.Text);
            if (messageBoxResult == DialogResult)
                this.Dispose();
            else return;
        }
        
        /// <summary>
        /// metodo para evento click de aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aceptar_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                model.carter.Codigo = this.ID;
                model.carter.Nombre = this.Nombre;
                model.carter.Direccion = this.Direccion;
                model.carter.Telefono = this.Telefono;
                model.carter.Ciudad = this.Ciudad;
                model.carter.Tipo = 2;
                //datos para usuarios
                model.carter.Usuario.Usuario = this.txtUsuario.Text;
                model.carter.Usuario.Clave = this.txtClave.Text;
                model.carter.Usuario.Tipousuario = "C";
                model.carter.Usuario.Sincroniza = 1;
                if (this.ID <= 0)
                {
                    if (model.add() == 1)
                    {
                        UtilsViews.showMsgSuccess("El carrero ha sido agregado correctamente", this.Text);
                        try
                        {
                            if (this.manager.Name == "CartersManager")
                            {
                                this.manager.toDGV();
                            }
                        }catch(Exception exc){
                            Utils.logExceptionError(exc);
                        }
                        this.Dispose();
                    }
                    else {
                        UtilsViews.showMsgSuccess("El carrero no se pudo agregar correctamente, favor verifique", this.Text);
                    }
                }
                else {
                    if (model.update()) {
                        UtilsViews.showMsgSuccess("El carrero ha sido actualizado correctamente", this.Text);
                        this.manager.toDGV();
                        this.Dispose();
                    }
                    else
                    {
                        UtilsViews.showMsgSuccess("El carrero no se pudo actualizar correctamente, favor verifique.", this.Text);
                    }
                }
            }
            else 
                UtilsViews.showMsgError("Hay campos requeridos vacios", this.Text);

        }
        bool validate()
        {
            if (string.IsNullOrWhiteSpace(nombre.Text)) return false;
            else if (string.IsNullOrWhiteSpace(direccion.Text)) return false;
            else if (string.IsNullOrWhiteSpace(telefono.Text)) return false;
            else if (string.IsNullOrWhiteSpace(selectCiudad.SelectedItem.ToString())) return false;
            else if (string.IsNullOrWhiteSpace(txtUsuario.Text)) return false;
            else if (string.IsNullOrWhiteSpace(txtClave.Text)) return false;
            else return true;
        }
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
       
        public string Ciudad
        {
            set
            { this.selectCiudad.SelectedItem = value; }
            get { return selectCiudad.SelectedItem.ToString(); }
        }



        public string Telefono 
        {
            set { telefono.Text = value; }
            get { return telefono.Text; }
        }

        public string  Direccion
        {
            set { direccion.Text = value; }
            get { return direccion.Text; }
        }
        public string Nombre
        {
            set { nombre.Text = value; }
            get { return nombre.Text; }
        }

        private void CartersEditor_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
