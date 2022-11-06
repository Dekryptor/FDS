using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

// Token: 0x020000E3 RID: 227
internal class Class50
{
	// Token: 0x06000748 RID: 1864 RVA: 0x00065D40 File Offset: 0x00063F40
	public static string smethod_0(string string_0 = "", string string_1 = "")
	{
		List<string> list = new List<string>();
		list.Add(string_0);
		list.Add(DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture));
		string text = Class54.smethod_1();
		list.Add(text);
		string text2 = Class45.smethod_0();
		list.Add(text2);
		string text3 = Class46.smethod_0();
		list.Add(text3);
		string text4 = Class47.smethod_0();
		list.Add(text4);
		string text5 = Class48.smethod_0();
		list.Add(text5);
		string text6 = Class53.smethod_1();
		list.Add(text6);
		string text7 = Class44.smethod_0();
		list.Add(text7);
		string text8 = Class52.smethod_0();
		list.Add(text8);
		string text9 = Class51.smethod_0();
		list.Add(text9);
		string text10 = Class49.smethod_0();
		list.Add(text10);
		string text11 = Class56.smethod_0();
		list.Add(text11);
		try
		{
			CultureInfo installedUICulture = CultureInfo.InstalledUICulture;
			list.Add(installedUICulture.TwoLetterISOLanguageName.ToLower());
		}
		catch
		{
			list.Add("");
		}
		try
		{
			RegionInfo regionInfo = new RegionInfo(CultureInfo.InstalledUICulture.LCID);
			list.Add(regionInfo.TwoLetterISORegionName.ToLower());
		}
		catch
		{
			list.Add("");
		}
		string text12 = Class15.smethod_8(Process.GetCurrentProcess().MainModule.FileName);
		list.Add(text12);
		list.Add(string_1);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < list.Count; i++)
		{
			stringBuilder.Append(list[i]);
			if (i + 1 != list.Count)
			{
				stringBuilder.Append(Class15.char_0);
			}
		}
		return stringBuilder.ToString();
	}
}
