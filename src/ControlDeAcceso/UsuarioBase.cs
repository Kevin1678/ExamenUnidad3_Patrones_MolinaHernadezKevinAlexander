using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    public class UsuarioBase : IUsuario
    {
        public virtual void Acceder()
        {
            Console.WriteLine("Acceso básico al sistema.");
        }
    }
}
