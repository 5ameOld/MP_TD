using System;
using System.Collections.Generic;
using System.Text;

namespace MP_TD.Base
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public bool IsTransient => Id != null;
    }
}
