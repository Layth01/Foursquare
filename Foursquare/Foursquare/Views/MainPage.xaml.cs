using Foursquare.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Foursquare 
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void click (object Sender, EventArgs e)
        {
            public var text = MainEntry.Text;
           await Navigation.PushModalAsync(new Resultat(text));
        }
    }
}
