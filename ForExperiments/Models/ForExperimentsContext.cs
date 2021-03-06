using ForExperiments.Infrastructure;
using ForExperiments.Models;
using Microsoft.EntityFrameworkCore;

namespace ForExperiments
{
    public partial class ForExperimentsContext : DbContext
    {
        public ForExperimentsContext()
        {
            //Database.EnsureCreated(); // гарант создания базы данных
        }

        public ForExperimentsContext(DbContextOptions<ForExperimentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Content> Contents { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<JuniorQuestion> JuniorQuestions { get; set; } = null!;
        public virtual DbSet<MiddleQuestion> MiddleQuestions { get; set; } = null!;
        public virtual DbSet<SeniorQuestion> SeniorQuestions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(SourceLite.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JuniorQuestion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<MiddleQuestion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<SeniorQuestion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Users_Id")
                    .IsUnique();

                entity.HasIndex(e => e.Login, "IX_Users_Login")
                    .IsUnique();

                entity.HasIndex(e => e.Mail, "IX_Users_Mail")
                    .IsUnique();

                entity.HasIndex(e => e.Mobile, "IX_Users_Mobile")
                    .IsUnique();

                entity.HasIndex(e => e.Telegramm, "IX_Users_Telegramm")
                    .IsUnique();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}