using PreStagingTools.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreStagingTools.Infrastructure.Interfaces
{
    public interface IFileHandler
    {
        List<GCode> GetGCodes();
    }
}
