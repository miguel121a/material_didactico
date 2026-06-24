string cadenaConexion = "Server=servidor;Database=BaseDatos;User Id=usuario;Password=contraseña;";

SqlConnection conexion = new SqlConnection(cadenaConexion);

conexion.Open();

// Operaciones con la base de datos

conexion.Close();