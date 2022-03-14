using Microsoft.EntityFrameworkCore;

namespace ForExperiments
{
    public partial class ForExperimentsContext : DbContext
    {
        public ForExperimentsContext()
        {
        }

        public ForExperimentsContext(DbContextOptions<ForExperimentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Content> Contents { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=D:\\localhost\\Giocatory\\WPFMiniTasks\\ForExperiments\\ForExperiments.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

        private partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}