using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.DTOs
{
    public class ProductProjectsDto :BaseDto
    {
        public string Name { get; set; }    
        public string ShortCode  { get; set; }
        public string Explanation { get; set; }
    }
}
