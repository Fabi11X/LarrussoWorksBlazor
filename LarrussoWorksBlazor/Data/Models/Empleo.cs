using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Data.Models
{
    public class Empleo
    {
        public Empleo()
        {
            Mensajes = new HashSet<Mensaje>();
            IdCategoria = -1;
            IdEmpresa = -1;
        }

        public int IdEmpleo { get; set; }
        public string NombreEmpleo { get; set; }
        public string DescripcionEmpleo { get; set; }
        public string RequisitosEmpleo { get; set; }
        public string PrestacionesEmpleo { get; set; }
        public string UbicacionEmpleo { get; set; }
        public string ImagenEmpleo { get; set; }
        public int IdCategoria { get; set; }
        public int IdEmpresa { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<Mensaje> Mensajes { get; set; }

        public string GetNameCategoria(IList<Categoria> categorias)
        {
            string nombreCate = categorias.Where(c => c.IdCategoria == IdCategoria).Select(c => c.NombreCategoria).FirstOrDefault();
            return nombreCate;
        }

        public string GetNameEmpresa(IList<Empresa> empresas)
        {
            string nombreEmpresa = empresas.Where(c => c.IdEmpresa == IdEmpresa).Select(c => c.NombreEmpresa).FirstOrDefault();
            return nombreEmpresa;
        }

        public string GetMailEmpresa(IList<Empresa> empresas)
        {
            string mailEmpresa = empresas.Where(c => c.IdEmpresa == IdEmpresa).Select(c => c.CorreoEmpresa).FirstOrDefault();
            return mailEmpresa;
        }

        public string GetPhoneEmpresa(IList<Empresa> empresas)
        {
            string phoneEmpresa = empresas.Where(c => c.IdEmpresa == IdEmpresa).Select(c => c.TelefonoEmpresa).FirstOrDefault();
            return phoneEmpresa;
        }
    }
}
