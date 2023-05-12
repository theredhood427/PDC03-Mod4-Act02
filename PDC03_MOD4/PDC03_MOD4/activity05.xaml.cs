using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();

            SetupData();
            ListView.ItemsSource= contacts;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(ListView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                ListView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();

            contacts.Add(new Contacts
            {
                Name= "Wayne Dowiee",
                    Age= 30,
                    Occupation="Analyst",
                    Country="Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Bonito Blakes",
                Age = 40,
                Occupation = "Developer",
                Country = "Japan"
            });

            contacts.Add(new Contacts
            {
                Name = "Johhny Miracle",
                Age = 25,
                Occupation = "Tester",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Dave Embiid",
                Age = 25,
                Occupation = "Programmer",
                Country = "Sweden"
            });

            contacts.Add(new Contacts
            {
                Name = "Steve Minerz",
                Age = 27,
                Occupation = "UI/UX",
                Country = "Wakanda"
            });
        }
       
    }
}