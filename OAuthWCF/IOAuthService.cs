using OAuthWCF.BaseOperation;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace OAuthWCF
{
    [ServiceContract]
    public interface IOAuthService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "/CheckLogin/{login}")]
        BaseResponse CheckLogin(string login);
    }
}