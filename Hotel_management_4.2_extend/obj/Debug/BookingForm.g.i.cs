﻿#pragma checksum "..\..\BookingForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "641B0DC7C9102ECB45171D4F573F8472DAF60F72"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Hotel_management_4._2_extend {
    
    
    /// <summary>
    /// BookingForm
    /// </summary>
    public partial class BookingForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_name;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_address;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_phone;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_room;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_check;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_duration;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_cost;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_payment;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_due;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\BookingForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_book_submit;
        
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
            System.Uri resourceLocater = new System.Uri("/Hotel_management_4.2_extend;component/bookingform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BookingForm.xaml"
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
            
            #line 18 "..\..\BookingForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\BookingForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_room = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_check = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\BookingForm.xaml"
            this.btn_check.Click += new System.Windows.RoutedEventHandler(this.btn_check_click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txt_duration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txt_cost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txt_payment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txt_due = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.btn_book_submit = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\BookingForm.xaml"
            this.btn_book_submit.Click += new System.Windows.RoutedEventHandler(this.btn_book_submit_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

