﻿#pragma checksum "..\..\Methods.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3200249F0234F53FB91C931F6BB5D809EA6AE118"
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
    /// Methods
    /// </summary>
    public partial class Methods : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid KinectRegionGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.KinectSensorChooserUI sensorChooserUi;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectCircleButton Cbutton1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectCircleButton Cbutton2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectCircleButton Cbutton3;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock answer1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock answer2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock answer3;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image tickimg;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Methods.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Congratulations;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Methods.xaml"
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
            System.Uri resourceLocater = new System.Uri("/InterfaceProgCW2;component/methods.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Methods.xaml"
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
            this.sensorChooserUi = ((Microsoft.Kinect.Toolkit.KinectSensorChooserUI)(target));
            return;
            case 3:
            
            #line 22 "..\..\Methods.xaml"
            ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target)).Click += new System.Windows.RoutedEventHandler(this.HomeButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Cbutton1 = ((Microsoft.Kinect.Toolkit.Controls.KinectCircleButton)(target));
            
            #line 24 "..\..\Methods.xaml"
            this.Cbutton1.Click += new System.Windows.RoutedEventHandler(this.KinectCircleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Cbutton2 = ((Microsoft.Kinect.Toolkit.Controls.KinectCircleButton)(target));
            
            #line 25 "..\..\Methods.xaml"
            this.Cbutton2.Click += new System.Windows.RoutedEventHandler(this.KinectCircleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cbutton3 = ((Microsoft.Kinect.Toolkit.Controls.KinectCircleButton)(target));
            
            #line 26 "..\..\Methods.xaml"
            this.Cbutton3.Click += new System.Windows.RoutedEventHandler(this.KinectCircleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.answer1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.answer2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.answer3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.tickimg = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.Congratulations = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.outputText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

