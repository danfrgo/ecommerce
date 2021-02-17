namespace API.Dtos
{
    public class ProductToReturnDto
    {
        // dtos para mover dados entre ecras

        public int Id { get; set; }
      
      
         public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        
        // relationships
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
    }
}