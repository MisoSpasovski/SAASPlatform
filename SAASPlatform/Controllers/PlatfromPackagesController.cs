using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SAASDomain.Entities;
using SAASPersistence.DataContracts;
using SAASRepository.Repositories.PlatfromPackages;
using SAASServices.Services.PlatfromPackages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAASPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatfromPackagesController : ControllerBase
    {      

        private readonly ILogger<PlatfromPackagesController> _logger;
        private IPlatfromPackagesService _platfromPackagesService;

        public PlatfromPackagesController(ILogger<PlatfromPackagesController> logger, IPlatfromPackagesService platfromPackagesService)
        {
            _logger = logger;
            _platfromPackagesService = platfromPackagesService;
        }

        [HttpGet]
        public async Task<ActionResult<RecommendedSubscription>> RecommendPackage(Guid userId)
        {
            return await _platfromPackagesService.GetRecommendedSubscription(userId);           
        }
    }
}
