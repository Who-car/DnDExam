using System.ComponentModel.DataAnnotations;
using DnDExamModels;
using DnDExamModels.Dto;
using DnDExamUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDExamUI.Controllers;

public class GameController : Controller
{
    private const string DbUrl = "http://localhost:5055/enemy/random";
    private const string BlUrl = "http://localhost:5257/fight/start";

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
            var enemy = await client.GetFromJsonAsync<EnemyModel>(DbUrl);
            gameModel.Enemy = enemy;
            var result = await client.PostAsJsonAsync(
                BlUrl,
                new FightOpponentsDto { Player = gameModel.Player, Enemy = gameModel.Enemy }
            );
            gameModel.Result = await result.Content.ReadFromJsonAsync<List<FightResultDto>>();
        }

        return View(gameModel);
    }
}