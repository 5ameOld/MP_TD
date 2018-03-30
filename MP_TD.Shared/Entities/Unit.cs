using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class Unit : BaseEntity<int>
    {
        public string Name { get; set; }
        public decimal HitPoints { get; set; }
        public decimal Damage { get; set; }
        public DamageType DamageType { get; set; }
        public Effect Effect { get; set; }
        public decimal Range { get; set; }
        public decimal Speed { get; set; }
        public decimal Costs { get; set; }
        public string Armor { get; set; }
        public decimal Penetration { get; set; }
        public bool AttackTurrets { get; set; }
    }
}
