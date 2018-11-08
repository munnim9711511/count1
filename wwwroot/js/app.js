var app = angular.module("app", []);
app.controller("updateNews", ($scope,$http)=>{
    $scope.Info ;
    $http.get("/admin/getInfo").then((data)=>{
        // console.log(data);
        Info = data;
        console.log(Info)
    });
    

  }
);
