using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlayCoreUpdateTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Button_Clicked(Object sender, EventArgs e)
        {
            var appReviewer = DependencyService.Get<PlayCoreUpdateTest.IInAppReview>();
            appReviewer.LaunchReview();
        }
    }
}
