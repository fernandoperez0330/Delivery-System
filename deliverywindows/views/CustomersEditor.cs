using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using deliverywindows.controllers;//importando los controladores

namespace deliverywindows
{
    using models;

    public partial class CustomersEditor : Form
    {
        ClientesManage manage;
        DATABASEDataContext data;
        int id = -1; //para cuando se valla a actualizar el cliente


        public CustomersEditor(ref ClientesManage manage)
        {
            InitializeComponent();
            data = DataConexion.getInstance();
            this.manage = manage;
            setCiudad();        
        }
        public void setUpdateFieldData(int id,string nombre,string direccion1,string direccion2,string ciudad,string telefono)
        {
            Nombre = nombre;
            Direccion1 = direccion1;
            Direccion2 = direccion2;
            Ciudad = ciudad;
            Telefono = telefono;
            this.id = id;
        }

        void setCiudad() 
        {
            var query = from a in data.Ciudades
                        select a.NOMBRE;
            ciudad.Items.AddRange(query.ToArray());
            ciudad.SelectedIndex = 0;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show(this, "Desea cancelar esta solicitud?","Agregar Cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Dispose();            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                MessageBox.Show(this, "El cliente ha sido agregado correctamente", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                manage.Guardar();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Llene Los Campos Correctamente");
            }
        }

        bool validate()
        {
            if (String.IsNullOrWhiteSpace(nombre.Text)) return false;
            else if (String.IsNullOrWhiteSpace(direccion.Text)) return false;
            else if (String.IsNullOrWhiteSpace(direccion2.Text)) return false;
            else if (String.IsNullOrWhiteSpace(ciudad.SelectedItem.ToString())) return false;
            else if (String.IsNullOrWhiteSpace(telefono.Text) && telefono.Text.Count() == 10) return false;
            else return true;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            set { nombre.Text = value; }
            get { return nombre.Text; }
        }
        public string Direccion1
        {
            set { direccion.Text = value; }
            get { return direccion.Text; }
        }
        public string Direccion2
        {
            set { direccion2.Text = value; }
            get { return direccion2.Text; }
        }
        public string Ciudad
        {
            set { 
                    for (int n = 0; n < ciudad.Items.Count - 1;n++ ) 
                    {
                        if(ciudad.Items[n].ToString() == value)
                        {
                            ciudad.SelectedIndex = n;
                        }
                    } 
                }
            get { return ciudad.SelectedItem.ToString(); }
        }
        public string Telefono 
        {
            get { return telefono.Text; }
            set { telefono.Text = value; }
        }
    }
}
