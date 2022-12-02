namespace LearnCSharp.Study.Delegate__Func__Lambda
{
    public delegate void Hello(string name);
    public  class LearnLambdaExpression
    {
        public static void main(string args)
        {
            Hello hello = delegate (string name)
            {
                Console.WriteLine($"Hi {name}.");
            };

            Hello hello2 =  (name)=>
            {
                Console.WriteLine($"Hi {name}.");
            };


            Hello hello3 = name => Console.WriteLine($"Hi {name}.");
            
            hello("Alisher");
            hello2("Botir");
            hello3("Jamol");
            // new codes  vuuuu
            // new codes
            // new codes
        }

    }
}
