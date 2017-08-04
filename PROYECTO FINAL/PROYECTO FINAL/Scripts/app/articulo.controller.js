(function () {

    'use strict';
    angular
        .module("app3")
        .controller("articuloController", articuloController);

    articuloController.$inject = ['$scope', '$http'];

    function articuloController($scope, $http) {

        $scope.data2 = [];

        getArticles();

        window.s = $scope;

        function getArticles() {
            $http.get('/ControlClient/ArticleList')
            .then(function (response) {
                console.log(respose);
                $scope.data2 = (response.data);
            }, function (error) {
                console.log(error);
            });
        }

    }//Fin articuloController


})();