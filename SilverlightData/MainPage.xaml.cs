using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace SilverlightData
{
    public partial class MainPage : UserControl
    {

        public MainPage()
        {
            InitializeComponent();
        }


        //ObservableCollection<ServiceReference.Student> li1 = new ObservableCollection<ServiceReference2.Student>();
        ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //client.GetStudentsCompleted += (s, de) =>
            //{
            //    li1 = de.Result;
            //    DG1.DataContext = li1;
            //};
            //client.GetStudentsAsync();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            //client.updateStudentCompleted += (s, de) =>
            //{

            //};
            //ServiceReference2.Student student = (ServiceReference2.Student)DG1.SelectedItem;
            //client.updateStudentAsync(student);
            //foreach(var student in li1)
            //{
            // client.updateStudentAsync(student);
            //}
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            //client.addStudentCompleted += (s, de) => { };
            //client.addStudentAsync(new ServiceReference2.Student() {
            //    Age = 12,
            //    Class = "5班",
            //    color = "Red",
            //    IsCheck = false,
            //    Name = "hh",
            //    Sex = true
            //});
        }
        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            //client.delStudentCompleted += (s, de) => {
            //    int count=de.Result;
            //    if (count > 0)
            //    {
            //        MessageBox.Show("修改成功");
            //    }
            //};
            //ServiceReference2.Student student = (ServiceReference2.Student)DG1.SelectedItem;
            //client.delStudentAsync(student);
        }
        private void ButtonSerch_Click(object sender, RoutedEventArgs e)
        {
            //client.GetStudentsCompleted += (s, de) =>
            //{
            //    li1 = de.Result;
            //    DG1.DataContext = li1;
            //};
            //client.GetStudentsAsync();
        }
    }
}
