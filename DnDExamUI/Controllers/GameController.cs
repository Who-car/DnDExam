using System.ComponentModel.DataAnnotations;
using DnDExamModels;
using DnDExamModels.Dto;
using DnDExamUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDExamUI.Controllers;

public class GameController : Controller
{
    private const string Url = "https://localhost:7094";

    [HttpGet]
    public IActionResult Game()
    {
        return View(new GameModel());
    }

    [HttpPost]
    public async Task<IActionResult> Game(GameModel gameModel)
    {
        if (ModelState.IsValid)
        {
            using var client = new HttpClient();
            var enemy = await client.GetFromJsonAsync<EnemyModel>($"{Url}/Fight/random");
            gameModel.Enemy = enemy;
            var result = await client.PostAsJsonAsync(
                $"{Url}/Fight/start",
                new FightOpponentsDto { Player = gameModel.Player, Enemy = gameModel.Enemy }
            );
            gameModel.FightResult = await result.Content.ReadFromJsonAsync<FightResultDto>();
        }

        return View(gameModel);
    }
}