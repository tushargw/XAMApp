using SQLite;
using System;
using System.IO;
using XAMApp.Models;
using XAMApp.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp
{
	public partial class App : Application
	{
		public static readonly SQLiteConnection Connection = new SQLiteConnection(Path.Combine(FileSystem.AppDataDirectory, "Data.db3"));

		public App()
		{
			InitializeComponent();

			_ = Connection.CreateTable<Login>();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
