
namespace CORE.Entities
{
    public class Product : BaseEntity
    {
      
        public string ProductName { get; set; }
                
        public string  Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal  Price { get; set; }

        public  Category Category { get; set; }

        public int CategoryId { get; set; }


    }
}
