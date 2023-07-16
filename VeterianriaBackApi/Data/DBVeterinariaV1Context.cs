using Microsoft.EntityFrameworkCore;
using VeterianriaBackApi.Models;

namespace VeterianriaBackApi.Data
{
    public class DBVeterinariaV1Context : DbContext
    {
        public DBVeterinariaV1Context() { }

        public DBVeterinariaV1Context(DbContextOptions<DBVeterinariaV1Context> options) : base(options) { }

        public virtual DbSet<tblUsuarios> tblUsuarios { get; set; }
        public virtual DbSet<tblRol> tblRol { get; set; }
        public virtual DbSet<tblMascotas> tblMascotas { get; set; }
        public virtual DbSet<tblIdentificacion> tblIdentificacion { get; set; }
        public virtual DbSet<tblHistoriaClinica> tblHistoriaClinica { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<tblUsuarios>(entity =>
            {
                entity.HasKey(e => e.iIDUsuario);

                entity.ToTable("tblUsuarios", "Administrativo");

                entity.Property(e => e.tNumeroIdentificacion).HasMaxLength(200);

                entity.Property(e => e.tPrimerNombre).HasMaxLength(200);

                entity.Property(e => e.tSegundoNombre).HasMaxLength(200);

                entity.Property(e => e.tPrimerApellido).HasMaxLength(200);

                entity.Property(e => e.tSegundoApellido).HasMaxLength(200);

                entity.Property(e => e.tNumeroTelefono).HasMaxLength(200);

                entity.Property(e => e.tDireccion).HasMaxLength(200);

                entity.Property(e => e.tCorreo).HasMaxLength(200);

                entity.Property(e => e.tContrasenna).HasMaxLength(200);

                entity.Property(e => e.iIDUsuarioCreacion).HasColumnType("int");

                entity.Property(e => e.dtFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.iIDUsuarioModificacion).HasColumnType("int");

                entity.Property(e => e.dtFechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.iIDUsuarioInactivacion).HasColumnType("int");

                entity.Property(e => e.dtFechaInactivacion).HasColumnType("datetime");

                entity.Property(e => e.bActivo).HasColumnType("bool");


                entity.HasOne(d => d.iIDTipoIdentificacionNavigation)
                    .WithMany(p => p.tblUsuariosNavigation)
                    .HasForeignKey(d => d.iIDTipoIdentificacion)
                    .HasConstraintName("FK_tblUsuarios_tblIdentificacion");

                entity.HasOne(d => d.iIDRolNavigation)
                    .WithMany(p => p.tblUsuariosNavigation)
                    .HasForeignKey(d => d.iIDRol)
                    .HasConstraintName("FK_tblUsuarios_tblRol");
            });

            modelBuilder.Entity<tblRol>(entity =>
            {
                entity.HasKey(e => e.iIDRol);

                entity.ToTable("tblRol", "Administrativo");

                entity.Property(e => e.tRol).HasMaxLength(200);

                entity.Property(e => e.tDescripcion).HasMaxLength(200);

                entity.Property(e => e.dtFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.dtFechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.dtFechaInactivacion).HasColumnType("datetime");

                entity.Property(e => e.bActivo).HasColumnType("bool");

                entity.HasOne(d => d.iIDUsuarioCreacionNavigation)
                .WithMany(p => p.tblRoliIDUsuarioCreacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioCreacion)
                .HasConstraintName("FK_tblRol_tblUsuarios_iIDUsuarioCreacion");

                entity.HasOne(d => d.iIDUsuarioModificacionNavigation)
                .WithMany(p => p.tblRoliIDUsuarioModificacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioModificacion)
                .HasConstraintName("FK_tblRol_tblUsuarios_iIDUsuarioModificacion");

                entity.HasOne(d => d.iIDUsuarioInactivacionNavigation)
                .WithMany(p => p.tblRoliIDUsuarioInactivacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioInactivacion)
                .HasConstraintName("FK_tblRol_tblUsuarios_iIDUsuarioInactivacion");

            });
            modelBuilder.Entity<tblMascotas>(entity =>
            {
                entity.HasKey(e => e.iIDMascota);

                entity.ToTable("tblMascotas", "Administrativo");

                entity.Property(e => e.tNombreMascota).HasMaxLength(200);

                entity.Property(e => e.tEspecie).HasMaxLength(200);

                entity.Property(e => e.tRaza).HasMaxLength(200);

                entity.Property(e => e.dtFechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.dtFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.dtFechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.dtFechaInactivacion).HasColumnType("datetime");

                entity.Property(e => e.bActivo).HasColumnType("bool");

                entity.HasOne(d => d.iIDUsuarioCreacionNavigation)
               .WithMany(p => p.tblMascotasiIDUsuarioCreacionNavigation)
               .HasForeignKey(d => d.iIDUsuarioCreacion)
               .HasConstraintName("FK_tblMascotas_iIDUsuarioCreacion");

                entity.HasOne(d => d.iIDUsuarioModificacionNavigation)
                .WithMany(p => p.tblMascotasiIDUsuarioModificacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioModificacion)
                .HasConstraintName("FK_tblMascotas_iIDUsuarioModificacion");

                entity.HasOne(d => d.iIDUsuarioInactivacionNavigation)
                .WithMany(p => p.tblMascotasiIDUsuarioInactivacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioInactivacion)
                .HasConstraintName("FK_tblMascotas_iIDUsuarioInactivacion");

                entity.HasOne(d => d.iIDDuennoNavigation)
               .WithMany(p => p.tblMascotasiIDDuennoNavigation)
               .HasForeignKey(d => d.iIDDuenno)
               .HasConstraintName("FK_tblMascotas_iIDDuenno");
            });

            modelBuilder.Entity<tblIdentificacion>(entity =>
            {
                entity.HasKey(e => e.iIDIdentificacion);

                entity.ToTable("tblIdentificacion", "Administrativo");

                entity.Property(e => e.tSiglasIdentificacion).HasMaxLength(200);

                entity.Property(e => e.tIdentificacion).HasMaxLength(200);

                entity.Property(e => e.dtFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.dtFechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.dtFechaInactivacion).HasColumnType("datetime");

                entity.Property(e => e.bActivo).HasColumnType("bool");

                entity.HasOne(d => d.iIDUsuarioCreacionNavigation)
               .WithMany(p => p.tblIdentificacioniIDUsuarioCreacionNavigation)
               .HasForeignKey(d => d.iIDUsuarioCreacion)
               .HasConstraintName("FK_tblIdentificacion_iIDUsuarioCreacion");

                entity.HasOne(d => d.iIDUsuarioModificacionNavigation)
                .WithMany(p => p.tblIdentificacioniIDUsuarioModificacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioModificacion)
                .HasConstraintName("FK_tblIdentificacion_iIDUsuarioModificacion");

                entity.HasOne(d => d.iIDUsuarioInactivacionNavigation)
                .WithMany(p => p.tblIdentificacioniIDUsuarioInactivacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioInactivacion)
                .HasConstraintName("FK_tblIdentificacion_iIDUsuarioInactivacion");
            });
            modelBuilder.Entity<tblHistoriaClinica>(entity =>
            {
                entity.HasKey(e => e.iIDHistoriaClinica);

                entity.ToTable("tblHistoriaClinica", "Administrativo");

                entity.Property(e => e.tTemperatura).HasMaxLength(200);

                entity.Property(e => e.tPeso).HasMaxLength(200);

                entity.Property(e => e.tEstadoAnimo).HasMaxLength(200);

                entity.Property(e => e.tDiagnostico).HasMaxLength(200);

                entity.Property(e => e.dtFechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.dtFechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.dtFechaInactivacion).HasColumnType("datetime");

                entity.Property(e => e.bActivo).HasColumnType("bool");

                entity.HasOne(d => d.iIDUsuarioCreacionNavigation)
               .WithMany(p => p.tblHistoriaClinicaiIDUsuarioCreacionNavigation)
               .HasForeignKey(d => d.iIDUsuarioCreacion)
               .HasConstraintName("FK_tblHistoriaClinica_iIDUsuarioCreacion");

                entity.HasOne(d => d.iIDUsuarioModificacionNavigation)
                .WithMany(p => p.tblHistoriaClinicaiIDUsuarioModificacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioModificacion)
                .HasConstraintName("FK_tblHistoriaClinica_iIDUsuarioModificacion");

                entity.HasOne(d => d.iIDUsuarioInactivacionNavigation)
                .WithMany(p => p.tblHistoriaClinicaiIDUsuarioInactivacionNavigation)
                .HasForeignKey(d => d.iIDUsuarioInactivacion)
                .HasConstraintName("FK_tblHistoriaClinica_iIDUsuarioInactivacion");

                entity.HasOne(d => d.iIDMascotaNavigation)
                .WithMany(p => p.tblHistoriaClinicaiIDMascotaNavigation)
                .HasForeignKey(d => d.iIDMascota)
                .HasConstraintName("FK_tblHistoriaClinica_iIDMascota");
            });

        }//OnModelCreating fin

    }
    }
