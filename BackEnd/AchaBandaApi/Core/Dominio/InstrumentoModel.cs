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
    }
}