using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webapi.Entites;

public class Documento {

    public int documento_id {get;set;}

    public string nome {get;set;} = "";

    public string url {get;set;} = "";

    public bool passe {get;set;}

    public int usuario_id {get;set;}
    public Usuario? usuario {get;set;}
}