using WEB.API.Attributes;

namespace WEB.API.Services
{
    public interface IPrivilegeService
    {
    }

    public class PrivilegeService: IPrivilegeService
    {

    }

    [First("Kaihan")]
    [Author("Hossein Ahmadi")]
    public class ReadService:PrivilegeService
    {
        public ReadService()
        {
            
        }
        public void GetName()
        {
            Console.WriteLine("Hello World ...");
        }
    }
}
