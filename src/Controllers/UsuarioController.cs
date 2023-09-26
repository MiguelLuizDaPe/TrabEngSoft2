using Microsoft.AspNetCore.Mvc;
using Webapi.Entites;
using Webapi.Contexts;

namespace Webapi.Controllers;

[ApiController]
[Route("api/usuario")]
public class UserController : ControllerBase
{
    private readonly UsuarioContext _context;

    public UserController(UsuarioContext context){
        _context = context;
    }

    [HttpGet("usuario_id", Name = "GetUser")]
    public ActionResult<Usuario> GetUser(int usuario_id)
    {
        var userdb = _context.usuario.FirstOrDefault(u => u.usuario_id == usuario_id);
        if(userdb == null) return NotFound();
        return Ok(userdb);
    }

    [HttpPost]
    public ActionResult<Usuario> CreateUser(Usuario usuario)
    {
        _context.usuario.Add(usuario);
        _context.SaveChanges();
        return NoContent();
    }
}
