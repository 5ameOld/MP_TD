using MP_TD.App.Depots;
using MP_TD.Base;
using MP_TD.Shared.Entities;
using MP_TD.Shared.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.App.Services
{
    public class BuildingService : BaseService<Building, BuildingDepot, int>
    {
        public List<Building> GetAll()
        {
            return Depot.GetAll();
        }

        public List<Building> GetBuildable()
        {
            return Depot.GetBuildable();
        }

        public BuildingView GetViewById(int id)
        {
            return Depot.GetViewById(id);
        }
    }
}
