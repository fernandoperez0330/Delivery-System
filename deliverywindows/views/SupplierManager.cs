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
    public partial class SupplierManager : Form
    {
        SupplierEditor editor;

        public SupplierManager()
        {
            InitializeComponent();
        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            editor = new SupplierEditor();
            editor.ShowDialog();
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
