using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Testing
{
	class MainClass
	{

		public static void Main (string[] args)
		{

			Console.WriteLine("Main:");
			SubProc x = new SubProc ();
			Thread w1 = new Thread(() => x.newSubs(5));
			Thread w2 = new Thread(() => x.newSubs(2));
			Thread w3 = new Thread(() => x.newSubs(6));

			w1.Start();
			w2.Start();
			w3.Start();
			x.Subs (2);
			x.Subs (5);
			x.Subs (6);
			Console.Read ();
			Co


		}
	}
}
