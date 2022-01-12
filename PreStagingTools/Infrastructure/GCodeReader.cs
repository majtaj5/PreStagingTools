namespace PreStagingTools.Infrastructure
{
    public class GCodeReader
    {
        public static void ReadGCodeFile()
        {
            string[] args = Environment.GetCommandLineArgs ();
            string filePath = args[1];
            string pathExists(string filePath) => filePath == string.Empty ? GetPathByUserInput() : "Perfect!";

            

           
            string[] lines = System.IO.File.ReadAllLines(filePath);
        }
        static private string GetPathByUserInput()
        {
            return Environment.GetCommandLineArgs()[0];

        }



    }
}
