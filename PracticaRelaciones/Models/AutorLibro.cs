using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaRelaciones.Models
{
    public class AutorLibro
    {
        public int Id { get; set; }
        public int IdLibro { get; set; }
        public int IdAutor { get; set; }

        public Autor Autor { get; set; }
        public Libro Libro { get; set; }

    }
}
