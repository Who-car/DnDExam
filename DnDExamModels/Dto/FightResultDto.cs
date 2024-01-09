namespace DnDExamModels.Dto;

public class FightResultDto
{
    public List<RoundResult> FightLog { get; set; } = new();

    public void Add(RoundResult roundResult)
    {
        FightLog.Add(roundResult);
    }
}