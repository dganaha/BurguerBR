using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurguerBR.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" + "VALUES ('Padrao','Lanche feito com ingredientes basicos')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" + "VALUES ('ZeroLactose','Lanche feito com ingredientes sem lactose')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" + "VALUES ('ZeroGluten','Lanche feito com ingredientes sem gluten')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" + "VALUES ('Premium','Lanche feito com ingredientes premium')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
