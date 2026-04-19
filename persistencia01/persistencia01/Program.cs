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
			string dir = "./";

            Console.WriteLine("Desafío 1...");
            string entrada = "usuario;clave123";
            string[] partes = entrada.Split(';');

            if (partes.Length > 1 && partes[1].Contains("123"))
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(dir, "seguridad.txt")))
                {
                    sw.WriteLine("Clave Débil detectada");
                }
                Console.WriteLine("Aviso de seguridad generado.");
            }

            string origenImg = Path.Combine(dir, "imagen.JPG");
            string destinoImg = Path.Combine(dir, "respaldo.JPG");

            if (!File.Exists(origenImg))
            {
                File.WriteAllText(origenImg, "bin");
            }

            using (FileStream fs1 = new FileStream(origenImg, FileMode.Open))
            using (FileStream fs2 = new FileStream(destinoImg, FileMode.Create))
            {
                byte[] buffer = new byte[1024];
                int bytesLeidos;
                while ((bytesLeidos = fs1.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fs2.Write(buffer, 0, bytesLeidos);
                }
            }

            DirectoryInfo info = new DirectoryInfo(dir);
            FileInfo[] lista = info.GetFiles();

            foreach (FileInfo archi in lista)
            {
                if (archi.Length > 5120)
                {
                    Console.WriteLine("Activando archivo pesado: " + archi.Name);
                }
            }

            Console.WriteLine("Proceso finalizado.");
            Console.ReadKey(true);
        }
    }
}
