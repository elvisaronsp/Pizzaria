﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Contato))]
    public class Contato
    {
        [Key]
        [ForeignKey(nameof(Cliente))]
        public int ClienteID { get; set; }
        [MaxLength(13, ErrorMessage = "Telefone do Cliente deve conter no máximo 12 caracteres {0} {1}")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefone Fixo esta em um formato incorreto")]
        public string Fixo { get; set; }    
        [MaxLength(13, ErrorMessage = "Telefone do Cliente deve conter no máximo 13 caracteres {0} {1}")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Telefone Celular esta em um formato incorreto")]
        [Required(ErrorMessage ="Celular é obrigatório")]
        public string Celular { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}