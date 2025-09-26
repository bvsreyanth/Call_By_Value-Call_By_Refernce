namespace CallByValue
{
    internal class OutKeyword
    {
        public static void IncrementByValue(out int x, out int y)
        {
            x = 34;
            x = x + 1;
            y = x;

            Console.WriteLine($"The value of x and y {x},{y}");
        }
       
    }

}

