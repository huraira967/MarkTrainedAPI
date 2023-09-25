using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Builders.DocumentPathBuilder
{
    internal class AwsFilePathBuilder : IFilePathBuilder
    {
        //setter of every filed will be here after that we will send in string form
        public string GetFilePath(params string[] segements)
        {
            return "Signature Path";
        }
    }
}
