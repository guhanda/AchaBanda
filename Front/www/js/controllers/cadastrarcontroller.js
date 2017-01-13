angular.module('app').controller('cadastrarCtrl', 
    ['$scope','EntrarFactory','$ionicNavBarDelegate','$location',
    function ($scope, EntrarFactory, $ionicNavBarDelegate, $location) {

        var cadastrar = this;
        $ionicNavBarDelegate.showBackButton(false);
        cadastrar.formData = EntrarFactory.bindLoginFormData;
        
        cadastrar.cadastrar = function(){
            
            debugger;
            $location.path('/instrumento');
            
            
        }
    }
]);