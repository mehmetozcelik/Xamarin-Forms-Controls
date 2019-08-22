using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsControls.Data;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSamplePage : ContentPage
    {

        List<UsersListView> myRealList = new List<UsersListView>();

        public ListViewSamplePage()
        {
            InitializeComponent();

            var myList = new List<UsersListView>
            {
                new UsersListView { userName="Mehmet", Id="1", imageUrl="profil.jpg" },
                new UsersListView { userName="Mehmet", Id="2", imageUrl="profil.jpg" },
                new UsersListView { userName="Mehmet", Id="3", imageUrl="profil.jpg" }
            };
            myRealList = myList;

            myListView.ItemsSource = myRealList;
        }

        private void OnDelete_Clicked(object sender, EventArgs e)
        {
            var myMenuItem = (MenuItem)sender;
            var userID = myMenuItem.CommandParameter.ToString();
            myRealList.RemoveAll(r => r.Id == userID);
            myListView.ItemsSource = null;
            myListView.ItemsSource = myRealList;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
        }
    }
}