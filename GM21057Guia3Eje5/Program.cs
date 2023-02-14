/*
 * Creado por SharpDevelop.
 * Usuario: BRANDON
 * Fecha: 2/3/2022
 * Hora: 11:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

// Guía: 3 
// Ejercicio: 5
// Fecha: 2/3/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia3Eje5
{
	//Descripcion del programa:
	/* Diseñar un prgrama que
     convierta una temperatura en grados Fahrenheit a celcius*/
	
	class Program
	{
		public static void Main(string[] args)
		{
	    //Identificacion del programa en pantalla
		Console.Title=("CALCULAR GRADOS FAHRENHEIT A CELCIUS ");
		Console.WriteLine("CALCULAR GRADOS FAHRENHEIT A CELCIUS");
		Console.WriteLine("Autor:Brandon Gomez");
	    Console.WriteLine(" ");
	    
		//DECLARACION DE VARIABLES
	    double c,f; 
	       //c= Grados Celcius; f= Grados Fahrenheit
		
		//ENTRADA DE DATOS
		Console.WriteLine("Ingrese los grados Fahrenheit a convertir: "); f= double.Parse(Console.ReadLine());
		c = (f-32)/1.8;
		
		//SALIDA DE DATOS
		Console.Write("El resultado es: {0:##.####} Grados Celcius",c);
		Console.ReadKey(true);
		
		
		}
	}
}