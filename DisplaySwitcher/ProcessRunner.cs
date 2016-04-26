using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplaySwitcher
{
	internal class ProcessRunner
	{
		public static void Run(string process, string args)
		{
			var proc = new Process();
			proc.EnableRaisingEvents = false;
			proc.StartInfo.FileName = process;
			proc.StartInfo.Arguments = args;

			proc.Start();

			proc.WaitForExit();
		}
	}
}
