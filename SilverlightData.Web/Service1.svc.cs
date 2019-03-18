using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NCS.DataAccess;
using NCS.DataAccess.Entity;
using NCS.Business.DataFlow;
using System.Collections.ObjectModel;
using System.Data.Objects;


namespace SilverlightData.Web
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {
        /// <summary>
        /// 添加数据是未审核已提交的数据
        /// </summary>
        /// <param name="studentP">Pending数据对象</param>
        /// <returns></returns>
        public int addStudentPending(StudentPending studentP)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                //添加pending数据
                db.StudentPending.AddObject(studentP);
                return db.SaveChanges();
            }
        }
        /// <summary>
        /// 删除数据不是真删除，只是修改状态，未审核状态
        /// </summary>
        /// <param name="studentP">ObservableCollection的StudentPending集合</param>
        /// <returns></returns>
        public bool delStudentPending(ObservableCollection<StudentPending> studentPs)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                foreach (var studentP in studentPs)
                {
                    //执行更新原始pending数据
                    var stItems = db.StudentPending.ToArray();
                    foreach (var st in stItems)
                    {
                        if (st.StudentId == studentP.StudentId)
                        {
                            st.UPDATE_OPERATOR_ID = studentP.UPDATE_OPERATOR_ID;
                            st.UPDATE_TIME = studentP.UPDATE_TIME;
                            st.OPERATOR_TYPE = studentP.OPERATOR_TYPE;
                            st.AUDIT_STATE = studentP.AUDIT_STATE;
                            break;
                        }
                    }
                }
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 查询得到Pending数据表信息
        /// </summary>
        /// <param name="querys">条件数据集</param>
        /// <param name="recount">返回执行数据数</param>
        /// <returns></returns>
        public IEnumerable<StudentPending> GetStudentPendings(QueryConditions querys, out int recount)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                return db.StudentPending.Where(querys, out recount).ToArray();
            }
        }

        /// <summary>
        /// 查询得到正式表数据表信息
        /// </summary>
        /// <param name="querys">条件数据集</param>
        /// <param name="recount">返回执行数据数</param>
        /// <returns></returns>
        public IEnumerable<Student> Getstudent(QueryConditions querys, out int recount)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                return db.Student.Where(querys, out recount).ToArray();
            }
        }

        /// <summary>
        /// 拒审执行，操作结果是一样的，与正式表无关
        /// </summary>
        /// <param name="studentP">ObservableCollection的StudentPending集合</param>
        /// <returns></returns>
        public bool UnAduit(ObservableCollection<StudentPending> studentPs)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                //执行更新原始pending数据
                if (Utility.UpdateEntityWithoutQuery<StudentPending>(db, studentPs) > 0)
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// 编辑数据操作
        /// </summary>
        /// <param name="studentPs">ObservableCollection的StudentPending集合</param>
        /// <returns></returns>
        public bool updateStudentPendidngs(ObservableCollection<StudentPending> studentPs)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                var stItems = db.StudentPending.ToArray();
                foreach (var studentP in studentPs)
                {
                    foreach (var st in stItems)
                    {
                        if (st.StudentId == studentP.StudentId)
                        {
                            st.AUDIT_STATE = studentP.AUDIT_STATE;
                            st.OPERATOR_TYPE = studentP.OPERATOR_TYPE;
                            st.StudentAge = studentP.StudentAge;
                            st.StudentClass = studentP.StudentClass;
                            st.StudentName = studentP.StudentName;
                            st.StudentSex = studentP.StudentSex;
                            st.UPDATE_OPERATOR_ID = studentP.UPDATE_OPERATOR_ID;
                            st.UPDATE_TIME = studentP.UPDATE_TIME;
                            break;
                        }
                    }
                }
                //执行更新原始pending数据
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 审核操作，所有的业务在数据中进行分类
        /// </summary>
        /// <param name="studentPs">ObservableCollection的SudentPending集合</param>
        /// <returns></returns>
        public bool Aduit(ObservableCollection<StudentPending> studentPs)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                //为了获取需要更新的Student表的原始数据
                var sItems = db.Student.ToArray();
                //获取需要的SttudentPending表的原始数据
                var sPItems = db.StudentPending.ToArray();
                //记录删除的对象
                ObservableCollection<StudentPending> delStudentPs = new ObservableCollection<StudentPending>();
                foreach (var studentP in studentPs)
                {
                    if (studentP.OPERATOR_TYPE == (int?)NCS.Business.DataFlow.EnumOperatorType.Add)
                    {
                        //正式表插入
                        Student student = new Student();

                        NCS.Utility.CopyObjectProperties(studentP, student, "EntityKey");

                        db.Student.AddObject(student);
                        //更新对象的pending对象
                        foreach (var stP in sPItems)
                        {
                            if (stP.StudentId == studentP.StudentId)
                            {
                                //更新对象
                                NCS.Utility.CopyObjectProperties(studentP, stP);
                                break;
                            }
                        }
                    }
                    else if (studentP.OPERATOR_TYPE == (int?)NCS.Business.DataFlow.EnumOperatorType.Edit)
                    {
                        //更新Student表数据
                        foreach (var s in sItems)
                        {
                            if (s.StudentId == studentP.StudentId)
                            {
                                s.StudentAge = studentP.StudentAge;
                                s.StudentClass = studentP.StudentClass;
                                s.StudentName = studentP.StudentName;
                                s.StudentSex = studentP.StudentSex;
                                s.CHECK_OPERATOR_ID = studentP.CHECK_OPERATOR_ID;
                                s.CHECK_OPERATOR_TIME = studentP.CHECK_OPERATOR_TIME;
                                s.UPDATE_OPERATOR_ID = studentP.UPDATE_OPERATOR_ID;
                                s.UPDATE_TIME = studentP.UPDATE_TIME;
                                break;
                            }
                        }
                        //更新StudentPending对象
                        foreach (var stP in sPItems)
                        {
                            if (stP.StudentId == studentP.StudentId)
                            {
                                //更新对象
                                NCS.Utility.CopyObjectProperties(studentP, stP);
                                break;
                            }
                        }
                    }
                    else if (studentP.OPERATOR_TYPE == (int?)NCS.Business.DataFlow.EnumOperatorType.Delete)
                    {
                        //找到对应的student数据进行处理。
                        foreach (var st in sItems)
                        {
                            if (st.StudentId == studentP.StudentId)
                            {
                                //正式表删除
                                db.Student.DeleteObject(st);
                                break;
                            }
                        }
                        //删除对应的pending数据
                        foreach (var stP in sPItems)
                        {
                            if (stP.StudentId == studentP.StudentId)
                            {
                                //删除pending表数据
                                db.StudentPending.DeleteObject(stP);
                                break;
                            }
                        }
                    }
                }
               
                //最后更新表
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        /// <summary>
        /// 获取所有的拒审数据
        /// </summary>
        /// <param name="querys">QueryConditions对象</param>
        /// <param name="recount">返回数量</param>
        /// <returns></returns>
        public IEnumerable<StudentPending> GetRejectStudent(QueryConditions querys, out int recount)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                return db.StudentPending.Where(querys, out recount).ToArray();
            }
        }

        /// <summary>
        /// 认证当前数据是否已经处于提交状态或是拒审状态
        /// </summary>
        /// <param name="StudentId">学号</param>
        public int ReState(int StudentId)
        {
            using (DBModelEntities1 db = new DBModelEntities1())
            {
                var student = db.StudentPending.Where(st => st.StudentId == StudentId).FirstOrDefault();
                return (int)student.AUDIT_STATE;
            }
        }
    }
}
