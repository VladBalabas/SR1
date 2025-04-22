using System.ComponentModel;
using SR1.ViewModels;
using Xamarin.Forms;

namespace SR1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}