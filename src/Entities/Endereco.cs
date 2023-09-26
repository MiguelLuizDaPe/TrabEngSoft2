using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webapi.Entites;

public class Endereco{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int endereco_id {get;set;}

    [Required]
    [MaxLength(9)]
    public string cep {get;set;} = "";

    [Required]
    [MaxLength(50)]
    public string estado {get;set;} = "";

    [Required]
    [MaxLength(80)]
    public string cidade {get;set;} = "";

    [Required]
    [MaxLength(80)]
    public string bairro {get;set;} = "";

    [Required]
    [MaxLength(80)]
    public string logradouro {get;set;} = "";

    [Required]
    [MaxLength(100)]
    public string complemento {get;set;} = "";

    [ForeignKey("usuario_id")]
    public int usuario_id {get;set;}
}