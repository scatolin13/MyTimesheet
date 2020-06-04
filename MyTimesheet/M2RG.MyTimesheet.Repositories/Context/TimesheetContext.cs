using Microsoft.EntityFrameworkCore;

namespace M2RG.MyTimesheet.Repositories.Context
{
    public partial class TimesheetContext : DbContext
    {
        public TimesheetContext()
        {
        }

        public virtual DbSet<Agendas> Agendas { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Feriados> Feriados { get; set; }
        public virtual DbSet<HorariosAgenda> Horariosagenda { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agendas>(entity =>
            {
                entity.ToTable("agendas");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmpresaId).HasColumnType("int(11)");

                entity.Property(e => e.FeriadoId).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.ToTable("empresas");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("CNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstaAtivo).HasColumnType("tinyint(1)");

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Feriados>(entity =>
            {
                entity.ToTable("feriados");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpresaId).HasColumnType("int(11)");

                entity.Property(e => e.FeriadoFixo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FeriadoNacional).HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<HorariosAgenda>(entity =>
            {
                entity.ToTable("horariosagenda");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AgendaId).HasColumnType("int(11)");

                entity.Property(e => e.Entrada).HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Parametros>(entity =>
            {
                entity.ToTable("parametros");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CargaHorariaDia).HasColumnType("decimal(10,2)");

                entity.Property(e => e.EmpresaId)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MediaMensalHora).HasColumnType("decimal(10,2)");

                entity.Property(e => e.UsarFixoMensal).HasColumnType("tinyint(1)");

                entity.Property(e => e.UsuarioId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Id)
                    .HasName("id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmpresaId).HasColumnType("int(11)");

                entity.Property(e => e.EstaAtivo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .HasColumnName("RG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tentativas).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
