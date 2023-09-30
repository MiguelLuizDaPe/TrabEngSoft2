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

        usuario.HasKey(d => d.usuario_id);

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
            .IsFixedLength()
            .HasMaxLength(16)
            .IsRequired();
        
        usuario
            .Property(u => u.status)
            .IsRequired();
        
        usuario
            .Property(u => u.quantidade_passe)
            .IsRequired();
        
        usuario
            .Property(u => u.data_registro)
            .IsRequired();

        usuario
            .Property(u => u.local_moradia)
            .HasMaxLength(100)
            .IsRequired();

        usuario
            .Property(u => u.categoria)
            .IsRequired();

        usuario
            .Property(u => u.motociclista)
            .IsRequired();

        usuario
            .HasOne(u => u.endereco)
            .WithOne(e => e.usuario)
            .HasForeignKey<Usuario>(u => u.endereco_id)
            .IsRequired();

        // usuario
        //     .HasMany(u => u.documentos)
        //     .WithOne(d => d.usuario)
        //     .HasForeignKey(d => d.usuario_id);

        endereco.HasKey(d => d.endereco_id);

        endereco
            .Property(e => e.cep)
            .IsFixedLength()
            .HasMaxLength(9)
            .IsRequired();

        endereco
            .Property(e => e.estado)
            .HasMaxLength(100)
            .IsRequired();

        endereco
            .Property(e => e.cidade)
            .HasMaxLength(100)
            .IsRequired();

        endereco
            .Property(e => e.bairro)
            .HasMaxLength(100)
            .IsRequired();

        endereco
            .Property(e => e.logradouro)
            .HasMaxLength(100)
            .IsRequired();

        endereco
            .Property(e => e.complemento)
            .HasMaxLength(100)
            .IsRequired();

        documento.HasKey(d => d.documento_id);

        // documento
        //     .HasOne(u => u.usuario)
        //     .WithMany(d => d.documentos)
        //     .HasForeignKey(d => d.usuario_id);

        documento
            .Property(e => e.nome)
            .HasMaxLength(100)
            .IsRequired();

        documento
            .Property(e => e.url)
            .HasMaxLength(200)
            .IsRequired();

        documento
            .Property(e => e.passe)
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
                    endereco_id = 1,
                    endereco = new Endereco(){
                            cep = "123456789",
                            estado = "kkk",
                            cidade = "risadas",
                            bairro = "ali",
                            logradouro = "bem ali",
                            complemento = "tas cego porra?",
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