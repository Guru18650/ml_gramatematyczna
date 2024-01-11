namespace ml_gramatematyczna
{
    public partial class MainPage : ContentPage
    {
        Color defclr;
        public MainPage()
        {
            InitializeComponent();
            sldr.MinimumTrackColor = Colors.Green;
            sldr.MaximumTrackColor = Colors.Green;
            sldr.ThumbColor = Colors.Green;
            dzielenie.IsChecked = false;
            dzielenie.IsEnabled = false;
            defclr = dzielenie.Color;
            
        }

        private void sldr_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            sldr.Value = Math.Round(sldr.Value, 0);
            switch (sldr.Value)
            {
                case 1:
                    sldr.MinimumTrackColor = Colors.Green;
                    sldr.MaximumTrackColor = Colors.Green;
                    sldr.ThumbColor = Colors.Green;
                    dzielenie.IsChecked = false;
                    dzielenie.IsEnabled = false;
                    dzielenie.Color = defclr;
                    break;

                case 2:
                    sldr.MinimumTrackColor = Colors.Orange;
                    sldr.MaximumTrackColor = Colors.Orange;
                    sldr.ThumbColor = Colors.Orange;
                    dzielenie.IsChecked = false;
                    dzielenie.IsEnabled = false;
                    dzielenie.Color = defclr;

                    break;

                case 3:
                    sldr.MinimumTrackColor = Colors.Red;
                    sldr.MaximumTrackColor = Colors.Red;
                    sldr.ThumbColor = Colors.Red;
                    dzielenie.IsEnabled = true; 
                    dzielenie.Color = sldr.ThumbColor;
                    break;

            }
        }

        private async void st_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Game(int.Parse(repsE.Text),(int)sldr.Value, dodawanie.IsChecked, odejmowanie.IsChecked, dzielenie.IsChecked, mnozenie.IsChecked));
        }
    }
}