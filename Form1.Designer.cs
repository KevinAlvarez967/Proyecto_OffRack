namespace Proyecto_GoShopping
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Panel_Iz = new Panel();
            PbShop = new PictureBox();
            PbSalir = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            TxtPass = new TextBox();
            BtnIniciar = new Button();
            Panel_Iz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbShop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbSalir).BeginInit();
            SuspendLayout();
            // 
            // Panel_Iz
            // 
            Panel_Iz.BackColor = Color.LightSkyBlue;
            Panel_Iz.Controls.Add(PbShop);
            Panel_Iz.ForeColor = Color.White;
            Panel_Iz.Location = new Point(-8, -9);
            Panel_Iz.Name = "Panel_Iz";
            Panel_Iz.Size = new Size(355, 488);
            Panel_Iz.TabIndex = 1;
            // 
            // PbShop
            // 
            PbShop.Image = (Image)resources.GetObject("PbShop.Image");
            PbShop.Location = new Point(42, 98);
            PbShop.Name = "PbShop";
            PbShop.Size = new Size(263, 259);
            PbShop.SizeMode = PictureBoxSizeMode.StretchImage;
            PbShop.TabIndex = 0;
            PbShop.TabStop = false;
            // 
            // PbSalir
            // 
            PbSalir.Image = (Image)resources.GetObject("PbSalir.Image");
            PbSalir.Location = new Point(708, 3);
            PbSalir.Name = "PbSalir";
            PbSalir.Size = new Size(35, 34);
            PbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            PbSalir.TabIndex = 1;
            PbSalir.TabStop = false;
            PbSalir.Click += PbSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(394, 121);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(394, 216);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F);
            txtUser.Location = new Point(394, 156);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(310, 33);
            txtUser.TabIndex = 4;
            // 
            // TxtPass
            // 
            TxtPass.Font = new Font("Segoe UI", 14.25F);
            TxtPass.Location = new Point(394, 251);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '*';
            TxtPass.Size = new Size(310, 33);
            TxtPass.TabIndex = 5;
            // 
            // BtnIniciar
            // 
            BtnIniciar.BackColor = Color.MediumSeaGreen;
            BtnIniciar.FlatStyle = FlatStyle.Flat;
            BtnIniciar.Font = new Font("Segoe UI", 14.25F);
            BtnIniciar.ForeColor = Color.White;
            BtnIniciar.Location = new Point(394, 334);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(310, 34);
            BtnIniciar.TabIndex = 6;
            BtnIniciar.Text = "Iniciar Sesion";
            BtnIniciar.UseVisualStyleBackColor = false;
            BtnIniciar.Click += BtnIniciar_Click;
            BtnIniciar.MouseEnter += BtnIniciar_MouseEnter;
            BtnIniciar.MouseLeave += BtnIniciar_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(746, 450);
            Controls.Add(BtnIniciar);
            Controls.Add(TxtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PbSalir);
            Controls.Add(Panel_Iz);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Panel_Iz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbShop).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panel_Iz;
        private PictureBox PbSalir;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox TxtPass;
        private Button BtnIniciar;
        private PictureBox PbShop;
    }
}
