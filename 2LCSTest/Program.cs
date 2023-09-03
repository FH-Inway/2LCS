using LCS.Model;
using Newtonsoft.Json;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dictionary<string, LcsGeo> lcsGeos = new Dictionary<string, LcsGeo>()
{
    { "United States", new LcsGeo()
        {
            Type = LcsGeoType.GlobalCloud,
            Name = "United States",
            LcsUrl = new Uri("https://lcs.dynamics.com"),
            LcsDiagUrl = new Uri("https://diag.lcs.dynamics.com"),
            LcsUpdateUrl = new Uri("https://update.lcs.dynamics.com"),
            LcsFixUrl = new Uri("https://fix.lcs.dynamics.com")
        }
    },
    { "Europe", new LcsGeo()
        { 
            Type = LcsGeoType.LocalCloud, 
            Name = "Europe",
            LcsUrl = new Uri("https://eu.lcs.dynamics.com"),
            LcsDiagUrl = new Uri("https://eu.diag.lcs.dynamics.com"),
            LcsUpdateUrl = new Uri("https://eu.update.lcs.dynamics.com"),
            LcsFixUrl = new Uri("https://eu.fix.lcs.dynamics.com")
        }
    },
    { "France", new LcsGeo()
        {
            Type = LcsGeoType.LocalCloud,
            Name = "France",
            LcsUrl = new Uri("https://fr.lcs.dynamics.com"),
            LcsDiagUrl = new Uri("https://fr.diag.lcs.dynamics.com"),
            LcsUpdateUrl = new Uri("https://fr.update.lcs.dynamics.com"),
            LcsFixUrl = new Uri("https://fr.fix.lcs.dynamics.com")
        }
    },
    { "South Africe", new LcsGeo()
        {
            Type = LcsGeoType.LocalCloud,
            Name = "South Africe",
            LcsUrl = new Uri("https://sa.lcs.dynamics.com"),
            LcsDiagUrl = new Uri("https://sa.diag.lcs.dynamics.com"),
            LcsUpdateUrl = new Uri("https://sa.update.lcs.dynamics.com"),
            LcsFixUrl = new Uri("https://sa.fix.lcs.dynamics.com")
        }
    }
};

Console.WriteLine(JsonConvert.SerializeObject(lcsGeos, Formatting.Indented));
