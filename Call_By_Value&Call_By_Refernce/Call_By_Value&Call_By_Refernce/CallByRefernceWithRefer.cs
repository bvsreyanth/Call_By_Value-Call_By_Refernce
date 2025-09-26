namespace CallByValue
{
    internal class CallByRefernceWithRefer
    {
        public void Callbyvalu()
        {
            int a = 15;
            int b = 20;
            Callbyvalu1(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Callbyvalu1(ref int b, ref int c)//15,20
        {
            b = 30;
            c = 40;
        }
       
    }
}
