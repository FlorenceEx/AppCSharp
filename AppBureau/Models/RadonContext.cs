using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppBureau.Models;

public partial class RadonContext : DbContext
{
    public RadonContext()
    {
    }

    public RadonContext(DbContextOptions<RadonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Conformite> Conformites { get; set; }

    public virtual DbSet<Detecteur> Detecteurs { get; set; }

    public virtual DbSet<Etablissement> Etablissements { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.29.13,1433\\MSSQLSERVER;User ID=sa;Password=erty64%;Database=RADON;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Conformite>(entity =>
        {
            entity.ToTable("conformite");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Libelle)
                .IsUnicode(false)
                .HasColumnName("libelle");
        });

        modelBuilder.Entity<Detecteur>(entity =>
        {
            entity.ToTable("detecteur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DatePose)
                .HasColumnType("datetime")
                .HasColumnName("datePose");
            entity.Property(e => e.DateRetrait)
                .HasColumnType("datetime")
                .HasColumnName("dateRetrait");
            entity.Property(e => e.IdEtablissement).HasColumnName("idEtablissement");
            entity.Property(e => e.NomPiece)
                .IsUnicode(false)
                .HasColumnName("nomPiece");
            entity.Property(e => e.ValeurReleve)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("valeurReleve");

            entity.HasOne(d => d.IdEtablissementNavigation).WithMany(p => p.Detecteurs)
                .HasForeignKey(d => d.IdEtablissement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detecteur_etablissement");
        });

        modelBuilder.Entity<Etablissement>(entity =>
        {
            entity.ToTable("etablissement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adresse)
                .IsUnicode(false)
                .HasColumnName("adresse");
            entity.Property(e => e.FormeJuridique)
                .IsUnicode(false)
                .HasColumnName("formeJuridique");
            entity.Property(e => e.IdConformite).HasColumnName("idConformite");
            entity.Property(e => e.IdTechnicien).HasColumnName("idTechnicien");
            entity.Property(e => e.Mail)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.RaisonSociale)
                .IsUnicode(false)
                .HasColumnName("raisonSociale");
            entity.Property(e => e.Siret)
                .IsUnicode(false)
                .HasColumnName("siret");
            entity.Property(e => e.Telephone)
                .IsUnicode(false)
                .HasColumnName("telephone");

            entity.HasOne(d => d.IdConformiteNavigation).WithMany(p => p.Etablissements)
                .HasForeignKey(d => d.IdConformite)
                .HasConstraintName("FK_etablissement_conformite");

            entity.HasOne(d => d.IdTechnicienNavigation).WithMany(p => p.Etablissements)
                .HasForeignKey(d => d.IdTechnicien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_etablissement_utilisateur");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.ToTable("utilisateur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstTechnicien).HasColumnName("estTechnicien");
            entity.Property(e => e.Login)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Nom)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Prenom)
                .IsUnicode(false)
                .HasColumnName("prenom");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
