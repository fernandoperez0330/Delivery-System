using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using deliverywindows.views;
using deliverywindows.entities;
using deliverywindows.utils;
using deliverywindows.models;

namespace deliverywindows
{
    public partial class OrdersEditor : Form
    {
        ModelOrder model;
        OrdersManager manager;

        /// <summary>
        /// constructor cuando sea para agregar
        /// </summary>
        public OrdersEditor()
        {
            InitializeComponent();
            this.model = new ModelOrder();
            this.manager = (OrdersManager)this.Owner;
        }


        /// <summary>
        /// constructor cuando sea para agregar nuevo a traves del adminsitracion de ordenes
        /// </summary>
        /// <param name="manager"></param>
        public OrdersEditor(OrdersManager manager) {
            InitializeComponent();
            this.model = new ModelOrder();
            this.manager = manager;
        
        }

        /// <summary>
        /// constructor cuando sea para editar a traves del adminsitracion de ordenes
        /// </summary>
        /// <param name="codigoorder"></param>
        /// <param name="manager"></param>
        public OrdersEditor(int codigoorder,OrdersManager manager)
        {
            InitializeComponent();
            this.model = new ModelOrder();
            this.model.find(codigoorder);
            if (this.model.order.Codigo  != 0) { 
                //llenar los campos del registro encontrado
                this.txtCodigoOrden.Text = model.order.Codigo.ToString();
                this.txtNombrePOOrden.Text = model.order.Po_box;
                this.txtCantidadcajasOrden.Text = model.order.Cantidad_cajas.ToString();
                this.txtPesoOrden.Text = model.order.Peso_orden.ToString();
                this.txtMensajeOrden.Text = model.order.Mensaje;
                //buscar la entidad de suplidor para rellenar campos
                this.fillSupplier(new ModelSupplier().find(model.order.Codigosuplidor));
                //buscar la entidad de clientes para relleanar campos
                this.fillCustomer(new ModelCustomer().find(model.order.Codigocliente));
                //buscar la entidad de clientes para relleanar campos
                this.fillTravel(new ModelTravel().find(model.order.Codigoviaje));
                this.Text = "Actualizar Orden";
            }
            this.manager = manager;
        }


        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult messageBoxResult = UtilsViews.showMsgConfirm("¿Desea cancelar la solicitud?",this.Text);
            if (messageBoxResult.Equals(DialogResult.Yes))
            {
                this.Close();
                this.Owner.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierFinder finder = new SupplierFinder();
            finder.ShowDialog(this);
        }


        public void fillSupplier(object sup) {
            EntitySupplier suplidor = ((EntitySupplier)sup);
            this.txtCodigoSupplier.Text = suplidor.Codigo.ToString();
            this.txtNombrecostroSupplier.Text = suplidor.Nombrecorto;
            this.txtNombreSupplier.Text = suplidor.Nombre;
            this.txtDireccionSupplier.Text = suplidor.Direccion;
            this.txtTelefonoSupplier.Text = suplidor.Telefono;
        }

        public void fillTravel(object travel)
        {
            EntityTravel viaje = ((EntityTravel)travel);
            this.txtCodigoViaje.Text = viaje.Codigo.ToString();
            this.txtCodigoEmpleado.Text = viaje.Codigoempleado.ToString();
            this.txtCodigoCamion.Text = viaje.Codigocamion.ToString();
            this.txtNombreEmpleado.Text = viaje.Empleado;
            this.txtNombreCamion.Text = viaje.Camion;
            this.txtFechaViaje.Text = viaje.Fechaviaje.ToString();
        }

