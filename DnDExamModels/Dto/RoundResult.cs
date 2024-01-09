namespace DnDExamModels.Dto;

public class RoundResult
{
    public DateTime Time { get; set; } = DateTime.Now;
    public int Round { get; set; }
    public bool IsOver { get; set; }
    public AbstractPlayerModel? Winner { get; set; }
    public AbstractPlayerModel Active { get; set; }
    public AbstractPlayerModel Passive { get; set; }
    public int PassivePlayerHitPointsLeft { get; set; }
    public HitType Hit { get; set; }
    public int Damage { get; set; }
}