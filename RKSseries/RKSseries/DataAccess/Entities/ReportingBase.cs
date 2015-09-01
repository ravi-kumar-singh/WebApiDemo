using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RKSseries.DataAccess.Entities
{
    public abstract class ReportingBase
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}