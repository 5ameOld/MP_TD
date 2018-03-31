using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class Ability : BaseEntity<string>
    {
        public string Name { get; set; }
        public decimal Cooldown { get; set; }
        public decimal Damage { get; set; }
        public string EffectId { get; set; }
        public string DamageTypeId { get; set; }
    }
}
