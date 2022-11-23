namespace MauiApp3;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
        {
            Label = "Subscribe to my channel?",
            Location = new Location(50.8514, 5.6910),
        });
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

