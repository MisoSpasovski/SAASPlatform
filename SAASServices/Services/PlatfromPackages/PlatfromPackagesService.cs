using SAASDomain.Entities;
using SAASPersistence.DataContracts;
using SAASRepository.Repositories.PlatfromPackages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAASServices.Services.PlatfromPackages
{
    public class PlatfromPackagesService : IPlatfromPackagesService
    {
        private IPlatfromPackagesRepository _platfromPackagesRepository;
        private IUserRepository _userRepository;

        public PlatfromPackagesService(IPlatfromPackagesRepository platfromPackagesRepository, IUserRepository userRepository)
        {
            _platfromPackagesRepository = platfromPackagesRepository;
            _userRepository = userRepository;
        }
               
        public async Task<RecommendedSubscription> GetRecommendedSubscription(Guid userId)
        {
            var response = new RecommendedSubscription();
            var region = await _userRepository.GetRegion(userId);

            var subPackage =  await _platfromPackagesRepository.GetSubscriptionPackage(region.Id);

            response.Id = subPackage.Id;
            response.Name = subPackage.Name;
            response.MonthlyPrice = subPackage.MonthlyPrice;
            response.YearlyPrice = subPackage.YearlyPrice;
            response.MonthlyPriceWithVat = (decimal)System.Math.Round((region.Vat / 100 * subPackage.MonthlyPrice) + subPackage.MonthlyPrice, 2); 
            response.YearlyPriceWithVat = (decimal)System.Math.Round((region.Vat / 100 * subPackage.YearlyPrice) + subPackage.YearlyPrice, 2);

            return response;
        }
    }
}
