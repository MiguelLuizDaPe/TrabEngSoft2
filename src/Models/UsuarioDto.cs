using Webapi.Entites;

namespace Webapi.Models;

public class UsuarioDto{

    public int usuario_id {get;set;}

    public string nome_completo {get;set;} = "";

    public string telefone {get;set;} = "";

    public string email {get;set;} = "";

    public string senha {get;set;} = "";

    public string cpf {get;set;} = "";

    public int status {get;set;}

    public int quantidade_passe {get;set;}

    public TimeOnly data_registro {get;set;}

    public string local_moradia {get;set;} = "";

    public bool categoria {get;set;}

    public bool motociclista {get;set;}

    public Endereco? endereco {get;set;}
    public List<Documento> documentos {get;set;} = new();
}