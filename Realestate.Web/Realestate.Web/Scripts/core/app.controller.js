function MainController() {
    this.Title = "Index";
}

function DashboardController() {
    this.Title = "Dashboard"
}

angular
    .module('realestate')
    .controller('MainController', MainController)
    .controller('DashboardController', DashboardController);
