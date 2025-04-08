using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaRelaciones.Models
{
    public class DetallesEmpleado
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }

        public Empleado Empleado { get; set; }
    }
}
