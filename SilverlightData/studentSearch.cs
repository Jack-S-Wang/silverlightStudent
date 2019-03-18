using System;
using System.ComponentModel.DataAnnotations;
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

namespace SilverlightData
{
    public class studentSearch : QueryConditionEntityViewBase
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
        [Display(Name ="审核人")]
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
}
