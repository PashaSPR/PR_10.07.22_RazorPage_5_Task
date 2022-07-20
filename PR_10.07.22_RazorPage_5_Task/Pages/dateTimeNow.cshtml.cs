using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PR_10._07._22_RazorPage_5_Task.Pages
{
    public class dateTimeNowModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = $"{DateTime.Now}";//.ToLongDateString()
        }
    }
}
