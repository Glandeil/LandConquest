﻿#pragma checksum "..\..\..\Forms\RatingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A2CF22E71F9DCF94F1FC707A337AE0A14DA33EE4CC50F467096B4E2F0D4A1FC1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LandConquest.Forms;
using LandConquest.Resources;
using System;
using System.Collections;
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


namespace LandConquest.Forms {
    
    
    /// <summary>
    /// RatingWindow
    /// </summary>
    public partial class RatingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image profileImage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonXP;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCoins;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonArmy;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonTitles;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView xpRankingsList;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView coinsRankingsList;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView armyRankingsList;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/forms/ratingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\RatingWindow.xaml"
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
            
            #line 12 "..\..\..\Forms\RatingWindow.xaml"
            ((LandConquest.Forms.RatingWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.profileImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.buttonXP = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Forms\RatingWindow.xaml"
            this.buttonXP.Click += new System.Windows.RoutedEventHandler(this.buttonXP_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonCoins = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Forms\RatingWindow.xaml"
            this.buttonCoins.Click += new System.Windows.RoutedEventHandler(this.buttonCoins_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonArmy = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Forms\RatingWindow.xaml"
            this.buttonArmy.Click += new System.Windows.RoutedEventHandler(this.buttonArmy_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonTitles = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Forms\RatingWindow.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.xpRankingsList = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.coinsRankingsList = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.armyRankingsList = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

