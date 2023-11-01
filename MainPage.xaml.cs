namespace NFCTagApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
#if IOS
            NFCTagApp.Platforms.iOS.NFCTagService nFCTagService = new NFCTagApp.Platforms.iOS.NFCTagService();
            nFCTagService.Scan();
#endif
        }
    }
}