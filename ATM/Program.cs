namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ////_________________________________________________________________________________________________________________________________________________________

            ////////// .........BANK SYSTEM.........

            double Balance = 0, WthdrawAmount;

            string Choosing;
            while (true)
            {
                Console.WriteLine("1) To Deposit ");
                Console.WriteLine("2) To Wthdraw ");
                Console.WriteLine("3) to Exist");
                Console.WriteLine(" enter your choosing..");
                Choosing = Console.ReadLine();
                switch (Choosing)
                {
                    case "1":
                        Console.Write("enter the amount of deposit  mony.. ");
                        Balance += double.Parse(Console.ReadLine());
                        Console.WriteLine("your depoist succesfully");
                        break;
                    case "2":
                        Console.Write("enter the amount of wthdraw mony.. ");
                        WthdrawAmount = double.Parse(Console.ReadLine());
                        if (Balance < WthdrawAmount)
                            Console.WriteLine("yuo dont have that amount of monay ????");
                        else
                        {
                            Console.WriteLine($"you wthdraw succesfully ({WthdrawAmount})");
                            Balance -= WthdrawAmount;
                        }
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Wrong choosing try again !! ");
                        break;
                }
                if (Choosing == "3")
                {
                    break;
                }

            }
            Console.ReadKey();

        }
    }
}