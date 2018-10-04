﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UserName
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
           


        }

        private async void btnEnv_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void btnIni_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}