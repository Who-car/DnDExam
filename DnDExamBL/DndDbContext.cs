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
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EnemyModel>().ToTable("Enemies");
        modelBuilder
            .Entity<EnemyModel>()
            .HasData(
                new EnemyModel
                {
                    EnemyId = 1,
                    Name = "Warlock",
                    HitPoints = 40,
                    ArmorClass = 15,
                    AttackPerRound = 1,
                    AttackModifier = 3,
                    DamageModifier = 2,
                    Damage = "3d6"
                },
                new EnemyModel
                {
                    EnemyId = 2,
                    Name = "Goblin",
                    HitPoints = 25,
                    ArmorClass = 12,
                    AttackPerRound = 2,
                    AttackModifier = 1,
                    DamageModifier = 0,
                    Damage = "1d4"
                },
                new EnemyModel
                {
                    EnemyId = 3,
                    Name = "Dragon",
                    HitPoints = 80,
                    ArmorClass = 18,
                    AttackPerRound = 5,
                    AttackModifier = 3,
                    DamageModifier = 3,
                    Damage = "4d8"
                },
                new EnemyModel
                {
                    EnemyId = 4,
                    Name = "Orc",
                    HitPoints = 35,
                    ArmorClass = 14,
                    AttackPerRound = 2,
                    AttackModifier = -2,
                    DamageModifier = 1,
                    Damage = "3d4"
                },
                new EnemyModel
                {
                    EnemyId = 5,
                    Name = "Skeleton",
                    HitPoints = 15,
                    ArmorClass = 10,
                    AttackPerRound = 1,
                    AttackModifier = 0,
                    DamageModifier = 0,
                    Damage = "1d8"
                },
                new EnemyModel
                {
                    EnemyId = 6,
                    Name = "Troll",
                    HitPoints = 50,
                    ArmorClass = 16,
                    AttackPerRound = 2,
                    AttackModifier = 4,
                    DamageModifier = 3,
                    Damage = "2d8"
                },
                new EnemyModel
                {
                    EnemyId = 7,
                    Name = "Wraith",
                    HitPoints = 30,
                    ArmorClass = 13,
                    AttackPerRound = 1,
                    AttackModifier = 1,
                    DamageModifier = -2,
                    Damage = "3d4"
                },
                new EnemyModel
                {
                    EnemyId = 8,
                    Name = "Harpy",
                    HitPoints = 20,
                    ArmorClass = 11,
                    AttackPerRound = 2,
                    AttackModifier = -1,
                    DamageModifier = 0,
                    Damage = "1d10"
                },
                new EnemyModel
                {
                    EnemyId = 9,
                    Name = "Beholder",
                    HitPoints = 60,
                    ArmorClass = 17,
                    AttackPerRound = 3,
                    AttackModifier = 3,
                    DamageModifier = 2,
                    Damage = "4d4"
                },
                new EnemyModel
                {
                    EnemyId = 10,
                    Name = "Lich",
                    HitPoints = 70,
                    ArmorClass = 19,
                    AttackPerRound = 4,
                    AttackModifier = -2,
                    DamageModifier = 3,
                    Damage = "5d6"
                },
                new EnemyModel
                {
                    EnemyId = 11,
                    Name = "Minotaur",
                    HitPoints = 45,
                    ArmorClass = 15,
                    AttackPerRound = 1,
                    AttackModifier = 3,
                    DamageModifier = -1,
                    Damage = "1d12"
                },
                new EnemyModel
                {
                    EnemyId = 12,
                    Name = "Gorgon",
                    HitPoints = 55,
                    ArmorClass = 16,
                    AttackPerRound = 1,
                    AttackModifier = -1,
                    DamageModifier = 0,
                    Damage = "1d10"
                },
                new EnemyModel
                {
                    EnemyId = 13,
                    Name = "Sphinx",
                    HitPoints = 65,
                    ArmorClass = 18,
                    AttackPerRound = 2,
                    AttackModifier = 2,
                    DamageModifier = 1,
                    Damage = "2d6"
                },
                new EnemyModel
                {
                    EnemyId = 14,
                    Name = "Banshee",
                    HitPoints = 25,
                    ArmorClass = 12,
                    AttackPerRound = 1,
                    AttackModifier = 2,
                    DamageModifier = 0,
                    Damage = "1d4"
                },
                new EnemyModel
                {
                    EnemyId = 15,
                    Name = "Chimera",
                    HitPoints = 75,
                    ArmorClass = 20,
                    AttackPerRound = 3,
                    AttackModifier = 3,
                    DamageModifier = 1,
                    Damage = "2d6"
                }
            );
    }
}