﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SilverlightData.Web
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class DBModelEntities1 : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“DBModelEntities1”部分中的连接字符串初始化新 DBModelEntities1 对象。
        /// </summary>
        public DBModelEntities1() : base("name=DBModelEntities1", "DBModelEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 DBModelEntities1 对象。
        /// </summary>
        public DBModelEntities1(string connectionString) : base(connectionString, "DBModelEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 DBModelEntities1 对象。
        /// </summary>
        public DBModelEntities1(EntityConnection connection) : base(connection, "DBModelEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Student> Student
        {
            get
            {
                if ((_Student == null))
                {
                    _Student = base.CreateObjectSet<Student>("Student");
                }
                return _Student;
            }
        }
        private ObjectSet<Student> _Student;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<StudentHistory> StudentHistory
        {
            get
            {
                if ((_StudentHistory == null))
                {
                    _StudentHistory = base.CreateObjectSet<StudentHistory>("StudentHistory");
                }
                return _StudentHistory;
            }
        }
        private ObjectSet<StudentHistory> _StudentHistory;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<StudentPending> StudentPending
        {
            get
            {
                if ((_StudentPending == null))
                {
                    _StudentPending = base.CreateObjectSet<StudentPending>("StudentPending");
                }
                return _StudentPending;
            }
        }
        private ObjectSet<StudentPending> _StudentPending;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 用于向 Student EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToStudent(Student student)
        {
            base.AddObject("Student", student);
        }
    
        /// <summary>
        /// 用于向 StudentHistory EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToStudentHistory(StudentHistory studentHistory)
        {
            base.AddObject("StudentHistory", studentHistory);
        }
    
        /// <summary>
        /// 用于向 StudentPending EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToStudentPending(StudentPending studentPending)
        {
            base.AddObject("StudentPending", studentPending);
        }

        #endregion

    }

    #endregion

    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBModelModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Student 对象。
        /// </summary>
        /// <param name="studentId">StudentId 属性的初始值。</param>
        public static Student CreateStudent(global::System.Int32 studentId)
        {
            Student student = new Student();
            student.StudentId = studentId;
            return student;
        }

        #endregion

        #region 简单属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CHECK_OPERATOR_ID
        {
            get
            {
                return _CHECK_OPERATOR_ID;
            }
            set
            {
                OnCHECK_OPERATOR_IDChanging(value);
                ReportPropertyChanging("CHECK_OPERATOR_ID");
                _CHECK_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "CHECK_OPERATOR_ID");
                ReportPropertyChanged("CHECK_OPERATOR_ID");
                OnCHECK_OPERATOR_IDChanged();
            }
        }
        private global::System.String _CHECK_OPERATOR_ID;
        partial void OnCHECK_OPERATOR_IDChanging(global::System.String value);
        partial void OnCHECK_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CHECK_OPERATOR_TIME
        {
            get
            {
                return _CHECK_OPERATOR_TIME;
            }
            set
            {
                OnCHECK_OPERATOR_TIMEChanging(value);
                ReportPropertyChanging("CHECK_OPERATOR_TIME");
                _CHECK_OPERATOR_TIME = StructuralObject.SetValidValue(value, "CHECK_OPERATOR_TIME");
                ReportPropertyChanged("CHECK_OPERATOR_TIME");
                OnCHECK_OPERATOR_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _CHECK_OPERATOR_TIME;
        partial void OnCHECK_OPERATOR_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnCHECK_OPERATOR_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CREATE_OPERATOR_ID
        {
            get
            {
                return _CREATE_OPERATOR_ID;
            }
            set
            {
                OnCREATE_OPERATOR_IDChanging(value);
                ReportPropertyChanging("CREATE_OPERATOR_ID");
                _CREATE_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "CREATE_OPERATOR_ID");
                ReportPropertyChanged("CREATE_OPERATOR_ID");
                OnCREATE_OPERATOR_IDChanged();
            }
        }
        private global::System.String _CREATE_OPERATOR_ID;
        partial void OnCREATE_OPERATOR_IDChanging(global::System.String value);
        partial void OnCREATE_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CREATE_TIME
        {
            get
            {
                return _CREATE_TIME;
            }
            set
            {
                OnCREATE_TIMEChanging(value);
                ReportPropertyChanging("CREATE_TIME");
                _CREATE_TIME = StructuralObject.SetValidValue(value, "CREATE_TIME");
                ReportPropertyChanged("CREATE_TIME");
                OnCREATE_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _CREATE_TIME;
        partial void OnCREATE_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnCREATE_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UPDATE_OPERATOR_ID
        {
            get
            {
                return _UPDATE_OPERATOR_ID;
            }
            set
            {
                OnUPDATE_OPERATOR_IDChanging(value);
                ReportPropertyChanging("UPDATE_OPERATOR_ID");
                _UPDATE_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "UPDATE_OPERATOR_ID");
                ReportPropertyChanged("UPDATE_OPERATOR_ID");
                OnUPDATE_OPERATOR_IDChanged();
            }
        }
        private global::System.String _UPDATE_OPERATOR_ID;
        partial void OnUPDATE_OPERATOR_IDChanging(global::System.String value);
        partial void OnUPDATE_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> UPDATE_TIME
        {
            get
            {
                return _UPDATE_TIME;
            }
            set
            {
                OnUPDATE_TIMEChanging(value);
                ReportPropertyChanging("UPDATE_TIME");
                _UPDATE_TIME = StructuralObject.SetValidValue(value, "UPDATE_TIME");
                ReportPropertyChanged("UPDATE_TIME");
                OnUPDATE_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _UPDATE_TIME;
        partial void OnUPDATE_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnUPDATE_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentId
        {
            get
            {
                return _StudentId;
            }
            set
            {
                if (_StudentId != value)
                {
                    OnStudentIdChanging(value);
                    ReportPropertyChanging("StudentId");
                    _StudentId = StructuralObject.SetValidValue(value, "StudentId");
                    ReportPropertyChanged("StudentId");
                    OnStudentIdChanged();
                }
            }
        }
        private global::System.Int32 _StudentId;
        partial void OnStudentIdChanging(global::System.Int32 value);
        partial void OnStudentIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String StudentName
        {
            get
            {
                return _StudentName;
            }
            set
            {
                OnStudentNameChanging(value);
                ReportPropertyChanging("StudentName");
                _StudentName = StructuralObject.SetValidValue(value, true, "StudentName");
                ReportPropertyChanged("StudentName");
                OnStudentNameChanged();
            }
        }
        private global::System.String _StudentName;
        partial void OnStudentNameChanging(global::System.String value);
        partial void OnStudentNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> StudentAge
        {
            get
            {
                return _StudentAge;
            }
            set
            {
                OnStudentAgeChanging(value);
                ReportPropertyChanging("StudentAge");
                _StudentAge = StructuralObject.SetValidValue(value, "StudentAge");
                ReportPropertyChanged("StudentAge");
                OnStudentAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _StudentAge;
        partial void OnStudentAgeChanging(Nullable<global::System.Int32> value);
        partial void OnStudentAgeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> StudentSex
        {
            get
            {
                return _StudentSex;
            }
            set
            {
                OnStudentSexChanging(value);
                ReportPropertyChanging("StudentSex");
                _StudentSex = StructuralObject.SetValidValue(value, "StudentSex");
                ReportPropertyChanged("StudentSex");
                OnStudentSexChanged();
            }
        }
        private Nullable<global::System.Int32> _StudentSex;
        partial void OnStudentSexChanging(Nullable<global::System.Int32> value);
        partial void OnStudentSexChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String StudentClass
        {
            get
            {
                return _StudentClass;
            }
            set
            {
                OnStudentClassChanging(value);
                ReportPropertyChanging("StudentClass");
                _StudentClass = StructuralObject.SetValidValue(value, true, "StudentClass");
                ReportPropertyChanged("StudentClass");
                OnStudentClassChanged();
            }
        }
        private global::System.String _StudentClass;
        partial void OnStudentClassChanging(global::System.String value);
        partial void OnStudentClassChanged();

        #endregion

    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBModelModel", Name="StudentHistory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class StudentHistory : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 StudentHistory 对象。
        /// </summary>
        /// <param name="id">Id 属性的初始值。</param>
        public static StudentHistory CreateStudentHistory(global::System.Int32 id)
        {
            StudentHistory studentHistory = new StudentHistory();
            studentHistory.Id = id;
            return studentHistory;
        }

        #endregion

        #region 简单属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> AUDIT_STATE
        {
            get
            {
                return _AUDIT_STATE;
            }
            set
            {
                OnAUDIT_STATEChanging(value);
                ReportPropertyChanging("AUDIT_STATE");
                _AUDIT_STATE = StructuralObject.SetValidValue(value, "AUDIT_STATE");
                ReportPropertyChanged("AUDIT_STATE");
                OnAUDIT_STATEChanged();
            }
        }
        private Nullable<global::System.Int32> _AUDIT_STATE;
        partial void OnAUDIT_STATEChanging(Nullable<global::System.Int32> value);
        partial void OnAUDIT_STATEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CHECK_OPERATOR_ID
        {
            get
            {
                return _CHECK_OPERATOR_ID;
            }
            set
            {
                OnCHECK_OPERATOR_IDChanging(value);
                ReportPropertyChanging("CHECK_OPERATOR_ID");
                _CHECK_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "CHECK_OPERATOR_ID");
                ReportPropertyChanged("CHECK_OPERATOR_ID");
                OnCHECK_OPERATOR_IDChanged();
            }
        }
        private global::System.String _CHECK_OPERATOR_ID;
        partial void OnCHECK_OPERATOR_IDChanging(global::System.String value);
        partial void OnCHECK_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CHECK_OPERATOR_TIME
        {
            get
            {
                return _CHECK_OPERATOR_TIME;
            }
            set
            {
                OnCHECK_OPERATOR_TIMEChanging(value);
                ReportPropertyChanging("CHECK_OPERATOR_TIME");
                _CHECK_OPERATOR_TIME = StructuralObject.SetValidValue(value, "CHECK_OPERATOR_TIME");
                ReportPropertyChanged("CHECK_OPERATOR_TIME");
                OnCHECK_OPERATOR_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _CHECK_OPERATOR_TIME;
        partial void OnCHECK_OPERATOR_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnCHECK_OPERATOR_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CREATE_OPERATOR_ID
        {
            get
            {
                return _CREATE_OPERATOR_ID;
            }
            set
            {
                OnCREATE_OPERATOR_IDChanging(value);
                ReportPropertyChanging("CREATE_OPERATOR_ID");
                _CREATE_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "CREATE_OPERATOR_ID");
                ReportPropertyChanged("CREATE_OPERATOR_ID");
                OnCREATE_OPERATOR_IDChanged();
            }
        }
        private global::System.String _CREATE_OPERATOR_ID;
        partial void OnCREATE_OPERATOR_IDChanging(global::System.String value);
        partial void OnCREATE_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CREATE_TIME
        {
            get
            {
                return _CREATE_TIME;
            }
            set
            {
                OnCREATE_TIMEChanging(value);
                ReportPropertyChanging("CREATE_TIME");
                _CREATE_TIME = StructuralObject.SetValidValue(value, "CREATE_TIME");
                ReportPropertyChanged("CREATE_TIME");
                OnCREATE_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _CREATE_TIME;
        partial void OnCREATE_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnCREATE_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> OPERATOR_TYPE
        {
            get
            {
                return _OPERATOR_TYPE;
            }
            set
            {
                OnOPERATOR_TYPEChanging(value);
                ReportPropertyChanging("OPERATOR_TYPE");
                _OPERATOR_TYPE = StructuralObject.SetValidValue(value, "OPERATOR_TYPE");
                ReportPropertyChanged("OPERATOR_TYPE");
                OnOPERATOR_TYPEChanged();
            }
        }
        private Nullable<global::System.Int32> _OPERATOR_TYPE;
        partial void OnOPERATOR_TYPEChanging(Nullable<global::System.Int32> value);
        partial void OnOPERATOR_TYPEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UPDATE_OPERATOR_ID
        {
            get
            {
                return _UPDATE_OPERATOR_ID;
            }
            set
            {
                OnUPDATE_OPERATOR_IDChanging(value);
                ReportPropertyChanging("UPDATE_OPERATOR_ID");
                _UPDATE_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "UPDATE_OPERATOR_ID");
                ReportPropertyChanged("UPDATE_OPERATOR_ID");
                OnUPDATE_OPERATOR_IDChanged();
            }
        }
        private global::System.String _UPDATE_OPERATOR_ID;
        partial void OnUPDATE_OPERATOR_IDChanging(global::System.String value);
        partial void OnUPDATE_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> UPDATE_TIME
        {
            get
            {
                return _UPDATE_TIME;
            }
            set
            {
                OnUPDATE_TIMEChanging(value);
                ReportPropertyChanging("UPDATE_TIME");
                _UPDATE_TIME = StructuralObject.SetValidValue(value, "UPDATE_TIME");
                ReportPropertyChanged("UPDATE_TIME");
                OnUPDATE_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _UPDATE_TIME;
        partial void OnUPDATE_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnUPDATE_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> StudentId
        {
            get
            {
                return _StudentId;
            }
            set
            {
                OnStudentIdChanging(value);
                ReportPropertyChanging("StudentId");
                _StudentId = StructuralObject.SetValidValue(value, "StudentId");
                ReportPropertyChanged("StudentId");
                OnStudentIdChanged();
            }
        }
        private Nullable<global::System.Int32> _StudentId;
        partial void OnStudentIdChanging(Nullable<global::System.Int32> value);
        partial void OnStudentIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String StudentName
        {
            get
            {
                return _StudentName;
            }
            set
            {
                OnStudentNameChanging(value);
                ReportPropertyChanging("StudentName");
                _StudentName = StructuralObject.SetValidValue(value, true, "StudentName");
                ReportPropertyChanged("StudentName");
                OnStudentNameChanged();
            }
        }
        private global::System.String _StudentName;
        partial void OnStudentNameChanging(global::System.String value);
        partial void OnStudentNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> StudentAge
        {
            get
            {
                return _StudentAge;
            }
            set
            {
                OnStudentAgeChanging(value);
                ReportPropertyChanging("StudentAge");
                _StudentAge = StructuralObject.SetValidValue(value, "StudentAge");
                ReportPropertyChanged("StudentAge");
                OnStudentAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _StudentAge;
        partial void OnStudentAgeChanging(Nullable<global::System.Int32> value);
        partial void OnStudentAgeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> StudentSex
        {
            get
            {
                return _StudentSex;
            }
            set
            {
                OnStudentSexChanging(value);
                ReportPropertyChanging("StudentSex");
                _StudentSex = StructuralObject.SetValidValue(value, "StudentSex");
                ReportPropertyChanged("StudentSex");
                OnStudentSexChanged();
            }
        }
        private Nullable<global::System.Int32> _StudentSex;
        partial void OnStudentSexChanging(Nullable<global::System.Int32> value);
        partial void OnStudentSexChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String StudentClass
        {
            get
            {
                return _StudentClass;
            }
            set
            {
                OnStudentClassChanging(value);
                ReportPropertyChanging("StudentClass");
                _StudentClass = StructuralObject.SetValidValue(value, true, "StudentClass");
                ReportPropertyChanged("StudentClass");
                OnStudentClassChanged();
            }
        }
        private global::System.String _StudentClass;
        partial void OnStudentClassChanging(global::System.String value);
        partial void OnStudentClassChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion

    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DBModelModel", Name="StudentPending")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class StudentPending : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 StudentPending 对象。
        /// </summary>
        /// <param name="studentId">StudentId 属性的初始值。</param>
        public static StudentPending CreateStudentPending(global::System.Int32 studentId)
        {
            StudentPending studentPending = new StudentPending();
            studentPending.StudentId = studentId;
            return studentPending;
        }

        #endregion

        #region 简单属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> AUDIT_STATE
        {
            get
            {
                return _AUDIT_STATE;
            }
            set
            {
                OnAUDIT_STATEChanging(value);
                ReportPropertyChanging("AUDIT_STATE");
                _AUDIT_STATE = StructuralObject.SetValidValue(value, "AUDIT_STATE");
                ReportPropertyChanged("AUDIT_STATE");
                OnAUDIT_STATEChanged();
            }
        }
        private Nullable<global::System.Int32> _AUDIT_STATE;
        partial void OnAUDIT_STATEChanging(Nullable<global::System.Int32> value);
        partial void OnAUDIT_STATEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CHECK_OPERATOR_ID
        {
            get
            {
                return _CHECK_OPERATOR_ID;
            }
            set
            {
                OnCHECK_OPERATOR_IDChanging(value);
                ReportPropertyChanging("CHECK_OPERATOR_ID");
                _CHECK_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "CHECK_OPERATOR_ID");
                ReportPropertyChanged("CHECK_OPERATOR_ID");
                OnCHECK_OPERATOR_IDChanged();
            }
        }
        private global::System.String _CHECK_OPERATOR_ID;
        partial void OnCHECK_OPERATOR_IDChanging(global::System.String value);
        partial void OnCHECK_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CHECK_OPERATOR_TIME
        {
            get
            {
                return _CHECK_OPERATOR_TIME;
            }
            set
            {
                OnCHECK_OPERATOR_TIMEChanging(value);
                ReportPropertyChanging("CHECK_OPERATOR_TIME");
                _CHECK_OPERATOR_TIME = StructuralObject.SetValidValue(value, "CHECK_OPERATOR_TIME");
                ReportPropertyChanged("CHECK_OPERATOR_TIME");
                OnCHECK_OPERATOR_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _CHECK_OPERATOR_TIME;
        partial void OnCHECK_OPERATOR_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnCHECK_OPERATOR_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CREATE_OPERATOR_ID
        {
            get
            {
                return _CREATE_OPERATOR_ID;
            }
            set
            {
                OnCREATE_OPERATOR_IDChanging(value);
                ReportPropertyChanging("CREATE_OPERATOR_ID");
                _CREATE_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "CREATE_OPERATOR_ID");
                ReportPropertyChanged("CREATE_OPERATOR_ID");
                OnCREATE_OPERATOR_IDChanged();
            }
        }
        private global::System.String _CREATE_OPERATOR_ID;
        partial void OnCREATE_OPERATOR_IDChanging(global::System.String value);
        partial void OnCREATE_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CREATE_TIME
        {
            get
            {
                return _CREATE_TIME;
            }
            set
            {
                OnCREATE_TIMEChanging(value);
                ReportPropertyChanging("CREATE_TIME");
                _CREATE_TIME = StructuralObject.SetValidValue(value, "CREATE_TIME");
                ReportPropertyChanged("CREATE_TIME");
                OnCREATE_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _CREATE_TIME;
        partial void OnCREATE_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnCREATE_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> OPERATOR_TYPE
        {
            get
            {
                return _OPERATOR_TYPE;
            }
            set
            {
                OnOPERATOR_TYPEChanging(value);
                ReportPropertyChanging("OPERATOR_TYPE");
                _OPERATOR_TYPE = StructuralObject.SetValidValue(value, "OPERATOR_TYPE");
                ReportPropertyChanged("OPERATOR_TYPE");
                OnOPERATOR_TYPEChanged();
            }
        }
        private Nullable<global::System.Int32> _OPERATOR_TYPE;
        partial void OnOPERATOR_TYPEChanging(Nullable<global::System.Int32> value);
        partial void OnOPERATOR_TYPEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UPDATE_OPERATOR_ID
        {
            get
            {
                return _UPDATE_OPERATOR_ID;
            }
            set
            {
                OnUPDATE_OPERATOR_IDChanging(value);
                ReportPropertyChanging("UPDATE_OPERATOR_ID");
                _UPDATE_OPERATOR_ID = StructuralObject.SetValidValue(value, true, "UPDATE_OPERATOR_ID");
                ReportPropertyChanged("UPDATE_OPERATOR_ID");
                OnUPDATE_OPERATOR_IDChanged();
            }
        }
        private global::System.String _UPDATE_OPERATOR_ID;
        partial void OnUPDATE_OPERATOR_IDChanging(global::System.String value);
        partial void OnUPDATE_OPERATOR_IDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> UPDATE_TIME
        {
            get
            {
                return _UPDATE_TIME;
            }
            set
            {
                OnUPDATE_TIMEChanging(value);
                ReportPropertyChanging("UPDATE_TIME");
                _UPDATE_TIME = StructuralObject.SetValidValue(value, "UPDATE_TIME");
                ReportPropertyChanged("UPDATE_TIME");
                OnUPDATE_TIMEChanged();
            }
        }
        private Nullable<global::System.DateTime> _UPDATE_TIME;
        partial void OnUPDATE_TIMEChanging(Nullable<global::System.DateTime> value);
        partial void OnUPDATE_TIMEChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentId
        {
            get
            {
                return _StudentId;
            }
            set
            {
                if (_StudentId != value)
                {
                    OnStudentIdChanging(value);
                    ReportPropertyChanging("StudentId");
                    _StudentId = StructuralObject.SetValidValue(value, "StudentId");
                    ReportPropertyChanged("StudentId");
                    OnStudentIdChanged();
                }
            }
        }
        private global::System.Int32 _StudentId;
        partial void OnStudentIdChanging(global::System.Int32 value);
        partial void OnStudentIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String StudentName
        {
            get
            {
                return _StudentName;
            }
            set
            {
                OnStudentNameChanging(value);
                ReportPropertyChanging("StudentName");
                _StudentName = StructuralObject.SetValidValue(value, true, "StudentName");
                ReportPropertyChanged("StudentName");
                OnStudentNameChanged();
            }
        }
        private global::System.String _StudentName;
        partial void OnStudentNameChanging(global::System.String value);
        partial void OnStudentNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> StudentAge
        {
            get
            {
                return _StudentAge;
            }
            set
            {
                OnStudentAgeChanging(value);
                ReportPropertyChanging("StudentAge");
                _StudentAge = StructuralObject.SetValidValue(value, "StudentAge");
                ReportPropertyChanged("StudentAge");
                OnStudentAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _StudentAge;
        partial void OnStudentAgeChanging(Nullable<global::System.Int32> value);
        partial void OnStudentAgeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> StudentSex
        {
            get
            {
                return _StudentSex;
            }
            set
            {
                OnStudentSexChanging(value);
                ReportPropertyChanging("StudentSex");
                _StudentSex = StructuralObject.SetValidValue(value, "StudentSex");
                ReportPropertyChanged("StudentSex");
                OnStudentSexChanged();
            }
        }
        private Nullable<global::System.Int32> _StudentSex;
        partial void OnStudentSexChanging(Nullable<global::System.Int32> value);
        partial void OnStudentSexChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String StudentClass
        {
            get
            {
                return _StudentClass;
            }
            set
            {
                OnStudentClassChanging(value);
                ReportPropertyChanging("StudentClass");
                _StudentClass = StructuralObject.SetValidValue(value, true, "StudentClass");
                ReportPropertyChanged("StudentClass");
                OnStudentClassChanged();
            }
        }
        private global::System.String _StudentClass;
        partial void OnStudentClassChanging(global::System.String value);
        partial void OnStudentClassChanged();

        #endregion

    }

    #endregion

}
