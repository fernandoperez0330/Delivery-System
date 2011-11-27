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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersEditor));
            this.agregar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(155, 220);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(236, 220);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 1;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(95, 27);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(212, 20);
            this.nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(95, 56);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(212, 36);
            this.direccion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Direccion";
            // 
            // direccion2
            // 
            this.direccion2.Location = new System.Drawing.Point(95, 98);
            this.direccion2.Multiline = true;
            this.direccion2.Name = "direccion2";
            this.direccion2.Size = new System.Drawing.Size(212, 39);
            this.direccion2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direccion 2";
            // 
            // ciudad
            // 
            this.ciudad.FormattingEnabled = true;
            this.ciudad.Location = new System.Drawing.Point(95, 143);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(212, 21);
            this.ciudad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ciudad";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(95, 176);
            this.telefono.Mask = "(999) 000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(118, 20);
            this.telefono.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // CustomersEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 263);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar;
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
    }
}