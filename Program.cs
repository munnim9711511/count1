using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Coun {
    public class Program {
        public static void Main (string[] args) {
            CreateWebHostBuilder(args).Build().Run();
            // var host = new WebHostBuilder ()
                // .UseKestrel ()
                // .UseUrls ("http://*:80")
                // .UseContentRoot (Directory.GetCurrentDirectory ())
                // .UseStartup<Startup> ()
                // .Build ();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}