using DnDExamModels;
using DnDExamModels.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DnDExamUI.Models;

public class GameModel
{
    // private const string DbUrl = "http://localhost:5055/enemy/random";
    // private const string BlUrl = "http://localhost:5257/fight/start";
    public PlayerModel Player { get; set; } = new();
    public EnemyModel? Enemy { get; set; }
    public List<FightResultDto>? Result;

    // public async Task OnPostAsync()
    // {
    //     if (!ModelState.IsValid) return;
    //     
    //     using var client = new HttpClient();
    //     var enemy = await client.GetFromJsonAsync<EnemyModel>(DbUrl);
    //     Enemy = enemy;
    //     var result = await client.PostAsJsonAsync(BlUrl, new FightOpponentsDto {Player = Player, Enemy = Enemy});
    //     Result = await result.Content.ReadFromJsonAsync<List<FightResultDto>>();
    // }
}