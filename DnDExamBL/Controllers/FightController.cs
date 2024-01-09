using System.Text.Json.Nodes;
using DnDExamBL.Services;
using DnDExamModels.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DnDExamBL.Controllers;

[ApiController]
[Route("[controller]")]
public class FightController : Controller
{
    private readonly DndDbContext _dbContext;
    private readonly IFightService _fightService;

    public FightController(DndDbContext dbContext, IFightService fightService)
    {
        _dbContext = dbContext;
        _fightService = fightService;
    }
    
    [HttpGet]
    [Route("random")]
    public JsonResult GetRandomCreature()
    {
        var randomIndex = new Random().Next(_dbContext.Enemies.Count());
        return Json(_dbContext.Enemies.AsEnumerable().ElementAt(randomIndex));
    }
    
    [HttpPost]
    [Route("start")]
    public JsonResult GetFightResult([FromBody] FightOpponentsDto opponents)
    {
        _fightService.Player = opponents.Player;
        _fightService.Enemy = opponents.Enemy;
        var result = _fightService.GetResult();
        var json = Json(result);
        return json;
    }
}