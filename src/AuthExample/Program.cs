using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace AuthExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                // https://github.com/aspnet/Hosting/blob/9479f0910ad06ddcff684167747b2f5c46452128/samples/SampleStartups/StartupFullControl.cs#L29
                .UseWebRoot("dist")
                .Build();

            host.Run();
        }
    }
}
