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

    public partial class SupplierEditor : Form
    {
        DATABASEDataContext data;
        SupplierManage manage;
        int id = -1;

        public SupplierEditor(ref SupplierManage m)
        {
            InitializeComponent();
            data = DataConexion.getInstance();
            manage = m;  
            //ciudades
            var ciudades = from c in data.Ciudades
                           select c.NOMBRE;
            ciudad.Items.AddRange(ciudades.ToArray());
            ciudad.SelectedIndex = 0;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea cancelar esta solicitud?", "Agregar Suplidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                manage.Guardar();
                MessageBox.Show(this, "El suplidor ha sido agregado correctamente", "Agregar Suplidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                manage.ToDGV();
            }

            else 
            {
                MessageBox.Show("LLene los Campos Correctamente");
            }
        }

        bool validate() 
        {
            if (String.IsNullOrWhiteSpace(nombre.Text)) return false;
            else if (String.IsNullOrWhiteSpace(ciudad.Text)) return false;
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
    }
}
