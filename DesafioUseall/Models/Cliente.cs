using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioUseall.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Display(Name = "Codigo")]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }
        
        [Required]
        [Display(Name = "CNPJ")]
        public int Cnpj { get; set; }

        [Display(Name = "Data Cadastro")]
        [Required]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Endereco")]
        [Required]
        public string Endereco { get; set; }

        [Display(Name = "Telefone")]
        [Required]
        public string Telefone { get; set; }
    }
}
