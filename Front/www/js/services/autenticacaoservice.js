angular.module('app').service('AutenticacaoService', ['$q', '$resource',

    function ($q, $resource) {

        var self = this;

        self.autenticar = function (obj) {

            return $q(function (resolve, reject) {
                   
                   var resource = $resource(config.urls.getPorEmail + "?email=" + obj);

                    
                    resource.get(null, function(response){
                        resolve(response);
                    }, function(error){
                        reject(error);
                    });

                }
            );
        };

        self.cadastrar = function(obj){

            return $q(function(resolve, reject){
                
               
                var resource = $resource(config.urls.loginAPI, null, {
                    save: { method: 'POST' }
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