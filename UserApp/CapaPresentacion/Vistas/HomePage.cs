using Microsoft.Data.SqlClient;
using Repository.Entities;
using Service.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace CapaPresentacion.Vistas
{
    public partial class HomePage : Form
    {
        private readonly IUsuarios _usuarios;
        public HomePage(IUsuarios usuarios)
        {
            InitializeComponent();
            _usuarios = usuarios;
        }

        private async void ViewList()
        {
            var list = await _usuarios.List();
            dataGridViewUsuarios.DataSource = list;
        }
        private async void HomePage_Load(object sender, EventArgs e)
        {
            ViewList();
        }


        private async void buttonRefresc_Click(object sender, EventArgs e)
        {
            ViewList();
        }

        private async void btnRegister_Click_2(object sender, EventArgs e)
        {
            // Validar que todos los controles estén inicializados
            if (textBoxNumeroDocumento == null ||
                textBoxPrimerNombre == null ||
                textBoxPrimerApellido == null ||
                textBoxDireccion == null ||
                textBoxEdad == null ||
                comboBoxGenero == null)
            {
                MessageBox.Show("Algunos controles de entrada no están inicializados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar campos obligatorios
            if (
                !int.TryParse(textBoxNumeroDocumento.Text, out int NumeroDocumento) ||
                string.IsNullOrWhiteSpace(textBoxPrimerNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxDireccion.Text) ||
                !int.TryParse(textBoxEdad.Text, out int edad) ||
                comboBoxGenero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios y asegúrese de que sean correctos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = new Usuarios
            {
                NumeroDocumento = int.TryParse(textBoxNumeroDocumento.Text, out int numeroDocumento) ? numeroDocumento : 0,
                PrimerNombre = textBoxPrimerNombre.Text,
                SegundoNombre = textBoxSegundoNombre.Text,
                PrimerApellido = textBoxPrimerApellido.Text,
                SegundoApellido = textBoxSegundoApellido.Text,
                Telefono = int.TryParse(textBoxTelefono.Text, out int telefono) ? telefono : 0,
                Correo = textBoxCorreo.Text,
                Direccion = textBoxDireccion.Text,
                Edad = edad,
                Genero = comboBoxGenero.SelectedItem.ToString()
            };

            try
            {
                if (_usuarios == null)
                {
                    MessageBox.Show("El servicio de usuarios no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var register = await _usuarios.Create(usuario);
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                var average = await _usuarios.AverageAge();
                var dt = new DataTable();
                dt.Columns.Add("Promedio", typeof(double));
                dt.Rows.Add(average);
                MessageBox.Show($"El promedio de edad es :  {average}");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error en la base de datos: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el promedio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var maxAge = await _usuarios.Maxage();
                var dt = new DataTable();
                dt.Columns.Add("Persona Mayor", typeof(string));
                dt.Rows.Add(maxAge);
                MessageBox.Show($"Persona mayor {maxAge}");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error en la base de datos: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el calculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void buttonMaxAge_Click(object sender, EventArgs e)
        {
            if (comboBoxG.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string genero = comboBoxG.SelectedItem.ToString();

            try
            {
                int count = await _usuarios.AmountGender(genero);
                MessageBox.Show($"Cantidad de usuarios {genero}: {count}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al contar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

