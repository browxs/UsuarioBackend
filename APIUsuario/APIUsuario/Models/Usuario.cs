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
        public string Email { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public Escolaridade Escolaridade { get; set; }
    }

    public enum Escolaridade
    {
        Infantil, Fundamental, Medio, Superior
    }
}
