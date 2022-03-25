using System;
using Npgsql;

public class DbModel
{
	public DbModel()
	{
	}

	public NpgsqlConnection conexion()
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        var configConnection = "Server=localhost; Port=5432; User Id=postgres; Password=AXQWEZRT7;Database=dvdrental";

        if (!string.IsNullOrWhiteSpace(configConnection))
        {
            try
            {
                conexion = new NpgsqlConnection(configConnection);
                conexion.Open();
            }
            catch(Exception e)
            {
                conexion.Close();
            }
        }
        return conexion;

    }


}
