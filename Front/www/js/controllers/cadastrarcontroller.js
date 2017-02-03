angular.module('app').controller('cadastrarCtrl', 
    ['$scope','EntrarFactory','$ionicNavBarDelegate','$location','$ionicPopup','$ionicSlideBoxDelegate', 'CadastrarService',
    function ($scope, EntrarFactory, $ionicNavBarDelegate, $location,$ionicPopup,$ionicSlideBoxDelegate,CadastrarService) {

        var cadastrar = this;
        
        cadastrar.step = 0;
        
        cadastrar.titulo = "Cadastrar";
        cadastrar.promise = null;
        
        $ionicNavBarDelegate.showBackButton(false);
        cadastrar.formData = EntrarFactory.bindLoginFormData;
        
        cadastrar.formData.listInstrumentos = [];
        cadastrar.formData.listInstrumentosDisponiveis = [];
            
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

        cadastrar.pageLoad = function(){

            cadastrar.carregarInstrumentos();

        };

        cadastrar.carregarInstrumentos = function(){

            cadastrar.promise = CadastrarService.buscarInstrumentos();

            cadastrar.promise.then(function(response){

                cadastrar.formData.listInstrumentosDisponiveis = response;
                
            }, function(error){

                debugger;

            });

        }
        
        $scope.ratingsCallback = function(rating, index) {
            cadastrar.formData.rating = rating;
        };
        
        cadastrar.addInstrumento = function(){
            debugger;
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
            
            var obj = jslinq(cadastrar.formData.listInstrumentosDisponiveis)
                            .where(function(value){ return value.IdInstrumento == cadastrar.formData.instrumento; })
                            .singleOrDefault(function (el){ return el;});


            obj.rating = cadastrar.formData.rating;

            cadastrar.formData.listInstrumentos.push(obj);

            //cadastrar.zerarRatings();
        };

        cadastrar.removeInstrumento = function(item){
           
            for(var i in cadastrar.formData.listInstrumentos){
                if(cadastrar.formData.listInstrumentos[i].IdInstrumento === item.IdInstrumento)
                {
                   cadastrar.formData.listInstrumentos.splice(i, 1); 
                   console.log(i);
                }
            }
        };
        
        cadastrar.filterAlreadyAdded = function(item){
            
            var retorno = jslinq(cadastrar.formData.listInstrumentos)
                            .where(function(value){ return value.IdInstrumento == item.IdInstrumento; }).count();
            
            return (retorno == 0);
            //return (cadastrar.formData.listInstrumentos.index(item) == -1);
        };
        
        cadastrar.irInstrumentos = function(){
        
            var alertPopup = $ionicPopup.alert({
                title: 'Selecionar',
                template: 'Escolha até 3 instrumentos que você toca.',
                buttons: [
                    {
                        text: '<b>Beleza</b>',
                        type: 'button-energized',
                    }
                ]
            });
            cadastrar.titulo = "Quais instrumentos você toca?";
            cadastrar.step = 1;
            
        };
        
        cadastrar.irEstilos = function(){
            
            var alertPopup = $ionicPopup.alert({
                title: 'Selecionar',
                template: 'Escolha até 5 estilos que você curte.',
                buttons: [
                    {
                        text: '<b>Beleza</b>',
                        type: 'button-energized',
                    }
                ]
            });
            cadastrar.titulo = "Quais estilos você curte?";
            cadastrar.step = 2;
            
        };
        
        cadastrar.concluir = function(){
            
            cadastrar.step = 0;
            cadastrar.titulo = "Cadastrar";
            
            $location.path('/side-menu21/menu.home');
        };
        
    }
]);