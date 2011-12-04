namespace deliverywindows
{
    partial class TravelsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelsEditor));
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.inactivo = new System.Windows.Forms.RadioButton();
            this.activo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Image = global::deliverywindows.Properties.Resources.cancel;
            this.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelar.Location = new System.Drawing.Point(136, 120);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 30);
            this.cancelar.TabIndex = 7;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Image = global::deliverywindows.Properties.Resources.accept2;
            this.aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptar.Location = new System.Drawing.Point(27, 120);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(103, 29);
            this.aceptar.TabIndex = 6;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado:";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(34, 25);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(202, 20);
            this.date.TabIndex = 1;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(95, 82);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(63, 17);
            this.inactivo.TabIndex = 5;
            this.inactivo.TabStop = true;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseVisualStyleBackColor = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(34, 82);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(55, 17);
            this.activo.TabIndex = 4;
            this.activo.TabStop = true;
            this.activo.Text = "Activo";
            this.activo.UseVisualStyleBackColor = true;
            // 
            // TravelsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar;
            this.ClientSize = new System.Drawing.Size(250, 158);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TravelsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RadioButton inactivo;
        private System.Windows.Forms.RadioButton activo;
    }
}