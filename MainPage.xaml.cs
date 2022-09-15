namespace App1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		border.StrokeDashArray.Add(5);
		border.StrokeDashArray.Add(150);
		border.StrokeDashArray.Add(300);
		border.StrokeDashArray.Add(0);
		border.StrokeDashOffset = 5;

		
		if (sender is Button button)
		{
			button.Text = "Clicked";
		}
	}
}