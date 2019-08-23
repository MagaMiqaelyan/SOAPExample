using System.ServiceModel;

namespace Services
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        string GetMessage(string msg);
    }
}
