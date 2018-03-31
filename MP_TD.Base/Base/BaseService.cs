using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Base
{
    public class BaseService<TEntity, TDepot, TId>
        where TEntity : BaseEntity<TId>
        where TDepot : BaseDepot<TEntity, TId>, new()
    {
        protected TDepot Depot;

        public BaseService()
        {
            Depot = new TDepot();
        }

        public TEntity GetById(TId id)
        {
            return Depot.GetById(id);
        }


    }
}
