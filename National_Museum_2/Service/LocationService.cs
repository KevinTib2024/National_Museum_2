﻿using National_Museum_2.Model;
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
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        public async Task CreateLocationAsync(Location location)
        {
            await _locationRepository.CreateLocationAsync(location);
        }

        public async Task<IEnumerable<Location>> GetAllLocationAsync()
        {
            return await _locationRepository.GetAllLocationAsync();
        }

        public async Task<Location> GetLocationByIdAsync(int id)
        {
            return await _locationRepository.GetLocationByIdAsync(id);
        }

        public async Task SoftDeleteLocationAsync(int id)
        {
            await _locationRepository.SoftDeleteLocationAsync(id);
        }

        public async Task UpdateLocationAsync(Location location)
        {
            await _locationRepository.UpdateLocationAsync(location);
        }
    }
}
