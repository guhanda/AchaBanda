

angular.module('app').service('CadastrarService', ['$q', '$resource', 
    function($q, $resource){
        var self = this;

        self.buscarInstrumentos = function(){
            return $q(function(resolve, reject){

                var resource = $resource(config.urls.buscarInstrumento);

                resource.query(function(response){
                    resolve(response);
                }, function(response){
                    reject(response);
                });

            });
        };
    }]);