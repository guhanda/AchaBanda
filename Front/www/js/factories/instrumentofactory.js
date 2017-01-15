(function() {
  'use strict';

  angular.module('app').factory('InstrumentoFactory', [
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
        entrarFormData.instrumento = "";
        entrarFormData.rating = 2; //nivel inicial
      }
    }
  ]);

})();
