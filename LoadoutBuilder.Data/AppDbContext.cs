using LoadoutBuilder.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WeaponSlot>()
                .HasKey(ws => new { ws.SlotNumber, ws.LoadoutId });

            modelBuilder.Entity<SightCategory>()
                .HasKey(sc => new {sc.SightId, sc.CotegoryId});

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Assault Rifle" },
                new Category { Id = 2, Name = "SMG" },
                new Category { Id = 3, Name = "Sniper Rifle" }
            );

            modelBuilder.Entity<Camo>().HasData(
                new Camo
                {
                    Id = 1,
                    Name = "Default",
                    Description = "Default weapon appearance",
                    IsDeleted = false
                },
                new Camo
                {
                    Id = 2,
                    Name = "Forest",
                    Description = "Forest camouflage",
                    IsDeleted = false
                },
                new Camo
                {
                    Id = 3,
                    Name = "Desert",
                    Description = "Desert camouflage",
                    IsDeleted = false
                }
            );

            modelBuilder.Entity<Sight>().HasData(
                new Sight
                {
                    Id = 1,
                    Type = "Red Dot",
                    Range = LoadoutBuilder.Data.Models.Range.Short,
                    IsDeleted = false
                },
                new Sight
                {
                    Id = 2,
                    Type = "Holographic",
                    Range = LoadoutBuilder.Data.Models.Range.Medium,
                    IsDeleted = false
                },
                new Sight
                {
                    Id = 3,
                    Type = "Sniper Scope",
                    Range = LoadoutBuilder.Data.Models.Range.Long,
                    IsDeleted = false
                }
            );

            modelBuilder.Entity<Weapon>().HasData(
                new Weapon
                {
                    Id = 1,
                    Name = "M4",
                    Description = "Assault rifle",
                    CotegoryId = 1,
                    IsDeleted = false
                },
                new Weapon
                {
                    Id = 2,
                    Name = "MP5",
                    Description = "Submachine gun",
                    CotegoryId = 2,
                    IsDeleted = false
                },
                new Weapon
                {
                    Id = 3,
                    Name = "AWP",
                    Description = "Sniper rifle",
                    CotegoryId = 3,
                    IsDeleted = false
                }
            );

            modelBuilder.Entity<SightCategory>().HasData(
                new SightCategory { SightId = 1, CotegoryId = 1 },
                new SightCategory { SightId = 1, CotegoryId = 2 },
                new SightCategory { SightId = 2, CotegoryId = 1 },
                new SightCategory { SightId = 2, CotegoryId = 2 },
                new SightCategory { SightId = 3, CotegoryId = 3 }
            );
        }
        public DbSet<Loadout> Loadouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Camo> Camos { get; set; }
        public DbSet<WeaponSlot> WeaponSlots { get; set; }
    }
}
