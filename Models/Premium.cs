using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Omenino.Models;
public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id{ get; set; }

    [Required(ErrorMessage = "informe o titulo do Premium")]
    [StringLength(80, ErrorMessage = "O Titulo deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = " O titulo deve conter pelo menos 5 caracteres")]
    [DisplayName("Titulo")]
    public string Title { get; set;} = string.Empty;

    [DataType(DataType.DateTime)]
  
    [DisplayName("Inicio")]
    public DateTime StartDate {get; set; }

    [DataType(DataType.DateTime)]
    [DisplayName("Término")]
    public DateTime EndDate { get; set;}

    [DisplayName ("Aluno")]
    [Required(ErrorMessage = "Aluno inválido")]
    public int StudentId { get; set; }
    public Student? Student {get; set;}

}

