namespace tema8w7
{
    internal class Locomotive
    {
        public void Start()
        {
            Console.WriteLine("locomotive is starting...");
        }
        public void Stop()
        {
            Console.WriteLine("locomotive is stopping...");
        }
    }

    class DieselLocomotive:Locomotive
    {
        private int power;
        public DieselLocomotive(int power)
        {
            this.power = power;
        }
    }
}
