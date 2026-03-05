using System.ComponentModel.DataAnnotations;

namespace Akses.App.Models
{
    public class CustomerVM
    {
        public int CustomerID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(11)]
        public string ContactNo { get; set; }
    }
}
