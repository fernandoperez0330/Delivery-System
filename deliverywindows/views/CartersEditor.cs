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

    public partial class CartersEditor : Form
    {
        int id = -1;
        CarreroManage manage;

        public CartersEditor(CarreroManage mgr)
        {
            InitializeComponent();
            manage = mgr;
            manage.setEditor(this);
        }
        public void setCityData(ref string[] ciudades)
        {
            ciudad.Items.AddRange(ciudades);
            ciudad.SelectedIndex = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea cancelar esta solicitud?", "Agregar Carrero", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Dispose();
            }
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
    }
}
