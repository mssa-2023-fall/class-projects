using SmartFiles;


class Program
{
    static void Main()
    {
        Program m = new Program();
        //delegate instantiation using "MultiplyNumbers"
        Action<int, double> d = (m, n) => Console.Write(m * n + " "); //anon function
       
        //invoke the delegate object.
        Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
        for (int i = 1; i<= 5;  i++)
        {
            d.Invoke(i, 2);
        }

        //keep the console window open
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }

    ///declare the associated method
    ///void MultiplyNumbers(int, m, double n)
    ///   {
    ///     Console.Write(m * n*a + " ");
    ///   }
}