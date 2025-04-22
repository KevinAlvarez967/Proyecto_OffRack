namespace Proyecto_GoShopping
{
    partial class Transacciones
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
            txtImpuesto = new TextBox();
            TxtMonto = new TextBox();
            TxtDescripcion = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            TxtCliente = new TextBox();
            CbSucursal = new ComboBox();
            BtnBuscar = new Button();
            BtnEliminar = new Button();
            BtnAgregar = new Button();
            BtnActualizar = new Button();
            TxtDescuento = new TextBox();
            CbPago = new ComboBox();
            CbTransaccion = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 30);
            label1.TabIndex = 1;
            label1.Text = "Registro de Transacciones";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtImpuesto);
            groupBox1.Controls.Add(TxtMonto);
            groupBox1.Controls.Add(TxtDescripcion);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(TxtCliente);
            groupBox1.Controls.Add(CbSucursal);
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(BtnEliminar);
            groupBox1.Controls.Add(BtnAgregar);
            groupBox1.Controls.Add(BtnActualizar);
            groupBox1.Controls.Add(TxtDescuento);
            groupBox1.Controls.Add(CbPago);
            groupBox1.Controls.Add(CbTransaccion);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 529);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(101, 381);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(190, 23);
            txtImpuesto.TabIndex = 27;
            // 
            // TxtMonto
            // 
            TxtMonto.Location = new Point(101, 342);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(190, 23);
            TxtMonto.TabIndex = 26;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(101, 231);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(190, 55);
            TxtDescripcion.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(101, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(101, 151);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(190, 23);
            TxtCliente.TabIndex = 23;
            // 
            // CbSucursal
            // 
            CbSucursal.FormattingEnabled = true;
            CbSucursal.Location = new Point(101, 111);
            CbSucursal.Name = "CbSucursal";
            CbSucursal.Size = new Size(190, 23);
            CbSucursal.TabIndex = 22;
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
            // TxtDescuento
            // 
            TxtDescuento.Location = new Point(101, 300);
            TxtDescuento.Name = "TxtDescuento";
            TxtDescuento.Size = new Size(190, 23);
            TxtDescuento.TabIndex = 15;
            // 
            // CbPago
            // 
            CbPago.FormattingEnabled = true;
            CbPago.Location = new Point(101, 70);
            CbPago.Name = "CbPago";
            CbPago.Size = new Size(190, 23);
            CbPago.TabIndex = 10;
            // 
            // CbTransaccion
            // 
            CbTransaccion.FormattingEnabled = true;
            CbTransaccion.Location = new Point(101, 31);
            CbTransaccion.Name = "CbTransaccion";
            CbTransaccion.Size = new Size(190, 23);
            CbTransaccion.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 389);
            label10.Name = "label10";
            label10.Size = new Size(77, 15);
            label10.TabIndex = 8;
            label10.Text = "Impuesto ($):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 350);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 7;
            label9.Text = "Monto Total ($):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 308);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 6;
            label8.Text = "Descuento ($):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 234);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 5;
            label7.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 195);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 4;
            label6.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 159);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 3;
            label5.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 119);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Sucursal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 78);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 1;
            label3.Text = "Pago:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 34);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Transacción:";
            // 
            // Transacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 580);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Transacciones";
            Text = "Transacciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox CbSucursal;
        private DateTimePicker dtpFecha;
        private Button BtnBuscar;
        private Button BtnEliminar;
        private Button BtnAgregar;
        private Button BtnActualizar;
        private ComboBox Cb;
        private ComboBox CbPago;
        private ComboBox CbTransaccion;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDescripcion;
        private TextBox TxtCliente;
        private TextBox TxtDescuento;
        private DateTimePicker dateTimePicker1;
        private TextBox TxtDescripcion;
        private TextBox txtImpuesto;
        private TextBox TxtMonto;
    }
}