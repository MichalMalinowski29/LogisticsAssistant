using System.ComponentModel.DataAnnotations;

namespace LogisticsAssistant.Models
{
    public class Truck
    {
        public int Id { get; set; }
        public int truckId { get; set; }
        public int vMax { get; set; }
        public int breakRequired { get; set; }
    }
}
