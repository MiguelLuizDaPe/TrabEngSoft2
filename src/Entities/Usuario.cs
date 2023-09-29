using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webapi.Entites;

public class Usuario{

    public int usuario_id {get;set;}


    public string nome_completo {get;set;} = "";

//com mascara estilo (47)91234-1234
    public string telefone {get;set;} = "";


    public string email {get;set;} = "";


    public string senha {get;set;} = "";

//estilo mascara 123.123.123-12
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