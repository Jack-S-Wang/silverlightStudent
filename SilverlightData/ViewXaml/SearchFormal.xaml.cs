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
using System.Collections.ObjectModel;

namespace SilverlightData.ViewXaml
{
    public partial class SearchFormal : UserControl
    {
        public SearchFormal()
        {
            InitializeComponent();

        }

        private void queryFormal_Loaded(object sender, RoutedEventArgs e)
        {
            studentSearch s = new studentSearch();

            queryFormal.PageSize = 20;
            queryFormal.EntityCheckedPropertyName = "IsCheck";
            //queryFormal.MulitSelect = false;
            queryFormal.QueryConditionEntity = s;
            queryFormal.QueryOrderByProperties = new NCS.DataAccess.QueryOrderByProperty[] { new NCS.DataAccess.QueryOrderByProperty()
            { Checked = true,DisplayName="学号",Property="StudentId",Priority=1,Sort=NCS.DataAccess.QuerySortIn.Ascending } };

            queryFormal.Header = $"EditWindow      User:{Shar.user}";
            queryFormal.ResultType = typeof(Student);

        }

        private void queryFormal_StartQuery(object sender, NCS.UI.Controls.QueryEventArgs e)
        {
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            client.GetstudentCompleted += (se, de) =>
            {
                var list = de.Result.ConvertEntityAndCollection<System.Collections.ObjectModel.ObservableCollection<Student>, Student, ServiceReference2.Student>();
                //循环添加选择时的判断
                foreach (var sp in list)
                {
                    sp.onChange += (spd, spe) =>
                    {
                        ServiceReference2.Service1Client client2 = new ServiceReference2.Service1Client();
                        //需要查找对应的Pending表，然后返回审核状态值及逆行比较
                        client2.ReStateCompleted += (gh, dde) =>
                        {
                            if (dde.Result == (int)NCS.Business.DataFlow.EnumAuditState.Submit || dde.Result == (int)NCS.Business.DataFlow.EnumAuditState.Reject)
                            {
                                MessageBox.Show("该数据有未审核或拒审的，不许进行其他操作，不能选择！");
                                sp.IsCheck = false;
                            }
                        };
                        client2.ReStateAsync(sp.StudentId);
                    };
                }
                queryFormal.FinishedQuery(list, de.recount);
            };
            client.GetstudentAsync(e.Conditions);
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var items = queryFormal.GetCheckedResultCollection<Student>().ToArray();
            if (items.Count() <= 0)
            {
                return;
            }
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            System.Collections.ObjectModel.ObservableCollection<ServiceReference2.StudentPending> studentPs = new System.Collections.ObjectModel.ObservableCollection<ServiceReference2.StudentPending>();
            foreach (var item in items)
            {
                ServiceReference2.StudentPending studentP = new ServiceReference2.StudentPending();
                Utility.CopyObjectProperties<Student, ServiceReference2.StudentPending>(item, studentP, new string[] { "OperatorType", "IsCheck", "EntityKey" });
                studentP.OPERATOR_TYPE = (int?)NCS.Business.DataFlow.EnumOperatorType.Edit;
                studentP.AUDIT_STATE = (int?)NCS.Business.DataFlow.EnumAuditState.Submit;
                studentP.UPDATE_OPERATOR_ID = Shar.user;
                studentP.UPDATE_TIME = DateTime.Now;
                studentPs.Add(studentP);
            }
            if (MessageBoxResult.OK == MessageBox.Show("是否需要更新数据", "提示信息", MessageBoxButton.OKCancel))
            {
                client.updateStudentPendidngsCompleted += (se, de) =>
                {
                    if (de.Result)
                    {
                        MessageBox.Show("修改完成，请到PendingWindow表查看");
                        var selected = queryFormal.GetCheckedResultCollection<Student>().ToArray();
                        foreach (var selectItem in selected)
                        {
                            selectItem.IsCheck = false;
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
            var stItems = queryFormal.GetCheckedResultCollection<Student>().ToArray();
            if (stItems.Count() <= 0)
            {
                return;
            }
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            System.Collections.ObjectModel.ObservableCollection<ServiceReference2.StudentPending> studentPs = new System.Collections.ObjectModel.ObservableCollection<ServiceReference2.StudentPending>();
            foreach (var item in stItems)
            {
                ServiceReference2.StudentPending studentP = new ServiceReference2.StudentPending();
                Utility.CopyObjectProperties<Student, ServiceReference2.StudentPending>(item, studentP, new string[] { "OperatorType", "IsCheck", "EntityKey" });
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
                        MessageBox.Show("删除完成，请到PendingWindow表查看！");
                        var selected = queryFormal.GetCheckedResultCollection<Student>().ToArray();
                        foreach (var selectItem in selected)
                        {
                            selectItem.IsCheck = false;
                        }
                    }else
                    {
                        MessageBox.Show("执行失败了！");
                    }
                };
                client.delStudentPendingAsync(studentPs);
            }
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student();
            MyDetail my = new MyDetail(s, true, queryFormal.ResultDataGrid);
            my.Show();
        }
    }
}
