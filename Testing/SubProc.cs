using System;
using System.Threading;

namespace Testing
{
	public class SubProc
	{
		public SubProc ()
		{
		}

		public void newSubs (int segons)
		{
			int ms_segons = segons * 1000;
			Thread.Sleep(ms_segons);
			Console.WriteLine("con thread " + segons);
		}

		public void Subs (int segons)
		{
			int ms_segons = segons * 1000;
			Thread.Sleep(ms_segons);
			Console.WriteLine("sin thread " + segons);
		}

	}
}

