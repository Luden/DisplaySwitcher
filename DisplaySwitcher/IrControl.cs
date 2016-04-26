using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplaySwitcher
{
	internal class IrControl
	{
		private readonly string _digisparkSender;
		private readonly string _commandOn;

		public IrControl(Settings settings)
		{
			_digisparkSender = settings.digiSparkSender;
			_commandOn = settings.irProtocolCommandTurnOn;
		}

		public void TurnOn()
		{
			ProcessRunner.Run(_digisparkSender, _commandOn);
		}
	}
}
