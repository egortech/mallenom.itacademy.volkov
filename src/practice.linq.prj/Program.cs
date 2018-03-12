using System;
using System.Linq;
using System.Windows.Forms;

using Practice.Linq.Forms;
using Practice.Linq.IEnumerableUtils;

namespace Practice.Linq
{
	/// <summary>
	/// The static class that hold application's entry point.
	/// </summary>
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

			var list = new[] { 1, 2, 3, 4, 5 };

			var res = list.TakeStart(1, 1).ToList();
			var res2 = list.Skip(2).Take(2);

			res = list.TakeStart(1, 3).ToList();
			res = list.TakeStart(2, 2).ToList();
		}


	}
}