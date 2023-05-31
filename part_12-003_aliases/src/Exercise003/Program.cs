namespace Exercise003
{
    // creating alias
    using Master = MasterProject.MasterClass;

    public class Program
    {
        public static void Main(string[] args)
        {
            //using alias by making object of it
            Master Master = new Master();
            Master.Master();
        }
    }
}