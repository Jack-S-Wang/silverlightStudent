using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using NCS;

namespace SilverlightData
{
    public partial class NcsData : UserControl
    {
        public NcsData()
        {
            InitializeComponent();
        }

        ServiceReference2.Service1Client c = new ServiceReference2.Service1Client();
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void queryForm1_Loaded(object sender, RoutedEventArgs e)
        {
            StudentPendingSearch sp = new StudentPendingSearch();
            queryForm1.QueryConditionEntity = sp;
            queryForm1.EntityCheckedPropertyName = "IsCheck";

        }
        private void queryForm1_StartQuery(object sender, NCS.UI.Controls.QueryEventArgs e)
        {
            var s = e.Conditions;
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            //client.GetStudentsCompleted += (sd, de) =>
            //        {
            //            var list = de.Result.ConvertEntityAndCollection<System.Collections.ObjectModel.ObservableCollection<Student>, Student, ServiceReference2.Student>();
            //            queryForm1.FinishedQuery(list, de.recount);
            //        };
            //client.GetStudentsAsync(s);
        }

        private void butUpdate_Click(object sender, RoutedEventArgs e)
        {
            var collection = queryForm1.GetCheckedResultCollection<ServiceReference2.Student>().FirstOrDefault();
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            //client.updateStudentCompleted += (sd, de) =>
            //{
            //    if (de.Result > 0)
            //    {
            //        MessageBox.Show("更新成功!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("更新失败!");
            //    }
            //};
            //client.updateStudentAsync(collection);
        }

        private void butAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void butDel_Click(object sender, RoutedEventArgs e)
        {
            var collection = queryForm1.GetCheckedResultCollection<ServiceReference2.Student>().FirstOrDefault();
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            //client.delStudentCompleted += (se, de) =>
            //{
            //    if (de.Result > 0)
            //    {
            //        MessageBox.Show("删除成功！");
            //    }
            //    else
            //    {
            //        MessageBox.Show("删除失败！");
            //    }
            //};
        }
    }
}
