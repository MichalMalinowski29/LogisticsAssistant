using System.ComponentModel.DataAnnotations;
namespace LogisticsAssistant.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime departureStart { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime departureEnd { get; set; }
        public decimal roadLength { get; set; }
        public int truckId { get; set; }
        public string? details { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? scheduleCreatedAt { get; set; }
    }
}
