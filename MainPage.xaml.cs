namespace MauiTutorial6;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        if (Screenshot.Default.IsCaptureSupported)
        {
            IScreenshotResult screen = await Screenshot.Default.CaptureAsync();
            Stream stream = await screen.OpenReadAsync();
            img.Source = ImageSource.FromStream(() => stream);
        }

        SemanticScreenReader.Announce("Image Captured");
	}
}

