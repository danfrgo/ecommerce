namespace Core.Entities
{
    public class Product : BaseEntity
    {
        //
        // o Id do produto será herdado do BaseEntity
        //
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureURL { get; set; }
        
        // relationships
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
    }
}