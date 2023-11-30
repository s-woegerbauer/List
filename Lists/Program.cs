namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OwnList<int> list = new OwnList<int>();

            for(int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine(list[4]);
        }
    }
}