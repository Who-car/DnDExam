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

    public FightController(DndDbContext dbContext)
    {
        _dbContext = dbContext;
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
        var fightService = new FightService(opponents.Player, opponents.Enemy);
        var result = fightService.GetResult();
        var json = Json(result);
        return json;
    }
}