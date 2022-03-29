using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Data.Models
{
    public class MensajesEmpresa
    {
        public int IdMensajeEmpresa { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public string MensajeEmpresa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }


        public int GetUsuarioId(IList<Usuario> usuario)
        {
            int id = usuario.Where(e => e.IdUsuario == IdUsuario).Select(e => e.IdUsuario).FirstOrDefault();
            return id;
        }



        public string GetNameUsuario(IList<Usuario> usuarios)
        {
            string nombreUsuario = usuarios.Where(c => c.IdUsuario == IdUsuario).Select(c => c.NombreUsuario).FirstOrDefault();
            return nombreUsuario;
        }

        public string GetNameEmpresa(IList<Empresa> empresas)
        {
            string nombreEmpresa = empresas.Where(c => c.IdEmpresa == IdEmpresa).Select(c => c.NombreEmpresa).FirstOrDefault();
            return nombreEmpresa;
        }
    }
}
