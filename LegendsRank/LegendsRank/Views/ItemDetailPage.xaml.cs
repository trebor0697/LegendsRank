using LegendsRank.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LegendsRank.Views
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