using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage
    {
        ObservableCollection<Employee> employee = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employee; } }

        public activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employee;

            employee.Add(new Employee { DisplayName = "Wayne Doe", Position = "President" });
            employee.Add(new Employee { DisplayName = "John Doe", Position = "Vice President" });
            employee.Add(new Employee { DisplayName = "Bee Doe", Position = "Director" });
            employee.Add(new Employee { DisplayName = "Baah Doe", Position = "Supervisor" });

        }

        private void Add_item(object sender, EventArgs e)
        {

        }

        private void Edit_item(object sender, EventArgs e)
        {

        }

        private void Delete_item(object sender, EventArgs e)
        {

        }
    }
}