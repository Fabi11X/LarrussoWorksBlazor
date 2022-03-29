using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Data.Models
{
    public class Mensaje
    {
        public int IdMensaje { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpleo { get; set; }
        public string BuzonMensaje { get; set; }

        public virtual Empleo IdEmpleoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }


        public int GetEmpresaId(IList<Empleo> empleo)
        {
            int id = empleo.Where(e => e.IdEmpleo == IdEmpleo).Select(e => e.IdEmpresa).FirstOrDefault();
            return id;
        }


        public string GetNameUsuario(IList<Usuario> usuarios)
        {
            string nombreUsuario = usuarios.Where(c => c.IdUsuario == IdUsuario).Select(c => c.NombreUsuario).FirstOrDefault();
            return nombreUsuario;
        }

        public string GetNameEmpleo(IList<Empleo> empleos)
        {
            string nombreEmpleo = empleos.Where(c => c.IdEmpresa == IdEmpleo).Select(c => c.NombreEmpleo).FirstOrDefault();
            return nombreEmpleo;
        }
    }
}
