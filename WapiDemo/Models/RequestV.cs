using System.ComponentModel.DataAnnotations;

namespace WapiDemo.Models
{
    public class RequestV
    {
        public string Language { get; set; } 
        [Required]
        public string Text { get; set; } 
    }
}
