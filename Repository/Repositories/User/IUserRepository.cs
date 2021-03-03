using SAASDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAASRepository.Repositories.PlatfromPackages
{
    public interface IUserRepository
    {
        Task<Region> GetRegion(Guid userId);
    }
}
