using NCS;
using NCS.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Net;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using NCS.Business.DataFlow;

namespace SilverlightData.ViewXaml
{
    public partial class SearchPending : UserControl
    {

        public SearchPending()
        {
            InitializeComponent();
        }

        private void querySerch_Loaded(object sender, RoutedEventArgs e)
        {
            StudentPendingSearch sp = new StudentPendingSearch();
            querySerch.QueryConditionEntity = sp;
            querySerch.PageSize = 20;
            querySerch.EntityCheckedPropertyName = "IsCheck";
            querySerch.QueryOrderByProperties = new NCS.DataAccess.QueryOrderByProperty[] { new NCS.DataAccess.QueryOrderByProperty()
            { Checked = true,DisplayName="学号",Property="StudentId",Priority=1,Sort=NCS.DataAccess.QuerySortIn.Ascending } };
            //querySerch.MulitSelect = false;
            querySerch.Header = $"PendingWindow     User:{Shar.user}";
            var datagrid = querySerch.ResultDataGrid as DataGridEx;
            datagrid.CheckCellEditable = (f, d, dg) => false;
            querySerch.ResultType = typeof(StudentPending);
        }

        private void querySerch_StartQuery(object sender, NCS.UI.Controls.QueryEventArgs e)
        {
            e.Conditions.Conditions.Add(new NCS.DataAccess.QueryCondition() { Checked = true,Operator=NCS.DataAccess.QueryConditionOperator.Equal, Property = "AUDIT_STATE", Value = 2 });
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            client.GetStudentPendingsCompleted += (se, de) =>
            {
                var list = de.Result.ConvertEntityAndCollection<System.Collections.ObjectModel.ObservableCollection<StudentPending>, StudentPending, ServiceReference2.StudentPending>();
                querySerch.FinishedQuery(list, de.recount);
            };
            client.GetStudentPendingsAsync(e.Conditions);
        }
    }
}
