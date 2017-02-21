angular.module('app').service('AutenticacaoService', ['$q', '$resource',

    function ($q, $resource) {

        var self = this;

        self.autenticar = function (obj) {

            return $q(function (resolve, reject) {
                   
                   var resource = $resource(config.urls.loginAPI);

                    debugger;
                    resource.get({id: obj}, function(response){
                        resolve(response);
                    }, function(error){
                        reject(error);
                    });

                }
            );
        };

        self.cadastrar = function(obj){

            return $q(function(resolve, reject){
                debugger;
               
                var resource = $resource(config.urls.loginAPI, null, {
                    save: { method: 'PUT' }
                });

                resource.save(obj, function(response){
                    resolve(response);
                }, function(error){
                    reject(error);
                });

            });

        };

    }

]);