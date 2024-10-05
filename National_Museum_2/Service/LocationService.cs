using National_Museum_2.Model;
using National_Museum_2.Repository;

namespace National_Museum_2.Service
{
    public interface ILocationService
    {
        Task<IEnumerable<Location>> GetAllLocationAsync();
        Task<Location> GetLocationByIdAsync(int id);
        Task CreateLocationAsync(Location location);
        Task UpdateLocationAsync(Location location);
        Task SoftDeleteLocationAsync(int id);
    }
    public class LocationService : ILocationService
    {
        public Task CreateLocationAsync(Location location)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>> GetAllLocationAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Location> GetLocationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteLocationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLocationAsync(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
