namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Hash Table and Binary Search Tree");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            hash.Remove("0");
            hash.Remove("1");
            hash.Remove("2");
            hash.Remove("3");
            hash.Remove("4");
            hash.Remove("5");
            hash.Remove("6");


            string hash0 = hash.Get("0");
            Console.WriteLine("0th index value: " + hash0);
            string hash1 = hash.Get("1");
            Console.WriteLine("1st index value: " + hash1);
            string hash2 = hash.Get("2");
            Console.WriteLine("2nd index value: " + hash2);
            string hash3 = hash.Get("3");
            Console.WriteLine("3rd index value: " + hash3);
            string hash4 = hash.Get("4");
            Console.WriteLine("4th index value: " + hash4);
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);



        }
    }
}