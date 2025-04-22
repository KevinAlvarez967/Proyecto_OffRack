using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_GoShopping
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        void abrirForm(Form form)
        {
            while (Panel_Base.Controls.Count > 0)
            {
                Panel_Base.Controls.RemoveAt(0);
            }

            Form formHijo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Panel_Base.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnInventarioMen_Click(object sender, EventArgs e)
        {
            abrirForm(new Inventario());
        }

        private void btnTransaccionesMen_Click(object sender, EventArgs e)
        {
            abrirForm(new Transacciones());
        }

        private void btnUsuarioMen_Click(object sender, EventArgs e)
        {
            abrirForm(new Usuarios());
        }

        private void PbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
