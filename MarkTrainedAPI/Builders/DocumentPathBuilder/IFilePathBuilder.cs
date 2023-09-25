using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Builders.DocumentPathBuilder
{
    internal interface IFilePathBuilder
    {
        string GetFilePath(params string[] segements);
    }
}
