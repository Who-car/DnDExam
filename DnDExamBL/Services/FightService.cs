using DnDExamModels;
using DnDExamModels.Dto;

namespace DnDExamBL.Services;

public class FightService : IFightService
{
    private readonly Random _random = new();
    public PlayerModel Player { get; set; }
    public EnemyModel Enemy { get; set; }

    public FightResultDto GetResult()
    {
        var result = new FightResultDto();
        result.PlayerModel = Player;
        result.Add(new RoundResult
        {
            Active = Player,
            Passive = Enemy,
            Round = 0
        });

        var currentRound = 1;
        while (Player.HitPoints > 0 && Enemy.HitPoints > 0)
        { 
            ProcessRound(currentRound, true, result);
            if (Player.HitPoints <= 0 || Enemy.HitPoints <= 0)
                break; 
            ProcessRound(currentRound, false, result);
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
        var hit = attack == 1
            ? HitType.CriticalMiss
            : attack == 20
                ? HitType.CriticalMatch
                : playerTurn
                    ? attack >= Enemy.ArmorClass || Player.AttackModifier + 1 >= Enemy.ArmorClass
                        ? HitType.Match
                        : HitType.Miss
                    : attack >= Player.ArmorClass || Enemy.AttackModifier + 1 >= Player.ArmorClass
                        ? HitType.Match
                        : HitType.Miss;
        var damage = hit == HitType.CriticalMiss || hit == HitType.Miss ? 0
            : hit == HitType.Match ? 
                playerTurn 
                    ? Player.GetDamage() + Player.DamageModifier 
                    : Enemy.GetDamage() + Enemy.DamageModifier
                : playerTurn 
                    ? Player.GetDamage() * 2 + Player.DamageModifier 
                    : Enemy.GetDamage() * 2 + Enemy.DamageModifier;
        if (playerTurn)
            Enemy.HitPoints -= damage;
        else
            Player.HitPoints -= damage;
        log.Add(new RoundResult
        {
            Round = roundNum,
            Active = playerTurn ? Player : Enemy,
            Passive = playerTurn ? Enemy : Player,
            PassivePlayerHitPointsLeft = playerTurn ? Enemy.HitPoints : Player.HitPoints,
            Hit = hit,
            Damage = damage,
        });
    }
}