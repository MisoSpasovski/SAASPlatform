using Microsoft.EntityFrameworkCore;
using SAASDomain.Entities;
using SAASPersistenc.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAASRepository.Repositories.PlatfromPackages
{
    public class PlatfromPackagesRepository : IPlatfromPackagesRepository
    {
        private IApplicationDbContext _applicationDbContext;
        public PlatfromPackagesRepository(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<SubscriptionPackage> GetSubscriptionPackage(int regionId)
        {
            var subPackages = await _applicationDbContext.SubscriptionPackage
                .FirstOrDefaultAsync(x => x.RegionId == regionId);

            return subPackages;                 
        }
    }
}
