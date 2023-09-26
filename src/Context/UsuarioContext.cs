using Microsoft.EntityFrameworkCore;
using Webapi.Entites;

namespace Webapi.Contexts;

public class UsuarioContext : DbContext
{
    public DbSet<Usuario> usuario { get; set; } = null!;
    public DbSet<Endereco> endereco { get; set; } = null!;
    public DbSet<Documento> decumento { get; set; } = null!;

    public UsuarioContext(DbContextOptions<UsuarioContext> options)
    : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .HasData(
                new Usuario()
                {
                    usuario_id = 1,
                    nome_completo = "Bill Gates",
                    cpf = "95395994076",
                    telefone = "(12)11234-1234",
                    email = "kkk@gmail.br",
                    senha = "hahahasenha",
                    status = 0,
                    quantidade_passe = 0,
                    data_registro = new TimeOnly(7, 23, 11),
                    local_moradia = "ali po kkkk",
                    categoria = false,
                    motociclista = true,
                });


        base.OnModelCreating(modelBuilder);
    }

}