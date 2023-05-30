﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ReactAuthDemo.Data
{
    public class AuthDemoDataContextFactory : IDesignTimeDbContextFactory<AuthDemoDataContext>
    {
        public AuthDemoDataContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}ReactAuthDemo.Web"))
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true).Build();

            return new AuthDemoDataContext(config.GetConnectionString("ConStr"));
        }
    }
}
