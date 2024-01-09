using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DnDExamModels;

public class AbstractPlayerModel
{
    [Required]
    [MaxLength(20, ErrorMessage = "Name is too long, try to shorten")]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required]
    [Range(10, 100, ErrorMessage = "Hit points must belong to [10;100] range")]
    [DisplayName("HitPoints")]
    public int HitPoints { get; set; }

    [Required]
    [Range(10, 20, ErrorMessage = "Your armor class can't be less than 10 or greater than 20")]
    [DisplayName("Armor Class")]
    public int ArmorClass { get; set; }

    [Required]
    [Range(1, 5, ErrorMessage = "You must have at least 1 attack per round.\n" +
                                "You can't have more than 5 attacks per round")]
    [DisplayName("Attacks per round")]
    public int AttackPerRound { get; set; }

    [Required]
    [Range(-5, 5, ErrorMessage = "Attack modifier must belong to [-5;5] range")]
    [DisplayName("Attack Modifier")]
    public int AttackModifier { get; set; }

    [Required]
    [Range(-5, 5, ErrorMessage = "Attack modifier must belong to [-5;5] range")]
    [DisplayName("Damage Modifier")]
    public int DamageModifier { get; set; }

    [Required]
    [RegularExpression(@"\d+d\d+", ErrorMessage = "Wrong format. Try something like 2d6")]
    [DisplayName("Damage")]
    public string Damage { get; set; }

    public int GetDamage()
    {
        var random = new Random();
        var total = 0;
        var count = int.Parse(Damage[0].ToString());
        var dice = int.Parse(Damage[2].ToString());

        for (var i = 0; i < count; i++)
            total += random.Next(1, dice + 1);

        return total;
    }
}