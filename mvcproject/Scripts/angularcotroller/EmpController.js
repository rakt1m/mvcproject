var app = angular.module("Homeapp", []);

 

app.controller("HomeController", function ($scope, $http) {

    $scope.btntext = "Save";

    // Add record

    $scope.savedata = function () {

        $scope.btntext = "Please Wait..";

        $http({

            method: 'POST',

            url: '/Emp/AddEmp',

            data: $scope.Employee

        }).success(function (d) {

            $scope.btntext = "Save";

            $scope.Employee = null;

            alert(d);

        }).error(function () {

            alert('Failed');

        });

    };


    // Display all record

    $http.get("/Emp/Get_data").then(function (d) {

        $scope.record = d.data;

    }, function (error) {

        alert('Failed');

    });
   

    // Display record by id

    $scope.loadrecord = function (id) {

        $http.get("/Emp/Get_databyid?id=" + id).then(function (d) {

            $scope.Employee = d.data[0];

        }, function (error) {

            alert('Failed');

        });

    };

    // Delete record

    $scope.deleterecord = function (id) {

        $http.get("/Emp/Delete_record?id=" + id).then(function (d) {

            alert(d.data);

            $http.get("/Home/Get_data").then(function (d) {

                $scope.record = d.data;

            }, function (error) {

                alert('Failed');

            });

        }, function (error) {

            alert('Failed');

        });

    };

    // Update record

    $scope.updatedata = function () {

        $scope.btntext = "Please Wait..";

        $http({

            method: 'POST',

            url: '/Emp/Update_record',

            data: $scope.Employee

        }).success(function (d) {

            $scope.btntext = "Update";

            $scope.Employee = null;

            alert(d);

        }).error(function () {

            alert('Failed');

        });

    };




});