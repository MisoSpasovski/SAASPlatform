using Microsoft.EntityFrameworkCore;
using SAASDomain.Entities;
using SAASPersistenc.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAASRepository.Repositories.PlatfromPackages
{
    public class UserRepository : IUserRepository
    {
        private IApplicationDbContext _applicationDbContext;
        public UserRepository(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<Region> GetRegion(Guid userId)
        {
            var region = await _applicationDbContext.User
                .Where(x=> x.Id == userId)
                .Select(x=>x.Country.Region)
                .FirstOrDefaultAsync();

            return region;        
        }
    }
}
