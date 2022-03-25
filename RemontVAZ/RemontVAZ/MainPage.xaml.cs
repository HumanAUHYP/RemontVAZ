using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RemontVAZ
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnTO_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TOPage());
        }

        private async void btnDiagnoz_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DiagnozPage());
        }

        private async void btnEngineRepair_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EngineRepairPage());
        }

        private async void btnTruckRepair_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrucksRepairPage());
        }

        private async void btnMufferRepair_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MufferRepairPage());
        }

        private async void btnTransmissionRepair_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransmissionRepairPage());
        }

        private async void btnAskAQuestion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SendQuestoinPage());
        }
    }
}
