using MP_TD.Base;
using MP_TD.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.App.Depots
{
    public class BuildingDepot : BaseDepot<Building, int>
    {
        public List<Building> GetAll()
        {
            return Database.Fetch<Building>(GetBaseSelectSql());
        }
    }
}
