using System;

#pragma warning disable

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var t = 0;
                var i = 32 / t;

                //throw new DivideByZeroException();
                //throw new ArgumentNullException();
            }
            catch (DivideByZeroException divEx)
            {
                Console.WriteLine("DivideByZeroException");
                //throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("{0} - {1}", ex.Source, ex.Message));
            }
            finally
            {
                //throw new ArgumentNullException();
            }

            try
            {
                throw new Exception();
            }
            catch
            {

            }
            finally
            {
                Console.WriteLine("Done!");
            }

            Console.ReadKey();
        }
    }
}
