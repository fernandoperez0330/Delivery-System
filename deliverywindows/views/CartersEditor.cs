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

        public CartersEditor(CarreroManage mgr)
        {
            InitializeComponent();
            manage = mgr;
            this.Text = "Actualizar Carrero";
            manage.setEditor(this);
        }
        public void setCityData(ref string[] ciudades)
        {
            try
            {
                ciudad.Items.AddRange(ciudades);
                ciudad.SelectedIndex = 0;
            }catch(Exception exc){
                Utils.logExceptionError(exc);
            }

        }

        private void button2_Click(object sender, EventArgs e){
            DialogResult messageBoxResult = MessageBox.Show(this, "¿Desea cancelar esta solicitud?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messageBoxResult == DialogResult)
            {
                this.Dispose();
            }
            else return;
        }



        private void aceptar_Click(object sender, EventArgs e)
        {
                if (validate())
                {
                    manage.Guardar();
                    this.Dispose();
                }
            
            else MessageBox.Show("Llene los campos Correctamente!");

        }
        bool validate()
        {
            if (string.IsNullOrWhiteSpace(nombre.Text)) return false;
            else if (string.IsNullOrWhiteSpace(direccion.Text)) return false;
            else if (string.IsNullOrWhiteSpace(telefono.Text)) return false;
            else if (string.IsNullOrWhiteSpace(ciudad.SelectedItem.ToString())) return false;
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
            {
                for (int n = 0; n < ciudad.Items.Count - 1; n++)
                {
                    if (ciudad.Items[n].ToString() == value)
                    {
                        ciudad.SelectedIndex = n;
                    }
                }
            }
            get { return ciudad.SelectedItem.ToString(); }
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
    }
}
