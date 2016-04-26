using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplaySwitcher
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var switcher = new DisplaySwitcher();

			if (args.Length == 0)
			{
				Console.WriteLine("Usage : DisplaySwitcher [-Work][-Game][-Switch][-Update]");
				return;
			}

			switch (args[0].ToLower().Trim())
			{
				case "-work":
					switcher.SetWorkMode();
					break;
				case "-game":
					switcher.SetGameMode();
					break;
				case "-switch":
					switcher.SwitchMode();
					break;
				case "-update":
					switcher.UpdateMode();
					break;
			}
		}
	}
}
