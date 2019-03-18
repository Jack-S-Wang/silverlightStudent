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

namespace SilverlightData.ViewXaml
{
    public partial class AddForm : ChildWindow
    {
        public AddForm()
        {
            InitializeComponent();
            StudentPending s = new StudentPending();
            s.AUDIT_STATE = NCS.Business.DataFlow.EnumAuditState.Pending;
            s.OPERATOR_TYPE = NCS.Business.DataFlow.EnumOperatorType.Add;
            //s.CREATE_TIME = new DateTime();
            //s.CREATE_OPERATOR_ID = EnumEpmlees.小明;
            this.dataForm1.ItemsSource = new System.Collections.ObjectModel.ObservableCollection<StudentPending>() { s };
        }

        public object studentO = new object();
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataForm1.CommitEdit())
            {
                var student = dataForm1.ItemsSource.GetEnumerator().Current;
                ServiceReference2.StudentPending studentP = (ServiceReference2.StudentPending)student;

                //ServiceReference2.StudentHistory studentH = new ServiceReference2.StudentHistory();
                //studentH = (ServiceReference2.StudentHistory)student;
                MessageBoxResult resut = MessageBox.Show("是否要执行该操作", "提示信息", MessageBoxButton.OKCancel);
                if (resut == MessageBoxResult.OK)
                {
                    studentO = student;
                    ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
                    client.addStudentPendingCompleted += (se, de) =>
                    {
                        if (de.Result > 0)
                        {
                            MessageBox.Show("已添加到未审核列表中！");
                        }
                    };
                    client.addStudentPendingAsync(studentP);
                }

            }
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void dataForm1_Loaded(object sender, RoutedEventArgs e)
        {
            dataForm1.BeginEdit();
        }
    }
}

