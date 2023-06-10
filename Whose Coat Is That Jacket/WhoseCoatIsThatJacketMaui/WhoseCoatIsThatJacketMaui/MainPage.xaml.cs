
using System.Diagnostics;

namespace WhoseCoatIsThatJacketMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		ProcessStartInfo startInfo = new ProcessStartInfo();
		startInfo.FileName = @"C:\Users\gerai\Documents\Repos\Whose Coat Is That Jacket\Whose Coat Is That Jacket\bin\Debug\net7.0\Whose Coat Is That Jacket.exe";
		Process.Start(startInfo);
    }
}

