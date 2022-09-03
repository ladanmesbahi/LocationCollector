using System.ComponentModel.DataAnnotations;

namespace LocationCollector.Core.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int PersonalCode { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
