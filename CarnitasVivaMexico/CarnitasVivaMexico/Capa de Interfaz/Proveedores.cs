using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CarnitasVivaMexico.Capa_de_Interfaz
{
    public partial class Proveedores : Form
    {
        private NpgsqlDataAdapter dataAdapter;
        BindingSource bSource = new BindingSource();
        private void GetData(String SQL)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=CarnitasVivaMexico";
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                dataAdapter = new NpgsqlDataAdapter(SQL, connection);
                DataTable dTabele = new DataTable();
                dataAdapter.Fill(dTabele);
                bSource.DataSource = dTabele;
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Proveedores()
        {
            InitializeComponent();
            GetData("select nombre, telefono from Proveedores");
            dataGridView1.DataSource = bSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnBackProveedores(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=CarnitasVivaMexico";
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                var command = new NpgsqlCommand($"INSERT INTO Proveedores (nombre, telefono) VALUES ('{txtBoxNombre.Text}', '{txtBoxTelefono.Text}')", connection);
                command.ExecuteNonQuery();
                GetData("select nombre, telefono from Proveedores");
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarReg_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=CarnitasVivaMexico";
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                var command = new NpgsqlCommand($"DELETE FROM Proveedores WHERE nombre = '{txtBoxNombre.Text}' AND telefono = '{txtBoxTelefono.Text}'", connection);
                command.ExecuteNonQuery();
                GetData("select nombre, telefono from Proveedores");
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
