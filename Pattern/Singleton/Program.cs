namespace Singleton
{
    class Singleton
    {
        static Singleton _instance;

        public string Name { get; set; }

        public static Singleton GetInstance()
        {
            return _instance == null ? _instance = new Singleton() : _instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sing1 = Singleton.GetInstance();
            sing1.Name = "hello";

            var sing2 = Singleton.GetInstance();

            var temp = sing2.Name;

        }
    }
}
