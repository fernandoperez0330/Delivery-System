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

    public partial class CartersManager : Form
    {
        CarreroManage manage;
        CartersEditor editor;
       
        public CartersManager()
        {
            InitializeComponent();
            manage = new CarreroManage(this);           
            manage.toDGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           editor =  new CartersEditor(manage);
           editor.ShowDialog();

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedCells.Count > 0)
            {               
               editor =  new CartersEditor(manage);
               manage.setModifyFieldData();
               editor.ShowDialog();
            }
            else MessageBox.Show("No hay Nada Selecionado...");
        }
        private void borrar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedCells.Count > 0)
            {
                if(MessageBox.Show(this,"Esta seguro?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    manage.Borrar();
                    manage.toDGV();
                }
            }
            else MessageBox.Show("No hay Nada Selecionado...");
       
        }
        public DataGridView DGV
        {
            set { dataGridView1 = value; }
            get { return dataGridView1; }
        }

    }
}
