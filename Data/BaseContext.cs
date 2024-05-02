using Microsoft.EntityFrameworkCore;
using registro_empleados.Models;

namespace proyect_API_Backend.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options): base(options){

        }
        public DbSet <Nota> Notas { get; set; }
     
    }
}
   
