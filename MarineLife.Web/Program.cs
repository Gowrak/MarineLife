using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace MarineLife.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateHostBuilder(string[] args)
        {
            return new WebHostBuilder()
                .UseKestrel()
                .UseSerilog()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://*:8088")
                .UseStartup<Startup>();
        }
    }
}