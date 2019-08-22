using Plugin.ExternalMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExternalMapsPage : ContentPage
    {
        public ExternalMapsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var success = await CrossExternalMaps.Current.NavigateTo("Xamarin", "394 pacific ave.", "San Francisco", "CA", "94111", "USA", "USA");

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var success = await CrossExternalMaps.Current.NavigateTo("Space Needle", 47.6204, -122.3491);

        }
    }
}