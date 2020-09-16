using Microsoft.SharePoint.Client;
using OfficeDevPnP.Core;
using System;

namespace PnPAuthenticationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string siteUrl = "https://cleverpointdev.sharepoint.com/sites/GradyTeam";
            var authManager = new AuthenticationManager();
            var ctx =  authManager.GetWebLoginClientContext(siteUrl, null);
            Console.WriteLine($"Success! Connected to SharePoint Online");
            Web web = ctx.Web;
            ctx.Load(web, w => w.Title);
            ctx.ExecuteQuery();            
            Console.WriteLine($"Web site title is '{web.Title}'");
        }
    }
}
