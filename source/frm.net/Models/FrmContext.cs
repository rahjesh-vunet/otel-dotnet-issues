using FrmApp.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace frm.Models;

public partial class FrmContext : DbContext
{
    public virtual DbSet<RiskScoreResponseDTO> RiskScoreResponses { get; set; } = null!;
    public FrmContext(DbContextOptions<FrmContext> options)
        : base(options)
    {
        Database.Migrate();

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    void Clear<T>(DbSet<T> dbSet) where T : class
    {
        dbSet.RemoveRange(dbSet);
        SaveChanges();
    }
}
