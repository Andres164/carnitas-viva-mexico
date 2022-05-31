using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnitasVivaMexico.Capa_de_Interfaz
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void BTNproveedores(object sender, EventArgs e)
        {
            Form MenuPrincipal = new Proveedores();
            MenuPrincipal.Show();
        }

        private void BtnVENTAS(object sender, EventArgs e)
        {
            Form MenuPrincipal = new Ventas();
            MenuPrincipal.Show();
        }

        private void BtnPRODUCTOS(object sender, EventArgs e)
        {
            Form MenuPrincipal = new Productos();
            MenuPrincipal.Show();
        }

        private void BtnINSUMOS(object sender, EventArgs e)
        {
            Form MenuPrincipal = new Insumos();
            MenuPrincipal.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
