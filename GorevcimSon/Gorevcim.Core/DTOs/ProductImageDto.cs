using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.DTOs
{
    public class ProductImageDto:BaseDto
    {
        public string ImageName { get; set; }
        public string LogoBase64Content { get; set; }

        public string FilePath { get; set; }

    }
}
