
namespace gregsList.Models;

    public class House
    {
        public int Id { get; set; }
        public int? Bedrooms { get; set; }
        public double? Bathrooms { get; set; }
        public int? Price { get; set; }
        public bool IsHaunted { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
