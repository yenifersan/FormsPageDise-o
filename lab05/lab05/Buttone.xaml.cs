using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttone : ContentPage
    {
        public Buttone()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {

            await label.RelRotateTo(360, 1000);
        }

    }
}