namespace deliverywindows
{
    partial class SupplierManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.modificarbtn = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarbtn
            // 
            this.agregarbtn.Image = ((System.Drawing.Image)(resources.GetObject("agregarbtn.Image")));
            this.agregarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarbtn.Location = new System.Drawing.Point(12, 27);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(100, 30);
            this.agregarbtn.TabIndex = 0;
            this.agregarbtn.Text = "Agregar";
            this.agregarbtn.UseVisualStyleBackColor = true;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // modificarbtn
            // 
            this.modificarbtn.Image = ((System.Drawing.Image)(resources.GetObject("modificarbtn.Image")));
            this.modificarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarbtn.Location = new System.Drawing.Point(118, 27);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(100, 30);
            this.modificarbtn.TabIndex = 1;
            this.modificarbtn.Text = "Modificar";
            this.modificarbtn.UseVisualStyleBackColor = true;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(504, 275);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 30);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(592, 206);
            this.dataGridView1.TabIndex = 3;
            // 
            // borrar
            // 
            this.borrar.Image = ((System.Drawing.Image)(resources.GetObject("borrar.Image")));
            this.borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrar.Location = new System.Drawing.Point(224, 27);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(100, 30);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de suplidores disponible en el sistema";
            // 
            // SupplierManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnsalir;
            this.ClientSize = new System.Drawing.Size(616, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.modificarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SupplierManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminsitración de Suplidores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.Button modificarbtn;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Label label2;
    }
}