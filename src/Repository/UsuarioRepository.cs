using Microsoft.EntityFrameworkCore;
using Webapi.Contexts;
using Webapi.Entites;
using Webapi.Models;

namespace Webapi.Repository;

public class UsuarioRepository{
    private readonly UsuarioContext _context;

    public UsuarioRepository(UsuarioContext context){
        _context = context;
    }

    public List<Usuario> GetUsuarios(){
        return _context.usuario.Include(u => u.endereco).Include(u => u.documentos).ToList();
    }

    public Usuario GetUsuarioById(int a){
        return _context.usuario.FirstOrDefault(u => u.usuario_id == a)!;
    }

    public void AddUsuario(Usuario user){
        _context.usuario.Add(user);
    }

    public void RemoveUsuario(Usuario user){
        _context.usuario.Remove(user);
    }



    public List<Endereco> GetEnderecos(){
        return _context.endereco.ToList();
    }

    public Endereco GetEnderecoById(int a){
        return _context.endereco.FirstOrDefault(u => u.usuario_id == a)!;
    }

    public void AddEndereco(Endereco endereco){
        _context.endereco.Add(endereco);
    }

    public void RemoveEndereco(Endereco endereco){
        _context.endereco.Remove(endereco);
    }





    public List<Documento>? GetDocumentos(int usuarioId){
        var usuarioFromDatabase = GetUsuarioById(usuarioId);
        return usuarioFromDatabase.documentos;
    }

    public Documento GetDocumentoById(int a){
        return _context.decumento.FirstOrDefault(u => u.usuario_id == a)!;
    }

    public void AddDocumento(Usuario user, Documento documento){
        user.documentos.Add(documento);
    }

    public void RemoveUsuario(Usuario user, Documento documento){
        user.documentos.Add(documento);
    }

    public void SaveChanges(){
        _context.SaveChanges();
    }

}