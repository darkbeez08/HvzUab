using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace HvzUab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("Resources/HALAL/ 1280px - Kaaba_Masjid_Al - Haram_Mecca_Saudi_Arabia_ - _panoramio");
            //await Launcher.OpenAsync("https://www.google.com/search?q=meca&client=opera-gx&hs=aWk&sxsrf=ALeKk03o17PQrSeAlhZpRP_ygeZUB6EC3g:1629851372030&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiYzsPA9cryAhVxzoUKHWFPBpEQ_AUoAXoECAEQAw&biw=1319&bih=658#imgrc=w06KMYrQG0PZ7M");
        }
    }
}