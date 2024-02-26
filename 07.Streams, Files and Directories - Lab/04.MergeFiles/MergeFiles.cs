namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using var firstFile = new StreamReader(@"..\..\..\Files\input1.txt");
            using var secondFile = new StreamReader(@"..\..\..\Files\input2.txt");

            using var writer = new StreamWriter(@"..\..\..\Files\output.txt");

            while (true)
            {
                var lineFromFile1 = firstFile.ReadLine();
                var lineFromFile2 = secondFile.ReadLine();

                if (lineFromFile1 == null || lineFromFile2 == null)
                {
                    break;
                }

                writer.WriteLine(lineFromFile1);
                writer.WriteLine(lineFromFile2);
            }
        }
    }
}
