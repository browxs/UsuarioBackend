using Microsoft.EntityFrameworkCore.Migrations;

namespace APIUsuario.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Usuarios(Nome, Sobrenome, Email, DataNascimento, Escolaridade) "+
                "Values('Bruno', 'Sousa', 'bruno@teste.com', '1992-03-17', 3)");

            migrationBuilder.Sql("Insert into Usuarios(Nome, Sobrenome, Email, DataNascimento, Escolaridade) " +
                "Values('Maria', 'Barbosa', 'maria@teste.com', '1989-08-04', 2)");

            migrationBuilder.Sql("Insert into Usuarios(Nome, Sobrenome, Email, DataNascimento, Escolaridade) " +
                "Values('João', 'Silva', 'joao@teste.com', '1987-05-12', 0)");

            migrationBuilder.Sql("Insert into Usuarios(Nome, Sobrenome, Email, DataNascimento, Escolaridade) " +
                "Values('José', 'Andrade', 'jose@teste.com', '1985-07-27', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("");
        }
    }
}
