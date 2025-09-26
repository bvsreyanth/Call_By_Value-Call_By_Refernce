namespace CallByValue
{
    internal class CallByRefernceWithValue
    {
        public class Students
        {
            public int Id;
            public string? Name;

        }
        public void Callbyvalu()
        {
            Students obj = new Students();
            obj.Id = 1;
            obj.Name = "Ravi";
            Students obj1 = obj;
            obj1.Id = 2;
            obj.Name = "Kumar";
            Console.WriteLine(obj.Id);
            UpdateReference(ref obj1);
            Console.WriteLine(obj1.Name);

        }
        public static void UpdateReference(ref Students obj1)
        {
            Students obj12 = new Students();
            obj12.Id = 1;
            obj12.Name = "Raj";
            obj1 = obj12;
        }
       
    }
}

