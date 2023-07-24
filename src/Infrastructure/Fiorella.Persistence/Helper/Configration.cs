using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Persistence.Helpers;

internal static class Configuration
{
    internal static string ConnectionString
    {
        get
        {

            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Directory.GetCurrentDirectory());

            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString("Default");
        }
    }

}

