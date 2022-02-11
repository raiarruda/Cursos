
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

    }
}
