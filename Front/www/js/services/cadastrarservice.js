

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

        self.buscarEstilos = function(){
            return $q(function(resolve, reject){
                var resource = $resource(config.urls.buscarEstilo);

                resource.query(function(response){
                    resolve(response);
                }, function(response){
                    reject(response);
                });
            });
        };

        self.cadastrarUsuarioInstrumento = function(obj){

             return $q(function(resolve, reject){
                 
                var resource = $resource(config.urls.cadastrarUsuarioInstrumento, null, {
                    'update': { method:'PUT' }
                });

                resource.update(obj, function(response){
                    resolve(response);
                }, function(response){
                    reject(response);
                });
            });

        };

        self.cadastrarUsuarioEstilo = function(obj){

             return $q(function(resolve, reject){
                 
                var resource = $resource(config.urls.cadastrarUsuarioEstilo, null, {
                    'update': { method:'PUT' }
                });

                resource.update(obj, function(response){
                    resolve(response);
                }, function(response){
                    reject(response);
                });
            });

        };

    }]);