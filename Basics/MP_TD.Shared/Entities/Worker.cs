using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class Worker : BaseEntity<int>
    {
        public decimal BuildingSpeed { get; set; }
    }
}
