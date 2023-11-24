using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicios_sem_14._2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static List<Usuario> listaUsuarios = new List<Usuario>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Registro de edades");
                Console.WriteLine("===============================");
                Console.WriteLine("1: Ingresar Usuario");
                Console.WriteLine("2: Ordenar edades");
                Console.WriteLine("3: Convertir a mayúsculas");
                Console.WriteLine("4: Ver datos");
                Console.WriteLine("5: Salir.");
                Console.WriteLine("===============================");

                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        IngresarUsuario();
                        break;
                    case "2":
                        OrdenarEdades();
                        break;
                    case "3":
                        ConvertirMayusculas();
                        break;
                    case "4":
                        VerDatos();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void IngresarUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del usuario: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Usuario nuevoUsuario = new Usuario { Nombre = nombre, Edad = edad };
                listaUsuarios.Add(nuevoUsuario);
                Console.WriteLine("Usuario ingresado exitosamente.");
            }
            else
            {
                Console.WriteLine("Edad ingresada no válida.");
            }
        }

        static void OrdenarEdades()
        {
            listaUsuarios = listaUsuarios.OrderBy(u => u.Edad).ToList();
            Console.WriteLine("Edades ordenadas de menor a mayor.");
        }

        static void ConvertirMayusculas()
        {
            foreach (var usuario in listaUsuarios)
            {
                usuario.Nombre = usuario.Nombre.ToUpper();
            }
            Console.WriteLine("Nombres convertidos a mayúsculas.");
        }

        static void VerDatos()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Datos de usuarios");
            Console.WriteLine("===============================");
            foreach (var usuario in listaUsuarios)
            {
                Console.WriteLine($"Nombre: {usuario.Nombre}, Edad: {usuario.Edad}");
            }
            Console.WriteLine("===============================");
            Console.ReadKey();  
        }
    }

    class Usuario
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
    
}
