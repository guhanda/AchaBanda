using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchaBandaApi.Core.Dominio
{
    [Table("estilo")]
    public class EstiloModel
    {
        [Key]
        public int IdEstilo { get; set; }
        public string NmEstilo { get; set; }
        public int IndAvaliacao { get; set; }
        public bool FlAtivo { get; set; }
    }
}