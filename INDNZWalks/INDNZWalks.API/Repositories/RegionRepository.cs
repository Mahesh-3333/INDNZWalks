using INDNZWalks.API.Data;
using INDNZWalks.API.Models.Domain;

namespace INDNZWalks.Api.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private INDNZWalksDbContext iNDNZWalksDbContext;

        public RegionRepository(INDNZWalksDbContext iNDNZWalksDbContext) 
        {
            this.iNDNZWalksDbContext = iNDNZWalksDbContext;
        }
        public IEnumerable<Region> GetAll()
        {
            return iNDNZWalksDbContext.Regions.ToList();

        }
    }
}
