﻿using Bookify.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Authorization
{
    internal sealed class AuthorizationService
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthorizationService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserRolesResponse> GetRolesForUserAsync(string identityId)
        {
            UserRolesResponse roles = await _dbContext.Set<User>()
           .Where(u => u.IdentityId == identityId)
           .Select(u => new UserRolesResponse
           {
               UserId = u.Id,
               Roles = u.Roles.ToList()
           })
           .FirstAsync();

            return roles;
        }
    }
}
