﻿#pragma checksum "..\..\IfStatement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08CDFDB7E0A61615F5E2F9D792C27367876FB1F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InterfaceProgCW2;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
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


namespace InterfaceProgCW2 {
    
    
    /// <summary>
    /// IfStatement
    /// </summary>
    public partial class IfStatement : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid KinectRegionGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectCircleButton Cbutton1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectCircleButton Cbutton2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectCircleButton Cbutton3;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock answer1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock answer2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock answer3;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image tickimg;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Congratulations;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\IfStatement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock outputText;
        
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
            System.Uri resourceLocater = new System.Uri("/InterfaceProgCW2;component/ifstatement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\IfStatement.xaml"
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
            this.KinectRegionGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 15 "..\..\IfStatement.xaml"
            ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target)).Click += new System.Windows.RoutedEventHandler(this.HomeButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Cbutton1 = ((Microsoft.Kinect.Toolkit.Controls.KinectCircleButton)(target));
            
            #line 17 "..\..\IfStatement.xaml"
            this.Cbutton1.Click += new System.Windows.RoutedEventHandler(this.KinectCircleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Cbutton2 = ((Microsoft.Kinect.Toolkit.Controls.KinectCircleButton)(target));
            
            #line 18 "..\..\IfStatement.xaml"
            this.Cbutton2.Click += new System.Windows.RoutedEventHandler(this.KinectCircleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Cbutton3 = ((Microsoft.Kinect.Toolkit.Controls.KinectCircleButton)(target));
            
            #line 19 "..\..\IfStatement.xaml"
            this.Cbutton3.Click += new System.Windows.RoutedEventHandler(this.KinectCircleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.answer1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.answer2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.answer3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.tickimg = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.Congratulations = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.outputText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

