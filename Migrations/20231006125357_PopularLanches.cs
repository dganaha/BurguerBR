using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurguerBR.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco)  VALUES(1,'Pão,hamburguer,ovo,presunto,queijo e batata palha','Delicioso pão com hamburguer 120gr, ovo frito; presunto e queijo acompanhado com batata palha',1,'http://www.teste.net/Imagens/lanches/cheesesalada1.jpg','http://www.teste.net/Imagens/lanches/cheesesalada1.jpg',0,'Cheese Salada',19.99)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco)  VALUES(2,'Pão australiano,hamburguer,queijo sem lactose, tomate','Delicioso pão australiano com hamburguer 180gr de fraldinha; queijo sem lactose, bacon e tomate',1,'http://www.teste.net/Imagens/lanches/cheesesalada2.jpg','http://www.teste.net/Imagens/lanches/cheesesalada2.jpg',0,'Burguer 0 lactose',24.99)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco)  VALUES(1,'Pão sem gluten,hamburguer,queijo,bacon e alface','Delicioso pão sem gluten com hamburguer 180gr de fraldinha, queijo, bacon, tomate e alface',1,'http://www.teste.net/Imagens/lanches/cheesesalada1.jpg','http://www.teste.net/Imagens/lanches/cheesesalada3.jpg',0,'Burguer 0 gluten',25.99)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco)  VALUES(1,'Pão especial,hamburguer,queijo cheddar, cebola, rucula, e batata palha','Delicioso pão especial com hamburguer 180gr de picanha, queijo cheddar, cebola caramelizada, rucula',1,'http://www.teste.net/Imagens/lanches/cheesesalada4.jpg','http://www.teste.net/Imagens/lanches/cheesesalada4.jpg',1,'Burguer Picanha',32.99)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
