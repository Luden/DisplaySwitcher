using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplaySwitcher
{
	internal class ModeGetter
	{
		private readonly string _tvName;

		public ModeGetter(Settings settings)
		{
			_tvName = settings.tvName;
		}

		public Mode GetCurrentMode()
		{
			return Screen.PrimaryScreen.DeviceFriendlyName() == _tvName ? Mode.Game : Mode.Work;
		}
	}
}
