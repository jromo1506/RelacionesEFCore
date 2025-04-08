using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaRelaciones.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public int IdCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}
