using Microsoft.EntityFrameworkCore;
using OrderAPizza_api.Models;

namespace OrderAPizza_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OpeningHour> OpeningHours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // table names

            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Address>().ToTable("addresses");
            modelBuilder.Entity<Group>().ToTable("groups");
            modelBuilder.Entity<Item>().ToTable("items");
            modelBuilder.Entity<Order>().ToTable("orders");
            modelBuilder.Entity<OrderItem>().ToTable("order_items");
            modelBuilder.Entity<OpeningHour>().ToTable("opening_hours");

            // users

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.FirstName).HasColumnName("first_name");
                entity.Property(e => e.LastName).HasColumnName("last_name");
                entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
                entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
                entity.Property(e => e.Role).HasColumnName("role");
                entity.Property(e => e.Points).HasColumnName("points");

                entity.HasMany(u => u.Addresses)
                      .WithOne(a => a.User)
                      .HasForeignKey(a => a.UsersId);

                entity.HasMany(u => u.Orders)
                      .WithOne(o => o.User)
                      .HasForeignKey(o => o.UsersId);

            });

            // addresses

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.UsersId).HasColumnName("users_id");
                entity.Property(e => e.City).HasColumnName("city");
                entity.Property(e => e.Street).HasColumnName("street");
                entity.Property(e => e.HouseNumber).HasColumnName("house_number");
                entity.Property(e => e.AddressNote).HasColumnName("address_note");

                entity.HasMany(a => a.Orders)
                      .WithOne(o => o.Address)
                      .HasForeignKey(o => o.AddressesId);
            });

            // groups

            modelBuilder.Entity<OrderAPizza_api.Models.Group>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");

                entity.HasMany(g => g.Items)
                      .WithOne(i => i.Group)
                      .HasForeignKey(i => i.GroupsId);
            });

            // items

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.GroupsId).HasColumnName("groups_id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Price).HasColumnName("price");
                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.HasMany(i => i.OrderItems)
                      .WithOne(oi => oi.Item)
                      .HasForeignKey(oi => oi.ItemsId);
            });

            // orders

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.UsersId).HasColumnName("users_id");
                entity.Property(e => e.AddressesId).HasColumnName("addresses_id");
                entity.Property(e => e.Status).HasColumnName("status");
                entity.Property(e => e.CreatedAt).HasColumnName("created_at");
                entity.Property(e => e.TotalPrice).HasColumnName("total_price");
                entity.Property(e => e.PointsGiven).HasColumnName("points_given");

                entity.HasMany(o => o.OrderItems)
                      .WithOne(oi => oi.Order)
                      .HasForeignKey(oi => oi.OrdersId);
            });

            // order items

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.OrdersId).HasColumnName("orders_id");
                entity.Property(e => e.ItemsId).HasColumnName("items_id");
                entity.Property(e => e.Quantity).HasColumnName("quantity");
                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");
            });

            // opening hours

            modelBuilder.Entity<OpeningHour>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.OpenTime).HasColumnName("open_time");
                entity.Property(e => e.CloseTime).HasColumnName("close_time");
            });
        }
    }
}
