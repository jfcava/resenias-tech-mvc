using System.ComponentModel;

namespace resenias_tech_mvc.Models
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public float Precio { get; set; }
    }
}
