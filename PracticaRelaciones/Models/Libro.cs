namespace PracticaRelaciones.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public List<AutorLibro> AutorLibro { get; set; }
    }
}
