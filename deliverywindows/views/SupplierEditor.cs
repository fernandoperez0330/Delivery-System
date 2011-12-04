using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using deliverywindows.models;

namespace deliverywindows
{
    using controllers;
    using deliverywindows.entities;
    using System.Collections;
    using deliverywindows.utils;

    public partial class SupplierEditor : Form
    {
        DATABASEDataContext data;
        SupplierManage manage;
        int id = -1;
        ModelSupplier model;
        public SortedList arrCiudades;

        public SupplierEditor(ref SupplierManage m)
        {
            InitializeComponent();
            data = DataConexion.getInstance();
            model = new ModelSupplier();
            manage = m;  
            this.selectCiudad.DataSource = new ModelCountry().getAlltoSortedList().GetValueList();
            try
            {
                selectCiudad.SelectedIndex = 0;
            }
            catch (Exception exc) {
                Utils.logExceptionError(exc);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea cancelar esta solicitud?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (validate())
            {
                model.supplier.Codigo = this.ID;
                model.supplier.Nombre = this.Nombre;
                model.supplier.Ciudad = this.Ciudad;
                model.supplier.Nombrecorto = this.NombreCorto;
                model.supplier.Telefono = this.Telefono;
                model.supplier.Estado = this.Estado;
                model.supplier.Direccion = this.Direccion;

                if (this.ID > 0) {
                    if (model.update()) {
                        MessageBox.Show(this, "El suplidor ha sido actualizado correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        manage.ToDGV();
                        this.Dispose();
                    }
                }
                else {
                    if (model.add() == 1)
                    {
                        MessageBox.Show(this, "El suplidor ha sido agregado correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        manage.ToDGV();
                        this.Dispose();
                    }
                }

            }

            else 
            {
                MessageBox.Show("LLene los Campos Correctamente");
            }
        }

        bool validate() 
        {
            if (String.IsNullOrWhiteSpace(nombre.Text)) return false;
            else if (String.IsNullOrWhiteSpace(selectCiudad.Text)) return false;
            else if (String.IsNullOrWhiteSpace(estado.Text)) return false;
            else if (String.IsNullOrWhiteSpace(telefono.Text)) return false;
            else if (String.IsNullOrWhiteSpace(direccion.Text)) return false;
            else if (String.IsNullOrWhiteSpace(nombrecorto.Text)) return false;
            return true;
        }
        public int ID 
        {
            set { id = value; }
            get { return id; }
        }
        public string Nombre 
        {
            set { nombre.Text = value; }
            get { return nombre.Text; }
        }
        public string NombreCorto
        {
            set { nombrecorto.Text = value; }
            get { return nombrecorto.Text; }
        }
        public string Direccion
        {
            set { direccion.Text = value; }
            get { return direccion.Text; }
        }
        public string Telefono
        {
            set { telefono.Text = value; }
            get { return telefono.Text; }
        }

        public string Estado
        {
            set { estado.Text = value; }
            get { return estado.Text; }
        }

        public int Ciudad
        {
            set
            {
                for (int n = 0; n < selectCiudad.Items.Count - 1; n++)
                {
                    if (Convert.ToInt32(arrCiudades.IndexOfValue(selectCiudad.SelectedItem.ToString())) == value)
                    {
                        selectCiudad.SelectedIndex = n;
                    }
                }
            }
            get {
                int keyCiudad = arrCiudades.IndexOfValue(this.selectCiudad.SelectedItem);
                return (int)arrCiudades.GetKey(keyCiudad);
            }
        }

        //;

        private void SupplierEditor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
