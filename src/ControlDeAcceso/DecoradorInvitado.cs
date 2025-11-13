using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    public class DecoradorInvitado : IUsuario
    {
        private readonly IUsuario _usuario;
        public DecoradorInvitado(IUsuario usuario) { _usuario = usuario; }
        public void Acceder()
        {
            _usuario.Acceder();
            Console.WriteLine("Permiso: solo lectura.");
        }
    }
}
