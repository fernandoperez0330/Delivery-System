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
    using models;

    public partial class TravelsManager : Form
    {
        DATABASEDataContext data;
        ViajesManage manage;
        TravelsEditor editor;

        public TravelsManager()
        {
            InitializeComponent();
            data = DataConexion.getInstance();
            manage = new ViajesManage(this);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            editor = new TravelsEditor(ref manage);
            manage.setEditor( editor);
            editor.ShowDialog();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
           if(DGV.SelectedRows.Count > 0)
           {
                editor = new TravelsEditor(ref manage);
                manage.setEditor(editor);
                manage.setFieldValues();
                editor.ShowDialog();
           }
           else
           {
               MessageBox.Show("No Hay Nada Seleccionado...");
           }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Seguro Desea Borrar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 if (DGV.SelectedRows.Count > 0)
                 {
                     manage.Borrar();
                     
                 }
            }
            else
            {
            }
        }
        public DataGridView DGV
        {
            set { dataGridView1 = value; }
            get { return dataGridView1; }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"Seguro Desea Salir?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==  DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
