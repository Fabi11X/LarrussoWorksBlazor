using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Data.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Empleos = new HashSet<Empleo>();
        }

        public int IdCategoria { get; set; }
        [Required]
        [StringLength(5, ErrorMessage = "El nombre de la categoria es muy largo")]
        public string? NombreCategoria { get; set; }

        public virtual ICollection<Empleo> Empleos { get; set; }
    }
}
