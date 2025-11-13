using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    public class DecoradorAdministrador : IUsuario
    {
        private readonly IUsuario _usuario;
        public DecoradorAdministrador(IUsuario usuario) { _usuario = usuario; }
        public void Acceder()
        {
            _usuario.Acceder();
            Console.WriteLine("Permiso: gestionar usuarios y roles.");
        }
    }
}
