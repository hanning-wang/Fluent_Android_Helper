﻿#pragma checksum "..\..\..\Software Settings Views\Theme.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "270A02BB8E8EF46F52789E6088390DE4B9772BA465D18B66CCFD2773A2A060C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using ModernWpf;
using ModernWpf.Controls;
using ModernWpf.Controls.Primitives;
using ModernWpf.DesignTime;
using ModernWpf.Markup;
using ModernWpf.Media.Animation;
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


namespace Fluent_Android_Helper.Software_Settings_Views {
    
    
    /// <summary>
    /// Theme
    /// </summary>
    public partial class Theme : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Software Settings Views\Theme.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ModernWpf.Controls.ToggleSwitch ThemeAccentBaseColor;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Software Settings Views\Theme.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ModernWpf.Controls.ToggleSwitch IsTransparentActive;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Software Settings Views\Theme.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SetWelcomeTitle;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Software Settings Views\Theme.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WelcomeTitleText;
        
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
            System.Uri resourceLocater = new System.Uri("/Fluent_Android_Helper;component/software%20settings%20views/theme.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Software Settings Views\Theme.xaml"
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
            this.ThemeAccentBaseColor = ((ModernWpf.Controls.ToggleSwitch)(target));
            
            #line 14 "..\..\..\Software Settings Views\Theme.xaml"
            this.ThemeAccentBaseColor.Toggled += new System.Windows.RoutedEventHandler(this.ThemeAccentBaseColor_Toggled);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IsTransparentActive = ((ModernWpf.Controls.ToggleSwitch)(target));
            
            #line 19 "..\..\..\Software Settings Views\Theme.xaml"
            this.IsTransparentActive.Toggled += new System.Windows.RoutedEventHandler(this.IsTransparentActive_Toggled);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SetWelcomeTitle = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Software Settings Views\Theme.xaml"
            this.SetWelcomeTitle.Click += new System.Windows.RoutedEventHandler(this.SetWelcomeTitle_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WelcomeTitleText = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

