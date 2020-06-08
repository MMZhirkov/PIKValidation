using System.Runtime.Serialization;

namespace AuthWCF.BaseOperation
{
    [DataContract]
    public class BaseRequest
    {
        [DataMember]
        public string Login { get; set; }
    }
}