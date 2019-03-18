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
using System.Data.Objects.DataClasses;
using System.Collections.ObjectModel;

namespace SilverlightData.ViewXaml
{
    public partial class AduitWindow : UserControl
    {
        public AduitWindow()
        {
            InitializeComponent();
        }
        private void queryExamine_Loaded(object sender, RoutedEventArgs e)
        {
            StudentPendingSearch studentP = new StudentPendingSearch();
            queryExamine.QueryConditionEntity = studentP;
            queryExamine.PageSize = 20;
            queryExamine.EntityCheckedPropertyName = "IsCheck";
            queryExamine.QueryOrderByProperties=new NCS.DataAccess.QueryOrderByProperty[] { new NCS.DataAccess.QueryOrderByProperty()
            { Checked = true,DisplayName="学号",Property="StudentId",Priority=1,Sort=NCS.DataAccess.QuerySortIn.Ascending } };
            //queryExamine.MulitSelect = false;
            queryExamine.Header = $"AuditWindow     User:{Shar.user}";
            //queryExamine.ResultDataGrid.CheckCellEditable = (b, d, bd) =>
            // {
            //     return b == "IsCheck";
            // };
            queryExamine.ResultDataGrid.CheckCellEditable = (b, d, bd) => false;
            queryExamine.ResultType = typeof(StudentPending);
        }

        private void queryExamine_StartQuery(object sender, NCS.UI.Controls.QueryEventArgs e)
        {
            e.Conditions.Conditions.Add(new NCS.DataAccess.QueryCondition() { Checked = true, Operator = NCS.DataAccess.QueryConditionOperator.Equal, Property = "AUDIT_STATE", Value = 2 });
            //e.Conditions.Conditions.AddRange(new NCS.DataAccess.QueryCondition[] {
            //    new NCS.DataAccess.QueryCondition() {
            //        Checked=true,
            //        Property="AUDIT_STATE",
            //        Operator=NCS.DataAccess.QueryConditionOperator.NotEqual,
            //        Value=3
            //},new NCS.DataAccess.QueryCondition() {
            //        Checked=true,
            //        Property="AUDIT_STATE",
            //        Operator=NCS.DataAccess.QueryConditionOperator.NotEqual,
            //        Value =4
            //}
            //});
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            client.GetStudentPendingsCompleted += (se, de) =>
            {
                var list = de.Result.ConvertEntityAndCollection<System.Collections.ObjectModel.ObservableCollection<StudentPending>, StudentPending, ServiceReference2.StudentPending>();
                queryExamine.FinishedQuery(list, de.recount);

            };
            client.GetStudentPendingsAsync(e.Conditions);
        }

        private void BtnApprove_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            var items = queryExamine.GetCheckedResultCollection<StudentPending>().ToArray();
            if (items.Count()<=0)
            {
                return;
            }
            ObservableCollection<ServiceReference2.StudentPending> studentPs = new ObservableCollection<ServiceReference2.StudentPending>();
            foreach (var item in items)
            {
                ServiceReference2.StudentPending studentP = new ServiceReference2.StudentPending();
                Utility.CopyObjectProperties<StudentPending, ServiceReference2.StudentPending>(item, studentP, new string[] { "IsCheck" });
                studentP.CHECK_OPERATOR_ID = Shar.user;
                studentP.CHECK_OPERATOR_TIME = DateTime.Now;
                studentP.AUDIT_STATE = (int?)NCS.Business.DataFlow.EnumAuditState.Approve;
                studentPs.Add(studentP);
            }
            if (MessageBoxResult.OK == MessageBox.Show("是否要审核选择的数据", "提示信息", MessageBoxButton.OKCancel))
            {
                client.AduitCompleted += (se, de) =>
                {
                    if (de.Result)
                    {
                        MessageBox.Show("审核完毕！");
                        var stitems = queryExamine.ResultCollection as ObservableCollection<StudentPending>;
                        var selecteds = queryExamine.GetCheckedResultCollection<StudentPending>().ToArray();
                        foreach (var selected in selecteds)
                        {
                            stitems.Remove(selected);
                        }
                    }
                    else
                    {
                        MessageBox.Show("未审核完毕");
                    }
                };
                client.AduitAsync(studentPs);
            }
        }

        private void BtnReject_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            var items = queryExamine.GetCheckedResultCollection<StudentPending>().ToArray();
            if (items.Count() <= 0)
            {
                return;
            }
            ObservableCollection<ServiceReference2.StudentPending> studentPs = new ObservableCollection<ServiceReference2.StudentPending>();
            foreach (var item in items)
            {
                ServiceReference2.StudentPending studentP = new ServiceReference2.StudentPending();
                Utility.CopyObjectProperties<StudentPending, ServiceReference2.StudentPending>(item, studentP, new string[] { "IsCheck", "Studentcolor" });
                studentP.CHECK_OPERATOR_ID = Shar.user;
                studentP.CHECK_OPERATOR_TIME = DateTime.Now;
                studentP.AUDIT_STATE = (int?)NCS.Business.DataFlow.EnumAuditState.Reject;
                studentPs.Add(studentP);
            }
            if (MessageBoxResult.OK == MessageBox.Show("是否要拒批选择的数据", "提示信息", MessageBoxButton.OKCancel))
            {
                client.UnAduitCompleted += (se, de) =>
                {
                    if (de.Result)
                    {
                        MessageBox.Show("已拒批！");
                        var stitems = queryExamine.ResultCollection as ObservableCollection<StudentPending>;
                        var selecteds = queryExamine.GetCheckedResultCollection<StudentPending>().ToArray();
                        foreach (var selected in selecteds)
                        {
                            stitems.Remove(selected);
                        }
                    }
                    else
                    {
                        MessageBox.Show("拒批失败！");
                    }
                };
                client.UnAduitAsync(studentPs);
            }
        }
    }
}
