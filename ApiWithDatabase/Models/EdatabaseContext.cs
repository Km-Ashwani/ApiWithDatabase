using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiWithDatabase.Models;

public partial class EdatabaseContext : DbContext
{
    public EdatabaseContext()
    {
    }

    public EdatabaseContext(DbContextOptions<EdatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estudent> Estudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=ASHWANIPC; database=EDatabase; User Id=ashwani; password=11410@ashu; encrypt=true; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudent>(entity =>
        {
            entity.ToTable("EStudent", "dbo");

            entity.Property(e => e.StudentGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Student_Gender");
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Student_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
