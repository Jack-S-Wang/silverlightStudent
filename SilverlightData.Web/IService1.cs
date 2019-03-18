using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NCS.DataAccess;
using System.Collections.ObjectModel;

namespace SilverlightData.Web
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// 获取Student数据表信息
        /// </summary>
        /// <typeparam name="Student">student表数据对象</typeparam>
        /// <param name=""></param>
        /// <param name="querys">查询条件QueryConditions对象</param>
        /// <param name="recount">返回数量</param>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<Student> Getstudent(QueryConditions querys,out int recount);

        /// <summary>
        /// 获取StudentPending数据表信息
        /// </summary>
        /// <typeparam name="StudentPending">pending表数据对象</typeparam>
        /// <param name=""></param>
        /// <param name="querys">查询条件QueryConditions对象</param>
        /// <param name="recount">返回数量</param>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<StudentPending> GetStudentPendings(QueryConditions querys, out int recount);

        /// <summary>
        /// 获取Reject数据表信息
        /// </summary>
        /// <typeparam name="StudentPending">pending表数据对象</typeparam>
        /// <param name=""></param>
        /// <param name="querys">查询条件QueryConditions对象</param>
        /// <param name="recount">返回数量</param>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<StudentPending> GetRejectStudent(QueryConditions querys, out int recount);


        /// <summary>
        /// 添加StudentPending数据
        /// </summary>
        /// <param name="studentP">StudendPending对象</param>
        [OperationContract]
        int addStudentPending(StudentPending studentP);

        /// <summary>
        /// 更新StudentPending表
        /// </summary>
        /// <param name="studentPs">ObservableCollection的StudentPending集合</param>
        /// <returns></returns>
        [OperationContract]
        bool updateStudentPendidngs(ObservableCollection<StudentPending> studentPs);

        /// <summary>
        /// 删除StudentPending数据
        /// </summary>
        /// <param name="studentPs">ObservableCollection的StudentPending集合</param>
        /// <returns></returns>
        [OperationContract]
        bool delStudentPending(ObservableCollection<StudentPending> studentPs);

        /// <summary>
        /// 审核操作,具体内容后台进行业务分成
        /// </summary>
        /// <param name="studentPs">ObservableCollection的StudentPending集合</param>
        /// <returns></returns>
        [OperationContract]
        bool Aduit(ObservableCollection<StudentPending> studentPs);

        /// <summary>
        /// 拒审核
        /// </summary>
        /// <param name="studentP">StudentPending对象</param>
        /// <returns></returns>
        [OperationContract]
        bool UnAduit(ObservableCollection<StudentPending> studentPs);

        /// <summary>
        /// 查找对应的Pending表返回审核状态值
        /// </summary>
        /// <param name="StudentId">学号</param>
        /// <returns></returns>
        [OperationContract]
        int ReState(int StudentId);
    }
}
