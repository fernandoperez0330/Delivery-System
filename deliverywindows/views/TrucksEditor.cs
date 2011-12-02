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

    public partial class TrucksEditor : Form
    {
        int id = -1;
        CamionManage manage;
        public TrucksEditor(ref CamionManage mgr)
        {
            InitializeComponent();
            manage = mgr;
            manage.setEditor(this);
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                manage.Guardar();
                this.Dispose();
            }
            else MessageBox.Show("Llene Correctamente los campos..");
        }
        bool validate() 
        {
            if (string.IsNullOrWhiteSpace(nombre.Text)) return false;
            else if (string.IsNullOrWhiteSpace(descripcion.Text)) return false;
            else return true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Esta Seguro Desea Cancelar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        public string Descripcion 
        {
            set { descripcion.Text = value; }
            get { return descripcion.Text; }
        }
        public string Nombre 
        {
            set { nombre.Text = value; }
            get { return nombre.Text; }
        }
        public int ID 
        {
            set { id = value; }
            get { return id; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea cancelar?", "Agregar Camion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
