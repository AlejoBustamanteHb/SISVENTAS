(function () {
    'use strict';

    angular.module("app")
        .controller("IndexController", IndexController)
        .controller("CategoriaController", CategoriaController)
        .controller("ArticuloController", ArticuloController);

    CategoriaController.$inject = ['$scope', '$http'];
    ArticuloController.$inject = ['$scope', '$http']; 
    IndexController.$inject = ['$scope', '$http'];


    function IndexController($scope) {
        window.s = $scope;
        $scope.myInterval = 3000;
        $scope.slides = [

            { route: '/Theme/slider1.jpg' },
            { route: '/Theme/slider2.jpg' },
            { route: '/Theme/slider3.jpg' },
            { route: '/Theme/slider4.jpg' },
            { route: '/Theme/slider6.jpg' },
            { route: '/Theme/slider7.jpg' },
            { route: '/Theme/slider8.jpg' }


        ];


    }//Fin IndexController


    function CategoriaController($scope, $http) {

        $scope.data = [];

        getCategorias();

        function getCategorias() {
            $http.get('/PublicCategory/CategoryList')
            .then(function (response) {
                console.log((response.data));
                $scope.data = (response.data);
            }, function (error) {
                console.log(error);
            });
        }


        $scope.filterbyCatId = function (id) {

            $http.get('/ControlClient/ArticleList')
            .then(function (response) {
                if (response.data.idcategoria === id) {
                    $scope.almacenarCat = (response.data);
                }
            }, function (error) {
                console.log(error);
            });

        }

    }// FIN CATEGORY CONTROLLER


    //Controlador para Llamadas a los Articulos
    function ArticuloController($scope, $http) {
        $scope.data2 = [];

        getArticles();

        window.s = $scope;

        function getArticles() {
            $http.get('/ControlClient/ArticleList')
            .then(function (response) {
                $scope.data2 = (response.data);
            }, function (error) {
                console.log(error);
            });
        }

    }


})();

