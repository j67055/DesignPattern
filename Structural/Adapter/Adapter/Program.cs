namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Galaxy galaxy = new Galaxy("Galaxy Note 10");
            IPhone iphone = new IPhone("IPhone 14");

            CAdapter cAdapter = new CAdapter(galaxy);
            computer.connect(cAdapter);
            computer.printData();

            Lightning8PinAdapter lightning8PinAdapter = new Lightning8PinAdapter(iphone);
            computer.connect(lightning8PinAdapter);
            computer.printData();
        }
    }
}
