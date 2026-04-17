/*
 * Creado por SharpDevelop.
 * Usuario: diana
 * Fecha: 17/4/2026
 * Hora: 2:23 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace persistencia01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("hola diana");
			
			//directorio
			
			string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos IUJO");
			
			string rutaReportes = Path.Combine(rutaRaiz, "REPORTE");
			
			Console.WriteLine (rutaRaiz);
			
		
			Console.WriteLine (rutaReportes);
			
			if(!Directory.Exists (rutaReportes)) {
				Directory.CreateDirectory(rutaReportes); 
				Console.WriteLine("directorio creado carrectamente"); 
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}