namespace MiCrudApi.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Llave foránea
        public int CategoriaId { get; set; }
        // Propiedad de navegación
        public Categoria Categoria { get; set; }
    }
}