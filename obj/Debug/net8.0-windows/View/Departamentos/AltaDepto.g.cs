﻿#pragma checksum "..\..\..\..\..\View\Departamentos\AltaDepto.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9DE89754676EA46D2B8F2B175174F8AFF78C0985"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica1.View.Departamentos;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Practica1.View.Departamentos {
    
    
    /// <summary>
    /// AltaDepto
    /// </summary>
    public partial class AltaDepto : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbClave;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtClave;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbDepto;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDepto;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbJefe;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtJefe;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbNotificacionAltaProducto;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Practica1;component/view/departamentos/altadepto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbClave = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtClave = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lbDepto = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtDepto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lbJefe = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtJefe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 18 "..\..\..\..\..\View\Departamentos\AltaDepto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnAgregarDepto);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbNotificacionAltaProducto = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

