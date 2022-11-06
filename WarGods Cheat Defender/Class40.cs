using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

// Token: 0x020000D2 RID: 210
internal static class Class40
{
	// Token: 0x060006AC RID: 1708 RVA: 0x00063BE4 File Offset: 0x00061DE4
	public static void smethod_0()
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
			if (processesByName.Length != 0)
			{
				foreach (Process process in processesByName)
				{
					if (process.Id != currentProcess.Id)
					{
						if (process.MainModule.FileName == currentProcess.MainModule.FileName && process.MainWindowHandle != IntPtr.Zero)
						{
							GClass45.SetForegroundWindow(process.MainWindowHandle);
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00063C80 File Offset: 0x00061E80
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		if (GClass50.smethod_14(Registry.CurrentUser, "Software\\wCD"))
		{
			GClass50.smethod_15(Registry.CurrentUser, "Software\\wCD");
		}
		if (!GClass42.smethod_0())
		{
			bool flag = true;
			Mutex mutex = new Mutex(true, "WarGodsCheatDefender", out flag);
			if (!flag)
			{
				MessageBox.Show("An instance of the application is already running.", "wCD already running!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Class40.smethod_0();
				Application.Exit();
				return;
			}
			GC.KeepAlive(mutex);
			Application.Run(new WCD());
			return;
		}
		else
		{
			if (!GClass42.smethod_1())
			{
				Application.Exit();
				return;
			}
			GClass42.smethod_2();
			Application.Restart();
			return;
		}
	}
}
