using Microsoft.EntityFrameworkCore;

namespace UserManagement.DBModels
{
    public class WinWinDBContext(DbContextOptions<WinWinDBContext> options) : DbContext(options)
    {
        /// <summary>
        /// 省份表
        /// </summary>
        public DbSet<Province> Provinces { get; set; }
        /// <summary>
        /// 地區表
        /// </summary>
        public DbSet<Location> Locations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// 建立關聯
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Province>(entity =>
            {
                entity.HasMany(a => a.Locations)
                    .WithOne(r => r.Province)
                    .HasForeignKey(a => a.ProvinceId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<User>(entity =>
            {
                entity.HasOne(a => a.Location)
                    .WithMany(r => r.Users)
                    .HasForeignKey(a => a.LocationId);
            });
        }
    }
}