using MP_TD.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MP_TD.Shared.Entities
{
    public class Unit : BaseRessourceEntity<int>
    {
        public string Name { get; set; }
        public decimal HitPoints { get; set; }
        public decimal Damage { get; set; }
        public string DamageTypeId { get; set; }
        public string EffectId { get; set; }
        public decimal Range { get; set; }
        public decimal Speed { get; set; }
        public decimal Armor { get; set; }
        public decimal Penetration { get; set; }
        public bool AttackTurrets { get; set; }
        public string AbilityId { get; set; }
    }
}
