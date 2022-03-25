using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemontVAZ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransmissionRepairPage : ContentPage
    {
        public TransmissionRepairPage()
        {
            InitializeComponent();
        }

        private async void btnCheckIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckInPage());
        }
    }
}