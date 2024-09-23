
using Microsoft.Data.SqlClient;
using Repository.Db;
using Repository.Entities;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace Repository.Implementation
{
    public class ImUsuariosRepository : UsuariosRepository
    {
        private readonly ConnectionBD _conexionBD;

        public ImUsuariosRepository(ConnectionBD conexionBD)
        {
            _conexionBD = conexionBD;
        }


        public async Task<int> AmountGender(string genero)
        {
            int count = 0;
            using (var connection = _conexionBD.Obtener())
            {
                await connection.OpenAsync();
                var command = new SqlCommand("amountpergender", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Buscar", genero);

                var result = await command.ExecuteScalarAsync();
                count = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
            return count;
        }

        public async Task<double> AverageAge()
        {
            double averageAge = 0;
            using (var connection = _conexionBD.Obtener())
            {
                await connection.OpenAsync();
                var command = new SqlCommand("averageage", connection);
                command.CommandType = CommandType.StoredProcedure;
                var result = await command.ExecuteScalarAsync();
                averageAge = result != DBNull.Value ? Convert.ToDouble(result) : 0;
            }
            return averageAge;
        }

        public async Task<string> Create(Usuarios objeto)
        {
            string answer = "Usuario registrado exitosamente.";
            using (var connection = _conexionBD.Obtener())
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand("createUser", connection))
                {
                    command.Parameters.AddWithValue("@NumeroDocumento", objeto.NumeroDocumento);
                    command.Parameters.AddWithValue("@PrimerNombre", objeto.PrimerNombre);
                    command.Parameters.AddWithValue("@SegundoNombre", objeto.SegundoNombre ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@PrimerApellido", objeto.PrimerApellido);
                    command.Parameters.AddWithValue("@SegundoApellido", objeto.SegundoApellido ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                    command.Parameters.AddWithValue("@Correo", objeto.Correo ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    command.Parameters.AddWithValue("@Edad", objeto.Edad);
                    command.Parameters.AddWithValue("@Genero", objeto.Genero);

                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        await command.ExecuteNonQueryAsync();
                    }
                    catch (Exception ex)
                    {
                        answer = $"Error al registrar usuario: {ex.Message}";
                    }
                }
            }
            return answer;
        }

        public async Task<List<Usuarios>> List()
        {
            List<Usuarios> list = new List<Usuarios>();
            using (var connection = _conexionBD.Obtener())
            {
                connection.Open();
                var command = new SqlCommand("listUsers", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (var Users = await command.ExecuteReaderAsync())
                {
                    while (await Users.ReadAsync())
                    {
                        list.Add(new Usuarios
                        {
                            NumeroDocumento = Convert.ToInt32(Users["NumeroDocumento"]),
                            PrimerNombre = Users["PrimerNombre"].ToString(),
                            SegundoNombre = Users["SegundoNombre"].ToString(),
                            PrimerApellido = Users["PrimerApellido"].ToString(),
                            SegundoApellido = Users["SegundoApellido"].ToString(),
                            Telefono = Convert.ToInt32(Users["Telefono"]),
                            Correo = Users["Correo"].ToString(),
                            Direccion = Users["Direccion"].ToString(),
                            Edad = Convert.ToInt32(Users["Edad"]),
                            Genero = Users["Genero"].ToString()
                        });
                    }
                }
            }
            return list;
        }
        public async Task<string> Maxage()
        {
            string maxAgeName = string.Empty;
            using (var connection = _conexionBD.Obtener())
            {
                await connection.OpenAsync();
                var command = new SqlCommand("maxage", connection);
                command.CommandType = CommandType.StoredProcedure;
                var result = await command.ExecuteScalarAsync();
                maxAgeName = result != DBNull.Value ? result.ToString() : string.Empty;
            }
            return maxAgeName;
        }

    }
}
