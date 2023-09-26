using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Webapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    enderecoid = table.Column<int>(name: "endereco_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cep = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    estado = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    cidade = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    bairro = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    logradouro = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    complemento = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    usuarioid = table.Column<int>(name: "usuario_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.enderecoid);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    usuarioid = table.Column<int>(name: "usuario_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomecompleto = table.Column<string>(name: "nome_completo", type: "character varying(100)", maxLength: 100, nullable: false),
                    telefone = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    senha = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    cpf = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    quantidadepasse = table.Column<int>(name: "quantidade_passe", type: "integer", nullable: false),
                    dataregistro = table.Column<TimeOnly>(name: "data_registro", type: "time without time zone", nullable: false),
                    localmoradia = table.Column<string>(name: "local_moradia", type: "character varying(100)", maxLength: 100, nullable: false),
                    categoria = table.Column<bool>(type: "boolean", nullable: false),
                    motociclista = table.Column<bool>(type: "boolean", nullable: false),
                    enderecoid = table.Column<int>(name: "endereco_id", type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.usuarioid);
                    table.ForeignKey(
                        name: "FK_usuario_endereco_endereco_id",
                        column: x => x.enderecoid,
                        principalTable: "endereco",
                        principalColumn: "endereco_id");
                });

            migrationBuilder.CreateTable(
                name: "decumento",
                columns: table => new
                {
                    documentoid = table.Column<int>(name: "documento_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    url = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    passe = table.Column<bool>(type: "boolean", nullable: false),
                    usuarioid = table.Column<int>(name: "usuario_id", type: "integer", nullable: false),
                    usuarioid1 = table.Column<int>(name: "usuario_id1", type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_decumento", x => x.documentoid);
                    table.ForeignKey(
                        name: "FK_decumento_usuario_usuario_id1",
                        column: x => x.usuarioid1,
                        principalTable: "usuario",
                        principalColumn: "usuario_id");
                });

            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "usuario_id", "categoria", "cpf", "data_registro", "email", "endereco_id", "local_moradia", "motociclista", "nome_completo", "quantidade_passe", "senha", "status", "telefone" },
                values: new object[] { 1, false, "95395994076", new TimeOnly(7, 23, 11), "kkk@gmail.br", null, "ali po kkkk", true, "Bill Gates", 0, "hahahasenha", 0, "(12)11234-1234" });

            migrationBuilder.CreateIndex(
                name: "IX_decumento_usuario_id1",
                table: "decumento",
                column: "usuario_id1");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_endereco_id",
                table: "usuario",
                column: "endereco_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "decumento");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "endereco");
        }
    }
}
