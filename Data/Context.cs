
using Cursos.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Data
{
    public class Context: DbContext

    {
        IConfiguration _configuration;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public virtual DbSet<Curso> Curso { get; set; } 
        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<PostagemBlog> PostagemBlogs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connection = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

                optionsBuilder.UseMySql(connection, Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Curso>().HasMany(a => a.Aulas)
                .WithOne(c => c.curso)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
