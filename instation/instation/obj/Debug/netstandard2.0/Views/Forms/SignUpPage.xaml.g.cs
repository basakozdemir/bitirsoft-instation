//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("instation.Views.Forms.SignUpPage.xaml", "Views/Forms/SignUpPage.xaml", typeof(global::instation.Views.Forms.SignUpPage))]

namespace instation.Views.Forms {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Forms\\SignUpPage.xaml")]
    public partial class SignUpPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::instation.Controls.BorderlessEntry NameEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::instation.Controls.BorderlessEntry PasswordEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::instation.Controls.BorderlessEntry ConfirmPasswordEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(SignUpPage));
            NameEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::instation.Controls.BorderlessEntry>(this, "NameEntry");
            PasswordEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::instation.Controls.BorderlessEntry>(this, "PasswordEntry");
            ConfirmPasswordEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::instation.Controls.BorderlessEntry>(this, "ConfirmPasswordEntry");
        }
    }
}