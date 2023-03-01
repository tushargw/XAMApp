using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMApp.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridCustomControl : Grid
	{
		public GridCustomControl()
		{
			InitializeComponent();
		}

		public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(nameof(TitleText),
 typeof(string),
 typeof(GridCustomControl),
 defaultValue: string.Empty,
 defaultBindingMode: BindingMode.OneWay,
 propertyChanged: TitleTextPropertyChanged);
		private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var control = (GridCustomControl)bindable;
			control.Title.Text = newValue?.ToString();
		}
		public string TitleText
		{
			get
			{
				return base.GetValue(TitleTextProperty)?.ToString();
			}
			set
			{
				base.SetValue(TitleTextProperty, value);
			}
		}

		public static readonly BindableProperty DescriptionTextProperty = BindableProperty.Create(nameof(TitleText),
		typeof(string),
		typeof(GridCustomControl),
		defaultValue: string.Empty,
		defaultBindingMode: BindingMode.OneWay,
		propertyChanged: DescriptionTextPropertyChanged);
		private static void DescriptionTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var control = (GridCustomControl)bindable;
			control.Description.Text = newValue?.ToString();
		}
		public string DescriptionText
		{
			get
			{
				return base.GetValue(DescriptionTextProperty)?.ToString();
			}
			set
			{
				base.SetValue(DescriptionTextProperty, value);
			}
		}
	}
}