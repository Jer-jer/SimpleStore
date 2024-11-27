using System.ComponentModel.DataAnnotations;

namespace TallecoTechAssessment.Models
{
    public class Order
    {
        public int id { get; set; }
        [Required] public List<OrderItem>? Items { get; set; }

        public decimal netPrice => Items != null ? Items.Sum(item => item.netCost) : 0;
    }
}
