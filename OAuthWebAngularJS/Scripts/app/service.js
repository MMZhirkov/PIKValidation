/// <reference path="../angular.min.js" />
/// <reference path="module.js" />

app.service("OAuthWebAngularJS", function ($http) {
    this.checkLogin = function (login) {
        return $http.get("http://localhost:58717/OAuthService.svc/CheckLogin/" + login);
    }
});