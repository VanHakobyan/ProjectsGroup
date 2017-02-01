using System.IO;

namespace WorkWithFiles02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create file
            FileStream file = File.Create(@"D:\textNewText.txt");

            var writer = new BinaryWriter(file);

            // Write in different data file.
            long number = 1000;
            int[] num = new int[number];
            string st = "Funy c#";

            writer.Write(number);
            writer.Write(st);
            for (int i = 0; i < num.Length; i++)
            {
                writer.Write(num[i]);
            }

            // Delete
            writer.Close();
        }
    }
}
