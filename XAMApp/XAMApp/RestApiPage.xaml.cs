using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static XAMApp.RestApiPage;

namespace XAMApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RestApiPage : ContentPage
	{
		private const string URL = "https://jsonplaceholder.typicode.com/posts";
		private HttpClient _client = new HttpClient();
		private ObservableCollection<Post> _posts;

		public class Post : INotifyPropertyChanged
		{
			public int Id { get; set; }
			public string Title { get; set; }
			public string Body { get; set; }

			public event PropertyChangedEventHandler PropertyChanged;
		}

		public RestApiPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			var content = await _client.GetStringAsync(URL);
			var post = JsonConvert.DeserializeObject<List<Post>>(content);
			_posts = new ObservableCollection<Post>(post);
			postsListView.ItemsSource = _posts;
			base.OnAppearing();
		}
		async void OnAdd(object sender, System.EventArgs e)
		{
			var post = new Post { Title = "Hello" + DateTime.Now.Ticks.ToString() };
			_posts.Insert(0, post);
			var content = JsonConvert.SerializeObject(post);
			await _client.PostAsync(URL, new StringContent(content));
		}
		
		async void OnUpdate(object sender, System.EventArgs e)
		{
			var post = _posts[0];
			post.Title += "Updated";
			var content = JsonConvert.SerializeObject(post);
			_posts[0] = post;
			await _client.PutAsync(URL, new StringContent(content));
		}

		async void OnDelete(object sender, System.EventArgs e)
		{
			var post = _posts[0];
			await _client.DeleteAsync(URL + "/" + post.Id);
			_posts.Remove(post);
		}
	}
}