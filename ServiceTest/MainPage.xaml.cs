namespace ServiceTest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        try
        {
            string address = "https://tcu.base2base.com.ua:9005/api";
            BasicHttpConnection connection = new BasicHttpConnection(address);
            var result = await connection.Post<string[]>("Values", "string", new CancellationToken());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Exception", ex.Message, "OK");
        }
    }
}