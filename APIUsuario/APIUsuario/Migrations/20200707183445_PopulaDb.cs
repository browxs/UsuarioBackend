using Microsoft.EntityFrameworkCore.Migrations;

namespace APIUsuario.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Usuarios(Nome, Sobrenome, Email, DataNascimento, Escolaridade) "+
                "Values('Bruno', 'Sousa', 'bruno@teste.com', getdate(), 1)");

            migrationBuilder.Sql("Insert into Usuarios(Nome, Sobrenome, Email, DataNascimento, Escolaridade) " +
                "Values('Priscilla', 'Alves', 'priscilla@teste.com', getdate(), 2)");

            migrationBuilder.Sql("Insert into Usuarios(Nome, Sobrenome, Email, DataNascimento, Escolaridade) " +
                "Values('João', 'Silva', 'lucas@teste.com', getdate(), 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("");
        }
    }
}
