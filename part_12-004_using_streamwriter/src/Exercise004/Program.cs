namespace Exercise004
{
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            //using statement, It makes object available for short time.When program is executed the StreamWriter object is destroyed itself.
            // freeup space in memory
            using (StreamWriter writer = new StreamWriter("file.txt"))
            {
                writer.WriteLine("Hello file!");
                writer.WriteLine("More text");
                writer.Write("And a little extra");
            }
            // writer.Close(); no need for it in using statement as it close files itself.
        }
    }
}