﻿#pragma checksum "..\..\..\AddApointmentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "176D7FC435B3EA98D2237BAD1182BB49727D71A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekt;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Projekt {
    
    
    /// <summary>
    /// AddApointmentWindow
    /// </summary>
    public partial class AddApointmentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\AddApointmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AddApointmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker AppointmentDatePicker;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\AddApointmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AppointmentTimeTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AddApointmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ServiceTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AddApointmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MenRadioButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AddApointmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton WomenRadioButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AddApointmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ChildRadioButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AddApointmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAppointmentButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projekt;component/addapointmentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddApointmentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CustomerNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AppointmentDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.AppointmentTimeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ServiceTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.MenRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.WomenRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.ChildRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.AddAppointmentButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\AddApointmentWindow.xaml"
            this.AddAppointmentButton.Click += new System.Windows.RoutedEventHandler(this.AddAppointmentButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

