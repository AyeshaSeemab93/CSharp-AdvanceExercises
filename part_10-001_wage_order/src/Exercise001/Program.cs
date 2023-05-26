namespace Exercise001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            humans.Add(new Human("Merja", 500));
            humans.Add(new Human("Pertti", 80));
            humans.Add(new Human("Matti", 150000));



            // Sort uses CompareTo internally

            humans.Sort();
            humans.ForEach(Console.WriteLine);
        }
    }
}