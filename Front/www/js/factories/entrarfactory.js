(function() {
  'use strict';

  angular.module('app').factory('EntrarFactory', [
    function() {

      // set variables
      var entrarFormData = {};
      resetLoginFormData();

      // set service
      var service = {
        bindLoginFormData: bindLoginFormData
      };

      return service;

      // public
      // used to bind loginFormData to controller
      function bindLoginFormData() {
        return entrarFormData;
      }

      // private
      // reset login form data
      function resetLoginFormData() {
        entrarFormData.Token = "";
        entrarFormData.Email = "";
        entrarFormData.Password = "";
        entrarFormData.Nome= "";
        entrarFormData.instrumento = "";
        entrarFormData.rating = 2; //nivel inicial
      }
    }
  ]);

})();
