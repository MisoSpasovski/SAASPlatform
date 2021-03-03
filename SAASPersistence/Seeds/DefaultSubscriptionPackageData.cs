using SAASDomain.Entities;
using System;
using System.Collections.Generic;

namespace SAASPersistence.Seeds
{
    public static class DefaultSubscriptionPackageData
    {
        public static List<SubscriptionPackage> SubscriptionPackageDataList()
        {
            return new List<SubscriptionPackage>
            {
                new SubscriptionPackage
                {
                    Id = new Guid("6317ce41-f6a2-48b8-833e-81c9b818cc41"),
                    Name = "Silver",
                    MonthlyPrice = 100,
                    YearlyPrice = 10000,
                    RegionId = 1
                },
                new SubscriptionPackage
                {
                     Id = new Guid("6a3b54cd-3348-48ec-b5e9-9d24e8ae7dc7"),
                    Name = "Platinum",
                     MonthlyPrice = 130,
                    YearlyPrice = 13000,
                    RegionId = 2
                },
                new SubscriptionPackage
                {
                   Id = new Guid("01349b68-b8d2-4643-ac15-c03b36d09155"),
                    Name = "Gold",
                    MonthlyPrice = 200,
                    YearlyPrice = 20000,
                    RegionId = 3
                }
            };
        }
    }
}
