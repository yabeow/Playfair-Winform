/*
 * Created by SharpDevelop.
 * User: Gia
 * Date: 3/17/2018
 * Time: 9:12 AM
 * 
 */
using System;
using System.Windows.Forms;

namespace Playfair
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
