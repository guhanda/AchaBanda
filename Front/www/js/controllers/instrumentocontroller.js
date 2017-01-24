angular.module('app').controller('instrumentoCtrl', 
    ['$scope','InstrumentoFactory','$ionicNavBarDelegate','$location','$ionicPopup',
    function ($scope, InstrumentoFactory, $ionicNavBarDelegate, $location,$ionicPopup) {

        var cadastrar = this;
        $ionicNavBarDelegate.showBackButton(false);
        cadastrar.formData = InstrumentoFactory.bindLoginFormData;
        cadastrar.formData.listInstrumentos = [];
        cadastrar.formData.listInstrumentosDisponiveis = [];
        
        cadastrar.formData.listInstrumentosDisponiveis.push(
            {id: 0, nome: "GUITARRA"},
            {id: 1, nome: "BATERIA"},
            {id: 2, nome: "TECLADO"},
            {id: 3, nome: "BAIXO"});
            
        cadastrar.zerarRatings = function(){
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
        };
                     
        $scope.ratingsCallback = function(rating, index) {
            cadastrar.formData.rating = rating;
        };
        
        cadastrar.addInstrumento = function(){
            
            if(cadastrar.formData.listInstrumentos.length >= 3)
            {
                
                var alertPopup = $ionicPopup.alert({
                    title: 'Ops!',
                    template: 'Você já tem 3 instrumentos cadastrados.',
                    buttons: [
                        {
                            text: '<b>Beleza</b>',
                            type: 'button-calm',
                        }
                    ]
                });
                
                return false;
            }
            
            cadastrar.formData.listInstrumentos.push({
                id: cadastrar.formData.listInstrumentosDisponiveis[cadastrar.formData.instrumento].id,
                nome: cadastrar.formData.listInstrumentosDisponiveis[cadastrar.formData.instrumento].nome,
                rating: cadastrar.formData.rating
            });

            cadastrar.zerarRatings();
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
        
        cadastrar.filterAlreadyAdded = function(item){
            
            var retorno = jslinq(cadastrar.formData.listInstrumentos)
                            .where(function(value){ return value.id == item.id; }).count();
            
            return (retorno == 0);
            //return (cadastrar.formData.listInstrumentos.index(item) == -1);
        };

        cadastrar.cadastrar = function(){
            
            $location.path('/menu.home');
        }
        
        cadastrar.pageLoad = function(){
            cadastrar.zerarRatings();
        }
    }
]);