using QuickNotes.ViewModel;

namespace QuickNotes
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vievModel)
        {
            InitializeComponent();
            BindingContext = vievModel;
        }

        
    }

}
