using DnDExamModels.Dto;

namespace DnDExamBL.Services;

public interface IFightService
{
    public FightResultDto GetResult();
}