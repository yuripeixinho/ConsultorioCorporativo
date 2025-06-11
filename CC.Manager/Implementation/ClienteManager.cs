﻿using CC.Core.Domain;
using CC.Manager.Interfaces;

namespace CC.Manager.Implementation;

public class ClienteManager : IClienteManager
{
    private readonly IClienteRepository _clienteRepository; 

    public ClienteManager(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<IEnumerable<Cliente>> GetClientesAsync()
    {
        return await _clienteRepository.GetClientesAsync();
    }

    public async Task<Cliente> GetClienteAsync(int id)
    {
        return await _clienteRepository.GetClienteAsync(id);   
    }

    public async Task<Cliente> InsertClienteAsync(Cliente cliente)
    {
        return await _clienteRepository.InsertClienteAsync(cliente);
    }

    public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
    {
        return await _clienteRepository.UpdateClienteAsync(cliente);
    }

    public async Task DeleteClienteAsync(int ClienteId)
    {
        await _clienteRepository.DeleteClienteAsync(ClienteId);
    }
}
