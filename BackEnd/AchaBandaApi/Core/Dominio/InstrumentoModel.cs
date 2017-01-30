using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchaBandaApi.Core.Dominio
{
    [Table("instrumento")]
    public class InstrumentoModel
    {
        [Key]
        public long IdInstrumento { get; set; }
        public string NmInstrumento { get; set; }
        public int IdTipoInstrumento { get; set; }
        public int IndAvaliacao { get; set; }
        public bool FlAtivo { get; set; }
    }
}