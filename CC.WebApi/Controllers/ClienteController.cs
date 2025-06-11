using CC.Core.Domain;
using CC.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CC.WebApi.Controllers;

[ApiController]
public class ClienteController : ApiControllerBase
{
    private readonly IClienteManager _clienteManager;

    public ClienteController(IClienteManager clienteManager)
    {
        _clienteManager = clienteManager;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _clienteManager.GetClientesAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _clienteManager.GetClienteAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Cliente cliente)
    {
        var clienteInserido = await _clienteManager.InsertClienteAsync(cliente);

        return CreatedAtAction(nameof(Get), new { id = cliente.ClienteId }, cliente);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] Cliente cliente)
    {
        var clienteAtualizado = await _clienteManager.UpdateClienteAsync(cliente);

        if (clienteAtualizado == null)
            return NotFound();

        return Ok(clienteAtualizado);   
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _clienteManager.DeleteClienteAsync(id);

        return NoContent();
    }
}
