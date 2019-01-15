using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cats.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cats.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class CatsController : ControllerBase
  {
    public List<Cat> Cats = new List<Cat>()
    {
  new Cat("Josie", "Little white cat"),
  new Cat("Bobby", "Little black kitten"),
  new Cat("George", "One bad kitty")
    };

    [HttpGet]
    public IEnumerable<Cat> Get()
    {
      return Cats;
    }
    [HttpGet("{id}")]
    public ActionResult<Cat> GetAction(int id)
    {
      try
      {
        return Cats[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH CAT\"}");
      }
    }
    [HttpPost]
    public ActionResult<List<Cat>> Post([FromBody] Cat cat)
    {
      Cats.Add(cat);
      return Cats;
    }
    [HttpPut("{id}")]
    public ActionResult<List<Cat>> Put(int id, [FromBody] Cat cat)
    {
      try
      {
        Cats[id] = cat;
        return Cats;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH CAT\"}");
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<List<Cat>> Delete(int id)
    {
      try
      {
        Cats.Remove(Cats[id]);
        return Cats;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH CAT\"}");
      }
    }
  }
}



