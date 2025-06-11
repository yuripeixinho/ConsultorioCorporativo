using CC.Core.Domain;

namespace CC.Manager.Interfaces;

public interface IClienteManager
{
    Task<Cliente> GetClienteAsync(int id);
    Task<IEnumerable<Cliente>> GetClientesAsync();
    Task<Cliente> InsertClienteAsync(Cliente cliente);
    Task<Cliente> UpdateClienteAsync(Cliente cliente);
    Task DeleteClienteAsync(int ClienteId);
}
