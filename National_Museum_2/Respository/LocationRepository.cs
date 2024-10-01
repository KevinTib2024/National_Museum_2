using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Respositoy
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAllLocationAsync();
        Task<Location> GetLocationByAsync(int id);
        Task CreateLocationAsync(Location location);
        Task UpdateLocationAsync(Location location);
        Task SoftDeleteLocationtAsync(int id);
    }
    public class LocationRepository : ILocationRepository
    {
        public Task CreateLocationAsync(Location location)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>> GetAllLocationAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Location> GetLocationByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteLocationtAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLocationAsync(Location location)
        {
            throw new NotImplementedException();
        }
    }
}