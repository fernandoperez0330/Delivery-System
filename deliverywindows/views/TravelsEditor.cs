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

    public partial class TravelsEditor : Form
    {
        ViajesManage manage;
        int id = -1;

        public TravelsEditor(ref ViajesManage mgr)
        {
            InitializeComponent();
            manage = mgr;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Desea Procesar ?", "Agregar Viaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                manage.Guardar();
                this.Dispose();
            }
            else
            {
                
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Desea Cancelar?", "Agregar Viaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else { }
        }
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public DateTime Fecha 
        {
            set { date.Value = value; }
            get { return date.Value; }
        }
        public bool Activo
        {
            set { activo.Checked = value; }
            get { return activo.Checked; }
        }
        public bool Inactivo 
        {
            set { inactivo.Checked = value; }
            get { return inactivo.Checked; }
        }
    }
}
