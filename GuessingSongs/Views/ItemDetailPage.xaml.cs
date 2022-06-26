using GuessingSongs.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GuessingSongs.Views
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