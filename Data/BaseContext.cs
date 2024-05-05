using Microsoft.EntityFrameworkCore;
using proyect_API_Backend.Models;

namespace proyect_API_Backend.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options): base(options){

        }
        public DbSet <Nota> Notas { get; set; }
     
    }
}
   
