﻿#pragma checksum "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C733547CE0471A4235135319197D755C6A53EB54DD9F19921372F8BDB33A721E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LandConquest.DialogWIndows;
using LandConquest.Resources;
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


namespace LandConquest.DialogWIndows {
    
    
    /// <summary>
    /// CreatePersonDialogWindow
    /// </summary>
    public partial class CreatePersonDialogWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox personName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createPersonBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PersonName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Male;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Female;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Creation;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Dynasty;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/dialogwindows/createpersondialogwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
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
            this.personName = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
            this.personName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.personName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.createPersonBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
            this.createPersonBtn.Click += new System.Windows.RoutedEventHandler(this.createPersonBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PersonName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Male = ((System.Windows.Controls.RadioButton)(target));
            
            #line 26 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
            this.Male.Checked += new System.Windows.RoutedEventHandler(this.Male_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Female = ((System.Windows.Controls.RadioButton)(target));
            
            #line 27 "..\..\..\DialogWIndows\CreatePersonDialogWindow.xaml"
            this.Female.Checked += new System.Windows.RoutedEventHandler(this.Female_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Creation = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Dynasty = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

