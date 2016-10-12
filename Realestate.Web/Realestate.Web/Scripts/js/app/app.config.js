/**
 * Application
 *
 * Each view are defined as state.
 * Initial there are written state for all view in theme.
 *
 */
function config($stateProvider, $urlRouterProvider, $locationProvider) {
    //$urlRouterProvider.otherwise("/index/main");

    //$ocLazyLoadProvider.config({
    //    // Set to true if you want to see what and when is dynamically loaded
    //    debug: false
    //});

    $stateProvider
        .state('dashboard', {
            url: 'dashboard',
            templateUrl: '/dashboard/index'
        })
        .state('company', {
            abstract: true,
            url: '/management/company',
            template: '<ui-view />'
        })
        .state('company.create', {
            url: '/create',
            templateUrl: '/management/company/create'
        })
        .state('company.list', {
            url: '/list',
            templateUrl: "/management/company/list"
        })
        .state('project', {
            abstract: true,
            url: "/management/project",
            template: '<ui-view />'
        })
        .state('project.create', {
            url: '/create',
            templateUrl: '/management/project/create'
        })
        .state('project.list', {
            url: '/list',
            templateUrl: '/management/project/list'
        })


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