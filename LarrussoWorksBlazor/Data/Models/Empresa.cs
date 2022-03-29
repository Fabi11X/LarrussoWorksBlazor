using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Data.Models
{
    public class Empresa
    {
        public Empresa()
        {
            Empleos = new HashSet<Empleo>();
            MensajesEmpresas = new HashSet<MensajesEmpresa>();
        }

        public int IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string LogoEmpresa { get; set; }
        public string DescripcionEmpresa { get; set; }
        public string UbicacionEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string CorreoEmpresa { get; set; }
        public string ContrasenaEmpresa { get; set; }
        public string NivelEmpresa { get; set; }

        public virtual ICollection<Empleo> Empleos { get; set; }
        public virtual ICollection<MensajesEmpresa> MensajesEmpresas { get; set; }

    }
}
