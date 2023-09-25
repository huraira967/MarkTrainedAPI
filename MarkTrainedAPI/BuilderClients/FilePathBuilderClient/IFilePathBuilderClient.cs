using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.BuilderClients.FilePathBuilderClient
{
    internal interface IFilePathBuilderClient
    {
        string GetAwsFilePath();
        string GetLocalFilePath();
    }
}
