using Microsoft.AspNetCore.Mvc;
using Webapi.Entites;
using Webapi.Contexts;
using Webapi.Models;
using AutoMapper;
using Webapi.Repository;

namespace Webapi.Controllers;

[ApiController]
[Route("api/usuario")]
public class UserController : ControllerBase
{
    private readonly UsuarioContext _context;
    private readonly IMapper _mapper;
    private readonly UsuarioRepository _repository;

    public UserController(UsuarioContext context, IMapper mapper, UsuarioRepository repository){
        _context = context;
        _mapper = mapper;
        _repository = repository;
    }

    [HttpGet("usuario_id", Name = "GetUser")]
    public ActionResult<Usuario> GetUser(int usuario_id)
    {
        var userdb = _repository.GetUsuarioById(usuario_id);
        if(userdb == null) return NotFound();
        return Ok(userdb);
    }

    [HttpPost]
    public ActionResult<Usuario> CreateUser(UsuarioForCreateDto usuarioDto)
    {
        var usuarioEntity = _mapper.Map<Usuario>(usuarioDto);
        _repository.AddUsuario(usuarioEntity);
        return NoContent();
    }
}
