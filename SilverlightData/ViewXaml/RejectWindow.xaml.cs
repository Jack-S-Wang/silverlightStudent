using NCS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class RejectWindow : UserControl
    {
        public RejectWindow()
        {
            InitializeComponent();
        }
        private void queryReject_Loaded(object sender, RoutedEventArgs e)
        {
            StudentPendingSearch studentP = new StudentPendingSearch();
            queryReject.QueryConditionEntity = studentP;
            queryReject.PageSize = 20;
            queryReject.EntityCheckedPropertyName = "IsCheck";
            queryReject.QueryOrderByProperties = new NCS.DataAccess.QueryOrderByProperty[] { new NCS.DataAccess.QueryOrderByProperty()
            { Checked = true,DisplayName="学号",Property="StudentId",Priority=1,Sort=NCS.DataAccess.QuerySortIn.Ascending } };
            //queryReject.MulitSelect = false;
            queryReject.Header = $"RejectWindow     User:{Shar.user}";
            queryReject.ResultType = typeof(StudentPending);
        }

        private void queryReject_StartQuery(object sender, NCS.UI.Controls.QueryEventArgs e)
        {
            e.Conditions.Conditions.Add(new NCS.DataAccess.QueryCondition() { Checked = true, Property = "AUDIT_STATE", Operator = NCS.DataAccess.QueryConditionOperator.Equal, Value = 4 });
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            client.GetRejectStudentCompleted += (se, de) =>
            {
                var list = de.Result.ConvertEntityAndCollection<System.Collections.ObjectModel.ObservableCollection<StudentPending>, StudentPending, ServiceReference2.StudentPending>();
                queryReject.FinishedQuery(list, de.recount);
            };
            client.GetRejectStudentAsync(e.Conditions);
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var items = queryReject.GetCheckedResultCollection<StudentPending>().ToArray();
            if (items.Count() <= 0)
            {
                return;
            }
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();

            ObservableCollection<ServiceReference2.StudentPending> studentPs = new ObservableCollection<ServiceReference2.StudentPending>();
            foreach (var item in items)
            {
                ServiceReference2.StudentPending studentP = new ServiceReference2.StudentPending();
                Utility.CopyObjectProperties<StudentPending, ServiceReference2.StudentPending>(item, studentP, new string[] { "OperatorType", "IsCheck" });
                studentP.OPERATOR_TYPE = (int?)NCS.Business.DataFlow.EnumOperatorType.Edit;
                studentP.AUDIT_STATE = (int?)NCS.Business.DataFlow.EnumAuditState.Submit;
                studentP.UPDATE_OPERATOR_ID = Shar.user;
                studentP.UPDATE_TIME = DateTime.Now;
                studentPs.Add(studentP);
            }

            if (MessageBoxResult.OK == MessageBox.Show("是否要修改选中的数据", "提示信息", MessageBoxButton.OKCancel))
            {
                client.updateStudentPendidngsCompleted += (se, de) =>
                {
                    if (de.Result)
                    {
                        MessageBox.Show("修改已提交，等待审核！");
                        var stitem = queryReject.ResultCollection as ObservableCollection<StudentPending>;
                        var selected = queryReject.GetCheckedResultCollection<StudentPending>().ToArray();
                        foreach (var selectItem in selected)
                        {
                            stitem.Remove(selectItem);
                        }
                    }else
                    {
                        MessageBox.Show("执行失败了！");
                    }
                };
                client.updateStudentPendidngsAsync(studentPs);
            }
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var stItems = queryReject.GetCheckedResultCollection<StudentPending>().ToArray();
            if (stItems.Count() <= 0)
            {
                return;
            }
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            ObservableCollection<ServiceReference2.StudentPending> studentPs = new ObservableCollection<ServiceReference2.StudentPending>();
            foreach (var item in stItems)
            {
                ServiceReference2.StudentPending studentP = new ServiceReference2.StudentPending();
                Utility.CopyObjectProperties<StudentPending, ServiceReference2.StudentPending>(item, studentP, new string[] { "OperatorType", "IsCheck" });
                studentP.UPDATE_OPERATOR_ID = Shar.user;
                studentP.UPDATE_TIME = DateTime.Now;
                studentP.OPERATOR_TYPE = (int?)NCS.Business.DataFlow.EnumOperatorType.Delete;
                studentP.AUDIT_STATE = (int?)NCS.Business.DataFlow.EnumAuditState.Submit;
                studentPs.Add(studentP);
            }
            if (MessageBoxResult.OK == MessageBox.Show("是否要删除选中的数据", "提示信息", MessageBoxButton.OKCancel))
            {
                client.delStudentPendingCompleted += (se, de) =>
                {
                    if (de.Result)
                    {
                        MessageBox.Show("处理执行完成并等待审核！");
                        var items = queryReject.ResultCollection as ObservableCollection<StudentPending>;
                        var selected = queryReject.GetCheckedResultCollection<StudentPending>().ToArray();
                        foreach (var selectItem in selected)
                        {
                            items.Remove(selectItem);
                        }
                    }else
                    {
                        MessageBox.Show("执行失败了！");
                    }
                };
                client.delStudentPendingAsync(studentPs);
            }
        }
    }
}
