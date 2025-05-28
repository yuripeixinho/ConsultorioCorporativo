using CC.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CC.WebApi.Controllers;

[ApiController]
public class ClienteController : ApiControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new List<Cliente>()
        {
            new Cliente
            {
                ClienteId = 1,
                DataNascimento = new DateTime(2003, 01, 21),
                Nome = "Yuri"
            }
        });
    }

    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
