using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class BuildingRessources : BaseEntity<int>
    {
        public string RessourceId { get; set; }
        public int BuildingId { get; set; }
    }
}
