using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webapi.Entites;

public class Documento {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int documento_id {get;set;}

    [Required]
    [MaxLength(80)]
    public string nome {get;set;} = "";

    [Required]
    [MaxLength(200)]
    public string url {get;set;} = "";

    [Required]
    public bool passe {get;set;}

    [ForeignKey("usuario_id")]
    public int usuario_id {get;set;}
}