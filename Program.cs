﻿using System;
using System.IO;
using System.Windows.Forms;

namespace FileChecksum
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length != 1)
			{
				MessageBox.Show("Usage: " + Path.GetFileName(Application.ExecutablePath) + " <Path to file>");
				return;
			}

			if (!File.Exists(args[0]))
			{
				MessageBox.Show("Error: File not found!\n\n" + args[0]);
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(args[0]));
		}
	}
}
