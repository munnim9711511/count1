var app = angular.module("app", []);
app.controller("updateNews", ($scope,$http)=>{
    $scope.Info ;
    $scope.name = "shahu";
    $http.get("/admin/getInfo").then((data)=>{
        
         Info = data.data;
         console.log(Info);
       
    });
    


  }
);
