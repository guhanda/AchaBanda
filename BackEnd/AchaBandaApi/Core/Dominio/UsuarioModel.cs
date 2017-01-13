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
    }
}