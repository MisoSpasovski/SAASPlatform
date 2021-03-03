using SAASDomain.Entities;
using System.Collections.Generic;

namespace SAASPersistence.Seeds
{
    public static class DefaultCountryData
    {
        public static List<Country> CountryDataList()
        {
            return new List<Country>
            {
                 new Country
                 {
                     CountryCode = "mk",
                     CountryName = "Macedonia",
                     RegionId = 2
                 },
                 new Country
                 {
                    CountryCode = "ny",
                    CountryName = "New York",
                    RegionId = 3
                 },
                 new Country
                 {
                     CountryCode = "en",
                     CountryName = "England",
                     RegionId = 1
                 }
            };
        }
    }
}
