(function() {
  angular.module('app').factory('LoginResource', [
    '$resource', function($resource) {
      return $resource(config.urls.loginAPI, null, {
        'update': {
          method: 'PUT'
        }
      });
    }
  ]);

}).call(this);
