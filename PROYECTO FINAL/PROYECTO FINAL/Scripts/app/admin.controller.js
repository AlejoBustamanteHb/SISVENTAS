
(function () {

    'use strict';
    angular
        .module("app2")
        .controller("adminController", adminController);

    adminController.$inject = ['$scope', '$http'];

    function adminController($scope, $http) {

        $scope.listPersons = [];

        getAllPeople();
        
        function getAllPeople() {
            $http
            .get('/Admin/ListPersons')
            .then(
                function (response) {
                    console.log(response);
                    $scope.listPersons = response.data;
                },
                function (error) {
                    console.log(error);
                }
            );
        }

    }//Fin ADMINCTRL

    
})();