using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace App.Entity
{
    public partial class ConAppContext : DbContext
    {
        public ConAppContext()
        {
        }

        public ConAppContext(DbContextOptions<ConAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserToken> UserToken { get; set; }
        public virtual DbSet<tbl_apartment> tbl_apartment { get; set; }
        public virtual DbSet<tbl_beneficiary> tbl_beneficiary { get; set; }
        public virtual DbSet<tbl_beneficiary_choice_map> tbl_beneficiary_choice_map { get; set; }
        public virtual DbSet<tbl_condominium> tbl_condominium { get; set; }
        public virtual DbSet<tbl_masterfields> tbl_masterfields { get; set; }
        public virtual DbSet<tbl_mastertype> tbl_mastertype { get; set; }
        public virtual DbSet<tbl_mastertype_supplier_map> tbl_mastertype_supplier_map { get; set; }
        public virtual DbSet<tbl_mastertypefields> tbl_mastertypefields { get; set; }
        public virtual DbSet<tbl_pages> tbl_pages { get; set; }
        public virtual DbSet<tbl_role> tbl_role { get; set; }
        public virtual DbSet<tbl_role_page> tbl_role_page { get; set; }
        public virtual DbSet<tbl_suppliers> tbl_suppliers { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SQL5103.site4now.net,1433;Database=db_a67321_constructionapp;UID=db_a67321_constructionapp_admin;PWD=Construction@4321;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.Property(e => e.ExpiresOn).HasColumnType("datetime");

                entity.Property(e => e.IssuedOn).HasColumnType("datetime");

                entity.Property(e => e.Token).HasMaxLength(500);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserToken)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserToken__UserI__4E88ABD4");
            });

            modelBuilder.Entity<tbl_apartment>(entity =>
            {
                entity.Property(e => e.area).HasMaxLength(50);

                entity.Property(e => e.building).HasMaxLength(50);

                entity.Property(e => e.code).HasMaxLength(50);

                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.fixtures).HasMaxLength(50);

                entity.Property(e => e.floorplan).HasMaxLength(50);

                entity.Property(e => e.staircase).HasMaxLength(50);

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.HasOne(d => d.condominium)
                    .WithMany(p => p.tbl_apartment)
                    .HasForeignKey(d => d.condominiumid)
                    .HasConstraintName("FK_tbl_apartment_tbl_condominium");
            });

            modelBuilder.Entity<tbl_beneficiary>(entity =>
            {
                entity.Property(e => e.Parcel).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.Subdivision).HasMaxLength(50);

                entity.Property(e => e.building).HasMaxLength(50);

                entity.Property(e => e.cadastralcategory).HasMaxLength(50);

                entity.Property(e => e.clientid).HasMaxLength(50);

                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.email).HasMaxLength(50);

                entity.Property(e => e.firstname).HasMaxLength(50);

                entity.Property(e => e.interior).HasMaxLength(50);

                entity.Property(e => e.lastname).HasMaxLength(50);

                entity.Property(e => e.phone).HasMaxLength(50);

                entity.Property(e => e.sqm).HasMaxLength(50);

                entity.Property(e => e.staircase).HasMaxLength(50);

                entity.Property(e => e.taxcode).HasMaxLength(50);

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.HasOne(d => d.apartment)
                    .WithMany(p => p.tbl_beneficiary)
                    .HasForeignKey(d => d.apartmentid)
                    .HasConstraintName("FK_tbl_beneficiary_tbl_apartment");

                entity.HasOne(d => d.condominium)
                    .WithMany(p => p.tbl_beneficiary)
                    .HasForeignKey(d => d.condominiumid)
                    .HasConstraintName("FK__tbl_benef__condo__00200768");
            });

            modelBuilder.Entity<tbl_beneficiary_choice_map>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.HasOne(d => d.ben)
                    .WithMany(p => p.tbl_beneficiary_choice_map)
                    .HasForeignKey(d => d.ben_id)
                    .HasConstraintName("FK_tbl_beneficiary_choice_map_tbl_beneficiary");

                entity.HasOne(d => d.mastertype)
                    .WithMany(p => p.tbl_beneficiary_choice_map)
                    .HasForeignKey(d => d.mastertypeid)
                    .HasConstraintName("FK_tbl_beneficiary_choice_map_tbl_mastertype");
            });

            modelBuilder.Entity<tbl_condominium>(entity =>
            {
                entity.Property(e => e.address).HasMaxLength(50);

                entity.Property(e => e.administrator).HasMaxLength(50);

                entity.Property(e => e.buildings).HasMaxLength(50);

                entity.Property(e => e.condominium_name).HasMaxLength(50);

                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.lat).HasMaxLength(50);

                entity.Property(e => e.lng).HasMaxLength(50);

                entity.Property(e => e.location).HasMaxLength(50);

                entity.Property(e => e.taxcode).HasMaxLength(50);

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.Property(e => e.users).HasMaxLength(50);

                entity.Property(e => e.vatnumber).HasMaxLength(50);

                entity.Property(e => e.zip_code).HasMaxLength(50);
            });

            modelBuilder.Entity<tbl_masterfields>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.createddate1).HasColumnType("datetime");

                entity.Property(e => e.datatype).HasMaxLength(50);

                entity.Property(e => e.name).HasMaxLength(50);

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.Property(e => e.updateddate1).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_mastertype>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.description).HasMaxLength(50);

                entity.Property(e => e.updateddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_mastertype_supplier_map>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.HasOne(d => d.mastertype)
                    .WithMany(p => p.tbl_mastertype_supplier_map)
                    .HasForeignKey(d => d.mastertypeid)
                    .HasConstraintName("FK_tbl_mastertype_supplier_map_tbl_mastertype");

                entity.HasOne(d => d.supplier)
                    .WithMany(p => p.tbl_mastertype_supplier_map)
                    .HasForeignKey(d => d.supplierid)
                    .HasConstraintName("FK_tbl_mastertype_supplier_map_tbl_suppliers");
            });

            modelBuilder.Entity<tbl_mastertypefields>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.HasOne(d => d.masterfield)
                    .WithMany(p => p.tbl_mastertypefields)
                    .HasForeignKey(d => d.masterfieldid)
                    .HasConstraintName("FK_tbl_mastertypefields_tbl_masterfields");

                entity.HasOne(d => d.mastertype)
                    .WithMany(p => p.tbl_mastertypefields)
                    .HasForeignKey(d => d.mastertypeid)
                    .HasConstraintName("FK_tbl_mastertypefields_tbl_mastertype");
            });

            modelBuilder.Entity<tbl_pages>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.pagename).HasMaxLength(50);

                entity.Property(e => e.updateddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_role>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.rolename).HasMaxLength(50);

                entity.Property(e => e.updateddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_role_page>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.HasOne(d => d.page)
                    .WithMany(p => p.tbl_role_page)
                    .HasForeignKey(d => d.pageid)
                    .HasConstraintName("FK_tbl_role_page_tbl_pages");

                entity.HasOne(d => d.role)
                    .WithMany(p => p.tbl_role_page)
                    .HasForeignKey(d => d.roleid)
                    .HasConstraintName("FK_tbl_role_page_tbl_role");
            });

            modelBuilder.Entity<tbl_suppliers>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.name).HasMaxLength(500);

                entity.Property(e => e.updateddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_user>(entity =>
            {
                entity.Property(e => e.createddate).HasColumnType("datetime");

                entity.Property(e => e.pswd).HasMaxLength(50);

                entity.Property(e => e.updateddate).HasColumnType("datetime");

                entity.Property(e => e.username).HasMaxLength(50);

                entity.HasOne(d => d.role)
                    .WithMany(p => p.tbl_user)
                    .HasForeignKey(d => d.roleid)
                    .HasConstraintName("FK_tbl_user_tbl_role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
