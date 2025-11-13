using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    public static class GestorRoles
    {
        public static List<string> ObtenerRoles(string usuario)
        {
            var roles = new List<string>();

            switch (usuario)
            {
                case "kevin":
                    roles.Add("Administrador");
                    roles.Add("Editor");
                    break;
                case "ana":
                    roles.Add("Editor");
                    break;
                case "luis":
                    roles.Add("Invitado");
                    break;
            }

            return roles;
        }
    }
}
