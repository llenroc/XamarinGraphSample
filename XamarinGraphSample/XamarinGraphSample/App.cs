using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using XamarinGraphSample.Views;

namespace XamarinGraphSample
{
    public class App : Application
    {
        public static PublicClientApplication IdentityClientApp = null;
        public static string ClientID = "3b1def2e-5b4e-413d-9a96-b8d8e9776029";
        public static string[] Scopes = {
                        "https://graph.microsoft.com/Calendars.Read",
                        "https://graph.microsoft.com/Contacts.Read",
                        "https://graph.microsoft.com/User.Read"


                    };
        public App()
        {
            IdentityClientApp = new PublicClientApplication(ClientID);
            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
