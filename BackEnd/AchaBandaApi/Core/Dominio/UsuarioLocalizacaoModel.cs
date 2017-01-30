using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchaBandaApi.Core.Dominio
{

    [Table("usuarioLocalizacao")]
    public class UsuarioLocalizacaoModel
    {
        [Key]
        [Editable(false)]
        public long IdUsuarioLocalizacao { get; set; }
        [Required]
        public long IdUsuario { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
    }
}