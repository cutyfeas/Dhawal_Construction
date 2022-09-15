using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class db_a67321_constructionappContext : DbContext
    {
        public db_a67321_constructionappContext()
        {
        }

        public db_a67321_constructionappContext(DbContextOptions<db_a67321_constructionappContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblApartment> TblApartments { get; set; }
        public virtual DbSet<TblBeneficiary> TblBeneficiaries { get; set; }
        public virtual DbSet<TblBeneficiaryChoiceMap> TblBeneficiaryChoiceMaps { get; set; }
        public virtual DbSet<TblCondominium> TblCondominia { get; set; }
        public virtual DbSet<TblMasterfield> TblMasterfields { get; set; }
        public virtual DbSet<TblMastertype> TblMastertypes { get; set; }
        public virtual DbSet<TblMastertypeSupplierMap> TblMastertypeSupplierMaps { get; set; }
        public virtual DbSet<TblMastertypefield> TblMastertypefields { get; set; }
        public virtual DbSet<TblPage> TblPages { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblRolePage> TblRolePages { get; set; }
        public virtual DbSet<TblSupplier> TblSuppliers { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=SQL5103.site4now.net,1433;Database=db_a67321_constructionapp;UID=db_a67321_constructionapp_admin;PWD=Construction@4321;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblApartment>(entity =>
            {
                entity.ToTable("tbl_apartment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .HasColumnName("area");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .HasColumnName("building");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Condominiumid).HasColumnName("condominiumid");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Fixtures)
                    .HasMaxLength(50)
                    .HasColumnName("fixtures");

                entity.Property(e => e.Floorplan)
                    .HasMaxLength(50)
                    .HasColumnName("floorplan");

                entity.Property(e => e.Staircase)
                    .HasMaxLength(50)
                    .HasColumnName("staircase");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.HasOne(d => d.Condominium)
                    .WithMany(p => p.TblApartments)
                    .HasForeignKey(d => d.Condominiumid)
                    .HasConstraintName("FK_tbl_apartment_tbl_condominium");
            });

            modelBuilder.Entity<TblBeneficiary>(entity =>
            {
                entity.ToTable("tbl_beneficiary");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Apartmentid).HasColumnName("apartmentid");

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .HasColumnName("building");

                entity.Property(e => e.Cadastralcategory)
                    .HasMaxLength(50)
                    .HasColumnName("cadastralcategory");

                entity.Property(e => e.Clientid)
                    .HasMaxLength(50)
                    .HasColumnName("clientid");

                entity.Property(e => e.Condominiumid).HasColumnName("condominiumid");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .HasColumnName("firstname");

                entity.Property(e => e.Interior)
                    .HasMaxLength(50)
                    .HasColumnName("interior");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasColumnName("lastname");

                entity.Property(e => e.Parcel).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.Sqm)
                    .HasMaxLength(50)
                    .HasColumnName("sqm");

                entity.Property(e => e.Staircase)
                    .HasMaxLength(50)
                    .HasColumnName("staircase");

                entity.Property(e => e.Subdivision).HasMaxLength(50);

                entity.Property(e => e.Taxcode)
                    .HasMaxLength(50)
                    .HasColumnName("taxcode");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.HasOne(d => d.Apartment)
                    .WithMany(p => p.TblBeneficiaries)
                    .HasForeignKey(d => d.Apartmentid)
                    .HasConstraintName("FK_tbl_beneficiary_tbl_apartment");
            });

            modelBuilder.Entity<TblBeneficiaryChoiceMap>(entity =>
            {
                entity.ToTable("tbl_beneficiary_choice_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BenId).HasColumnName("ben_id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Mastertypeid).HasColumnName("mastertypeid");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.HasOne(d => d.Ben)
                    .WithMany(p => p.TblBeneficiaryChoiceMaps)
                    .HasForeignKey(d => d.BenId)
                    .HasConstraintName("FK_tbl_beneficiary_choice_map_tbl_beneficiary");

                entity.HasOne(d => d.Mastertype)
                    .WithMany(p => p.TblBeneficiaryChoiceMaps)
                    .HasForeignKey(d => d.Mastertypeid)
                    .HasConstraintName("FK_tbl_beneficiary_choice_map_tbl_mastertype");
            });

            modelBuilder.Entity<TblCondominium>(entity =>
            {
                entity.ToTable("tbl_condominium");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Administrator)
                    .HasMaxLength(50)
                    .HasColumnName("administrator");

                entity.Property(e => e.Buildings)
                    .HasMaxLength(50)
                    .HasColumnName("buildings");

                entity.Property(e => e.CondominiumName)
                    .HasMaxLength(50)
                    .HasColumnName("condominium_name");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .HasColumnName("lng");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.Taxcode)
                    .HasMaxLength(50)
                    .HasColumnName("taxcode");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.Property(e => e.Users)
                    .HasMaxLength(50)
                    .HasColumnName("users");

                entity.Property(e => e.Vatnumber)
                    .HasMaxLength(50)
                    .HasColumnName("vatnumber");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasColumnName("zip_code");
            });

            modelBuilder.Entity<TblMasterfield>(entity =>
            {
                entity.ToTable("tbl_masterfields");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdby1).HasColumnName("createdby1");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Createddate1)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate1");

                entity.Property(e => e.Datatype)
                    .HasMaxLength(50)
                    .HasColumnName("datatype");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updatedby1).HasColumnName("updatedby1");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.Property(e => e.Updateddate1)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate1");
            });

            modelBuilder.Entity<TblMastertype>(entity =>
            {
                entity.ToTable("tbl_mastertype");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");
            });

            modelBuilder.Entity<TblMastertypeSupplierMap>(entity =>
            {
                entity.ToTable("tbl_mastertype_supplier_map");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Mastertypeid).HasColumnName("mastertypeid");

                entity.Property(e => e.Quotedvalue).HasColumnName("quotedvalue");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.HasOne(d => d.Mastertype)
                    .WithMany(p => p.TblMastertypeSupplierMaps)
                    .HasForeignKey(d => d.Mastertypeid)
                    .HasConstraintName("FK_tbl_mastertype_supplier_map_tbl_mastertype");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TblMastertypeSupplierMaps)
                    .HasForeignKey(d => d.Supplierid)
                    .HasConstraintName("FK_tbl_mastertype_supplier_map_tbl_suppliers");
            });

            modelBuilder.Entity<TblMastertypefield>(entity =>
            {
                entity.ToTable("tbl_mastertypefields");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Masterfieldid).HasColumnName("masterfieldid");

                entity.Property(e => e.Mastertypeid).HasColumnName("mastertypeid");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.HasOne(d => d.Masterfield)
                    .WithMany(p => p.TblMastertypefields)
                    .HasForeignKey(d => d.Masterfieldid)
                    .HasConstraintName("FK_tbl_mastertypefields_tbl_masterfields");

                entity.HasOne(d => d.Mastertype)
                    .WithMany(p => p.TblMastertypefields)
                    .HasForeignKey(d => d.Mastertypeid)
                    .HasConstraintName("FK_tbl_mastertypefields_tbl_mastertype");
            });

            modelBuilder.Entity<TblPage>(entity =>
            {
                entity.ToTable("tbl_pages");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Pagename)
                    .HasMaxLength(50)
                    .HasColumnName("pagename");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.ToTable("tbl_role");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .HasColumnName("rolename");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");
            });

            modelBuilder.Entity<TblRolePage>(entity =>
            {
                entity.ToTable("tbl_role_page");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Pageid).HasColumnName("pageid");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.TblRolePages)
                    .HasForeignKey(d => d.Pageid)
                    .HasConstraintName("FK_tbl_role_page_tbl_pages");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblRolePages)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK_tbl_role_page_tbl_role");
            });

            modelBuilder.Entity<TblSupplier>(entity =>
            {
                entity.ToTable("tbl_suppliers");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_user");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK_tbl_user_tbl_role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
