using practice_6;

public interface IParent
{
    string info();
    double cost();
}
class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        IParent transport;

        for (int i = 0; i < 5; i++)
        {
            int speed = rnd.Next(1,101);
            int costOfProduction = rnd.Next(1,1001);
            bool isSeaTransport = rnd.Next(0, 2) == 0;

            if (isSeaTransport)
            {
                transport = new Child1(speed, costOfProduction);
            }
            else
            {
                int roadTax = rnd.Next(1, 1001);
                transport = new Child2(speed, costOfProduction, roadTax);
            }
            transport.cost();
            Console.WriteLine(transport.info());

        }
    }
}