using APIUsuario.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace APIUsuario.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [NaoPermitirDataAtual]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Range(0, 3)]
        public int Escolaridade { get; set; }
    }
}
