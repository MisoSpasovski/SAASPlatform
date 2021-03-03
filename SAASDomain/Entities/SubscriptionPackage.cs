using System;
using System.Collections.Generic;

namespace SAASDomain.Entities
{
    public class SubscriptionPackage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal MonthlyPrice { get; set; }
        public decimal YearlyPrice { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
    }
}
