using System;

public class Modelo
{
	//Atributos modificadores d acceso privado
	private int film_id;
	private string title;
	private string description;
	private int release_year;

	//Constructor de clase vacío
	public Modelo()
	{
	}

	//Metodos get y set para acceder a los atributos de la clase
	public int Film_Id
    {
		get { return film_id; }
		set { film_id = value; }
    }
	public string Description
    {
		get { return description; }
		set { description = value; }
    }

	public string Title
    {
		get { return title; }
		set { title= value; }
    }

	public int Release_Year
	{ 
		get { return release_year; } 
		set { release_year = value; } 
	}

   }

