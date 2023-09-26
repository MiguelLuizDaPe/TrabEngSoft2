using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webapi.Entites;

public class Usuario{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int usuario_id {get;set;}

    [Required]
    [MaxLength(100)]
    public string nome_completo {get;set;} = "";

    [Required]
    [MaxLength(14)]//com mascara estilo (47)91234-1234
    public string telefone {get;set;} = "";

    [Required]
    [MaxLength(50)]
    public string email {get;set;} = "";

    [Required]
    [MaxLength(100)]
    public string senha {get;set;} = "";

    [Required]
    [MaxLength(14)]//estilo mascara 123.123.123-12
    public string cpf {get;set;} = "";

    [Required]
    public int status {get;set;}

    [Required]
    public int quantidade_passe {get;set;}

    [Required]
    public TimeOnly data_registro {get;set;}

    [Required]
    [MaxLength(100)]
    public string local_moradia {get;set;} = "";

    [Required]
    public bool categoria {get;set;}

    [Required]
    public bool motociclista {get;set;}

    public Endereco? endereco {get;set;}
    public List<Documento> documentos {get;set;} = new();
}