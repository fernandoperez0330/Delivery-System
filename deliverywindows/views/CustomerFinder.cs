using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using deliverywindows.models;
using System.Collections;
using deliverywindows.entities;


namespace deliverywindows.views
{
    public partial class CustomerFinder : Form
    {
        ModelCustomer model;

        public CustomerFinder()
        {
            InitializeComponent();
            model = new ModelCustomer();
            IQueryable querySupplier = model.findAll();
            this.dataGridView1.DataSource = querySupplier;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IQueryable queryCustomer = model.findByName(this.textBox1.Text);
            this.dataGridView1.DataSource = queryCustomer;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e) {
            button1_Click(sender,e);
        }

        private void SupplierFinder_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int prkey = Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value);
                EntityCustomer customer = (EntityCustomer)model.find(prkey);
                if (this.Owner.Name == "OrdersEditor")
                {
                    ((OrdersEditor)this.Owner).fillCustomer(customer);
                    this.Dispose();
                }

            }
        }
    }
}
