using BallBadminton_Helper.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BallBadminton_Helper.Views
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