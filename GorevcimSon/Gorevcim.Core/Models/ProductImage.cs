using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public class ProductImage: BaseEntity
    {
        public string ImageName { get; set; }
        public string Base64Content { get; set; }
       
        public ICollection<ProductFeatures> ProductFeatures { get; set; }
    }
}
