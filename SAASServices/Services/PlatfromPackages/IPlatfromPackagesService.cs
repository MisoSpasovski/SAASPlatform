using SAASDomain.Entities;
using SAASPersistence.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAASServices.Services.PlatfromPackages
{
    public interface IPlatfromPackagesService
    {
        Task<RecommendedSubscription> GetRecommendedSubscription(Guid userId);
    }
}
