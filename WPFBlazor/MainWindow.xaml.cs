using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.DependencyInjection;
using WebApp;
using Index = WebApp.Index;

namespace WPFBlazor;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
        
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWpfBlazorWebView();
        serviceCollection.AddBlazorWebViewDeveloperTools();
        
        WebAppServices.registerServices(serviceCollection);
        
        Resources.Add("services", serviceCollection.BuildServiceProvider());
        
        BlazorWebView1.HostPage = "wwwroot/index.html";
        BlazorWebView1.Services = serviceCollection.BuildServiceProvider();
        
    }
}