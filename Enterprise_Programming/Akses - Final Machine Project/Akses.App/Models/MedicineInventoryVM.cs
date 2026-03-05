using System.ComponentModel.DataAnnotations;

namespace Akses.App.Models
{
    public class MedicineInventoryVM
    {
        public int MedicineID { get; set; }
        public int? Quantity { get; set; }
        [Required]
        [Display(Name = "Medicine Name")]
        [MinLength(4)]
        [MaxLength(50)]
        public string? MedicineName { get; set; }

        public DateTime? MFGDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public decimal? Price { get; set; }
    }
}
