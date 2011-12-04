namespace deliverywindows
{
    partial class CustomersEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersEditor));
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.direccion2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDireccion2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(65, 9);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(212, 20);
            this.nombre.TabIndex = 1;
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
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(65, 39);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(212, 36);
            this.direccion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion: ";
            // 
            // direccion2
            // 
            this.direccion2.Location = new System.Drawing.Point(65, 81);
            this.direccion2.Multiline = true;
            this.direccion2.Name = "direccion2";
            this.direccion2.Size = new System.Drawing.Size(212, 39);
            this.direccion2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion 2:";
            // 
            // ciudad
            // 
            this.ciudad.FormattingEnabled = true;
            this.ciudad.Location = new System.Drawing.Point(65, 129);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(212, 21);
            this.ciudad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciudad:";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(65, 164);
            this.telefono.Mask = "(999) 000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(212, 20);
            this.telefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(62, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(000) 000-0000";
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Image = global::deliverywindows.Properties.Resources.cancel1;
            this.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelar.Location = new System.Drawing.Point(177, 208);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 30);
            this.cancelar.TabIndex = 12;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // agregar
            // 
            this.agregar.Image = global::deliverywindows.Properties.Resources.accept2;
            this.agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregar.Location = new System.Drawing.Point(71, 208);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(100, 30);
            this.agregar.TabIndex = 11;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorDireccion
            // 
            this.errorDireccion.ContainerControl = this;
            // 
            // errorDireccion2
            // 
            this.errorDireccion2.ContainerControl = this;
            // 
            // errorCiudad
            // 
            this.errorCiudad.ContainerControl = this;
            // 
            // errorTelefono
            // 
            this.errorTelefono.ContainerControl = this;
            // 
            // CustomersEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar;
            this.ClientSize = new System.Drawing.Size(316, 249);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.direccion2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccion2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ciudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox telefono;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ErrorProvider errorNombre;
        public System.Windows.Forms.ErrorProvider errorDireccion;
        public System.Windows.Forms.ErrorProvider errorDireccion2;
        public System.Windows.Forms.ErrorProvider errorCiudad;
        public System.Windows.Forms.ErrorProvider errorTelefono;
    }
}