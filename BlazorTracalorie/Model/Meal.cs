using System.ComponentModel.DataAnnotations;

namespace BlazorTracalorie.Model
{
    public class Meal
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }        
        public string Calories { get; set; }
    }
}
