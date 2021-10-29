using AimsCarRentals.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AimsCarRentals.Context
{
    public class AimsDbContext : DbContext
    {
        public AimsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Id).IsRequired();
            modelBuilder.Entity<Role>().HasIndex(u => u.Id).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Category>().HasKey(s => s.Id);
            modelBuilder.Entity<Branch>().HasKey(s => s.Id);
            modelBuilder.Entity<Bookings>().HasKey(s => s.Id);
            modelBuilder.Entity<Car>().HasKey(s => s.Id);
            modelBuilder.Entity<User>().Property(u => u.Email)
                .IsRequired();
            modelBuilder.Entity<UserRole>().HasKey(ur => ur.Id);
            modelBuilder.Entity<User>().HasMany(u => u.UserRoles).WithOne(ur => ur.User).HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<Role>().HasMany(r => r.UserRoles).WithOne(ur => ur.Role).HasForeignKey(ur => ur.RoleId);
           modelBuilder.Entity<UserRole>().HasIndex(U => U.UserId);
            modelBuilder.Entity<UserRole>().HasIndex(u => u.RoleId);
            modelBuilder.Entity<User>().HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(ur => ur.UserId);
            modelBuilder.Entity<Role>().HasMany(r => r.UserRoles)
                .WithOne(r => r.Role)
                .HasForeignKey(r => r.RoleId);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    PasswordHash = "Pq0zPzvnkKkIoa5prU80VcV6+i9BF1RhDTnDyuF7FMs=",
                    HashSalt = "ftuIrIDS+TJqDpa0wGVv1w==",
                    Email = "jafar@gmail.com",
                      FirstName = "Jafar",
                      MiddleName = "Okiki",
                      LastName = "Lawal",
                      Gender = "Male",
                      DateOfBirth = DateTime.Now,
                      PhoneNo = "09071681776",
                      Address = "asd",
                }

               ) ; 
            modelBuilder.Entity<Role>().HasData(
             new Role { Id = 1, Name = "SuperAdmin", CreatedAt = DateTime.Now }, new Role { Id = 2, Name = "Admin", CreatedAt = DateTime.Now }, new Role { Id = 3, Name = "Customer", CreatedAt = DateTime.Now }
            );
            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 1, UserId = 1, RoleId = 1, CreatedAt = DateTime.Now });

            base.OnModelCreating(modelBuilder);
        }
    }
}
