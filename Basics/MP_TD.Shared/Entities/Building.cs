using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class Building : BaseRessourceEntity<int>
    {
        public string Name { get; set; }
        public int BuildingSteps { get; set; }
        public decimal UnitsPerStep { get; set; }
        public string BuildingTypeId { get; set; }
    }
}
