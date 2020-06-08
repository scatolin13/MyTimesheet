using M2RG.MyTimesheet.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace M2RG.MyTimesheet.Repositories.Context
{
    public partial class TimesheetContext : DbContext
    {
        public TimesheetContext()
        {
        }

        public virtual DbSet<Calendarios> Calendarios { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Escalas> Escalas { get; set; }
        public virtual DbSet<Feriados> Feriados { get; set; }
        public virtual DbSet<Lancamentos> Lancamentos { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<Perfis> Perfis { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosEmpresas> UsuariosEmpresas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calendarios>(entity =>
            {
                entity.ToTable("calendarios");

                entity.HasIndex(e => e.EmpresaId)
                    .HasName("fk_calendarios_empresas1_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ParametroId)
                    .HasName("fk_calendarios_parametros1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataFim).HasColumnType("date");

                entity.Property(e => e.DataInicio).HasColumnType("date");

                entity.Property(e => e.EmpresaId).HasColumnType("int(11)");

                entity.Property(e => e.ParametroId).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId).HasColumnType("int(11)");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Calendarios)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_calendarios_empresas1");

                entity.HasOne(d => d.Parametro)
                    .WithMany(p => p.Calendarios)
                    .HasForeignKey(d => d.ParametroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_calendarios_parametros1");
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

                entity.Property(e => e.CriadoPor).HasColumnType("int(11)");

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

            modelBuilder.Entity<Escalas>(entity =>
            {
                entity.ToTable("escalas");

                entity.HasIndex(e => e.CalendarioId)
                    .HasName("fk_escalas_calendarios1_idx");

                entity.HasIndex(e => e.EmpresaId)
                    .HasName("fk_escalas_empresas1_idx");

                entity.HasIndex(e => e.FeriadoId)
                    .HasName("fk_escalas_feriados1_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("fk_escalas_usuarios1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CalendarioId).HasColumnType("int(11)");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmpresaId).HasColumnType("int(11)");

                entity.Property(e => e.FeriadoId).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId).HasColumnType("int(11)");

                entity.HasOne(d => d.Calendario)
                    .WithMany(p => p.Escalas)
                    .HasForeignKey(d => d.CalendarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_escalas_calendarios1");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Escalas)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_escalas_empresas1");

                entity.HasOne(d => d.Feriado)
                    .WithMany(p => p.Escalas)
                    .HasForeignKey(d => d.FeriadoId)
                    .HasConstraintName("fk_escalas_feriados1");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Escalas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_escalas_usuarios1");
            });

            modelBuilder.Entity<Feriados>(entity =>
            {
                entity.ToTable("feriados");

                entity.HasIndex(e => e.EmpresaId)
                    .HasName("fk_feriados_empresas1_idx");

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

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Feriados)
                    .HasForeignKey(d => d.EmpresaId)
                    .HasConstraintName("fk_feriados_empresas1");
            });

            modelBuilder.Entity<Lancamentos>(entity =>
            {
                entity.ToTable("lancamentos");

                entity.HasIndex(e => e.EscalaId)
                    .HasName("fk_lancamentos_escalas1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Entrada).HasColumnType("tinyint(1)");

                entity.Property(e => e.EscalaId).HasColumnType("int(11)");

                entity.HasOne(d => d.Escala)
                    .WithMany(p => p.Lancamentos)
                    .HasForeignKey(d => d.EscalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lancamentos_escalas1");
            });

            modelBuilder.Entity<Parametros>(entity =>
            {
                entity.ToTable("parametros");

                entity.HasIndex(e => e.EmpresaId)
                    .HasName("fk_parametros_empresas1_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ConsiderarDomingo).HasColumnType("tinyint(1)");

                entity.Property(e => e.ConsiderarQuarta).HasColumnType("tinyint(1)");

                entity.Property(e => e.ConsiderarQuinta).HasColumnType("tinyint(1)");

                entity.Property(e => e.ConsiderarSabado).HasColumnType("tinyint(1)");

                entity.Property(e => e.ConsiderarSegunda).HasColumnType("tinyint(1)");

                entity.Property(e => e.ConsiderarSexta).HasColumnType("tinyint(1)");

                entity.Property(e => e.ConsiderarTerca).HasColumnType("tinyint(1)");

                entity.Property(e => e.EmpresaId).HasColumnType("int(11)");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Parametros)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_parametros_empresas1");
            });

            modelBuilder.Entity<Perfis>(entity =>
            {
                entity.ToTable("perfiis");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.EhAdministrador).HasColumnType("tinyint(1)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Id)
                    .HasName("id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PerfilId)
                    .HasName("fk_usuarios_perfiis1_idx");

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

                entity.Property(e => e.PerfilId).HasColumnType("int(11)");

                entity.Property(e => e.Rg)
                    .HasColumnName("RG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tentativas).HasColumnType("int(11)");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_perfiis1");
            });

            modelBuilder.Entity<UsuariosEmpresas>(entity =>
            {
                entity.ToTable("usuariosempresas");

                entity.HasIndex(e => e.EmpresaId)
                    .HasName("fk_usuariosempresas_empresas_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => new { e.UsuarioId, e.EmpresaId })
                    .HasName("UserEmp_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.EmpresaId).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId).HasColumnType("int(11)");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.UsuariosEmpresas)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuariosempresas_empresas");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuariosEmpresas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuariosempresas_usuarios1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
