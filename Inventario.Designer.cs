namespace Proyecto_GoShopping
{
    partial class Inventario
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            TxtNombre = new TextBox();
            BtnBuscar = new Button();
            BtnEliminar = new Button();
            BtnAgregar = new Button();
            NudCantidad = new NumericUpDown();
            BtnActualizar = new Button();
            CbDepartamento = new ComboBox();
            TxtPrecio = new TextBox();
            CbColor = new ComboBox();
            CbTalla = new ComboBox();
            TxtDescripcion = new TextBox();
            CbSucursal = new ComboBox();
            CbProveedor = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 30);
            label1.TabIndex = 0;
            label1.Text = "Registro de inventario";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtNombre);
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(BtnEliminar);
            groupBox1.Controls.Add(BtnAgregar);
            groupBox1.Controls.Add(NudCantidad);
            groupBox1.Controls.Add(BtnActualizar);
            groupBox1.Controls.Add(CbDepartamento);
            groupBox1.Controls.Add(TxtPrecio);
            groupBox1.Controls.Add(CbColor);
            groupBox1.Controls.Add(CbTalla);
            groupBox1.Controls.Add(TxtDescripcion);
            groupBox1.Controls.Add(CbSucursal);
            groupBox1.Controls.Add(CbProveedor);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(5, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 529);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(100, 116);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(191, 23);
            TxtNombre.TabIndex = 22;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.MediumSeaGreen;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(164, 496);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 27);
            BtnBuscar.TabIndex = 21;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.MediumSeaGreen;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(38, 497);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 27);
            BtnEliminar.TabIndex = 20;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.MediumSeaGreen;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(38, 459);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 27);
            BtnAgregar.TabIndex = 18;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // NudCantidad
            // 
            NudCantidad.Location = new Point(101, 414);
            NudCantidad.Name = "NudCantidad";
            NudCantidad.Size = new Size(120, 23);
            NudCantidad.TabIndex = 17;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.MediumSeaGreen;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(164, 459);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 27);
            BtnActualizar.TabIndex = 19;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // CbDepartamento
            // 
            CbDepartamento.FormattingEnabled = true;
            CbDepartamento.Location = new Point(101, 368);
            CbDepartamento.Name = "CbDepartamento";
            CbDepartamento.Size = new Size(190, 23);
            CbDepartamento.TabIndex = 16;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(101, 323);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(121, 23);
            TxtPrecio.TabIndex = 15;
            // 
            // CbColor
            // 
            CbColor.FormattingEnabled = true;
            CbColor.Location = new Point(101, 278);
            CbColor.Name = "CbColor";
            CbColor.Size = new Size(121, 23);
            CbColor.TabIndex = 14;
            // 
            // CbTalla
            // 
            CbTalla.FormattingEnabled = true;
            CbTalla.Location = new Point(101, 235);
            CbTalla.Name = "CbTalla";
            CbTalla.Size = new Size(121, 23);
            CbTalla.TabIndex = 13;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(101, 156);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(190, 63);
            TxtDescripcion.TabIndex = 12;
            // 
            // CbSucursal
            // 
            CbSucursal.FormattingEnabled = true;
            CbSucursal.Location = new Point(101, 70);
            CbSucursal.Name = "CbSucursal";
            CbSucursal.Size = new Size(190, 23);
            CbSucursal.TabIndex = 10;
            // 
            // CbProveedor
            // 
            CbProveedor.FormattingEnabled = true;
            CbProveedor.Location = new Point(101, 31);
            CbProveedor.Name = "CbProveedor";
            CbProveedor.Size = new Size(190, 23);
            CbProveedor.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 422);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 8;
            label10.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 376);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 7;
            label9.Text = "Departamento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 331);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 6;
            label8.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 286);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 5;
            label7.Text = "Color:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 243);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 4;
            label6.Text = "Talla:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 159);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 3;
            label5.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 119);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 78);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Sucursal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 34);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "Proveedor:";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 580);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventario";
            Text = "Inventario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox CbProveedor;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox CbSucursal;
        private ComboBox CbDepartamento;
        private TextBox TxtPrecio;
        private ComboBox CbColor;
        private ComboBox CbTalla;
        private TextBox TxtDescripcion;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button BtnBuscar;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Button BtnAgregar;
        private NumericUpDown NudCantidad;
        private TextBox TxtNombre;
    }
}