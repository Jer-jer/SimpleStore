using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TallecoTechAssessment.Models
{
    public class Product
    {
        public int product_id { get; set; }
        [Required] public string? product_name { get; set; }
        public decimal cost { get; set; }
    }
}
