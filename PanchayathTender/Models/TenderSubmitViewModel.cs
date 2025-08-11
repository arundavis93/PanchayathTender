using System.ComponentModel.DataAnnotations;

namespace PanchayathTender.Models
{
    public class TenderSubmitViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        [Display(Name = "Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Project code is required")]
        [StringLength(50, ErrorMessage = "Project code cannot be longer than 50 characters")]
        [Display(Name = "Project Code")]
        public string ProjectCode { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Tender details are required")]
        [StringLength(2000, ErrorMessage = "Details cannot be longer than 2000 characters")]
        [Display(Name = "Tender Details")]
        public string Details { get; set; }
    }
}
