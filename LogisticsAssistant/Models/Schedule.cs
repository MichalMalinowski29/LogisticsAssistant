using System.ComponentModel.DataAnnotations;
namespace LogisticsAssistant.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime departureStart { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime departureEnd { get; set; }

        [Required]
        public decimal roadLength { get; set; }

        [Required]
        public int truckId { get; set; }

        [Required]
        public string? details { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? scheduleCreatedAt { get; set; }
    }
}
