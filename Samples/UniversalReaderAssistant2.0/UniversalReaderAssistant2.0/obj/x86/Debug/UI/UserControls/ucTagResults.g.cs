﻿#pragma checksum "..\..\..\..\..\UI\UserControls\ucTagResults.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11479F318081D9F518E25E62595C793584B07756"
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
using ThingMagic.URA2;
using ThingMagic.URA2.BL;


namespace ThingMagic.URA2 {
    
    
    /// <summary>
    /// ucTagResults
    /// </summary>
    public partial class ucTagResults : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTagResults;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn serialNoColumn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn epcColumn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn epcColumnInAscii;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn epcColumnInReverseBase36;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dataColumn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dataColumnInAscii;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn timeStampColumn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn rssiColumn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn readCountColumn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn antennaColumn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn protocolColumn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn frequencyColumn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn phaseColumn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSelectedCell;
        
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
            System.Uri resourceLocater = new System.Uri("/UniversalReaderAssistant;component/ui/usercontrols/uctagresults.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
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
            this.dgTagResults = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
            this.dgTagResults.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dgTagResults_LoadingRow);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
            this.dgTagResults.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.dgTagResults_MouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
            this.dgTagResults.LostFocus += new System.Windows.RoutedEventHandler(this.dgTagResults_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.serialNoColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.epcColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.epcColumnInAscii = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.epcColumnInReverseBase36 = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.dataColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.dataColumnInAscii = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.timeStampColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 10:
            this.rssiColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            this.readCountColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 12:
            this.antennaColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 13:
            this.protocolColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 14:
            this.frequencyColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 15:
            this.phaseColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 16:
            this.txtSelectedCell = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 20 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\..\..\UI\UserControls\ucTagResults.xaml"
            ((System.Windows.Controls.CheckBox)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.headerCheckBox_MouseEnter);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

