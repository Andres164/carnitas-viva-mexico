using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnitasVivaMexico
{
    using Npgsql;
    public partial class Autenticacion : Form
    {
        public Autenticacion()
        {
            InitializeComponent();
        }
        
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=CarnitasVivaMexico";
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                string SQL = "SELECT usuario, password FROM usuarios";
                var command = new NpgsqlCommand(SQL, connection);
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    if (txtBoxUsuario.Text == reader.GetString(0) && txtBoxPassword.Text == reader.GetString(1))
                    {
                        Capa_de_Interfaz.MenuPrincipal menuPrincipal = new Capa_de_Interfaz.MenuPrincipal();
                        menuPrincipal.Show();
                        connection.Close();
                        this.Hide();
                        break;
                    }
                    else
                        MessageBox.Show("Usuario y/o contraseña incorrecta", "Autenticacion Fallida", MessageBoxButtons.OK);
                }
            }
            catch(Exception exept)
            {
                MessageBox.Show(exept.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Salio del TRY", "Info", MessageBoxButtons.OK);
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {

        }
    }
}
