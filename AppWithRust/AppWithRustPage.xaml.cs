using Xamarin.Forms;

namespace AppWithRust
{
    public partial class AppWithRustPage : ContentPage
    {
        public AppWithRustPage()
        {
            this.BindingContext = new MainPageViewModel();
            InitializeComponent();
        }
    }
}
