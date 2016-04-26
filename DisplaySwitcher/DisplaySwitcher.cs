using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplaySwitcher
{
	internal class DisplaySwitcher
	{
		static readonly Settings _settings = new Settings();

		private readonly DisplayFusionControl _displayControl	= new DisplayFusionControl(_settings);
		private readonly IrControl	_irControl					= new IrControl(_settings);
		private readonly ModeGetter _modeGetter				= new ModeGetter(_settings);
		private readonly TvWorkingChecker _tvChecker			= new TvWorkingChecker(_settings);

		public DisplaySwitcher()
		{ }

		public void UpdateMode()
		{
			var currentMode = _modeGetter.GetCurrentMode();

			if (currentMode == Mode.Work)
				SetWorkMode();
			else if (currentMode == Mode.Game)
				SetGameMode();
		}

		public void SwitchMode()
		{
			var currentMode = _modeGetter.GetCurrentMode();

			if (currentMode == Mode.Work)
				SetGameMode();
			else if (currentMode == Mode.Game)
				SetWorkMode();
		}

		public void SetWorkMode()
		{
			_displayControl.SetMode(Mode.Work);
		}

		public void SetGameMode()
		{
			_displayControl.SetMode(Mode.Game);

			if (!_tvChecker.IsTvWorking())
				_irControl.TurnOn();
		}
	}
}
