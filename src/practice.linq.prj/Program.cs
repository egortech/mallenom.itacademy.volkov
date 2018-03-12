using System;
using System.Windows.Forms;

using Practice.Linq.Forms;

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
		}
	}
}