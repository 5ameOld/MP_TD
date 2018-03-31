using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class BuildingUnit : BaseEntity<int>
    {
        public int UnitId { get; set; }
        public int BuildingId { get; set; }
    }
}
