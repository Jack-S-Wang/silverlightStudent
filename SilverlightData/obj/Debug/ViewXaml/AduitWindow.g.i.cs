﻿#pragma checksum "C:\Users\Administrator\documents\visual studio 2015\Projects\SilverlightData\SilverlightData\ViewXaml\AduitWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F63E77E4533CA169893B7CB1683B8EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using NCS.UI.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SilverlightData.ViewXaml {
    
    
    public partial class AduitWindow : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal NCS.UI.Controls.QueryForm queryExamine;
        
        internal System.Windows.Controls.Button BtnApprove;
        
        internal System.Windows.Controls.Button BtnReject;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverlightData;component/ViewXaml/AduitWindow.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.queryExamine = ((NCS.UI.Controls.QueryForm)(this.FindName("queryExamine")));
            this.BtnApprove = ((System.Windows.Controls.Button)(this.FindName("BtnApprove")));
            this.BtnReject = ((System.Windows.Controls.Button)(this.FindName("BtnReject")));
        }
    }
}

