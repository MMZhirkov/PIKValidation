using System.Runtime.Serialization;

namespace AuthWCF.BaseOperation
{
    [DataContract]
    public class BaseResponse
    {
        [DataMember]
        private string SuccessMessage { get; set; }

        [DataMember]
        private string[] ErrorMessages { get; set; }

        public BaseResponse()
        {
            SuccessMessage = "Успешно";
            ErrorMessages = new string[] { };
        }

        public BaseResponse(string message)
        {
            SuccessMessage = string.Empty;
            ErrorMessages = new string[] { message };
        }
    }
}