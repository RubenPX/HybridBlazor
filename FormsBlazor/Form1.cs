using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using Index = WebApp.Index;

namespace FormsBlazor;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
        
        var services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        
        BlazorWebView blazorWebView = new BlazorWebView();
        blazorWebView.HostPage = "wwwroot\\index.html";
        blazorWebView.Services = services.BuildServiceProvider();
        blazorWebView.RootComponents.Add<Index>("#app");
        
        blazorWebView.Dock = DockStyle.Fill;
        Controls.Add(blazorWebView);
    }
}