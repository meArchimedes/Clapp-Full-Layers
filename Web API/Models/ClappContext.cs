using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web_API.Models
{
    public partial class ClappContext : DbContext
    {
        public ClappContext()
        {
        }

        public ClappContext(DbContextOptions<ClappContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<CheckingAccount> CheckingAccounts { get; set; } = null!;
        public virtual DbSet<Cleaner> Cleaners { get; set; } = null!;
        public virtual DbSet<CleanerBankDetail> CleanerBankDetails { get; set; } = null!;
        public virtual DbSet<CreditCard> CreditCards { get; set; } = null!;
        public virtual DbSet<GooglePay> GooglePays { get; set; } = null!;
        public virtual DbSet<Housekeeper> Housekeepers { get; set; } = null!;
        public virtual DbSet<PayPal> PayPals { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Documents\\WebAPI\\Clapp Full Layers\\DB\\CleanApp.mdf\";Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.AddressId).ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(50)
                    .HasColumnName("Address line 1");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .HasColumnName("Address line 2");

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .HasColumnName("zip");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Address__UserCod__10566F31");
            });

            modelBuilder.Entity<CheckingAccount>(entity =>
            {
                entity.ToTable("Checking Account");

                entity.Property(e => e.CheckingAccountId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cleaner>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.BankDetails)
                    .WithMany(p => p.Cleaners)
                    .HasForeignKey(d => d.BankDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cleaners__BankDe__395884C4");
            });

            modelBuilder.Entity<CleanerBankDetail>(entity =>
            {
                entity.HasKey(e => e.BankDetailsId);

                entity.Property(e => e.BankDetailsId).ValueGeneratedNever();

                entity.Property(e => e.AccountName).HasMaxLength(50);

                entity.Property(e => e.Bank).HasMaxLength(50);
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.ToTable("CreditCard");

                entity.Property(e => e.CreditCardId).ValueGeneratedNever();

                entity.Property(e => e.CardHolder).HasMaxLength(30);

                entity.Property(e => e.Cvv)
                    .HasMaxLength(3)
                    .HasColumnName("cvv")
                    .IsFixedLength();

                entity.Property(e => e.Exp)
                    .HasColumnType("date")
                    .HasColumnName("exp");
            });

            modelBuilder.Entity<GooglePay>(entity =>
            {
                entity.ToTable("Google Pay");

                entity.Property(e => e.GooglePayId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Housekeeper>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Housekeepers)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK__Housekeep__Payme__37703C52");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Housekeepers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Housekeep__UserC__123EB7A3");
            });

            modelBuilder.Entity<PayPal>(entity =>
            {
                entity.ToTable("PayPal");

                entity.Property(e => e.PayPalId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("Payment Methods");

                entity.Property(e => e.PaymentMethodId).ValueGeneratedNever();

                entity.HasOne(d => d.CreditCard)
                    .WithMany(p => p.PaymentMethods)
                    .HasForeignKey(d => d.CreditCardId)
                    .HasConstraintName("FK__Payment M__Credi__1BC821DD");

                entity.HasOne(d => d.GooglePay)
                    .WithMany(p => p.PaymentMethods)
                    .HasForeignKey(d => d.GooglePayId)
                    .HasConstraintName("FK__Payment M__Googl__30C33EC3");

                entity.HasOne(d => d.PayPal)
                    .WithMany(p => p.PaymentMethods)
                    .HasForeignKey(d => d.PayPalId)
                    .HasConstraintName("FK__Payment M__PayPa__31B762FC");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__AddressId__0F624AF8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
