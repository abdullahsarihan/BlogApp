﻿using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=DESKTOP-GCKQC5T\\SQLEXPRESS;database=BlogApiDb; integrated security=true; TrustServerCertificate=True;");
    }
    public DbSet<Employee> Employees { get; set; }
}
