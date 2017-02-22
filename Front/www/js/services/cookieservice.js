angular.module('app').service('CookieService', ['$base64','localStorageService',

    function ($base64, localStorageService) {

        this.gravarCookieUsuario = function(usuario){

            
            localStorageService.set('user', $base64.encode(JSON.stringify(usuario)));

        };

        this.retornarCookieUsuario = function(){

            
            var user = localStorageService.get('user');

            if(user)
            {
                return JSON.parse($base64.decode(user));
            }

            return false;            

        };

    }

]);