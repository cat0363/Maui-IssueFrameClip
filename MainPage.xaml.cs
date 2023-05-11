namespace Maui_IssueFrameClip;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		System.Diagnostics.Debug.WriteLine("IsClippedToBounds:" + frm.IsClippedToBounds);
	}
}

