using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webapi.Entites;

public class Endereco{
    public int endereco_id {get;set;}
//9
    public string cep {get;set;} = "";

    public string estado {get;set;} = "";

    public string cidade {get;set;} = "";

    public string bairro {get;set;} = "";

    public string logradouro {get;set;} = "";

    public string complemento {get;set;} = "";

    public int usuario_id {get;set;}
    public Usuario? usuario {get;set;}
}