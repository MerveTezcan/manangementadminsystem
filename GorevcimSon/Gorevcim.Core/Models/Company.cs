using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public class Company:BaseCompany
    {
        public string Name { get; set; }
        public ICollection<BranchOffice> BranchOffice { get; set; }
        public ICollection<CompanyDealer> CompanyDealer { get; set; }
    }
}
