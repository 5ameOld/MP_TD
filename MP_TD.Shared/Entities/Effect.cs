using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class Effect : BaseEntity<int>
    {
        public string Name { get; set; }
        public decimal Duration { get; set; }
    }
}
