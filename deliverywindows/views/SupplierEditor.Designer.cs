namespace deliverywindows
{
    partial class SupplierEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierEditor));
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nombrecorto = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.MaskedTextBox();
            this.selectCiudad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombreCorto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreCorto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(179, 218);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 30);
            this.btnagregar.TabIndex = 12;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(285, 218);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 30);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(43, 25);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(156, 20);
            this.nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciudad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado:";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(229, 77);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(156, 20);
            this.estado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion:";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(43, 187);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(156, 20);
            this.direccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre Corto: ";
            // 
            // nombrecorto
            // 
            this.nombrecorto.Location = new System.Drawing.Point(229, 25);
            this.nombrecorto.Name = "nombrecorto";
            this.nombrecorto.Size = new System.Drawing.Size(156, 20);
            this.nombrecorto.TabIndex = 3;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(43, 126);
            this.telefono.Mask = "(999) 000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(156, 20);
            this.telefono.TabIndex = 9;
            this.telefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // selectCiudad
            // 
            this.selectCiudad.FormattingEnabled = true;
            this.selectCiudad.Location = new System.Drawing.Point(43, 76);
            this.selectCiudad.Name = "selectCiudad";
            this.selectCiudad.Size = new System.Drawing.Size(156, 21);
            this.selectCiudad.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(40, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(000) 000-0000";
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorNombreCorto
            // 
            this.errorNombreCorto.ContainerControl = this;
            // 
            // errorCiudad
            // 
            this.errorCiudad.ContainerControl = this;
            // 
            // errorEstado
            // 
            this.errorEstado.ContainerControl = this;
            // 
            // errorTelefono
            // 
            this.errorTelefono.ContainerControl = this;
            // 
            // errorDireccion
            // 
            this.errorDireccion.ContainerControl = this;
            // 
            // SupplierEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(400, 255);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectCiudad);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.nombrecorto);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Suplidor";
            this.Load += new System.EventHandler(this.SupplierEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreCorto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombrecorto;
        private System.Windows.Forms.MaskedTextBox telefono;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ErrorProvider errorNombre;
        public System.Windows.Forms.ErrorProvider errorNombreCorto;
        public System.Windows.Forms.ErrorProvider errorCiudad;
        public System.Windows.Forms.ErrorProvider errorEstado;
        public System.Windows.Forms.ErrorProvider errorTelefono;
        public System.Windows.Forms.ErrorProvider errorDireccion;
        public System.Windows.Forms.ComboBox selectCiudad;
    }
}