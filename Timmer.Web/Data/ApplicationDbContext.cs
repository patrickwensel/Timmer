using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Timmer.Web.Models;

namespace Timmer.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductLocation> ProductLocations { get; set; }
        public virtual DbSet<ProductMake> ProductMake { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Users

            const string StandardUserRoleID = "56e7b432-2e9d-4704-8b18-a4f8a2433147";
            const string AdminRoleID = "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18";

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = StandardUserRoleID,
                Name = "StandardUser",
                NormalizedName = "StandardUser"
            });


            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = AdminRoleID,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            string Admin1Guid = Guid.NewGuid().ToString();
            string Admin2Guid = Guid.NewGuid().ToString();
            string StandardUser1Guid = Guid.NewGuid().ToString();
            string StandardUser2Guid = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = Admin1Guid,
                UserName = "admin@timmer.com",
                NormalizedUserName = "admin@timmer.com",
                Email = "admin@timmer.com",
                NormalizedEmail = "admin@timmer.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@55word"),
                SecurityStamp = string.Empty
            });

            #endregion

            #region SeedData

            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { ProductCategoryID = 1, Name = "Tractors" });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { ProductCategoryID = 2, Name = "Harvest Equipment" });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { ProductCategoryID = 3, Name = "Planting Equipment" });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { ProductCategoryID = 4, Name = "Tillage Equipment" });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { ProductCategoryID = 5, Name = "Hay and Forage Equipment" });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { ProductCategoryID = 6, Name = "Chemical Applicators" });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { ProductCategoryID = 7, Name = "Skid Steers" });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { ProductCategoryID = 8, Name = "Mini Excavartors" });

            modelBuilder.Entity<ProductLocation>().HasData(new ProductLocation { ProductLocationID = 1, Name = "Aitkin" });
            modelBuilder.Entity<ProductLocation>().HasData(new ProductLocation { ProductLocationID = 2, Name = "Pease" });

            modelBuilder.Entity<ProductMake>().HasData(new ProductMake { ProductMakeID = 1, Name = "Case" });
            modelBuilder.Entity<ProductMake>().HasData(new ProductMake { ProductMakeID = 2, Name = "New Holland" });
            modelBuilder.Entity<ProductMake>().HasData(new ProductMake { ProductMakeID = 3, Name = "John Deere" });
            modelBuilder.Entity<ProductMake>().HasData(new ProductMake { ProductMakeID = 4, Name = "Ford" });
            modelBuilder.Entity<ProductMake>().HasData(new ProductMake { ProductMakeID = 5, Name = "Allis-Chalmers" });
            modelBuilder.Entity<ProductMake>().HasData(new ProductMake { ProductMakeID = 6, Name = "International" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 1,
                ProductCategoryID = 1,
                ProductLocationID = 1,
                ProductMakeID = 2,
                Model = "T7.245",
                Image = "https://media.sandhills.com/img.axd?id=4129650021&wid=4326205933&rwl=False&p=&ext=&w=500&h=375&t=&lp=TH&c=True&wt=False&sz=Max&rt=0&checksum=OTHmW%2bJcC744MSwlghua8l5qgov4SDlkUwyvJA1pyYg%3d"
            });



            #endregion

            base.OnModelCreating(modelBuilder);
        }

    }
}
