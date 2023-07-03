using System.Diagnostics;
using PartsClient.Data;
using PartsClient.ViewModels;


namespace PartsClient.Pages;

public partial class PartsPage : ContentPage
{
    private readonly HttpClient _httpClient;
    private readonly PartsManager partsManager;
    public PartsPage()
    {
        try
        {
            InitializeComponent();

            partsManager = new PartsManager(_httpClient);
            BindingContext = new PartsViewModel(partsManager); //typeof(PartsViewModel); //DependencyService.Resolve<PartsViewModel>(); //Hier ist ein Fehler!
            //BindingContext = new PartsViewModel();
        }
        catch (Exception ex) 
        {
            Debug.WriteLine(ex.ToString());
        }
    }

}