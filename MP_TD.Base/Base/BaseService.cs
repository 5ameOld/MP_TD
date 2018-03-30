using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP_TD.Base
{
    public class BaseService<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        protected BaseDepot<TEntity, TId> Depot;

        public TEntity GetById(TId id)
        {
            return Depot.GetById(id);
        }


    }
}
