using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBugCollections.ViewModel;

namespace XamarinBugCollections.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Label_LineBreakMode : ContentPage
    {
        public Page_Label_LineBreakMode()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((ViewModelLocator)this.BindingContext).Onboarding.RefreshData();
        }
    }
}