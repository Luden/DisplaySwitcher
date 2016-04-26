using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DisplaySwitcher
{
	internal class TvWorkingChecker
	{
		private readonly string _tvAddress;

		public TvWorkingChecker(Settings settings)
		{
			_tvAddress = settings.tvAddress;
		}

		private bool PingHost(string nameOrAddress)
		{
			var pingable = false;
			var pinger = new Ping();

			for (int i = 0; i < 4; i++)
			{
				try
				{
					var reply = pinger.Send(nameOrAddress, 50);
					if (reply.Status == IPStatus.Success)
						return true;
				}
				catch (PingException)
				{
					// Discard PingExceptions and return false;
				}
			}
			return false;
		}
		
		public bool IsTvWorking()
		{
			return PingHost(_tvAddress);
		}
	}
}
