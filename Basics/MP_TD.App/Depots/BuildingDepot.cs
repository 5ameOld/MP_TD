using MP_TD.Base;
using MP_TD.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MP_TD.Shared.Views;
using NPoco;

namespace MP_TD.App.Depots
{
    public class BuildingDepot : BaseDepot<Building, int>
    {
        public List<Building> GetAll()
        {
            return Database.Fetch<Building>(GetBaseSelectSql());
        }

        public List<Building> GetBuildable()
        {
            return Database.Fetch<Building>(GetBaseSelectSql().Where("BuildingTypeId != @HQ", new { HQ = "HQ" }));
        }

        public BuildingView GetViewById(int id)
        {
            return Database.Fetch<BuildingView>(GetViewBaseSelectSql().Where("BU.Id = @Id", new { Id = id })).FirstOrDefault();
        }

        private Sql GetViewBaseSelectSql()
        {
            return Sql.Builder.Select("*").From(TableName + " AS BU")
                                          .InnerJoin("BuildingRessoures AS BR").On("BU.Id = BR.BuildingId");
        }
    }
}
