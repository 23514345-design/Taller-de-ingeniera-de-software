using AppMovil.ViewModels;

namespace AppMovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new AlertaViewModel();
        }
    }
}
