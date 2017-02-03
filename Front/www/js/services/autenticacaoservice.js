angular.module('app').service('AutenticacaoService', ['$q', '$resource',

    function ($q, $resource) {

        var self = this;

        self.autenticar = function () {

            return $q(function (resolve, reject) {
                   
                   var resource = $resource(config.urls.loginAPI);

                    debugger;
                    resource.get({id: 2}, function(response){
                        resolve(response);
                    }, function(error){
                        reject(error);
                    });

                }
            );
        };

    }

]);