        public void fillCustomer(object customer)
        {
            EntityCustomer cliente = ((EntityCustomer)customer);
            this.txtCodigoCliente.Text = cliente.Codigo.ToString();
            this.txtNombreCliente.Text = cliente.Nombre.ToString();
            this.txtTelefonoCliente.Text = cliente.Telefono.ToString();
            this.txtDireccionCliente.Text = cliente.Direccion1.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TravelFinder().ShowDialog(this);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CustomerFinder().ShowDialog(this);
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            //validar los campos
            Boolean error = false;
            if (this.txtCodigoSupplier.Text == "")
            {
                UtilsViews.showMsgError("El suplidor es requerido",this.Text);
                this.linkSuplidor.Focus();
                error = true;
            }
            else if (this.txtCodigoViaje.Text == "")
            {
                UtilsViews.showMsgError("El viaje es requerido", this.Text);
                this.linkViaje.Focus();
                error = true;
            }
            else if (this.txtCodigoCliente.Text == "")
            {
                UtilsViews.showMsgError("El cliente es requerido", this.Text);
                this.linkRecibidor.Focus();
                error = true;
            }
            else if (this.txtNombrePOOrden.Text == "") {
                UtilsViews.showMsgError("El nombre de la oficina postal es requerido", this.Text);
                this.txtNombrePOOrden.Focus();
                error = true;
            }
            else if (this.txtCantidadcajasOrden.Text == "")
            {
                UtilsViews.showMsgError("La cantidad de cajas es requerido", this.Text);
                this.txtCantidadcajasOrden.Focus();
                error = true;
            }
            else if (this.txtPesoOrden.Text == "")
            {
                UtilsViews.showMsgError("El peso de la orden es requerido", this.Text);
                this.txtCantidadcajasOrden.Focus();
                error = true;
            }
            else if (this.txtMensajeOrden.Text == "")
            {
                UtilsViews.showMsgError("El mensaje es requerido", this.Text);
                this.txtCantidadcajasOrden.Focus();
                error = true;
            }
            Boolean success = false;
            //cuando se validó todos los campos
            if (!error) {
                try {
                    try { model.order.Codigo = Convert.ToInt32(this.txtCodigoOrden.Text); }
                    catch (Exception exc) {
                        Utils.logExceptionError(exc);
                        model.order.Codigo = 0;
                    }
                    model.order.Codigocliente = Convert.ToInt32(this.txtCodigoCliente.Text);
                    model.order.Codigosuplidor = Convert.ToInt32(this.txtCodigoSupplier.Text);
                    model.order.Codigoviaje = Convert.ToInt32(this.txtCodigoViaje.Text);
                    model.order.Nombrerecibidor = this.txtNombreCliente.Text;
                    model.order.Po_box = this.txtNombrePOOrden.Text;
                    model.order.Cantidad_cajas = Convert.ToInt32(this.txtCantidadcajasOrden.Text);
                    model.order.Peso_orden = Convert.ToInt32(this.txtPesoOrden.Text);
                    //fecha actual para la orden
                    model.order.Fechaorden = DateTime.Now;
                    model.order.Fechaentrega = DateTime.Parse(this.txtFechaViaje.Text);
                    model.order.Mensaje = this.txtMensajeOrden.Text;

                    //cuando sea para agregar
                    if (Convert.ToInt32(model.order.Codigo) == 0)
                    {
                        if (model.add() == 1)
                        {
                            success = true;
                        }
                    }

                    //cuando sea para actualizar
                    else
                    {
                        if (model.update())
                        {
                            success = true;
                        }
                    }

                }catch(Exception exc){
                    Utils.logExceptionError(exc);
                }
                String mensaje;

                //cuando se ejecuto la solicitud correctamente (para agregar y actualizar)
                if (success) {
                    mensaje = (model.order.Codigo != 0) ? "La orden fue actualizada correctamente" : "La orden fue agregada correctamente";
                    UtilsViews.showMsgAlert(mensaje,this.Text);
                    this.Dispose();
                    //verificar si el propietario es el ordermanager para asi actualizar el datagrid
                    try
                    {
                        this.manager.toDGV();
                    }
                    catch (Exception exc) {
                        Utils.logExceptionError(exc);
                    }
                }
                //cuando no se pudo ejecutar la solicitud
                else{
                    mensaje = (model.order.Codigo != 0) ? "La orden no se pudo actualizar correctamente, puede que contenga datos invalido, favor verifica" : "La orden no se pudo agregar correctamente, puede que contenga datos invalido, favor verifica";
                    UtilsViews.showMsgError(mensaje);
                }
            }

        }
    }
}
