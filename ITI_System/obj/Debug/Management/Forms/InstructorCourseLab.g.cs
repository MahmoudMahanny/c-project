﻿#pragma checksum "..\..\..\..\Management\Forms\InstructorCourseLab.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1ABF67A2F50A1A5B3568E5902478488E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ITI_System.Management.Forms;
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


namespace ITI_System.Management.Forms {
    
    
    /// <summary>
    /// InstructorCourseLab
    /// </summary>
    public partial class InstructorCourseLab : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Management\Forms\InstructorCourseLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBInstructor;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Management\Forms\InstructorCourseLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBCourse;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Management\Forms\InstructorCourseLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBLab;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Management\Forms\InstructorCourseLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddInsCrsLab;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Management\Forms\InstructorCourseLab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG1;
        
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
            System.Uri resourceLocater = new System.Uri("/ITI_System;component/management/forms/instructorcourselab.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Management\Forms\InstructorCourseLab.xaml"
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
            this.CBInstructor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\..\Management\Forms\InstructorCourseLab.xaml"
            this.CBInstructor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBInstructor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CBCourse = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CBLab = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.BtnAddInsCrsLab = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Management\Forms\InstructorCourseLab.xaml"
            this.BtnAddInsCrsLab.Click += new System.Windows.RoutedEventHandler(this.BtnAddInsCrsLab_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DG1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

