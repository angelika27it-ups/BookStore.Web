using System.Text;
using BookStore.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers;

public class BookController : Controller
{
    // GET /Book/Hello
    public IActionResult Hello()
    {
        return Content("Witaj w BookStore!", "text/plain; charset=utf-8");
    }

    // GET /Book/Status?code=418
    public IActionResult Status(int code = 200)
    {
        if (code < 100 || code > 599)
            return BadRequest("Kod statusu musi być z zakresu 100–599.");

        return StatusCode(code);
    }

    // GET /Book/Details/3
    public IActionResult Details(int id)
    {
        ViewBag.Id = id;
        return View();
    }

    // GET /Book/Echo?name=Ala&count=3
    public IActionResult Echo(
        [FromQuery] string name = "nieznajomy",
        [FromQuery] int count = 1)
    {
        count = Math.Clamp(count, 1, 20);

        return Content(
            string.Join("\n", Enumerable.Repeat($"Cześć, {name}!", count)),
            "text/plain; charset=utf-8");
    }

    // GET /Book/Square/7
    [HttpGet("Book/Square/{id:int}")]
    public IActionResult Square(int id)
    {
        return Json(new { id, square = (long)id * id });
    }

    // POST /Book/Import
    [HttpPost]
    public IActionResult Import([FromBody] BookDto dto)
    {
        return Json(new
        {
            received = dto.Title,
            isbn = dto.Isbn,
            price = dto.Price
        });
    }

    // GET /Book/Inspect
    public IActionResult Inspect()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Method: {Request.Method}");
        sb.AppendLine($"Path: {Request.Path}{Request.QueryString}");

        foreach (var header in Request.Headers)
            sb.AppendLine($"{header.Key}: {header.Value}");

        return Content(sb.ToString(), "text/plain; charset=utf-8");
    }

    // GET /Book/Sum?a=2&b=3
    public IActionResult Sum(int a, int b)
    {
        return Content((a + b).ToString());
    }

    // GET /Book/UserAgent
    public IActionResult UserAgent()
    {
        return Content(
            Request.Headers.UserAgent.ToString(),
            "text/plain; charset=utf-8");
    }

    // GET /Book/Health
    public IActionResult Health()
    {
        return Json(new
        {
            status = "ok",
            time = DateTime.Now
        });
    }
}
