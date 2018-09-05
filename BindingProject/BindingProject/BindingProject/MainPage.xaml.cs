using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BindingXaml_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PorXaml.BindingXamlPage());
        }

        private void BindingCSharp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PorCSharp.BindingCSharpPage());
        }
    }
}
