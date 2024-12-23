﻿using Infrastructure.Configurations.Map;

using Microsoft.EntityFrameworkCore;

namespace BlazorAndFluxorCrud.Model;

public class AppDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ItemConfiguration());
    }
}