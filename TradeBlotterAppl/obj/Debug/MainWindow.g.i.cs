﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "96407D0EAD3E2F4652306F14CF38D8DD"
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
using TradeBlotterAppl;


namespace TradeBlotterAppl {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image loginImage_png;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataTrade;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstUserName;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button2;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button3;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker startDate;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker endDate;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resultByFilterDate;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profileButton;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button4;
        
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
            System.Uri resourceLocater = new System.Uri("/TradeBlotterAppl;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 19 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnPreviousClicked);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 25 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnNextClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.loginImage_png = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.dataTrade = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\MainWindow.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.filterEvent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstUserName = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.button2 = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\MainWindow.xaml"
            this.button2.Click += new System.Windows.RoutedEventHandler(this.toEmailWindow);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button3 = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\MainWindow.xaml"
            this.button3.Click += new System.Windows.RoutedEventHandler(this.toMessageWindow);
            
            #line default
            #line hidden
            return;
            case 9:
            this.startDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.endDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            this.resultByFilterDate = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\MainWindow.xaml"
            this.resultByFilterDate.Click += new System.Windows.RoutedEventHandler(this.getResultsByDateFilter);
            
            #line default
            #line hidden
            return;
            case 12:
            this.profileButton = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\MainWindow.xaml"
            this.profileButton.Click += new System.Windows.RoutedEventHandler(this.ToUserWindow);
            
            #line default
            #line hidden
            return;
            case 13:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\MainWindow.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.calculator);
            
            #line default
            #line hidden
            return;
            case 14:
            this.button4 = ((System.Windows.Controls.Button)(target));
            
            #line 167 "..\..\MainWindow.xaml"
            this.button4.Click += new System.Windows.RoutedEventHandler(this.writeNotes);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

