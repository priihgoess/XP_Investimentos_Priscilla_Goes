using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Remove(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();

        IEnumerable<ClienteDto> GetByDetalhes();

        ClienteDto GetById(int id);
    }
}