using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaAccesoFacade sistema = new SistemaAccesoFacade();

            Console.WriteLine("=== CONTROL DE ACCESO ===\n");

            while (true)
            {
                Console.ResetColor();
                Console.Write("Ingrese su nombre de usuario o 'salir': ");
                string usuario = Console.ReadLine();
                if (usuario.ToLower() == "salir") break;

                Console.Write("Ingrese su contraseña: ");
                string contraseña = Console.ReadLine();

                IUsuario u = sistema.IniciarSesion(usuario, contraseña);
                if (u != null)
                {
                    Console.WriteLine("Permisos asignados:");
                    u.Acceder();
                    Console.ResetColor();
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("=== CONTROL DE ACCESO ===\n");
            }
        }

    }

}

