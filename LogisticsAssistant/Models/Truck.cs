using System.ComponentModel.DataAnnotations;

namespace LogisticsAssistant.Models
{
    public class Truck
    {
        public int Id { get; set; }
        [Required]
        public int truckId { get; set; }
        [Required]
        public int vMax { get; set; }
        [Required]
        public int breakRequired { get; set; }
    }
}
