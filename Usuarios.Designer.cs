namespace Proyecto_GoShopping
{
    partial class Usuarios
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
            CbTipo = new ComboBox();
            TxtUsuario = new TextBox();
            TxtEmail = new TextBox();
            TxtApellidos = new TextBox();
            TxtNombre = new TextBox();
            BtnBuscar = new Button();
            BtnAgregar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnEliminar = new Button();
            BtnActualizar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 1;
            label1.Text = "Registrar Usuarios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnEliminar);
            groupBox1.Controls.Add(CbTipo);
            groupBox1.Controls.Add(BtnActualizar);
            groupBox1.Controls.Add(TxtUsuario);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(TxtApellidos);
            groupBox1.Controls.Add(TxtNombre);
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(BtnAgregar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 361);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // CbTipo
            // 
            CbTipo.FormattingEnabled = true;
            CbTipo.Location = new Point(105, 184);
            CbTipo.Name = "CbTipo";
            CbTipo.Size = new Size(186, 23);
            CbTipo.TabIndex = 26;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(81, 145);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(210, 23);
            TxtUsuario.TabIndex = 25;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(81, 109);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(210, 23);
            TxtEmail.TabIndex = 24;
            // 
            // TxtApellidos
            // 
            TxtApellidos.Location = new Point(81, 70);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(210, 23);
            TxtApellidos.TabIndex = 23;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(81, 26);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(210, 23);
            TxtNombre.TabIndex = 22;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.MediumSeaGreen;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(164, 290);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 27);
            BtnBuscar.TabIndex = 21;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += button4_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.MediumSeaGreen;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(38, 253);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 27);
            BtnAgregar.TabIndex = 18;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 192);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 4;
            label6.Text = "Tipo de usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 153);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 3;
            label5.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 117);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 78);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 34);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombres:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.MediumSeaGreen;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(38, 291);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 27);
            BtnEliminar.TabIndex = 22;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.MediumSeaGreen;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(164, 253);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 27);
            BtnActualizar.TabIndex = 21;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 580);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox TxtNombre;
        private Button BtnBuscar;
        private Button BtnAgregar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox CbTipo;
        private TextBox TxtUsuario;
        private TextBox TxtEmail;
        private TextBox TxtApellidos;
        private Button BtnEliminar;
        private Button BtnActualizar;
    }
}