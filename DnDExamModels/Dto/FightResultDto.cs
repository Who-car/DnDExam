namespace DnDExamModels.Dto;

public class FightResultDto
{
    public List<RoundResult> Result { get; set; } = new();

    public void Add(RoundResult roundResult)
    {
        Result.Add(roundResult);
    }
}