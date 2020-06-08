using AuthWCF.BaseOperation;
using System.ServiceModel;

namespace AuthWCF
{
    [ServiceContract]
    public interface AuthService
    {
        [OperationContract]
        BaseResponse CheckLogin(BaseRequest request);
    }
}
