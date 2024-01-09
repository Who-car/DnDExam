using System.ComponentModel.DataAnnotations;

namespace DnDExamModels;

public class EnemyModel : AbstractPlayerModel
{
    [Key]
    public int EnemyId { get; set; }
}