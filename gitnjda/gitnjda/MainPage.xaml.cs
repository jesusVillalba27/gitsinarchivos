namespace gitnjda
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
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnRespuestaClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string respuesta = button.Text;

            if (respuesta == "París")
            {
                await DisplayAlert("Resultado", "¡Correcto!", "OK");
            }
            else
            {
                await DisplayAlert("Resultado", "Incorrecto. Intenta de nuevo.", "OK");
            }
        }

    }

}
