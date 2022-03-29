using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Data.Models
{
    public class Autenticacion
    {
        public int id { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Nivel { get; set; }
    }
}
