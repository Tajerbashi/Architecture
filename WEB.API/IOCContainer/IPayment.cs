namespace WEB.API.IOCContainer
{
    public interface IPayment
    {
        string Pay();
    }

    public class Mellat : IPayment
    {
        public string Pay()
        {
            return "Pay With Bank Mellat...";
        }
    }
    public class Sepah : IPayment
    {
        public string Pay()
        {
            return "Pay With Bank Sepah...";
        }
    }
    public class Buy
    {
        private readonly IPayment _payment;
        public Buy(IPayment payment)
        {
            _payment = payment;
        }
        public string Pay()
        {
            return _payment.Pay();
        }
    }
}
