using System;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using Dapper;

public class DAOPostgres
{
    public DAOPostgres()
    {
    }

    static String servidor = "localhost"; //Aqui va tu servidor
    static String bd = "dvdrental"; //Aqui va el nombre de la db
    static String usuario = "postgres"; //Aqui va tu usuario
    static String password = "Root";//Aqui va tu contraseña
    static String puerto = "5432"; //Puerto de conexión
    //Instancia  de la clase NpgsqlConnection
    NpgsqlConnection conexion = new NpgsqlConnection();
    //Cadena con la información necesaria para establecer la conexión a la DB
    String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

    //Método que permite establcer al conexión incial
    public NpgsqlConnection establecerConexion()
    {
     
        try
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Se conectó correctamente a la base de datos");

            }
            else
            {
                MessageBox.Show("La conexión ya esta hecha");
            }
        }

        catch (NpgsqlException e)
        {
            MessageBox.Show("No se pudo conectar a la base de datos de PostgreSQL, error: " + e.ToString());

        }

        return conexion;
    }

    //Permite cerrar la conexión a la db
    public NpgsqlConnection cerrarConexionADb()
    {
        
        try
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
                MessageBox.Show("Se ha cerrado la conexión a la DB");

            }
            else
            {
                MessageBox.Show("La conexión ya ha finalizado");
            }
        }

        catch (NpgsqlException e)
        {
            MessageBox.Show("Error al cerrar la base de datos de PostgreSQL, error: " + e.ToString());

        }

        return conexion;
    }
    //Permite realizar una consulta de manera general
    //public List<Modelo> consultar()
    //{
    //    string query = "SELECT * FROM film ORDER BY film_id ASC;";
    //    if(establecerConexion().State == ConnectionState.Open){
    //        return conexion.Query<Modelo>(query).ToList();
    //    }
    //    else
    //    {
    //        establecerConexion();
    //        MessageBox.Show("Se conectó correctamente a la base de datos");
    //        return conexion.Query<Modelo>(query).ToList();
    //    }
    //}

    public List<Modelo> buscarId(int valor)
    {

        string query = "SELECT * FROM film where film_id = ('" + valor + "') ORDER BY film_id ASC;";
        if (establecerConexion().State == ConnectionState.Open)
        {
            return conexion.Query<Modelo>(query).ToList();
        }
        else
        {
            establecerConexion();
            MessageBox.Show("Se conectó correctamente a la base de datos");
            return conexion.Query<Modelo>(query).ToList();
        }
    }

    public List<Modelo> buscarNombre(String valor)
    {

        string query = "SELECT * FROM film where title = ('" + valor + "') ORDER BY film_id ASC;";
        if (establecerConexion().State == ConnectionState.Open)
        {
            return conexion.Query<Modelo>(query).ToList();
        }
        else
        {
            establecerConexion();
            MessageBox.Show("Se conectó correctamente a la base de datos");
            return conexion.Query<Modelo>(query).ToList();
        }
    }

    public List<Modelo> buscarAño(int valor)
    {

        string query = "SELECT * FROM film where release_year = ('" + valor + "') ORDER BY film_id ASC;";
        if (establecerConexion().State == ConnectionState.Open)
        {
            return conexion.Query<Modelo>(query).ToList();
        }
        else
        {
            establecerConexion();
            MessageBox.Show("Se conectó correctamente a la base de datos");
            return conexion.Query<Modelo>(query).ToList();
        }
    }
}
