using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.Win32;

// Token: 0x020000F8 RID: 248
internal class Class59
{
	// Token: 0x060007CD RID: 1997 RVA: 0x000680E8 File Offset: 0x000662E8
	private static GEnum58 smethod_0(GEnum57 genum57_0, string string_0)
	{
		uint num = 0U;
		GClass50.smethod_8(Registry.LocalMachine, ((genum57_0 == GEnum57.const_1) ? Class14.String_87 : Class14.String_52) + "\\" + string_0, Class14.String_174, out num);
		if (num == 1U)
		{
			return GEnum58.const_1;
		}
		return GEnum58.const_0;
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x0006812C File Offset: 0x0006632C
	public static Class58[] smethod_1(string string_0, GEnum57 genum57_0)
	{
		GEnum58 genum = Class59.smethod_0(genum57_0, string_0);
		if (genum == GEnum58.const_0)
		{
			throw new NotSupportedException();
		}
		List<Class58> list = new List<Class58>();
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(((genum57_0 == GEnum57.const_1) ? Class14.String_87 : Class14.String_52) + "\\" + string_0, false);
		if (registryKey == null)
		{
			throw new NotSupportedException();
		}
		string[] array = new string[0];
		for (int i = 0; i < 5; i++)
		{
			try
			{
				array = registryKey.GetValueNames();
				break;
			}
			catch (IOException)
			{
				Thread.Sleep(100);
			}
		}
		foreach (string text in array)
		{
			if (registryKey.GetValueKind(text) == RegistryValueKind.Binary)
			{
				byte[] array3 = (byte[])registryKey.GetValue(text);
				if (genum == GEnum58.const_1 && (long)array3.Length == (long)((ulong)Class60.uint_0))
				{
					Class60 @class = new Class60(array3);
					Class58 class2 = new Class58(text, @class.Int64_0, genum);
					list.Add(class2);
				}
			}
		}
		return list.ToArray();
	}
}
