namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            point1:counter += 1;
            Console.WriteLine(counter);
            if(counter == 10)
            {
                goto point2;
            }
            goto point1;
        point2: Console.WriteLine("End");
        }
    }
}