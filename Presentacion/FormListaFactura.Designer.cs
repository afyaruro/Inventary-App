namespace Presentacion
{
    partial class FormListaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaFactura));
            this.dataGridListaFactura = new System.Windows.Forms.DataGridView();
            this.ColumnNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroFacura = new System.Windows.Forms.TextBox();
            this.labelNumeroFactura = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListaFactura
            // 
            this.dataGridListaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumeroFactura,
            this.ColumnCedulaCliente,
            this.ColumnNombreCliente,
            this.ColumnApellidoCliente,
            this.ColumnTotal});
            this.dataGridListaFactura.Location = new System.Drawing.Point(125, 124);
            this.dataGridListaFactura.Name = "dataGridListaFactura";
            this.dataGridListaFactura.Size = new System.Drawing.Size(533, 372);
            this.dataGridListaFactura.TabIndex = 0;
            // 
            // ColumnNumeroFactura
            // 
            this.ColumnNumeroFactura.HeaderText = "# Factura";
            this.ColumnNumeroFactura.Name = "ColumnNumeroFactura";
            // 
            // ColumnCedulaCliente
            // 
            this.ColumnCedulaCliente.HeaderText = "Cedula Cliente";
            this.ColumnCedulaCliente.Name = "ColumnCedulaCliente";
            // 
            // ColumnNombreCliente
            // 
            this.ColumnNombreCliente.HeaderText = "Nombre Cliente";
            this.ColumnNombreCliente.Name = "ColumnNombreCliente";
            // 
            // ColumnApellidoCliente
            // 
            this.ColumnApellidoCliente.HeaderText = "Apellido Cliente";
            this.ColumnApellidoCliente.Name = "ColumnApellidoCliente";
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(472, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 36);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroFacura
            // 
            this.txtNumeroFacura.Location = new System.Drawing.Point(334, 69);
            this.txtNumeroFacura.Name = "txtNumeroFacura";
            this.txtNumeroFacura.Size = new System.Drawing.Size(123, 20);
            this.txtNumeroFacura.TabIndex = 44;
            // 
            // labelNumeroFactura
            // 
            this.labelNumeroFactura.AutoSize = true;
            this.labelNumeroFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelNumeroFactura.Location = new System.Drawing.Point(269, 73);
            this.labelNumeroFactura.Name = "labelNumeroFactura";
            this.labelNumeroFactura.Size = new System.Drawing.Size(59, 16);
            this.labelNumeroFactura.TabIndex = 43;
            this.labelNumeroFactura.Text = "#Factura";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(734, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 23);
            this.btnCerrar.TabIndex = 46;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(664, 513);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 36);
            this.btnEditar.TabIndex = 50;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(551, 513);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FormListaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(783, 561);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroFacura);
            this.Controls.Add(this.labelNumeroFactura);
            this.Controls.Add(this.dataGridListaFactura);
            this.Name = "FormListaFactura";
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        public System.Windows.Forms.TextBox txtNumeroFacura;
    }
}