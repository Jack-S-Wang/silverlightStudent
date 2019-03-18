using NCS.Business.DataFlow;
using NCS.View.DataAnnotations;
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

namespace SilverlightData
{
    public class StudentPending : NCS.View.EntityViewBase
    {
        public event EventHandler onChange;
        private bool _IsCheck;
        [Display(Name = "选择")]
        [DataGridColumnSetup(Frozen = true,IgnoreEditTemplate =true)]
        public bool IsCheck
        {
            get { return _IsCheck; }
            set
            {
                _IsCheck = value; OnPropertyChanged(nameof(IsCheck));
                //false就不用执行该事件
                if (value == false)
                {
                    onChange?.Invoke(this, new EventArgs());

                }
            }
        }

        private int _ID;
        [Display(Name = "学号")]
        [AutoGenerateBehavior(DataFormExEnabled = false)]
        public int StudentId
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(StudentId));
            }
        }
        private string _Name;
        [Display(Name = "姓名")]
        public string StudentName
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(StudentName));
            }
        }
        private Sex _Sex;
        [Display(Name = "性别")]

        public Sex StudentSex
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;
                OnPropertyChanged(nameof(Sex));
            }
        }
        private string _Class;
        [Display(Name = "班级")]
        public string StudentClass
        {
            get
            {
                return _Class;
            }
            set
            {
                _Class = value;
                OnPropertyChanged(nameof(StudentClass));
            }
        }
        [Display(Name = "颜色")]
        public string Studentcolor
        {
            get
            {
                if (StudentSex == 0)
                {
                    return "Yellow";
                }
                else
                {
                    return "Red";
                }
            }

        }
        private int _Age;
        [Display(Name = "年龄")]
        public int StudentAge
        {
            get { return _Age; }
            set { _Age = value; OnPropertyChanged(nameof(StudentAge)); }
        }


        private EnumOperatorType _OperatorType;
        [Display(Name = "数据状态")]
        [AutoGenerateBehavior(DataFormExEnabled = false)]
        [DataGridColumnSetup(IgnoreEditTemplate = true)]
        public EnumOperatorType OPERATOR_TYPE
        {
            get { return _OperatorType; }
            set { _OperatorType = value; OnPropertyChanged(nameof(OPERATOR_TYPE)); }
        }

        private EnumAuditState _AuditState;
        [Display(Name = "审核状态")]
        [AutoGenerateBehavior(DataFormExEnabled = false)]
        [DataGridColumnSetup(IgnoreEditTemplate = true)]
        public EnumAuditState AUDIT_STATE
        {
            get { return _AuditState; }
            set { _AuditState = value; OnPropertyChanged(nameof(AUDIT_STATE)); }
        }

        private string _CHECK_OPERATOR_ID;
        [Display(Name = "审核人")]
        [AutoGenerateBehavior(DataFormExEnabled = false)]
        [DataGridColumnSetup(IgnoreEditTemplate = true)]
        public string CHECK_OPERATOR_ID
        {
            get { return _CHECK_OPERATOR_ID; }
            set { _CHECK_OPERATOR_ID = value; OnPropertyChanged(nameof(CHECK_OPERATOR_ID)); }
        }

        private string _CREATE_OPERATOR_ID;
        [Display(Name = "创建执行人")]
        [AutoGenerateBehavior(DataFormExEnabled = false)]
        [DataGridColumnSetup(IgnoreEditTemplate = true)]
        public string CREATE_OPERATOR_ID
        {
            get { return _CREATE_OPERATOR_ID; }
            set { _CREATE_OPERATOR_ID = value; OnPropertyChanged(nameof(CREATE_OPERATOR_ID)); }
        }
        private DateTime _CHECK_OPERATOR_TIME;
        [Display(Name = "审核时间")]
        [AutoGenerateBehavior(DataFormExEnabled = false)]
        [DataGridColumnSetup(IgnoreEditTemplate = true)]
        public DateTime CHECK_OPERATOR_TIME
        {
            get { return _CHECK_OPERATOR_TIME; }
            set { _CHECK_OPERATOR_TIME = value; OnPropertyChanged(nameof(CHECK_OPERATOR_TIME)); }
        }

        private DateTime _CREATE_TIME;
        [Display(Name = "创建时间")]
        [AutoGenerateBehavior(DataFormExEnabled = false)]
        [DataGridColumnSetup(IgnoreEditTemplate = true)]
        public DateTime CREATE_TIME
        {
            get { return _CREATE_TIME; }
            set { _CREATE_TIME = value; OnPropertyChanged(nameof(CREATE_TIME)); }
        }
        private string _UPDATE_OPERATOR_ID;
        [Display(Name = "更新执行人")]
        [AutoGenerateBehavior(DataFormExEnabled = false)]
        [DataGridColumnSetup(IgnoreEditTemplate = true)]
        public string UPDATE_OPERATOR_ID
        {
            get { return _UPDATE_OPERATOR_ID; }
            set { _UPDATE_OPERATOR_ID = value; OnPropertyChanged(nameof(UPDATE_OPERATOR_ID)); }
        }
        private DateTime _UPDATE_TIME;
        [Display(Name = "更新时间")]
        [AutoGenerateBehavior(DataFormExEnabled =false)]
        [DataGridColumnSetup(IgnoreEditTemplate =true)]
        public DateTime UPDATE_TIME
        {
            get { return _UPDATE_TIME; }
            set { _UPDATE_TIME = value; OnPropertyChanged(nameof(UPDATE_TIME)); }
        }
    }
}
