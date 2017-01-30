using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace AchaBandaApi.Core.Dominio
{
    
    [Table("usuario")]
    public class UsuarioModel
    {
        [Key]
        public long idUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Celular { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Token { get; set; }

    }
}