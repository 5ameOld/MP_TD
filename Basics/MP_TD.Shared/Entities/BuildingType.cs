using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class BuildingType : BaseEntity<string>
    {
        public string Name { get; set; }
    }
}
