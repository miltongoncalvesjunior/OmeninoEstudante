using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Omenino.Models
{
  
public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id{get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage ="O nome deve contar o minino de 5 caracteres")]
    [DisplayName("Nome completo")]
    public string Name {get; set;} = string.Empty;

    [Required(ErrorMessage = "informe o Seu E-mail")]
    [EmailAddress(ErrorMessage = "E-mail Incorreto")]
    [DisplayName("E-mail")]
      public string Email  {get; set;} = string.Empty;

    public List<Premium> Premiums {get; set;} = new();
    
}
}