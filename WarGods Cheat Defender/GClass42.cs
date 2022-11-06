using System;
using System.Windows.Forms;
using Microsoft.Win32;

// Token: 0x0200006F RID: 111
public class GClass42
{
	// Token: 0x06000374 RID: 884 RVA: 0x0004D794 File Offset: 0x0004B994
	public static bool smethod_0()
	{
		return 0U == GClass42.uint_0;
	}

	// Token: 0x06000375 RID: 885 RVA: 0x0004D7AC File Offset: 0x0004B9AC
	public static bool smethod_1()
	{
		string text = "Information";
		return MessageBox.Show("We like to remember you a few things:\n" + "\n* the purpose of this application is to detect cheats from Counter-Strke 1.6 and generate reports, therefore we scan the memory & some files (processes, loaded game binaries, game configs and resources [e.g: models, sprites], forensics data and files)" + "\n* we collect and use your personal information (such as IP address, Steam ID, computer specifications, OS information, country, language, etc.) in order to fullfil the purpose of this application and to improve our (free) service and security" + "\n* we do NOT send any private information (such as the content of the files)!" + "\n* to protect wCD against hacks a watch dog will be started; this has the purpose to monitor every created/exited process" + "\n* any attempt to bypass wCD's temporary ban, using fake/cracked wCD executable or any method to bypass wCD's scanning engines will result in an permanent ban" + "\n* violating our terms & conditions will result in a permanent ban" + "\n\nFor more details about this project please visit: " + Class12.smethod_1(true) + "\n\nAre you sure you want to agree with our terms and conditions?", text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
	}

	// Token: 0x06000376 RID: 886 RVA: 0x0004D828 File Offset: 0x0004BA28
	public static void smethod_2()
	{
		GClass50.smethod_11(Registry.CurrentUser, "Software\\wCD", "Eula", GClass42.uint_0, true);
	}

	// Token: 0x04000360 RID: 864
	public static readonly uint uint_0 = 4U;
}
