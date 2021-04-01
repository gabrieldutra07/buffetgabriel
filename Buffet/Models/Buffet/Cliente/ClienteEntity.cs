using System;
using System.ComponentModel.DataAnnotations;
using Buffet.ViewModels.Shared;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        public int Id { get; set; } 
        [Required] public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Idade { get; set; }
        
        public StatusConvidado StatusConvidado { get; set; }
    }
}