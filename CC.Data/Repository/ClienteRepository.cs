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
}
