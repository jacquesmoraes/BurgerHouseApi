using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Entities
{
    public class Product : BaseEntity
    {
     
        public string PdoductName { get; set; }
                
        public string  Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal  Price { get; set; }

        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }

        public Category ProductCategory { get; set; }

        public int ProductCategoryId { get; set; }


    }
}
