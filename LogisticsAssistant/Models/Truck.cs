using System.ComponentModel.DataAnnotations;

namespace LogisticsAssistant.Models
{
    public class Truck
    {
        public int Id { get; set; }
        public int Vmax { get; set; }
        public int BreakRequired { get; set; }
    }
}
