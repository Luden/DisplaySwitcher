using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplaySwitcher
{
	internal class DisplayFusionControl
	{
		private readonly string _displayFusionPath;

		public DisplayFusionControl(Settings settings)
		{
			_displayFusionPath = settings.displayFusionPath;
		}

		public void SetMode(Mode mode)
		{
			ProcessRunner.Run(_displayFusionPath, $"-monitorloadprofile \"{mode}\"");
		}
	}
}
