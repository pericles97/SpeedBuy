﻿#pragma checksum "..\..\..\View\AddProduct.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85BB069F51A0B7083770AF192DAF7D08A34CE25E"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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
using ViewWPF.View;


namespace ViewWPF.View {
    
    
    /// <summary>
    /// AddProduct
    /// </summary>
    public partial class AddProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCodigo;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCategoria;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPreco;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrar;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAlterar;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDataBinding;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button remove;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\View\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button alterar;
        
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
            System.Uri resourceLocater = new System.Uri("/ViewWPF;component/view/addproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AddProduct.xaml"
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
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtCodigo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtCategoria = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPreco = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnCadastrar = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\View\AddProduct.xaml"
            this.btnCadastrar.Click += new System.Windows.RoutedEventHandler(this.BtnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\View\AddProduct.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.BtnCancelProduct_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAlterar = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\View\AddProduct.xaml"
            this.btnAlterar.Click += new System.Windows.RoutedEventHandler(this.ButtonAlterarSalvar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lvDataBinding = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.remove = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\View\AddProduct.xaml"
            this.remove.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.alterar = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\View\AddProduct.xaml"
            this.alterar.Click += new System.Windows.RoutedEventHandler(this.BtnAlterar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

