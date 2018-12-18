namespace Basic
{
    public class Approach1
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

        public class DataAccessFactory
        {
            public static ICustomerDataAccess GetCustomerDataAccessObj()
            {
                return new CustomerDataAcces();
            }
        }

        public class CustomerBusinessLogic
        {
            private readonly ICustomerDataAccess _customerDataAccess;

            public CustomerBusinessLogic()
            {
                _customerDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
            }

            public string GetCustomerName(int id)
            {
                return _customerDataAccess.GetCustomerName(id);
            }
        }
    }
}
