namespace Proyecto_GoShopping
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panel1 = new Panel();
            PbSalir = new PictureBox();
            panel2 = new Panel();
            btnUsuarioMen = new Button();
            btnTransaccionesMen = new Button();
            btnInventarioMen = new Button();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            Panel_Base = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbSalir).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(PbSalir);
            panel1.Location = new Point(-10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 45);
            panel1.TabIndex = 0;
            // 
            // PbSalir
            // 
            PbSalir.Image = (Image)resources.GetObject("PbSalir.Image");
            PbSalir.Location = new Point(1184, 3);
            PbSalir.Name = "PbSalir";
            PbSalir.Size = new Size(38, 39);
            PbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            PbSalir.TabIndex = 2;
            PbSalir.TabStop = false;
            PbSalir.Click += PbSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnUsuarioMen);
            panel2.Controls.Add(btnTransaccionesMen);
            panel2.Controls.Add(btnInventarioMen);
            panel2.Location = new Point(-10, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 644);
            panel2.TabIndex = 1;
            // 
            // btnUsuarioMen
            // 
            btnUsuarioMen.FlatStyle = FlatStyle.Flat;
            btnUsuarioMen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarioMen.Location = new Point(13, 238);
            btnUsuarioMen.Name = "btnUsuarioMen";
            btnUsuarioMen.Size = new Size(205, 43);
            btnUsuarioMen.TabIndex = 4;
            btnUsuarioMen.Text = "Registrar Usuario";
            btnUsuarioMen.UseVisualStyleBackColor = true;
            btnUsuarioMen.Click += btnUsuarioMen_Click;
            // 
            // btnTransaccionesMen
            // 
            btnTransaccionesMen.FlatStyle = FlatStyle.Flat;
            btnTransaccionesMen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaccionesMen.Location = new Point(13, 189);
            btnTransaccionesMen.Name = "btnTransaccionesMen";
            btnTransaccionesMen.Size = new Size(205, 43);
            btnTransaccionesMen.TabIndex = 3;
            btnTransaccionesMen.Text = "Transacciones";
            btnTransaccionesMen.UseVisualStyleBackColor = true;
            btnTransaccionesMen.Click += btnTransaccionesMen_Click;
            // 
            // btnInventarioMen
            // 
            btnInventarioMen.FlatStyle = FlatStyle.Flat;
            btnInventarioMen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventarioMen.Location = new Point(13, 140);
            btnInventarioMen.Name = "btnInventarioMen";
            btnInventarioMen.Size = new Size(205, 43);
            btnInventarioMen.TabIndex = 2;
            btnInventarioMen.Text = "Inventario";
            btnInventarioMen.UseVisualStyleBackColor = true;
            btnInventarioMen.Click += btnInventarioMen_Click;
            // 
            // Panel_Base
            // 
            Panel_Base.Location = new Point(217, 51);
            Panel_Base.Name = "Panel_Base";
            Panel_Base.Size = new Size(986, 603);
            Panel_Base.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 666);
            Controls.Add(Panel_Base);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Principal";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbSalir).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox PbSalir;
        private Panel panel2;
        private Button btnInventarioMen;
        private Button btnUsuarioMen;
        private Button btnTransaccionesMen;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private Panel Panel_Base;
    }
}