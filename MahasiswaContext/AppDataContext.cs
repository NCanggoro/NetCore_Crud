using MahasiswaCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace MahasiswaCrud.MahasiswaContext
{
    public class AppdataContext : DbContext
    {
        public AppdataContext(DbContextOptions<AppdataContext> options) : base(options){ }

        public DbSet<Mahasiswa> Mahasiswas { get; set; } 
    }

    
}