using System;

public class DbPostgresEntidades
{
	private int id;
	private string categoriaProducto;
	private string marcaProducto;
	private string descripcionProducto;
	private int precioProducto;
	private int numeroDeUnidades;

	public DbPostgresEntidades()
	{
	}

	public string CategoriaProducto
    {
		get { return categoriaProducto; }
		set { categoriaProducto = value; }
    }
	public string MarcaProducto
    {
		get { return marcaProducto; }
		set { marcaProducto = value; }
    }

	public string DescripcionProducto
    {
		get { return descripcionProducto; }
		set { descripcionProducto = value; }
    }

	public int PrecioProducto 
	{ 
		get { return precioProducto; } 
		set { precioProducto = value; } 
	}

	public int NumeroDeUnidades
    {
		get { return numeroDeUnidades; }
		set { numeroDeUnidades = value; }
    }
}

