using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchaBandaApi.Core.Dominio
{
    [Table("usuarioEstilo")]
    public class UsuarioEstiloModel
    {
        [Key]
        public long idUsuarioEstilo { get; set; }
        public long idUsuario { get; set; }
        public long idEstilo { get; set; }
    }
}