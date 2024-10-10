﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using National_Museum_2.Context;
using National_Museum_2.Model;

namespace National_Museum_2.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(int id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task SoftDeleteUserAsync(int id);
        Task<bool> ValidateUserAsync(string email, string password);
    }

    public class UserRepository : IUserRepository
    {
        private readonly MuseumDbContext _context;

        public UserRepository(MuseumDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            // Agregar el objeto al contexto
            _context.user.Add(user);

            // Guardar cambios en la base de datos
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await _context.user
            .Where(s => !s.IsDeleted)
            .ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.user
            .FirstOrDefaultAsync(s => s.userId == id && !s.IsDeleted);
        }

        public async Task SoftDeleteUserAsync(int id)
        {
            var user = await _context.user.FindAsync(id);
            if (user != null)
            {
                user.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateUserAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var existingUser = await _context.user.FindAsync(user.userId);
            if (existingUser == null)
                throw new ArgumentException($"user with ID {user.userId} not found");

            // Actualizar las propiedades del objeto existente
            existingUser.user_Type_Id = user.user_Type_Id;
            existingUser.identificationType_Id = user.identificationType_Id;
            existingUser.identificationNumber = user.identificationNumber;
            existingUser.names = user.names;
            existingUser.lastNames = user.lastNames;
            existingUser.birthDate = user.birthDate;
            existingUser.contact = user.contact;
            existingUser.gender_Id = user.gender_Id;
            existingUser.email = user.email;
            existingUser.password = user.password;

            await _context.SaveChangesAsync();
        }

        public async Task<bool> ValidateUserAsync(string email, string password)
        {
            var passwordHasher = new PasswordHasher<User>();

            var user = await _context.user.FirstOrDefaultAsync(u => u.email == email);

            if (user == null) 
                return false;

            var userVerification = passwordHasher.VerifyHashedPassword(user, user.password, password);
            
            if (userVerification == PasswordVerificationResult.Success) return true;

            return false;
        }
    }
}
