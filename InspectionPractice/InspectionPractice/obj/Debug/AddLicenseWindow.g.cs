﻿#pragma checksum "..\..\AddLicenseWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1749459021FDC88C1F79B42AD90766C6FA2C68283DF3032F4C406015A60F5C98"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using InspectionPractice;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace InspectionPractice {
    
    
    /// <summary>
    /// AddLicenseWindow
    /// </summary>
    public partial class AddLicenseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\AddLicenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateStart;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddLicenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateEnd;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddLicenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSeries;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddLicenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNumber;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddLicenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxDriver;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddLicenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxStatus;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\AddLicenseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxCategories;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InspectionPractice;component/addlicensewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddLicenseWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DateStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.DateEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.TextBoxSeries = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textBoxNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.comboBoxDriver = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.comboBoxStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.comboBoxCategories = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 113 "..\..\AddLicenseWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Leave);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 121 "..\..\AddLicenseWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddLicenseClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
