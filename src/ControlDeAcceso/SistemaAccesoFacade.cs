using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    public class SistemaAccesoFacade
    {
        public IUsuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            Console.WriteLine($"\nIntentando iniciar sesión como: {nombreUsuario}");

            bool valido = Autenticador.ValidarUsuario(nombreUsuario, contraseña);

            if (!valido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Datos incorrectos.\n");
                Console.ResetColor();
                return null;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Usuario autenticado correctamente.\n");
            Console.ResetColor();

            IUsuario usuario = new UsuarioBase();

            List<string> roles = GestorRoles.ObtenerRoles(nombreUsuario);

            foreach (string rol in roles)
            {
                switch (rol)
                {
                    case "Administrador":
                        usuario = new DecoradorAdministrador(usuario);
                        break;
                    case "Editor":
                        usuario = new DecoradorEditor(usuario);
                        break;
                    case "Invitado":
                        usuario = new DecoradorInvitado(usuario);
                        break;
                }
            }

            MostrarColorPorRol(roles);

            return usuario;
        }

        private void MostrarColorPorRol(List<string> roles)
        {
            if (roles.Contains("Administrador"))
                Console.ForegroundColor = ConsoleColor.Red;
            else if (roles.Contains("Editor"))
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (roles.Contains("Invitado"))
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
