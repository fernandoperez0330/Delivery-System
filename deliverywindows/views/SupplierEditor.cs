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

    public partial class SupplierEditor : Form
    {
        DATABASEDataContext data;

        public SupplierEditor()
        {
            InitializeComponent();
            data = DataConexion.getInstance();
           
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
                MessageBox.Show(this, "El suplidor ha sido agregado correctamente", "Agregar Suplidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
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
    }
}
