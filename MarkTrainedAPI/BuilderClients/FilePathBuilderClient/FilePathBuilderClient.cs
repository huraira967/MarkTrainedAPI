using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.BuilderClients.FilePathBuilderClient
{
    internal class FilePathBuilderClient : IFilePathBuilderClient
    {
        public string GetAwsFilePath()
        {
            IFilePathBuilderClient client = new FilePathBuilderClient();
            return client.GetAwsFilePath();
        }

        public string GetLocalFilePath()
        {
            throw new NotImplementedException();
        }
    }
}
