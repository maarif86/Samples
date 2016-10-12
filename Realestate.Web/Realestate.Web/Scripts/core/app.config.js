function config($stateProvider, $urlRouterProvider, $locationProvider) {

    $urlRouterProvider.otherwise('dashboard');

    $stateProvider
        .state('dashboard', {
            url: "/dashboard",
            templateUrl: "/dashboard/index"
        })
        .state('project', {
            abstract: true,
            url: "/project",
            templateUrl: "management/index"
        })
        .state('newProject', {
            url: "/management/project/new",
            templateUrl: "/management/project/new"
        });

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
}

angular
    .module('realestate')
    .config(config)
    .run(function ($rootScope, $state) {
        $rootScope.$state = $state;
    });