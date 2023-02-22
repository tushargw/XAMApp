using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace XAMApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
		private int _index = 0;
		private string[] _quotes = new string[] {
			"I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best. ― Marilyn Monroe",
			"You've gotta dance like there's nobody watching, Love like you'll never be hurt, Sing like there's nobody listening, And live like it's heaven on earth. ― William W. Purkey",
			"You only live once, but if you do it right, once is enough. ― Mae West",
			"In three words I can sum up everything I've learned about life: it goes on. ― Robert Frost",
			"To live is the rarest thing in the world. Most people exist, that is all. ― Oscar Wilde",
			"Insanity is doing the same thing, over and over again, but expecting different results. ― Narcotics Anonymous",
			"It is better to be hated for what you are than to be loved for what you are not. ― Andre Gide, Autumn Leaves",
			"There are only two ways to live your life. One is as though nothing is a miracle. The other is as though everything is a miracle. ― Albert Einstein",
			"It does not do to dwell on dreams and forget to live. ― J.K. Rowling, Harry Potter and the Sorcerer's Stone",
			"Good friends, good books, and a sleepy conscience: this is the ideal life. ― Mark Twain",
			"Life is what happens to us while we are making other plans. ― Allen Saunders" 
		};

		private string Quote { get; set; }

		public QuotesPage()
		{
			InitializeComponent();

			SetQuote(0);
		}

		private void Previous_Clicked(object sender, EventArgs e)
		{
			_index = _index > 0 ? --_index : 0;
			SetQuote(_index);
		}

		private void Next_Clicked(object sender, EventArgs e)
		{
			_index = _index < _quotes.Length - 1 ? ++_index : _quotes.Length - 1;
			SetQuote(_index);
		}

		private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			var fontSize = (int)e.NewValue;
			slider.Value = fontSize;
			quoteLabel.FontSize = fontSize;
		}

		private void SetQuote(int index)
		{
			Quote = _quotes[index];
			quoteLabel.Text = Quote;
		}

	}
}