namespace DnDExamModels.Dto;

public class RoundResult
{
    public DateTime Time { get; set; } = DateTime.Now;
    public int Round { get; set; }
    public AbstractPlayerModel CurrentPlayer { get; set; }
    public bool HasHit { get; set; }
    public int DamageCaused { get; set; }
    public bool IsOver { get; set; }
    public AbstractPlayerModel? Winner { get; set; }
}