using INDNZWalks.API.Models.Domain;

namespace INDNZWalks.Api.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}
