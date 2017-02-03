using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchaBandaApi.Core.Dominio
{
    [Table("usuarioInstrumento")]
    public class UsuarioInstrumentoModel
    {
        [Key]
        public long idUsuarioInstrumento { get; set; }
        public long idUsuario { get; set; }
        public long idInstrumento { get; set; }
    }
}