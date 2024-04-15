using API5_1.Classes;
using API5_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace API5_1.Controllers;

[ApiController]
[Route("animals")]
public class AnimalController: ControllerBase
{
    private IMockDB _mockDb;

    public AnimalController(IMockDB mockDb)
    {
        _mockDb = mockDb;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_mockDb.GetAll());
    }

    [HttpPost]
    public IActionResult Add(AnimalProp animalProp)
    {
        _mockDb.Add(animalProp);
        return Created();
    }

    [HttpPut("{id}")]
    public IActionResult Replace(AnimalProp animalProp, int id)
    {
        if (_mockDb.Replace(animalProp, id))
            return Ok();
        return Problem();

    }

    [HttpDelete("{id}")]
    public IActionResult Remove(int id)
    {
        if (_mockDb.Remove(id))
            return Ok();
        return Problem();
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var animal = _mockDb.Get(id);
        return animal is not null ? Ok(animal) : Problem();
    }

    [HttpPost("{id}")]
    public IActionResult AddVisit(Visit visit, int id)
    {
        if (_mockDb.AddVisit(visit, id))
            return Ok();
        return Problem();
    }

}