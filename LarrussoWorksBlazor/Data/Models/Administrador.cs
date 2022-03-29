using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Data.Models
{
    public class Administrador
    {
        public int IdAdmin { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string NombreAdmin { get; set; }

        public string ApellidoAdmin { get; set; }

        public string SexoAdmin { get; set; }

        public string FechanacAdmin { get; set; }

        public string TelefonoAdmin { get; set; }

        public string CorreoAdmin { get; set; }

        public string ContrasenaAdmin { get; set; }

        public string DireccionAdmin { get; set; }

        public string FotografiaAdmin { get; set; }

        public string NivelAdmin { get; set; }
    }
}
