angular.module('app').controller('instrumentoCtrl', 
    ['$scope','EntrarFactory','$ionicNavBarDelegate','$location',
    function ($scope, EntrarFactory, $ionicNavBarDelegate, $location) {

        var cadastrar = this;
        $ionicNavBarDelegate.showBackButton(false);
        cadastrar.formData = EntrarFactory.bindLoginFormData;
        
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
            console.log('Selected rating is : ', rating, ' and the index is : ', index);
        };
        
        cadastrar.cadastrar = function(){
            
            debugger;
            $location.path('/menu.home');
            
            
        }
    }
]);