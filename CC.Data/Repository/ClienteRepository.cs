using CC.Core.Domain;
using CC.Data.Context;
using CC.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CC.Data.Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly CCContext _context;

    public ClienteRepository(CCContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Cliente>> GetClientesAsync()
    {
        return await _context.Clientes.AsNoTracking().ToListAsync();
    }

    public async Task<Cliente> GetClienteAsync(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }

    public async Task<Cliente> InsertClienteAsync(Cliente cliente)
    {
        await _context.Clientes.AddAsync(cliente);  
        await _context.SaveChangesAsync();
        
        return cliente;
    }

    public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
    {
        var clienteConsultado = await _context.Clientes.FindAsync(cliente.ClienteId);

        if (clienteConsultado == null)
            return null;

        _context.Entry(clienteConsultado).CurrentValues.SetValues(cliente); // verifica os campos que foram alterados e atualiza seus valores 
       /* _context.Clientes.Update(clienteConsultado);*/ // quando se usa o Entry não é necessário utilizar o .Update, ele já faz isso de forma implícita
        await _context.SaveChangesAsync();
        return clienteConsultado;
    }

    public async Task DeleteClienteAsync(int ClienteId)
    {
        var clienteConsultado = await _context.Clientes.FindAsync(ClienteId);

        if (clienteConsultado == null)
            throw new Exception("Cliente não encontrado.");

        _context.Clientes.Remove(clienteConsultado);    

        await _context.SaveChangesAsync();  
    }
}
