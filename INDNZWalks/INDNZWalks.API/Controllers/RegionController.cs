using AutoMapper;
using INDNZWalks.Api.Repositories;
using INDNZWalks.API.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace INDNZWalks.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RegionController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionController(IRegionRepository regionRepository , IMapper mapper) 
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        public IMapper Mapper { get; }

        [HttpGet]
        public async Task< IActionResult> GetAllRegions()
        {
           var regions= await regionRepository.GetAllAsync();
            //return DTO regions

            //var regionsDTO = new List<Models.DTO.Region>();

            //regions.ToList().ForEach(region =>
            //{ 
            //    var regionDTO = new Models.DTO.Region();
            //    {
            //        Id = region.Id;
            //        Code = region.Code;
            //        Name = region.Name;
            //        Area = region.Area;
            //        Lat = region.Lat;
            //        Long = region.Long;
            //        Population = region.Population;
            //    }
            //    regionsDTO.Add(regionDTO);
            //});

          var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }
    }
}
