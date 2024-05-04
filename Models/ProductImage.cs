namespace FiorelloSlider_OneToMany.Models
{
    public class ProductImage : BaseEntity
    {
        public string Name { get; set; }
        public bool IsMain { get; set; } = false;
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
