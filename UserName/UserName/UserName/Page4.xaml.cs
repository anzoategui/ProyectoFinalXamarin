using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UserName
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : TabbedPage
	{
		public Page4 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            btnVerContactos.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new PaginaListaContactos());
            };
   
            
        }

        private async void btnVer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }

        private async void btnCierra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}