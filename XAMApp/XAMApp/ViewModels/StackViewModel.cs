using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XAMApp.ViewModels
{
	public class StackViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string _title;
		public string Title
		{
			get { return _title; }
			set
			{
				if (_title != value)
				{
					_title = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
				}
			}
		}

		private string _description;
		public string Description
		{
			get { return _description; }
			set
			{
				if (_description != value)
				{
					_description = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
				}
			}
		}
	}
}
