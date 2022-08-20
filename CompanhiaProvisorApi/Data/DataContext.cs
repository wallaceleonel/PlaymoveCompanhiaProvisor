﻿using CompanhiaProvisorApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanhiaProvisorApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
}
