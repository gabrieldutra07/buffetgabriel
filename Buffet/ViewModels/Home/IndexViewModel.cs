using System.Collections;
using System.Collections.Generic;
using Buffet.Models.Buffet.Cliente;

namespace Buffet.ViewModels.Home
{
    public class IndexViewModel
    {
        public string InformacaoQualquer { get; set; }
        public string Titulo { get; set; }

        public Usuario UsuarioLogado { get; set; }
        
        public ICollection<Cliente> Clientes { get; set; }

        public IndexViewModel(ICollection<Cliente> clientes)
        {
            Clientes = clientes;
        }
    }
    
    

    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string Id { get; set; }
    }
}