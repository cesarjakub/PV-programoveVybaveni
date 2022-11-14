namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> sta = new MyStack<int>();
            sta.Push(5);
            sta.Push(2);
            sta.Push(3);
            sta.Push(4);


            while (!sta.IsEmpty())
            {
                Console.WriteLine(sta.Pop());
            }
        }
    }
}