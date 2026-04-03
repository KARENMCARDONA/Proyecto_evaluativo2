
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SponsorController : ControllerBase
{
    private readonly SponsorService _service = new SponsorService();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.GetAll());
    }

    [HttpPost]
    public IActionResult Create(SponsorRequestDTO dto)
    {
        var result = _service.Create(dto);
        return Created("", result);
    }
}
