using System;
using System.Data.SqlClient;

namespace CSharp_UsingStatement
{
    class Program
    {
        // http://stackoverflow.com/questions/212198/what-is-the-c-sharp-using-block-and-why-should-i-use-it

        public class MyDisposableClass : IDisposable
        {
            public void Dispose()
            {
            }
        }

        public class SimpleClass
        {

        }

        static void Main(string[] args)
        {
            using (var conn = new SqlConnection())
            {
                //conn.
                
            }

            //This is same 
            /*
            var conn = new SqlConnection();
            try
            {

            }
            finally
            {
                conn.Dispose();
            }
            */
            // It produces compile error.
            /*
            using (var simple = new SimpleClass)
            {
                
            }
            */

            // It is good.
            using (var disp = new MyDisposableClass())
            {
                
            }
        }
    }
}
