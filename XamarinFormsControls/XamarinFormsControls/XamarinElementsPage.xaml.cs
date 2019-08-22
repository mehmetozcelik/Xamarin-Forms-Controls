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
    public partial class XamarinElementsPage : ContentPage
    {
        public XamarinElementsPage()
        {
            InitializeComponent();
        }
        private void myButton_Clicked(object sender, EventArgs e)
        {
            myEntry.Text = "Merhaba Xamarin.Forms!";
            myLabel.Text = "Merhaba Xamarin Label";
            mySlider.Value = 50;
            myDatePicker.Date = new DateTime(2017, 7, 18);
            myTimePicker.Time = new TimeSpan(4, 45, 34);
            mySwitch.IsToggled = true;
            myButton.Text = "You pushed me";

            var myList = new List<string>();
            myList.Add("First Item");
            myList.Add("Second Item");
            myList.Add("Third Item");
            myList.Add("Fourth Item");

            myPicker.ItemsSource = myList;
        }

        private void myPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            myEntry.Text = myPicker.SelectedItem.ToString();
        }
    }
}