using System;

namespace RestApiModeloDDD.Application.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string EnderecoPrincipal { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
    }
}