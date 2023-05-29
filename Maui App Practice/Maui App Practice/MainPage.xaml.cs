using System.Diagnostics;

namespace Maui_App_Practice;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		/*count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);*/

		ProcessStartInfo startInfo = new ProcessStartInfo();
		startInfo.FileName = @"\Users\geraintwaddon\Documents\GitHub\Foundry-Phase1-Geraint\Banking App\Banking App\bin\Debug\net7.0\Banking App.exe";
		startInfo.Arguments = usernameEntry.Text + " " + passwordEntry.Text;
		Process.Start(startInfo);

    }

    void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		CounterBtn.IsVisible = true;
    }
}