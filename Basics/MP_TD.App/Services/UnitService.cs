using MP_TD.App.Depots;
using MP_TD.Base;
using MP_TD.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.App.Services
{
    public class UnitService : BaseService<Unit, UnitDepot, int>
    {
        public UnitService() : base()
        {
            
        }

        public List<Unit> GetAll()
        {
            return Depot.GetAll();
        }
    }
}
