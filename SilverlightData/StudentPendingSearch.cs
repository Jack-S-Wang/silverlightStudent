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
using NCS.View;
using System.ComponentModel.DataAnnotations;
using NCS.Business.DataFlow;
using NCS.View.DataAnnotations;

namespace SilverlightData
{
    public class StudentPendingSearch : QueryConditionEntityViewBase
    {
        [Display(Name = "学号")]
        public QueryConditionInt32Item StudentId { get; set; }
        [Display(Name = "姓名")]
        public QueryConditionStringItem StudnetName { get; set; }
        [Display(Name = "年龄")]
        public QueryConditionInt32Item StudentAge { get; set; }
        [Display(Name = "班级")]
        public QueryConditionStringItem StudentClass { get; set; }
        [Display(Name = "性别")]
        public QueryConditionItem<Sex> StudentSex { get; set; }
        [Display(Name = "数据状态")]
        public QueryConditionItem<EnumOperatorType> OPERATOR_TYPE { get; set; }
        
        [Display(Name = "审核人")]
        public QueryConditionStringItem CHECK_OPERATOR_ID { get; set; }
        [Display(Name = "创建人")]
        public QueryConditionStringItem CREATE_OPERATOR_ID { get; set; }
        [Display(Name = "更新人")]
        public QueryConditionStringItem UPDATE_OPERATOR_ID { get; set; }
        [Display(Name = "审核时间")]
        public QueryConditionDateTimeRangeItem CHECK_OPERATOR_TIME { get; set; }
        [Display(Name = "创建时间")]
        public QueryConditionDateTimeRangeItem CREATE_TIME { get; set; }
        [Display(Name = "更新时间")]
        public QueryConditionDateTimeRangeItem UPDATE_TIME { get; set; }

    }

    
    /// <summary>
    /// 枚举性别类型
    /// </summary>
    public enum Sex
    {
        male,
        female
    }
    /// <summary>
    /// 枚举数据状态类型
    /// </summary>
    //public enum EnumOperatorType
    //{
    //    Add,Delete,Edit,None
    //}
    /// <summary>
    /// 枚举审核状态类型
    /// </summary>
    //public enum EnumAuditState
    //{
    //    Approve,//批准
    //    Archived,//被存入文档的
    //    Pending,//待定的
    //    Processed,//处理的
    //    Reject,//拒绝
    //    Submit//提交
    //}
    //枚举数据表应用于不同的账户操作
    public enum EnumBase
    {
        Examined,
        NotExamined
    }
    /// <summary>
    /// 枚举有权限进行审核的人员
    /// </summary>
    public enum EnumJudges
    {
        李明,
        张明,
        Jock,
        CEO,
        杜明,
        none
    }

    /// <summary>
    /// 枚举职员
    /// </summary>
    public enum EnumEpmlees
    {
        王明,
        小明,
        杜丽,
        none
    }

}
