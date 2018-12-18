namespace Basic
{
    public class Approach2
    {
        public interface ICustomerDataAccess
        {
            string GetCustomerName(int id);
        }

        public class CustomerDataAcces : ICustomerDataAccess
        {
            public string GetCustomerName(int id)
            {
                return "Dummy Customer Name";
            }
        }

        public class CustomerBusinessLogic
        {
            private readonly ICustomerDataAccess _customerDataAccess;

            public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
            {
                _customerDataAccess = customerDataAccess;
            }

            public string GetCustomerName(int id)
            {
                return _customerDataAccess.GetCustomerName(id);
            }
        }

        public class CustomerService
        {
            private readonly CustomerBusinessLogic _businessLogic;

            public CustomerService()
            {
                _businessLogic = new CustomerBusinessLogic(new CustomerDataAcces());
            }

            public string GetCustomerName(int id)
            {
                return _businessLogic.GetCustomerName(id);
            }
        }
    }
}
