namespace deliverywindows
{
    partial class OrdersEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersEditor));
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoSupplier = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefonoSupplier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccionSupplier = new System.Windows.Forms.TextBox();
            this.txtNombrecostroSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkSuplidor = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigoCamion = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtFechaViaje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreCamion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtCodigoViaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkViaje = new System.Windows.Forms.LinkLabel();
            this.txtNombrePOOrden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMensajeOrden = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidadcajasOrden = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPesoOrden = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.linkRecibidor = new System.Windows.Forms.LinkLabel();
            this.txtCodigoOrden = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Image = global::deliverywindows.Properties.Resources.cancel;
            this.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelar.Location = new System.Drawing.Point(531, 371);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 30);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Image = global::deliverywindows.Properties.Resources.accept2;
            this.aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptar.Location = new System.Drawing.Point(425, 371);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 30);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código: ";
            // 
            // txtCodigoSupplier
            // 
            this.txtCodigoSupplier.Enabled = false;
            this.txtCodigoSupplier.Location = new System.Drawing.Point(52, 35);
            this.txtCodigoSupplier.Name = "txtCodigoSupplier";
            this.txtCodigoSupplier.Size = new System.Drawing.Size(75, 20);
            this.txtCodigoSupplier.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefonoSupplier);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDireccionSupplier);
            this.groupBox1.Controls.Add(this.txtNombrecostroSupplier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreSupplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.linkSuplidor);
            this.groupBox1.Controls.Add(this.txtCodigoSupplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 159);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Suplidor";
            // 
            // txtTelefonoSupplier
            // 
            this.txtTelefonoSupplier.Enabled = false;
            this.txtTelefonoSupplier.Location = new System.Drawing.Point(61, 124);
            this.txtTelefonoSupplier.Name = "txtTelefonoSupplier";
            this.txtTelefonoSupplier.Size = new System.Drawing.Size(116, 20);
            this.txtTelefonoSupplier.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Direccion: ";
            // 
            // txtDireccionSupplier
            // 
            this.txtDireccionSupplier.Enabled = false;
            this.txtDireccionSupplier.Location = new System.Drawing.Point(61, 94);
            this.txtDireccionSupplier.Name = "txtDireccionSupplier";
            this.txtDireccionSupplier.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionSupplier.TabIndex = 20;
            // 
            // txtNombrecostroSupplier
            // 
            this.txtNombrecostroSupplier.Enabled = false;
            this.txtNombrecostroSupplier.Location = new System.Drawing.Point(174, 35);
            this.txtNombrecostroSupplier.Name = "txtNombrecostroSupplier";
            this.txtNombrecostroSupplier.Size = new System.Drawing.Size(87, 20);
            this.txtNombrecostroSupplier.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alias: ";
            // 
            // txtNombreSupplier
            // 
            this.txtNombreSupplier.Enabled = false;
            this.txtNombreSupplier.Location = new System.Drawing.Point(52, 64);
            this.txtNombreSupplier.Name = "txtNombreSupplier";
            this.txtNombreSupplier.Size = new System.Drawing.Size(209, 20);
            this.txtNombreSupplier.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre: ";
            // 
            // linkSuplidor
            // 
            this.linkSuplidor.AutoSize = true;
            this.linkSuplidor.Location = new System.Drawing.Point(182, 127);
            this.linkSuplidor.Name = "linkSuplidor";
            this.linkSuplidor.Size = new System.Drawing.Size(79, 13);
            this.linkSuplidor.TabIndex = 15;
            this.linkSuplidor.TabStop = true;
            this.linkSuplidor.Tag = "Buscar suplidor";
            this.linkSuplidor.Text = "Buscar suplidor";
            this.linkSuplidor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigoCamion);
            this.groupBox2.Controls.Add(this.txtCodigoEmpleado);
            this.groupBox2.Controls.Add(this.txtFechaViaje);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNombreCamion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNombreEmpleado);
            this.groupBox2.Controls.Add(this.txtCodigoViaje);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.linkViaje);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 159);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información viaje";
            // 
            // txtCodigoCamion
            // 
            this.txtCodigoCamion.Location = new System.Drawing.Point(211, 94);
            this.txtCodigoCamion.Name = "txtCodigoCamion";
            this.txtCodigoCamion.Size = new System.Drawing.Size(15, 20);
            this.txtCodigoCamion.TabIndex = 34;
            this.txtCodigoCamion.Visible = false;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(211, 64);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(15, 20);
            this.txtCodigoEmpleado.TabIndex = 33;
            this.txtCodigoEmpleado.Visible = false;
            // 
            // txtFechaViaje
            // 
            this.txtFechaViaje.Enabled = false;
            this.txtFechaViaje.Location = new System.Drawing.Point(191, 31);
            this.txtFechaViaje.Name = "txtFechaViaje";
            this.txtFechaViaje.Size = new System.Drawing.Size(131, 20);
            this.txtFechaViaje.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Camion: ";
            // 
            // txtNombreCamion
            // 
            this.txtNombreCamion.Enabled = false;
            this.txtNombreCamion.Location = new System.Drawing.Point(60, 94);
            this.txtNombreCamion.Name = "txtNombreCamion";
            this.txtNombreCamion.Size = new System.Drawing.Size(145, 20);
            this.txtNombreCamion.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Empleado:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(60, 64);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(145, 20);
            this.txtNombreEmpleado.TabIndex = 27;
            // 
            // txtCodigoViaje
            // 
            this.txtCodigoViaje.Enabled = false;
            this.txtCodigoViaje.Location = new System.Drawing.Point(58, 31);
            this.txtCodigoViaje.Name = "txtCodigoViaje";
            this.txtCodigoViaje.Size = new System.Drawing.Size(82, 20);
            this.txtCodigoViaje.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Código: ";
            // 
            // linkViaje
            // 
            this.linkViaje.AutoSize = true;
            this.linkViaje.Location = new System.Drawing.Point(257, 127);
            this.linkViaje.Name = "linkViaje";
            this.linkViaje.Size = new System.Drawing.Size(65, 13);
            this.linkViaje.TabIndex = 24;
            this.linkViaje.TabStop = true;
            this.linkViaje.Tag = "Buscar viaje";
            this.linkViaje.Text = "Buscar viaje";
            this.linkViaje.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // txtNombrePOOrden
            // 
            this.txtNombrePOOrden.Location = new System.Drawing.Point(333, 199);
            this.txtNombrePOOrden.Name = "txtNombrePOOrden";
            this.txtNombrePOOrden.Size = new System.Drawing.Size(234, 20);
            this.txtNombrePOOrden.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 24;
            this.label10.Tag = "Nombre de la oficina postal";
            this.label10.Text = "P.O. Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 25;
            this.label11.Tag = "Mensaje de la orden";
            this.label11.Text = "Mensaje:";
            // 
            // txtMensajeOrden
            // 
            this.txtMensajeOrden.Location = new System.Drawing.Point(333, 307);
            this.txtMensajeOrden.Multiline = true;
            this.txtMensajeOrden.Name = "txtMensajeOrden";
            this.txtMensajeOrden.Size = new System.Drawing.Size(298, 55);
            this.txtMensajeOrden.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 27;
            this.label12.Tag = "Nombre de la oficina postal";
            this.label12.Text = "Cantidad Cajas:";
            // 
            // txtCantidadcajasOrden
            // 
            this.txtCantidadcajasOrden.Location = new System.Drawing.Point(333, 256);
            this.txtCantidadcajasOrden.Name = "txtCantidadcajasOrden";
            this.txtCantidadcajasOrden.Size = new System.Drawing.Size(98, 20);
            this.txtCantidadcajasOrden.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(462, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 29;
            this.label13.Tag = "Nombre de la oficina postal";
            this.label13.Text = "Peso orden:";
            // 
            // txtPesoOrden
            // 
            this.txtPesoOrden.Location = new System.Drawing.Point(491, 253);
            this.txtPesoOrden.Name = "txtPesoOrden";
            this.txtPesoOrden.Size = new System.Drawing.Size(76, 20);
            this.txtPesoOrden.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(462, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 31;
            this.label14.Tag = "Peso en Kilograme";
            this.label14.Text = "Kg.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtCodigoCliente);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtTelefonoCliente);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtDireccionCliente);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.linkRecibidor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 179);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del Recibidor";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Enabled = false;
            this.txtCodigoCliente.Location = new System.Drawing.Point(61, 16);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(75, 20);
            this.txtCodigoCliente.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Telefono:";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Enabled = false;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(61, 128);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(114, 20);
            this.txtTelefonoCliente.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Direccion:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Enabled = false;
            this.txtDireccionCliente.Location = new System.Drawing.Point(61, 92);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(209, 20);
            this.txtDireccionCliente.TabIndex = 28;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(61, 54);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(199, 20);
            this.txtNombreCliente.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Nombre: ";
            // 
            // linkRecibidor
            // 
            this.linkRecibidor.AutoSize = true;
            this.linkRecibidor.Location = new System.Drawing.Point(193, 153);
            this.linkRecibidor.Name = "linkRecibidor";
            this.linkRecibidor.Size = new System.Drawing.Size(83, 13);
            this.linkRecibidor.TabIndex = 25;
            this.linkRecibidor.TabStop = true;
            this.linkRecibidor.Tag = "Buscar viaje";
            this.linkRecibidor.Text = "Buscar recibidor";
            this.linkRecibidor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // txtCodigoOrden
            // 
            this.txtCodigoOrden.Location = new System.Drawing.Point(309, 198);
            this.txtCodigoOrden.Name = "txtCodigoOrden";
            this.txtCodigoOrden.Size = new System.Drawing.Size(18, 20);
            this.txtCodigoOrden.TabIndex = 34;
            this.txtCodigoOrden.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Código: ";
            // 
            // OrdersEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar;
            this.ClientSize = new System.Drawing.Size(643, 412);
            this.Controls.Add(this.txtCodigoOrden);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPesoOrden);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCantidadcajasOrden);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMensajeOrden);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNombrePOOrden);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdersEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Ordenes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkSuplidor;
        private System.Windows.Forms.TextBox txtTelefonoSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccionSupplier;
        private System.Windows.Forms.TextBox txtNombrecostroSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFechaViaje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreCamion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtCodigoViaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkViaje;
        private System.Windows.Forms.TextBox txtNombrePOOrden;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMensajeOrden;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidadcajasOrden;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPesoOrden;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkRecibidor;
        private System.Windows.Forms.TextBox txtCodigoCamion;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtCodigoOrden;
        private System.Windows.Forms.Label label18;

    }
}