namespace MiCrudApi.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        // Propiedad de navegación para los productos
        public ICollection<Producto> Productos { get; set; }
    }
}