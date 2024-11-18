namespace MauiApp4.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}