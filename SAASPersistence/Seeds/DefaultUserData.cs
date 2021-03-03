﻿using SAASDomain.Entities;
using System;
using System.Collections.Generic;

namespace SAASPersistence.Seeds
{
    public static class DefaultUserData
    {
        public static List<User> UserDataList()
        {
            return new List<User>
            {
                new User
                {
                    Id = new Guid("d194bda8-1ef1-4c7b-bfff-18bb30fd5eec"),
                    Name = "Miso Spasovski",
                    Email = "spasmiso@gmail.com",
                    CountryCode = "mk"
                },
                new User
                {
                     Id = new Guid("3b6c6c8b-7d7c-4ee4-90fd-11cbb15a4b18"),
                    Name = "John Doo",
                    Email = "john@gmail.com",
                    CountryCode = "ny"
                },
                new User
                {
                   Id = new Guid("a1980251-7113-49a1-ad15-c87a26ea70b4"),
                    Name = "Derek McCormack",
                    Email = "Derek@gmail.com",
                    CountryCode = "en"
                }
            };
        }
    }
}
