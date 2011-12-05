using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using deliveryweb.models;
using deliveryweb.utils;

namespace deliveryweb
{
    public partial class RastreoOrden : System.Web.UI.Page
    {
        ModelOrder model;

        public RastreoOrden() {
            model = new ModelOrder();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// metodo del evento click del buscar la orden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.Label2.Text.Equals(""))
            {
                this.Label2.Text = "La orden esta en blanco";
            }
            else
            {
                try
                {
                    this.model.find(Convert.ToInt32(this.TextBox1.Text));
                    if (this.model.order.Codigo == 0)
                    {
                        this.Label2.Text = "La orden No." + this.TextBox1.Text + " no se encontró";
                    }
                    else
                        this.Label2.Text = "La orden No." + this.TextBox1.Text + " está en estatus " + model.order.Estatus;
                }
                catch (Exception exc)
                {
                    Utils.logExceptionError(exc);
                    this.Label2.Text = "La orden es invalida";
                }
            }
        }
    }
}