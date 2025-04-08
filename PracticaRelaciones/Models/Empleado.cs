using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaRelaciones.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public int IdDetallesEmpleado { get; set; }
        public DetallesEmpleado DetallesEmpelado { get; set; }
    }
}
