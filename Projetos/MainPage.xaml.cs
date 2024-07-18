using Microsoft.Maui.Controls;

namespace Projetos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void UpdateScannedData(string data)
        {
            scannedEntry.Text = data;
        }
    }
}
