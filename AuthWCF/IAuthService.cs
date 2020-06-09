using AuthWCF.BaseOperation;
using System.ServiceModel;

namespace AuthWCF
{



    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        BaseResponse CheckLogin(BaseRequest request);
    }
}
