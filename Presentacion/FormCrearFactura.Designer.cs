namespace Presentacion
{
    partial class FormCrearFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearFactura));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.dataGridFactura = new System.Windows.Forms.DataGridView();
            this.columnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNumeroFactura = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelAño = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombreProducto = new System.Windows.Forms.Label();
            this.labelTalla = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.labelFacturacion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.labelApellidoMostrar = new System.Windows.Forms.Label();
            this.labelNombreClienteMostrar = new System.Windows.Forms.Label();
            this.labelCelularMostrar = new System.Windows.Forms.Label();
            this.labelNombreProductoMostrar = new System.Windows.Forms.Label();
            this.labelPrecioMostrar = new System.Windows.Forms.Label();
            this.labelTallaMostrar = new System.Windows.Forms.Label();
            this.labelTotalMostrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(663, 516);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 36);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Image = ((System.Drawing.Image)(resources.GetObject("btnTotal.Image")));
            this.btnTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotal.Location = new System.Drawing.Point(242, 513);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(140, 39);
            this.btnTotal.TabIndex = 52;
            this.btnTotal.Text = "Calcular Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // dataGridFactura
            // 
            this.dataGridFactura.AllowUserToOrderColumns = true;
            this.dataGridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCodigo,
            this.ColumnNombre,
            this.ColumnTalla,
            this.ColumnCantidad,
            this.ColumnPrecioUnitario,
            this.ColumnSubtotal});
            this.dataGridFactura.Location = new System.Drawing.Point(74, 261);
            this.dataGridFactura.Name = "dataGridFactura";
            this.dataGridFactura.Size = new System.Drawing.Size(643, 242);
            this.dataGridFactura.TabIndex = 54;
            // 
            // columnCodigo
            // 
            this.columnCodigo.HeaderText = "Codigo";
            this.columnCodigo.Name = "columnCodigo";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnTalla
            // 
            this.ColumnTalla.HeaderText = "Talla";
            this.ColumnTalla.Name = "ColumnTalla";
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumnPrecioUnitario
            // 
            this.ColumnPrecioUnitario.HeaderText = "PrecioUnitario";
            this.ColumnPrecioUnitario.Name = "ColumnPrecioUnitario";
            // 
            // ColumnSubtotal
            // 
            this.ColumnSubtotal.HeaderText = "Subtotal";
            this.ColumnSubtotal.Name = "ColumnSubtotal";
            // 
            // labelNumeroFactura
            // 
            this.labelNumeroFactura.AutoSize = true;
            this.labelNumeroFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelNumeroFactura.Location = new System.Drawing.Point(141, 54);
            this.labelNumeroFactura.Name = "labelNumeroFactura";
            this.labelNumeroFactura.Size = new System.Drawing.Size(59, 16);
            this.labelNumeroFactura.TabIndex = 55;
            this.labelNumeroFactura.Text = "Factura#";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(374, 28);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(47, 16);
            this.labelFecha.TabIndex = 56;
            this.labelFecha.Text = "Fecha";
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelDia.Location = new System.Drawing.Point(367, 52);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(27, 16);
            this.labelDia.TabIndex = 57;
            this.labelDia.Text = "Dia";
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelMes.Location = new System.Drawing.Point(442, 52);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(33, 16);
            this.labelMes.TabIndex = 58;
            this.labelMes.Text = "Mes";
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelAño.Location = new System.Drawing.Point(523, 51);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(31, 16);
            this.labelAño.TabIndex = 59;
            this.labelAño.Text = "Año";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelProducto.Location = new System.Drawing.Point(9, 137);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(60, 16);
            this.labelProducto.TabIndex = 60;
            this.labelProducto.Text = "Producto";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelCodigo.Location = new System.Drawing.Point(19, 174);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(48, 16);
            this.labelCodigo.TabIndex = 61;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelNombreProducto
            // 
            this.labelNombreProducto.AutoSize = true;
            this.labelNombreProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelNombreProducto.Location = new System.Drawing.Point(275, 171);
            this.labelNombreProducto.Name = "labelNombreProducto";
            this.labelNombreProducto.Size = new System.Drawing.Size(53, 16);
            this.labelNombreProducto.TabIndex = 62;
            this.labelNombreProducto.Text = "Nombre";
            // 
            // labelTalla
            // 
            this.labelTalla.AutoSize = true;
            this.labelTalla.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTalla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelTalla.Location = new System.Drawing.Point(437, 171);
            this.labelTalla.Name = "labelTalla";
            this.labelTalla.Size = new System.Drawing.Size(34, 16);
            this.labelTalla.TabIndex = 63;
            this.labelTalla.Text = "Talla";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelCantidad.Location = new System.Drawing.Point(177, 173);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(59, 16);
            this.labelCantidad.TabIndex = 64;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelPrecio.Location = new System.Drawing.Point(523, 171);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(93, 16);
            this.labelPrecio.TabIndex = 65;
            this.labelPrecio.Text = "Precio Unitario";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelCliente.Location = new System.Drawing.Point(9, 80);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(48, 16);
            this.labelCliente.TabIndex = 66;
            this.labelCliente.Text = "Cliente";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelCedula.Location = new System.Drawing.Point(19, 106);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(48, 16);
            this.labelCedula.TabIndex = 67;
            this.labelCedula.Text = "Cedula";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelNombre.Location = new System.Drawing.Point(171, 104);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(53, 16);
            this.labelNombre.TabIndex = 68;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelApellido.Location = new System.Drawing.Point(328, 103);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(54, 16);
            this.labelApellido.TabIndex = 69;
            this.labelApellido.Text = "Apellido";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelCelular.Location = new System.Drawing.Point(484, 104);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(48, 16);
            this.labelCelular.TabIndex = 70;
            this.labelCelular.Text = "Celular";
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(496, 219);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(108, 36);
            this.btnAñadir.TabIndex = 74;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(610, 219);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(18, 516);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(69, 29);
            this.labelTotal.TabIndex = 75;
            this.labelTotal.Text = "Total";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(65, 103);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 76;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 167);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 77;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(198, 49);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroFactura.TabIndex = 85;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(400, 51);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(36, 20);
            this.txtDia.TabIndex = 86;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(481, 50);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(36, 20);
            this.txtMes.TabIndex = 87;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(555, 50);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(65, 20);
            this.txtAño.TabIndex = 88;
            // 
            // labelFacturacion
            // 
            this.labelFacturacion.AutoSize = true;
            this.labelFacturacion.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacturacion.Location = new System.Drawing.Point(25, 12);
            this.labelFacturacion.Name = "labelFacturacion";
            this.labelFacturacion.Size = new System.Drawing.Size(125, 29);
            this.labelFacturacion.TabIndex = 90;
            this.labelFacturacion.Text = "Facturacion";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(731, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 23);
            this.btnCerrar.TabIndex = 91;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(233, 167);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(36, 20);
            this.txtCantidad.TabIndex = 93;
            // 
            // labelApellidoMostrar
            // 
            this.labelApellidoMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoMostrar.Location = new System.Drawing.Point(388, 103);
            this.labelApellidoMostrar.Name = "labelApellidoMostrar";
            this.labelApellidoMostrar.Size = new System.Drawing.Size(90, 16);
            this.labelApellidoMostrar.TabIndex = 94;
            // 
            // labelNombreClienteMostrar
            // 
            this.labelNombreClienteMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreClienteMostrar.Location = new System.Drawing.Point(220, 103);
            this.labelNombreClienteMostrar.Name = "labelNombreClienteMostrar";
            this.labelNombreClienteMostrar.Size = new System.Drawing.Size(90, 16);
            this.labelNombreClienteMostrar.TabIndex = 95;
            // 
            // labelCelularMostrar
            // 
            this.labelCelularMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelularMostrar.Location = new System.Drawing.Point(530, 103);
            this.labelCelularMostrar.Name = "labelCelularMostrar";
            this.labelCelularMostrar.Size = new System.Drawing.Size(90, 16);
            this.labelCelularMostrar.TabIndex = 96;
            // 
            // labelNombreProductoMostrar
            // 
            this.labelNombreProductoMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProductoMostrar.Location = new System.Drawing.Point(328, 171);
            this.labelNombreProductoMostrar.Name = "labelNombreProductoMostrar";
            this.labelNombreProductoMostrar.Size = new System.Drawing.Size(90, 16);
            this.labelNombreProductoMostrar.TabIndex = 97;
            // 
            // labelPrecioMostrar
            // 
            this.labelPrecioMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioMostrar.Location = new System.Drawing.Point(613, 170);
            this.labelPrecioMostrar.Name = "labelPrecioMostrar";
            this.labelPrecioMostrar.Size = new System.Drawing.Size(90, 16);
            this.labelPrecioMostrar.TabIndex = 98;
            // 
            // labelTallaMostrar
            // 
            this.labelTallaMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTallaMostrar.Location = new System.Drawing.Point(474, 170);
            this.labelTallaMostrar.Name = "labelTallaMostrar";
            this.labelTallaMostrar.Size = new System.Drawing.Size(36, 16);
            this.labelTallaMostrar.TabIndex = 99;
            // 
            // labelTotalMostrar
            // 
            this.labelTotalMostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMostrar.Location = new System.Drawing.Point(93, 516);
            this.labelTotalMostrar.Name = "labelTotalMostrar";
            this.labelTotalMostrar.Size = new System.Drawing.Size(114, 29);
            this.labelTotalMostrar.TabIndex = 100;
            // 
            // FormCrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(783, 561);
            this.Controls.Add(this.labelTotalMostrar);
            this.Controls.Add(this.labelTallaMostrar);
            this.Controls.Add(this.labelPrecioMostrar);
            this.Controls.Add(this.labelNombreProductoMostrar);
            this.Controls.Add(this.labelCelularMostrar);
            this.Controls.Add(this.labelNombreClienteMostrar);
            this.Controls.Add(this.labelApellidoMostrar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.labelFacturacion);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelTalla);
            this.Controls.Add(this.labelNombreProducto);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNumeroFactura);
            this.Controls.Add(this.dataGridFactura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnTotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.DataGridView dataGridFactura;
        private System.Windows.Forms.Label labelNumeroFactura;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombreProducto;
        private System.Windows.Forms.Label labelTalla;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.Label labelApellidoMostrar;
        public System.Windows.Forms.Label labelNombreClienteMostrar;
        public System.Windows.Forms.Label labelCelularMostrar;
        public System.Windows.Forms.Label labelNombreProductoMostrar;
        public System.Windows.Forms.Label labelPrecioMostrar;
        public System.Windows.Forms.Label labelTallaMostrar;
        public System.Windows.Forms.Label labelTotalMostrar;
        public System.Windows.Forms.TextBox txtNumeroFactura;
        public System.Windows.Forms.TextBox txtDia;
        public System.Windows.Forms.TextBox txtMes;
        public System.Windows.Forms.TextBox txtAño;
    }
}