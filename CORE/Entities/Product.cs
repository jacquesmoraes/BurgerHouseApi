
namespace CORE.Entities
{
    public class Product : BaseEntity
    {
     
        public string PdoductName { get; set; }
                
        public string  Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal  Price { get; set; }

        public virtual Category Category { get; set; }

        public int CategoryId { get; set; }


    }
}
