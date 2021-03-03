using SAASDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAASRepository.Repositories.PlatfromPackages
{
    public interface IPlatfromPackagesRepository
    {
        Task<SubscriptionPackage> GetSubscriptionPackage(int regionId);
    }
}
