namespace MyFirstMauiApp;

public partial class NewPage1 : ContentPage
{
	private int count;
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        count++;
        lblCounter.Text = count.ToString();

        SemanticScreenReader.Announce(lblCounter.Text);
    }
}