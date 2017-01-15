angular.module('app').controller('instrumentoCtrl', 
    ['$scope','InstrumentoFactory','$ionicNavBarDelegate','$location',
    function ($scope, InstrumentoFactory, $ionicNavBarDelegate, $location) {

        var cadastrar = this;
        $ionicNavBarDelegate.showBackButton(false);
        cadastrar.formData = InstrumentoFactory.bindLoginFormData;
        cadastrar.formData.listInstrumentos = [];
        
        $scope.ratingsObject = {
            iconOn: 'ion-ios-star',    //Optional
            iconOff: 'ion-ios-star-outline',   //Optional
            iconOnColor: 'rgb(17,193,243)',  //Optional
            iconOffColor:  'rgb(17,193,243)',    //Optional
            rating:  2, //Optional
            minRating:1,    //Optional
            readOnly: true, //Optional
            callback: function(rating, index) {    //Mandatory
            $scope.ratingsCallback(rating, index);
            }
        };
        
        $scope.ratingsCallback = function(rating, index) {
            cadastrar.formData.rating = rating;
        };
        
        cadastrar.addInstrumento = function(){
            
            cadastrar.formData.listInstrumentos.push({
                id: cadastrar.formData.listInstrumentos.length,
                nome: cadastrar.formData.instrumento,
                rating: cadastrar.formData.rating
            });

            console.log(cadastrar.formData.listInstrumentos);
        };

        cadastrar.removeInstrumento = function(item){
           
            for(var i in cadastrar.formData.listInstrumentos){
                if(cadastrar.formData.listInstrumentos[i].id === item.id)
                {
                   cadastrar.formData.listInstrumentos.splice(i, 1); 
                   console.log(i);
                }
            }
        };

        cadastrar.cadastrar = function(){
            
            $location.path('/menu.home');
        }
    }
]);