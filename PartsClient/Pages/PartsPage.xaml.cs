using System.Diagnostics;
using PartsClient.Data;
using PartsClient.ViewModels;

namespace PartsClient.Pages;

public partial class PartsPage : ContentPage
{
    public PartsPage()
    {
        try
        {
            InitializeComponent();
            BindingContext = DependencyService.Resolve<PartsViewModel>(); //
            //BindingContext = new PartsViewModel();
        }
        catch (Exception ex) 
        {
            Debug.WriteLine(ex.ToString());
        }
    }
}