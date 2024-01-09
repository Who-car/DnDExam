using DnDExamModels;
using Microsoft.EntityFrameworkCore;

namespace DnDExamBL;

public class DndDbContext : DbContext
{
    public DbSet<EnemyModel> Enemies => Set<EnemyModel>();

    public DndDbContext(DbContextOptions<DndDbContext> options)
        : base(options)
    {
    }
}