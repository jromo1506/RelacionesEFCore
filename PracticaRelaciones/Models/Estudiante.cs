using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaRelaciones.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Curso> Cursos {get;set; }
       

    }
}
