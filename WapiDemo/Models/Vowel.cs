using System.ComponentModel.DataAnnotations;

namespace WapiDemo.Models
{
    public class Vowel
    {
        public string Language { get; set; } = "tr";
        [Required]
        public string Text { get; set; } 
    }
}
