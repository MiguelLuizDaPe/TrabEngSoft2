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
        var usuario = modelBuilder.Entity<Usuario>();
        var endereco = modelBuilder.Entity<Endereco>();
        var documento = modelBuilder.Entity<Documento>();

        usuario
            .Property(u => u.nome_completo)
            .HasMaxLength(100)
            .IsRequired();
        
        usuario
            .Property(u => u.telefone)
            .IsFixedLength()
            .HasMaxLength(13)
            .IsRequired();

        usuario
            .Property(u => u.email)
            .HasMaxLength(100)
            .IsRequired();

        usuario
            .Property(u => u.senha)
            .HasMaxLength(100)
            .IsRequired();
        
        usuario
            .Property(u => u.cpf)
            .HasMaxLength(100)
            .IsRequired();
        
        usuario
            .Property(u => u.status)
            .IsRequired();
        
        usuario
            .Property(u => u.senha)
            .HasMaxLength(100)
            .IsRequired();
        
        usuario
            .Property(u => u.senha)
            .HasMaxLength(100)
            .IsRequired();
        


        






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
                    endereco = new Endereco(){
                        endereco_id = 1,
                        cep = "122345543",
                        estado = "ali",
                        cidade = "nages",
                        bairro = "pipi",
                        logradouro = "kkkk perto",
                        complemento = "legal",
                        usuario_id = 1
                    },
                    documentos = new List<Documento>(){
                        new Documento(){
                            documento_id = 1,
                            nome = "pedro",
                            url = "aaaaaaaaaaaaaaaaaaaa",
                            passe = false,
                            usuario_id = 1
                        },
                        new Documento(){
                            documento_id = 2,
                            nome = "pedra",
                            url = "bb",
                            passe = false,
                            usuario_id = 1
                        }
                    }
                });


        base.OnModelCreating(modelBuilder);
    }

}