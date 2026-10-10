using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApplication15.Models;

namespace WebApplication15.Data;

public class AppDbContext : DbContext
    {
        public DbSet<UserViewModel> Users { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public static void SeedData(AppDbContext context)
        {
            context.Database.EnsureCreated();
            
            foreach (var contextUser in context.Users)
            {
                context.Users.Remove(contextUser);
            }
            
            context.Users.AddRange(
                new UserViewModel
                {
                    Nickname = "Name 1",
                    Status = "Backend dev",
                    BirthDate = new DateTime(1998, 5, 14),
                    RegistrationDate = new DateTime(2023, 1, 15),
                    LastLoginDate = DateTime.UtcNow.AddMinutes(-15),
                    AvatarUrl = "https://images.unsplash.com/photo-1535713875002-d1d0cf377fde?auto=format&fit=crop&w=150&q=80"
                },
                new UserViewModel
                {
                    Nickname = "Name 2",
                    Status = "Frontend dev",
                    BirthDate = new DateTime(2001, 9, 22),
                    RegistrationDate = new DateTime(2023, 5, 10),
                    LastLoginDate = DateTime.UtcNow.AddHours(-2),
                    AvatarUrl = "https://images.unsplash.com/photo-1494790108377-be9c29b29330?auto=format&fit=crop&w=150&q=80"
                },
                new UserViewModel
                {
                    Nickname = "Name 3",
                    Status = "DevOps️",
                    BirthDate = new DateTime(1995, 12, 3),
                    RegistrationDate = new DateTime(2022, 11, 1),
                    LastLoginDate = DateTime.UtcNow.AddDays(-1),
                    AvatarUrl = "https://images.unsplash.com/photo-1570295999919-56ceb5ecca61?auto=format&fit=crop&w=150&q=80"
                }
            );
            context.SaveChanges();
            
        }
    }