angular.module('app.routes', [])

.config(function($stateProvider, $urlRouterProvider) {

  // Ionic uses AngularUI Router which uses the concept of states
  // Learn more here: https://github.com/angular-ui/ui-router
  // Set up the various states which the app can be in.
  // Each state's controller can be found in controllers.js
  $stateProvider
  
  .state('menu.home', {
    url: '/menu.home',
    views: {
      'side-menu21': {
        templateUrl: 'templates/home.html',
        //controller: 'homeCtrl'
      }
    }
  })

  .state('menu.perfil', {
    url: '/menu.perfil',
    views: {
      'side-menu21': {
        templateUrl: 'templates/perfil.html',
        //controller: 'homeCtrl'
      }
    }
  })

  .state('menu.instrumentos', {
    url: '/menu.instrumentos',
    views: {
      'side-menu21': {
        templateUrl: 'templates/instrumento.html',
        //controller: 'homeCtrl'
      }
    }
  })  

  .state('menu.buscar', {
    url: '/page2',
    views: {
      'side-menu21': {
        templateUrl: 'templates/buscar.html',
        controller: 'buscarCtrl'
      }
    }
  })

  .state('menu.cloud', {
    url: '/page3',
    views: {
      'side-menu21': {
        templateUrl: 'templates/cloud.html',
        controller: 'cloudCtrl'
      }
    }
  })

  .state('menu', {
    url: '/side-menu21',
    templateUrl: 'templates/menu.html',
    controller: 'menuCtrl'
  })

  .state('menu.resultado', {
    url: '/page4',
    views: {
      'side-menu21': {
        templateUrl: 'templates/resultado.html',
        controller: 'resultadoCtrl'
      }
    }
  })

  .state('entrar', {
    url: '/page6',
    templateUrl: 'templates/entrar.html',
    controller: 'entrarCtrl'
  })
  
  .state('cadastrar', {
    url: '/cadastrar',
    templateUrl: 'templates/cadastrar.html',
  })
 
  $urlRouterProvider.otherwise('/page6')

});