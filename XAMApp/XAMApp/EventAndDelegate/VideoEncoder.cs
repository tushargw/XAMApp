using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace XAMApp.EventAndDelegate
{
	internal class VideoEncoder
	{
		public delegate void VideoEncoderEventHandler (object sender, EventArgs e);

		public event VideoEncoderEventHandler VideoEncoded;

		public void Encode(Image video)
		{
			Thread.Sleep(3000);

			OnVideoEncoded();
		}

		private void OnVideoEncoded()
		{
			if (VideoEncoded != null)
			{
				VideoEncoded(this, EventArgs.Empty);
			}
		}
	}
}
