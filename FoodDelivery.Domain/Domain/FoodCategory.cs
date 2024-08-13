using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Domain
{
    public class FoodCategory 
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        //public virtual ICollection<FoodCategoryInFood>? FoodCategoryInFoods{ get; set; }
    }
}
