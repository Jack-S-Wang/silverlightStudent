using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using NCS.UI.Controls.Private;
using NCS.Business.DataFlow;
using NCS;

namespace SilverlightData.ViewXaml
{
    //public class Test1
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Test2
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //}

    public class MyDetail : DetailWindow
    {
        public Student dataSave = null;
        //可以这样扩展
        //public MyDetail(Student data, bool editMode, NCS.UI.Controls.DataGridEx g, string user) : base(data, editMode, g)
        //{
        //    dataSave = data;
        //    this.user = user;

        //}
        public MyDetail(Student data, bool editMode, NCS.UI.Controls.DataGridEx g) : base(data, editMode, g)
        {
            dataSave = data;

        }

        public override bool CustomerSaveData(object data)
        {
            ServiceReference2.StudentPending studentP = new ServiceReference2.StudentPending();
            Utility.CopyObjectProperties<Student, ServiceReference2.StudentPending>(dataSave, studentP);

            studentP.StudentId = dataSave.StudentId;
            studentP.StudentAge = dataSave.StudentAge;
            studentP.StudentClass = dataSave.StudentClass;
            studentP.StudentName = dataSave.StudentName;
            studentP.StudentSex = (int?)dataSave.StudentSex;
            studentP.AUDIT_STATE = (int?)EnumAuditState.Submit;
            studentP.CHECK_OPERATOR_ID = null;
            studentP.CHECK_OPERATOR_TIME = null;
            studentP.CREATE_OPERATOR_ID = Shar.user;
            studentP.CREATE_TIME = DateTime.Now;
            studentP.OPERATOR_TYPE = (int?)EnumOperatorType.Add;
            studentP.UPDATE_OPERATOR_ID = Shar.user;
            studentP.UPDATE_TIME = DateTime.Now;
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            //存入pending表
            client.addStudentPendingCompleted += (se, de) =>
            {
                if (de.Result > 0)
                {
                    MessageBox.Show("存入成功！请到SearchWindow查看！");
                    this.Close();
                }
            };
            client.addStudentPendingAsync(studentP);
            return true;
        }
    }
}
