using System.ComponentModel.DataAnnotations.Schema;

namespace PetHouse.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductCategoriesId { get; set; }
        public ProductCategory ProductCategories { get; set; }
        public int Size { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Image { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public DateTime DateUpdate { get; set; }
        public int ApliedId { get; set; }
        public Aplied Aplieds { get; set; }
    }
}
