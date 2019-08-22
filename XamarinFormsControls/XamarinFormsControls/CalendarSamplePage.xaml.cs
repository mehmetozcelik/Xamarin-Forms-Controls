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
    public partial class CalendarSamplePage : ContentPage
    {
        public CalendarSamplePage()
        {
            InitializeComponent();
        }

        private async void ShowDate_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Uyarı", calendar.SelectedDate.ToString(), "Tamam");
        }
    }
}