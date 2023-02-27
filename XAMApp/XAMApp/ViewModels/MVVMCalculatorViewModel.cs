using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using Xamarin.Forms;

namespace XAMApp.ViewModels
{
    public class MVVMCalculatorViewModel : INotifyPropertyChanged
	{
		private readonly IView _view;

		int _firstNumber;
		public int FirstNumber
		{
			get => _firstNumber;
			set
			{
				_firstNumber = value;
				var args = new PropertyChangedEventArgs(nameof(FirstNumber));
				PropertyChanged?.Invoke(this, args);
			}
		}

		int _secondNumber;
		public int SecondNumber
		{
			get => _secondNumber;
			set
			{
				_secondNumber = value;
				var args = new PropertyChangedEventArgs(nameof(SecondNumber));
				PropertyChanged?.Invoke(this, args);
			}
		}

		double _result;
		public double Result
		{
			get => _result;
			set
			{
				_result = value;
				var args = new PropertyChangedEventArgs(nameof(Result));
				PropertyChanged?.Invoke(this, args);
			}
		}

		public Command AddCommand { get; }
		public Command SubCommand { get; }
		public Command MulCommand { get; }
		public Command DivCommand { get; }
		
		public event PropertyChangedEventHandler PropertyChanged;

		public MVVMCalculatorViewModel(IView view)
		{
			_view = view;

			AddCommand = new Command(() => { Result = FirstNumber + SecondNumber; });
			SubCommand = new Command(() => { Result = FirstNumber - SecondNumber; });
			MulCommand = new Command(() => { Result = FirstNumber * SecondNumber; });
			DivCommand = new Command(() => { 
				if(SecondNumber == 0)
				{
					_view.ShowError("Second number cannot be 0.");
					Result = 0;
					return;
				}
					Result = (double)FirstNumber / SecondNumber; 
			});
		}
	}
}
