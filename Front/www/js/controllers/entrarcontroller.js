angular.module('app').controller('entrarCtrl', ['$scope', '$stateParams','Facebook','EntrarFactory','$location','$ionicNavBarDelegate', 'AutenticacaoService','localStorageService',
    function ($scope, $stateParams,Facebook,EntrarFactory, $location, $ionicNavBarDelegate, AutenticacaoService, localStorageService) {

        $ionicNavBarDelegate.showBackButton(false);
        
        var entrar = this;
        
        entrar.formData = EntrarFactory.bindLoginFormData;
        
        entrar.formData.Token = "";
        entrar.formData.Email = "";
        entrar.formData.Password = "";
        entrar.formData.Nome= "";

        Facebook.getLoginStatus(function (response) {

            if (response.status == 'connected') {
                userIsConnected = true;
            }
        });

        $scope.IntentLogin = function () {
            
            $scope.loginFacebook();
            
        };

        $scope.loginFacebook = function () {
            Facebook.login(function () {
                // não faz nada, deixa a resposta a cargo da promise
            }, { scope: 'public_profile,email' }).then(function (response) {
                console.log(response);
                debugger;

                if (response.status == 'connected') {

                    entrar.formData.Token = response.authResponse.accessToken;
                    $scope.logged = true;
                    $scope.me();
                }

            }, function (response) {
                debugger;
                login.msgRetorno = error;
            });
            
        };

        $scope.me = function () {

            Facebook.api('/me', function () {
                // não faz nada, deixa a resposta a cargo da promise
            }, { "fields": "email,first_name" }).then(function (response) {
                debugger;
            
                entrar.formData.Token = response.id;
                entrar.formData.Email = response.email;
                entrar.formData.Nome = response.first_name;
                entrar.formData.Password = "";
                
                submitLogin();
            });

        };
        
        function submitLogin(){
            debugger;
            //buscar o usuário
            var promise = AutenticacaoService.autenticar();

            promise.then(function(response){
                
                console.log(response);
                debugger;
                localStorageService.set('user',response)

                $location.path("/cadastrar");
                
            }, function(error){
                debugger;
                console.log(error);
            });

        };

    }
]);