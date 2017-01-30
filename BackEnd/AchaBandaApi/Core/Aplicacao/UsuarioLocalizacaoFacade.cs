using AchaBandaApi.Core.Dominio;
using AchaBandaApi.Core.Infraestrutura;
using Geolocation;
using System.Collections.Generic;
using Dapper;
using System.Linq;


namespace AchaBandaApi.Core.Aplicacao
{
    public class UsuarioLocalizacaoFacade : FacadeCRUD<UsuarioLocalizacaoModel>
    {
        public UsuarioLocalizacaoModel SelecionarUltimo(int id)
        {
            var retorno = connection.GetList<UsuarioLocalizacaoModel>("where idusuario = @id order by dataUltimaAlteracao desc", new { id = id });

            return retorno.FirstOrDefault();
        }

        public IEnumerable<UsuarioLocalizacaoModel> SelecionarProximos(UsuarioLocalizacaoModel item, int MaxKilometros)
        {
            IEnumerable<UsuarioLocalizacaoModel> retorno = new List<UsuarioLocalizacaoModel>() ;

            //Busca o MAX e o MIN de LONG e LAT
            // EntradaCordenadas - LONG e LAT do Usuario
            var milha = 0.62137;
            var distancia = MaxKilometros * milha;
            //

            var EntradaCordenadas = new Coordinate();
            EntradaCordenadas.Latitude = item.Latitude;
            EntradaCordenadas.Longitude = item.Longitude;

            var boundaries = new CoordinateBoundaries(EntradaCordenadas, distancia);
            double minLatitude = boundaries.MinLatitude;
            double maxLatitude = boundaries.MaxLatitude;
            double minLongitude = boundaries.MinLongitude;
            double maxLongitude = boundaries.MaxLongitude;

            var usuariosLista = connection.Query<UsuarioLocalizacaoModel>(
                @"select b.* from(select Max(idUsuarioLocalizacao) as id from usuarioLocalizacao group by idUsuario) as a inner join usuarioLocalizacao b on a.id = b.idUsuarioLocalizacao
                where idusuario <> @idusuario and latitude >= @minLatitude and latitude <= @maxLatitude and longitude >= @minLongitude and longitude <= @maxLongitude"
                , new { idusuario = item.IdUsuario, minLatitude = minLatitude, maxLatitude = maxLatitude, minLongitude = minLongitude, maxLongitude = maxLongitude });

            //var usuariosLista = connection.GetList<UsuarioLocalizacaoModel>("where idusuario <> @idusuario and latitude >= @minLatitude and latitude <= @maxLatitude and longitude >= @minLongitude and longitude <= @maxLongitude "
            //    , new {idusuario = item.IdUsuario, minLatitude = minLatitude, maxLatitude = maxLatitude, minLongitude = minLongitude, maxLongitude = maxLongitude });

            return usuariosLista;
        }
    }
}