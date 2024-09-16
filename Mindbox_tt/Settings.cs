using Microsoft.Extensions.Configuration;

namespace Mindbox_tt;

public static class Settings
{
    public static double Accuracy { get; }
    
    static Settings()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional:false, reloadOnChange:true)
            .Build();
        
        Accuracy = configuration.GetValue<double>("Accuracy");
    }
}