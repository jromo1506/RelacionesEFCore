namespace PracticaRelaciones.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public List<AutorLibro> AutorLibro { get; set; }
    }
}
