namespace Presentacion
{
    partial class FormConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultas));
            this.dataGridListaFactura = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroFacura = new System.Windows.Forms.TextBox();
            this.labelNumeroFactura = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListaFactura
            // 
            this.dataGridListaFactura.AllowUserToAddRows = false;
            this.dataGridListaFactura.AllowUserToDeleteRows = false;
            this.dataGridListaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaFactura.Location = new System.Drawing.Point(62, 124);
            this.dataGridListaFactura.Name = "dataGridListaFactura";
            this.dataGridListaFactura.ReadOnly = true;
            this.dataGridListaFactura.Size = new System.Drawing.Size(673, 372);
            this.dataGridListaFactura.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(485, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 36);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroFacura
            // 
            this.txtNumeroFacura.Location = new System.Drawing.Point(288, 32);
            this.txtNumeroFacura.Name = "txtNumeroFacura";
            this.txtNumeroFacura.Size = new System.Drawing.Size(180, 20);
            this.txtNumeroFacura.TabIndex = 44;
            // 
            // labelNumeroFactura
            // 
            this.labelNumeroFactura.AutoSize = true;
            this.labelNumeroFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroFactura.ForeColor = System.Drawing.Color.Black;
            this.labelNumeroFactura.Location = new System.Drawing.Point(218, 74);
            this.labelNumeroFactura.Name = "labelNumeroFactura";
            this.labelNumeroFactura.Size = new System.Drawing.Size(61, 16);
            this.labelNumeroFactura.TabIndex = 43;
            this.labelNumeroFactura.Text = "Filtar Por";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(734, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 23);
            this.btnCerrar.TabIndex = 46;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Numero Factura",
            "Cedula del Cliente",
            "Codigo de Producto"});
            this.comboBox1.Location = new System.Drawing.Point(288, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 561);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroFacura);
            this.Controls.Add(this.labelNumeroFactura);
            this.Controls.Add(this.dataGridListaFactura);
            this.Name = "FormConsultas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridListaFactura;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelNumeroFactura;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox txtNumeroFacura;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}