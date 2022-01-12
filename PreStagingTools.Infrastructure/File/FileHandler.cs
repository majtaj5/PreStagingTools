using PreStagingTools.Core.Models;
using PreStagingTools.Infrastructure.Interfaces;

namespace PreStagingTools.Infrastructure.File
{
    internal class FileHandler : IFileHandler
    {
        public List<GCode> GetGCodes()
        {
            List<GCode> codes = new List<GCode>();
            string[] lines = System.IO.File.ReadAllLines("GCodes.txt");

            foreach(string line in lines)
            {

            }

        }
    }
}
