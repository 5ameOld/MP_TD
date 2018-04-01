using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class BaseRessourceEntity<TId> : BaseEntity<TId>
    {
        public decimal WoodCosts { get; set; }
        public decimal MetalCosts { get; set; }
        public decimal FoodCosts { get; set; }
    }
}
