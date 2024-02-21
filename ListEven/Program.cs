namespace ListEven
{
    internal class Program
    {
        private static List<int> listEven;

        static void Main(string[] args, IEnumerable<int> listOdd)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Chetni" + string.Join(" ", GetEvenElements(list)));
            Console.WriteLine("Nechetni" + string.Join(" ", GetEvenElements(list)));
            List<int> listEven = new List<int>();
          
            
        }
        static List<int> GetEvenElements(List<int> inputs)
        {
            for (int i = 0;i < inputs.Count;i++)
            {
                if (inputs[i] % 2 == 0) 
                {
                    listEven.Add(inputs[i]);
                }
            }
            return listEven;
        }
    }
}
