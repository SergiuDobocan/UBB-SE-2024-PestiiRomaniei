using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSProject
{
    class ConfigurationHelper
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("C:\\Users\\raul\\Documents\\ISS\\appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public static string GetApiBaseUrl()
        {
            return Configuration["ApiBaseUrl"];
        }

        public static string GetDestinationFolderPath()
        {
            return Configuration["DestinationFolderPath"];
        }
    }
}
