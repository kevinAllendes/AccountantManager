﻿#pragma checksum "..\..\PortalClientes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "115725B856EF97ACA3015C0DD0082979F818B92C7E889A1CF549E50C1D34675B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AccountantManager;
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


namespace AccountantManager {
    
    
    /// <summary>
    /// PortalClientes
    /// </summary>
    public partial class PortalClientes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\PortalClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGClientes;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\PortalClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEliminar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PortalClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAgregarCliente;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\PortalClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.StatusBar MiStatusBar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\PortalClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MiTextBlock;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PortalClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBuscar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\PortalClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBBuscar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PortalClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSalir;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountantManager;component/portalclientes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PortalClientes.xaml"
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
            this.DGClientes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BtnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\PortalClientes.xaml"
            this.BtnEliminar.Click += new System.Windows.RoutedEventHandler(this.BtnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnAgregarCliente = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\PortalClientes.xaml"
            this.BtnAgregarCliente.Click += new System.Windows.RoutedEventHandler(this.BtnAgregarCliente_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MiStatusBar = ((System.Windows.Controls.Primitives.StatusBar)(target));
            return;
            case 5:
            this.MiTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.BtnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\PortalClientes.xaml"
            this.BtnBuscar.Click += new System.Windows.RoutedEventHandler(this.BtnBuscar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TBBuscar = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\PortalClientes.xaml"
            this.TBBuscar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBBuscar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\PortalClientes.xaml"
            this.BtnSalir.Click += new System.Windows.RoutedEventHandler(this.BtnSalir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

