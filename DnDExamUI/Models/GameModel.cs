using DnDExamModels;
using DnDExamModels.Dto;

namespace DnDExamUI.Models;

public class GameModel
{
    public PlayerModel Player { get; set; } = new();
    public EnemyModel? Enemy { get; set; }
    public FightResultDto? FightResult;
}