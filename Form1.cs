using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proyecto_GoShopping
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void BtnIniciar_MouseEnter(object sender, EventArgs e)
        {
            BtnIniciar.BackColor = Color.LightSkyBlue;
        }

        private void BtnIniciar_MouseLeave(object sender, EventArgs e)
        {
            BtnIniciar.BackColor = Color.MediumSeaGreen;
        }

        private void PbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Contadores para intentos fallidos
        private int intentosFallidos = 0;
        private const int maxIntentos = 3;

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = TxtPass.Text;

            try
            {
                ConexionBD conexion = new ConexionBD();
                using (MySqlConnection conn = conexion.Conectar())
                {
                    string consulta = "SELECT * FROM usuario WHERE usuario = @usuario AND usuarioPwd = @password";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Login exitoso
                                MessageBox.Show("¡Bienvenido al sistema!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                intentosFallidos = 0;

                                // Abriendo formulario principal
                                this.Hide();
                                var principal = new Principal();
                                principal.ShowDialog();                                
                            }
                            else
                            {
                                intentosFallidos++;
                                MessageBox.Show($"Usuario o contraseña incorrectos. Intento {intentosFallidos} de {maxIntentos}.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                if (intentosFallidos >= maxIntentos)
                                {
                                    MessageBox.Show("Has superado el número de intentos. La aplicación se cerrará.");
                                    Application.Exit();
                                }
                                txtUser.Clear();
                                TxtPass.Clear();
                                txtUser.Focus();
                            }
                        }
                    }

                    conexion.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
