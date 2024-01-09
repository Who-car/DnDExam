using DnDExamModels;
using DnDExamModels.Dto;

namespace DnDExamBL.Services;

public interface IFightService
{
    public PlayerModel Player { get; set; }
    public EnemyModel Enemy { get; set; }
    public FightResultDto GetResult();
}