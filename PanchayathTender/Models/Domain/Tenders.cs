using System.ComponentModel.DataAnnotations;

namespace PanchayathTender.Models.Domain
{
    public class Tenders
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }

        
        public string ProjectCode { get; set; }

        
        public decimal Price { get; set; }

        
        public string Details { get; set; }
    }
}
