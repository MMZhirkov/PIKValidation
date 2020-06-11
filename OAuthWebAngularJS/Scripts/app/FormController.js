/// <reference path="../angular.min.js" />  
/// <reference path="module.js" />  
/// <reference path="service.js" />  

app.controller("FormController",
    function FormController($scope, OAuthWebAngularJS) {
        $scope.checkLogin = function (login) {
            var promiseGetSingle = OAuthWebAngularJS.checkLogin(login);
            promiseGetSingle.then(function (pl) {
                if (pl.data.SuccessMessage) {
                    alert("Пользователь не найден, можно сохранить");
                    return;
                }
              
                alert(pl.data.ErrorMessages.join());
            },
            function (errorPl) {
                console.log('Some Error in Getting Details', errorPl);
            });
        };
});
