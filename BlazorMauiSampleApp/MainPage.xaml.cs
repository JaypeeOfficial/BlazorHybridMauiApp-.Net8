﻿namespace BlazorMauiSampleApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Native UI!", "This is coming from a native button", "OK"); 
        }
    }
}
