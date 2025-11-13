using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    public static class Autenticador
    {
        public static bool ValidarUsuario(string usuario, string contraseña)
        {
            return (usuario == "kevin" && contraseña == "12345") ||
                   (usuario == "ana" && contraseña == "abc") ||
                   (usuario == "luis" && contraseña == "guest");
        }
    }
}
