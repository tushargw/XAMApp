﻿using System.ComponentModel;
using Xamarin.Forms;

namespace XAMApp.ViewModels
{
	internal class MVVMPageViewModel : INotifyPropertyChanged
	{
		public MVVMPageViewModel()
		{
			ClearCommand = new Command(() =>
			{
				Comments = string.Empty;
			});
			PostCommand = new Command(() =>
			{
				Result = Comments;
				Comments = string.Empty;
			});
		}
		string _Comments;
		string _result;
		public string Comments
		{
			get => _Comments;
			set
			{
				_Comments = value;
				var args = new PropertyChangedEventArgs(nameof(Comments));
				PropertyChanged?.Invoke(this, args);
			}
		}
		public string Result
		{
			get => _result;
			set
			{
				_result = value;
				var args = new PropertyChangedEventArgs(nameof(Result));
				PropertyChanged?.Invoke(this, args);
			}
		}
		public Command PostCommand { get; }
		public Command ClearCommand { get; }
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
