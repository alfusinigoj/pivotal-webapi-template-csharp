﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PivotalServices.WebApiTemplate.CSharp.Integration.Tests
{
    public class TestingWebApplicationFactory : WebApplicationFactory<Startup>
    {
        //protected override void ConfigureWebHost(IWebHostBuilder builder)
        //{
        //    base.ConfigureWebHost(builder);
        //    builder.ConfigureAppConfiguration((builderContext, configBuilder) =>
        //    {
        //        configBuilder.SetBasePath(Directory.GetCurrentDirectory());
        //        configBuilder.AddYamlFile("appsettings.Integration.yaml", false);
        //    });
        //}
    }
}
