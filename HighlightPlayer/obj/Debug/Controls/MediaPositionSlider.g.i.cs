﻿#pragma checksum "..\..\..\Controls\MediaPositionSlider.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5CEEEB94F8BA6F7481C1D1122EC84086"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using HighlightPlayer.Controls;
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


namespace HighlightPlayer.Controls {
    
    
    /// <summary>
    /// MediaPositionSlider
    /// </summary>
    public partial class MediaPositionSlider : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Controls\MediaPositionSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HighlightPlayer.Controls.MediaPositionSlider control;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\MediaPositionSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblPosition;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Controls\MediaPositionSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblDuration;
        
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
            System.Uri resourceLocater = new System.Uri("/HighlightPlayer;component/controls/mediapositionslider.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\MediaPositionSlider.xaml"
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
            this.control = ((HighlightPlayer.Controls.MediaPositionSlider)(target));
            return;
            case 2:
            this.tblPosition = ((System.Windows.Controls.TextBlock)(target));
            
            #line 18 "..\..\..\Controls\MediaPositionSlider.xaml"
            this.tblPosition.SizeChanged += new System.Windows.SizeChangedEventHandler(this.tblPosition_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tblDuration = ((System.Windows.Controls.TextBlock)(target));
            
            #line 26 "..\..\..\Controls\MediaPositionSlider.xaml"
            this.tblDuration.SizeChanged += new System.Windows.SizeChangedEventHandler(this.tblDuration_SizeChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

