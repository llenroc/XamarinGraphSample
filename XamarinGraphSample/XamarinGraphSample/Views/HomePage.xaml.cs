using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using Xamarin.Forms;
using XamarinGraphSample.Helper;

namespace XamarinGraphSample.Views
{
    public partial class HomePage : ContentPage
    {
        public IPlatformParameters platformParameters { get; set; }
        private static GraphServiceClient graphClient = null;
        public HomePage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            App.IdentityClientApp.PlatformParameters = platformParameters;

            try
            {
                var graphClient = AuthenticationHelper.GetAuthenticatedClient();

                var me = await graphClient.Me.Request().GetAsync();
                UserName.Text = me.DisplayName;
                UserRole.Text = me.JobTitle;
                UserOffice.Text = me.OfficeLocation;


                var calendar = await graphClient.Me.Calendar.Events.Request().GetAsync();
                var evnt = calendar.FirstOrDefault();
                EventsTitle.Text = evnt.Subject;
                EventDate.Text = evnt.Start.DateTime.ToString();


                var contacts = await graphClient.Me.Contacts.Request().GetAsync();
                var contact = contacts.FirstOrDefault();
                ContactName.Text = contact.DisplayName;
                ContactEmail.Text = contact.EmailAddresses.FirstOrDefault().Address;


            }
            catch (Exception ex)
            {
                await this.DisplayAlert("Error", ex.Message, "Ok");
                //throw;
            }
        }
    }
}
