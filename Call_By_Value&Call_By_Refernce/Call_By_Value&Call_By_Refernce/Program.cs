using CallByValue;

namespace Call_By_Value_Call_By_Refernce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call By Refernce With Refer
            CallByRefernceWithRefer obj = new CallByRefernceWithRefer();
            obj.Callbyvalu();

            ////CallByRefernceWithValue
            //CallByRefernceWithValue callByValueWithRef = new CallByRefernceWithValue();
            //callByValueWithRef.Callbyvalu();

            ////CallByvalueWithRefernce
            //CallByvalueWithRefernce callByvalueWithRefernce = new CallByvalueWithRefernce();
            //callByvalueWithRefernce.Callbyvalu();

            ////CallbyvaluewithValue
            //CallbyvaluewithValue callbyvalue = new CallbyvaluewithValue();
            //callbyvalue.Callbyvalu();
            //callbyvalue.Callbyvalu2();

            //////OutKeyword
            //int num;
            //int num1;
            //OutKeyword.IncrementByValue(out num, out num1);
            //Console.WriteLine($"The value of num and num1 {num},{num1}");
            //Console.ReadLine();
        }
    }
}