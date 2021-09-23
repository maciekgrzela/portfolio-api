﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Persistence.Context;

namespace Persistence.Seed
{
    public static class Seed
    {
        public static async Task SeedDataAsync(DataContext context, UserManager<User> manager, IConfiguration configuration)
        {
            if (!manager.Users.Any())
            {
                var user = new User
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Maciek",
                    LastName = "Grzela",
                    Email = "maciekgrzela45@gmail.com"
                };

                await manager.CreateAsync(user, configuration.GetSection("DefaultUsersCredentials").Value);
            }
        }
    }
}