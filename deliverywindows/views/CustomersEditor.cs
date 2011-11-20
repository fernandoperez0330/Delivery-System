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
    public partial class CustomersEditor : Form
    {
        public CustomersEditor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show(this, "Desea cancelar esta solicitud?","Agregar Cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Dispose();            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "El cliente ha sido agregado correctamente", "Agregar Cliente",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
