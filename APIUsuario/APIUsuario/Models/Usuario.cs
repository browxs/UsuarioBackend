namespace APIUsuario.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public Escolaridade Escolaridade { get; set; }
    }

    public enum Escolaridade
    {
        Infantil, Fundamental, Medio, Superior
    }
}
