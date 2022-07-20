using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace PR_10._07._22_RazorPage_5_Task.Pages
{
    public class appsettingsShowModel : PageModel
    {
        public string MessageAppsetting { get; set; }
        private readonly IConfiguration Configuration;

        public appsettingsShowModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void OnGet()
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var str = conf.GetSection("appSet")["id"];
            MessageAppsetting = $"рядок з файлу: {str}\n";

        }
    }
}