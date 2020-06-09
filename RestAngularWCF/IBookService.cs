using RestAngularWCF.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestAngularWCF
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/AddBook")]
        void AddBook(Book book);

        [OperationContract]
        [WebInvoke(Method = "OPTIONS",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/AddBook")]
        void AddBookOptions(Book book);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "DeleteBook/{BookId}")]
        void DeleteBook(string bookId);

        [OperationContract]
        [WebInvoke(Method = "OPTIONS",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "DeleteBook/{BookId}")]
        void DeleteBookOptions(string bookId);

        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetBook/")]
        List<Book> GetBook();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetBookDetails/{BookId}")]
        Book GetBookDetails(string bookId);

        [OperationContract]
        [WebInvoke(Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/UpdateBook")]
        void UpdateBook(Book book);
    }
}
