using Microsoft.EntityFrameworkCore;
using ToDoList.Models.Entidades;

namespace ToDoList.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Tarea> Tareas { get; set; }
    }
}
