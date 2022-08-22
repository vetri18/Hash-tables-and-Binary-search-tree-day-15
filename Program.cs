namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);

            hash.GetFreq();



            Console.ReadKey();

        }
    }
}