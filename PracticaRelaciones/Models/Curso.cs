using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PracticaRelaciones.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public int IdEstudiante { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
