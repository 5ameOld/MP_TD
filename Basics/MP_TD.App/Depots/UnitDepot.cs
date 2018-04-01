using MP_TD.Base;
using MP_TD.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MP_TD.App.Depots
{
    public class UnitDepot : BaseDepot<Unit, int>
    {
        public List<Unit> GetAll()
        {
            return Database.Fetch<Unit>(GetBaseSelectSql());
        }
    }
}
