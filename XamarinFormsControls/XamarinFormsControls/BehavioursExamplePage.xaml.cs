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
    public partial class BehavioursExamplePage : ContentPage
    {
        public BehavioursExamplePage()
        {
            InitializeComponent();
            Random rnd = new Random();
            int firstNumber = rnd.Next(1, 11);
            int secondNumber = rnd.Next(1, 11);
            catchaLabel.Text = firstNumber.ToString() + " + " + secondNumber.ToString();
        }
    }
}