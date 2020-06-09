/// <reference path="../angular.min.js" />
/// <reference path="module.js" />

app.service("CRUD_AngularJs_RESTService", function ($http) {
    //Create new record  
    this.post = function (Book) {
        var request = $http({
            method: "post",
            url: "http://localhost:58896/BookService.svc/AddBook",
            data: Book
        });
        return request;
    }

    //Update the Record  
    this.put = function (BookId, Book) {
        debugger;
        var request = $http({
            method: "put",
            url: "http://localhost:58896/BookService.svc/UpdateBook",
            data: Book
        });
        return request;
    }

    this.getBook = function () {
        return $http.get("http://localhost:58896/BookService.svc/GetBook");
    };

    //Get Single Records  
    this.get = function (BookId) {
        return $http.get("http://localhost:58896/BookService.svc/GetBookDetails/" + BookId);
    }

    //Delete the Record  
    this.delete = function (BookId) {
        var request = $http({
            method: "delete",
            url: "http://localhost:58896/BookService.svc/DeleteBook/" + BookId
        });
        return request;
    }
});
