using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XAMApp.ViewModels
{
    public interface IView
    {
		void ShowError(string message);
	}
}
