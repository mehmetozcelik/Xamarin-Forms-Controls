using Plugin.Connectivity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsControls.Helper;

namespace XamarinFormsControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginSettingsPage : ContentPage
    {
        public LoginSettingsPage()
        {
            InitializeComponent();

            // Uygulama ilk açıldığında 'Settings' classında kayıtlı veri varsa onu Entry'lere basar.
            userName.Text = Settings.GeneralSettings;
            passWord.Text = Settings.GeneralSettingsPass;
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            // Eğer cihazda internet bağlantısı varsa giriş işlemlerini yap.
            if (CrossConnectivity.Current.IsConnected)
            {
                // 'Beni Hatırla' switch'i true ise Entry'lerdeki değeri 'Settings' classının attributelerine kayıt eder. 
                if (isRemembered.IsToggled == true)
                {
                    Settings.GeneralSettings = userName.Text;
                    Settings.GeneralSettingsPass = passWord.Text;
                }
                else
                {
                    Settings.GeneralSettings = string.Empty;
                    Settings.GeneralSettingsPass = string.Empty;
                }

                await Navigation.PushModalAsync(new ImageCirclePage());
            }
            else
            {
                await DisplayAlert("Uyarı", "İnternet bağlantınızı aktifleştiriniz!", "Tamam");
            }            
        }
    }
}