using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class App : Application
	{
		public App ()
		{
			var webpage = new WebPage ();

			MainPage = webpage;
		}
	}
}

