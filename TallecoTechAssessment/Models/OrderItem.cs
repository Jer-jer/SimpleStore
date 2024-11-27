using System.ComponentModel.DataAnnotations;

namespace TallecoTechAssessment.Models
{
    public class OrderItem
    {
        public int id { get; set; }
        public decimal netCost { get; set; }
    }
}
