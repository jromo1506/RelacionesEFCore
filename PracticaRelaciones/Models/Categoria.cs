using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace PracticaRelaciones.Models;

public class Categoria
{
    [Key]
    public int Id { get; set; }
    public ICollection<Producto> Productos { get; set; }
}
