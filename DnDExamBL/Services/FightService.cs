using DnDExamModels;
using DnDExamModels.Dto;

namespace DnDExamBL.Services;

public class FightService : IFightService
{
    private readonly Random _random = new();
    public PlayerModel Player { get; set; }
    public EnemyModel Enemy { get; set; }

    public FightService(PlayerModel player, EnemyModel enemy)
    {
        Player = player;
        Enemy = enemy;
    }

    public FightResultDto GetResult()
    {
        var result = new FightResultDto();
        var playerAttack = _random.Next(1, 21) + Player.AttackModifier;
        var enemyAttack = _random.Next(1, 21) + Enemy.AttackModifier;
        var isPlayerTurn = playerAttack >= enemyAttack;

        result.Add(new RoundResult { CurrentPlayer = isPlayerTurn ? Player : Enemy, Round = 0 });

        var currentRound = 1;
        while (Player.HitPoints > 0 && Enemy.HitPoints > 0)
        { 
            ProcessRound(currentRound, isPlayerTurn, result);
            isPlayerTurn = !isPlayerTurn;
            if (Player.HitPoints <= 0 || Enemy.HitPoints <= 0)
                break; 
            ProcessRound(currentRound, isPlayerTurn, result);
            isPlayerTurn = !isPlayerTurn;
            currentRound++;
        }

        result.Add(new RoundResult
        {
            IsOver = true,
            Winner = Player.HitPoints > 0 ? Player : Enemy
        });

        return result;
    }

    private void ProcessRound(int roundNum, bool playerTurn, FightResultDto log)
    {
        var attack = playerTurn
            ? _random.Next(1, 21) + Player.AttackModifier
            : _random.Next(1, 21) + Enemy.AttackModifier;
        var hasHit = playerTurn
            ? attack >= Enemy.ArmorClass || Player.AttackModifier + 1 >= Enemy.ArmorClass
            : attack >= Player.ArmorClass || Enemy.AttackModifier + 1 >= Player.ArmorClass;
        var damage = hasHit
            ? playerTurn
                ? Player.GetDamage() + Player.DamageModifier
                : Enemy.GetDamage() + Enemy.DamageModifier
            : 0;
        if (playerTurn)
            Enemy.HitPoints -= damage;
        else
            Player.HitPoints -= damage;
        log.Add(new RoundResult
        {
            Round = roundNum,
            CurrentPlayer = playerTurn ? Player : Enemy,
            HasHit = hasHit,
            DamageCaused = damage
        });
    }
}