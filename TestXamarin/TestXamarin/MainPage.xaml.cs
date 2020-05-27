using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ServiceStack.Text;

namespace TestXamarin
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        const int ErrorFontSize = 12;
        const int StandartFontSize = 40;

        public MainPage()
        {
            InitializeComponent();
            UpdateCovidCases();
        }

        private void UpdateButtonClicked(object sender, EventArgs e)
        {
            CountText.FontSize = StandartFontSize;
            CountText.Text = "Loading...";
            UpdateCovidCases();
        }

        void UpdateCovidCases()
        {
            try
            {
                CountText.Text = CovidInfoGetter.GetCases().ToString();
            }
            catch
            {
                CountText.FontSize = ErrorFontSize;
                CountText.Text = "Error. It's can be network problem. Connect to internet and press \"Update cases\"";
            }
        }

    }
}
