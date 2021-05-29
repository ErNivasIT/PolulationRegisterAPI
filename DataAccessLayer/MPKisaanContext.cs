using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccessLayer
{
    public partial class MPKisaanContext : DbContext
    {
        public MPKisaanContext()
        {
        }

        public MPKisaanContext(DbContextOptions<MPKisaanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=PopulationConnectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Persons", "PopulationRegister");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedBy).HasColumnName("Added_By");

                entity.Property(e => e.AddedByIp)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("Added_By_IP");

                entity.Property(e => e.AddedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_On");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Father_Name");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("First_Name");

                entity.Property(e => e.GenderId).HasColumnName("Gender_ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Middle_Name");

                entity.Property(e => e.MotherName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Mother_Name");
            });

            modelBuilder.Entity<PersonAddress>(entity =>
            {
                entity.ToTable("Person_Address", "PopulationRegister");

                entity.HasIndex(e => e.MobileNumber, "IX_Person_Address")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedBy).HasColumnName("Added_By");

                entity.Property(e => e.AddedByIp)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("Added_By_IP");

                entity.Property(e => e.AddedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_On");

                entity.Property(e => e.BlockId).HasColumnName("Block_ID");

                entity.Property(e => e.DistrictId).HasColumnName("District_ID");

                entity.Property(e => e.GpZoneId).HasColumnName("GP_Zone_ID");

                entity.Property(e => e.HouseAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("House_Address");

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_Number");

                entity.Property(e => e.PersonId).HasColumnName("Person_ID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.PinCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PIN_Code");

                entity.Property(e => e.VillageWardId).HasColumnName("Village_Ward_ID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.InversePerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_Address_Person_Address");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
