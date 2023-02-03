using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public abstract class BaseCompany
    {
        public int Id { get; set; }
	public string Name{ get; set; }
        public string Description { get; set; } 
        public string Adress { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string Explanation { get; set; }
        public string CompanyWebUrl { get; set; }
        public string TaxNumber { get; set; }
        public string TaxAdministration { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoiceMailAddress { get; set; }
        public string CompanyType { get; set; }
    }
}
