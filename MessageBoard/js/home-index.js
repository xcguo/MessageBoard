//home-index.js

function homeIndexController($scope, $http) {
    $scope.dataCount = 0;
    $scope.data = [];
    $scope.isBusy = true;

    $http.get("/api/topics?includeReplies=true")
    .then(function (result) {
        //successful
        angular.copy(result.data, $scope.data);
        $scope.dataCount = result.data.length;
    },
    function () {
        // error
        alert("could not load topics");
    })
    .then(function () {
        $scope.isBusy = false;
    });
}