using Microsoft.EntityFrameworkCore;
using PanchayathTender.Models.Domain;

namespace PanchayathTender.Data
{
    public class PanchayathTenderDBContext: DbContext
    {
        public PanchayathTenderDBContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Tenders> Tenders { get; set; }
    }
}
