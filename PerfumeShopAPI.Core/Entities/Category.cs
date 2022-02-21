using System.ComponentModel.DataAnnotations;

namespace PerfumeShopAPI.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}