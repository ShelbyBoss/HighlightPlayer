﻿#pragma checksum "..\..\..\Controls\HighlightCollectionControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CBB8FA5DB16F0C0AC4109F71AC7D8EB9"
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
    /// HighlightCollectionControl
    /// </summary>
    public partial class HighlightCollectionControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Controls\HighlightCollectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HighlightPlayer.Controls.HighlightCollectionControl control;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\HighlightCollectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg;
        
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
            System.Uri resourceLocater = new System.Uri("/HighlightPlayer;component/controls/highlightcollectioncontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\HighlightCollectionControl.xaml"
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
            this.control = ((HighlightPlayer.Controls.HighlightCollectionControl)(target));
            return;
            case 2:
            this.dg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\..\Controls\HighlightCollectionControl.xaml"
            this.dg.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.Dg_LoadingRow);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Controls\HighlightCollectionControl.xaml"
            this.dg.UnloadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.Dg_UnloadingRow);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Controls\HighlightCollectionControl.xaml"
            this.dg.AutoGeneratedColumns += new System.EventHandler(this.Dg_AutoGeneratedColumns);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Controls\HighlightCollectionControl.xaml"
            this.dg.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.DataGrid_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

