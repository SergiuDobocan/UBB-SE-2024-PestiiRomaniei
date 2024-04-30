using Microsoft.Extensions.Configuration;
using System.IO;


public class ConfigurationHelper
{
    public static IConfigurationRoot Configuration { get; set; }

    public static void InitializeConfiguration() {
        var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("C:\\Users\\sergi\\Documents\\GitHub\\UBB-SE-2024-PestiiRomaniei\\Lab5\\api\\SpookifyApi\\appsettings.json", optional: false, reloadOnChange: true);
        Configuration = builder.Build();
    }

    public static string GetApiBaseUrl() {
        return Configuration["ApiBaseUrl"];
    }

    public static string GetDestinationFolderPath()
    {
        return Configuration["DestinationFolderPath"];
    }
}
