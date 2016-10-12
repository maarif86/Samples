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
            url: '/company',
            template: '<ui-view />'
        })
        .state('company.create', {
            url: '/create',
            templateUrl: '/company/create'
        })
        .state('company.list', {
            url: '/list',
            templateUrl: "/company/list"
        })
        .state('project', {
            url: "project",
            templateUrl: "management/project/index"
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