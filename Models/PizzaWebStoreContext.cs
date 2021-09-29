using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PizzaApplication.Models
{
    public partial class PizzaWebStoreContext : DbContext
    {
        public PizzaWebStoreContext()
        {
        }

        public PizzaWebStoreContext(DbContextOptions<PizzaWebStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }
        public virtual DbSet<ToppinngDetail> ToppinngDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source=DESKTOP-AALMCVF\\SQLSERVER2019G3; Integrated Security=true;Initial catalog=PizzaWebStore");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.DeliveryCharge).HasColumnName("Delivery_Charge");

                entity.Property(e => e.Status)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__User_Id__3E52440B");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Order_De__3FB50874B49E5AD0");

                entity.ToTable("Order_Details");

                entity.Property(e => e.ItemId).HasColumnName("Item_Id");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_Id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Order_Det__Order__412EB0B6");

                entity.HasOne(d => d.Pizza)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK__Order_Det__Pizza__4222D4EF");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("Pizza");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_Id");

                entity.Property(e => e.IsVeg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("isVeg");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Speciality)
                    .HasMaxLength(40)
                    .IsUnicode(false);
                entity.Property(e => e.Imageurl)
                .HasMaxLength(40)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Topping>(entity =>
            {
                entity.Property(e => e.ToppingId).HasColumnName("Topping_Id");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToppinngDetail>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ToppingId })
                    .HasName("PK__Toppinng__FFA5DE0E7492E33D");

                entity.ToTable("Toppinng_Details");

                entity.Property(e => e.ItemId).HasColumnName("Item_Id");

                entity.Property(e => e.ToppingId).HasColumnName("Topping_Id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ToppinngDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Toppinng___Item___44FF419A");

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.ToppinngDetails)
                    .HasForeignKey(d => d.ToppingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Toppinng___Toppi__45F365D3");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserEmail)
                    .HasName("PK__Users__EB5FD347AE747201");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("User_email");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
