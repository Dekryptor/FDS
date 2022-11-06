using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.Win32;

// Token: 0x020000D7 RID: 215
public class GClass59
{
	// Token: 0x060006CA RID: 1738 RVA: 0x00064144 File Offset: 0x00062344
	private static GEnum52 smethod_0(string string_0)
	{
		uint num = 0U;
		GClass50.smethod_8(Registry.CurrentUser, Class14.String_194 + "\\" + string_0, Class14.String_174, out num);
		if (num == 3U)
		{
			return GEnum52.const_1;
		}
		if (num != 5U)
		{
			return GEnum52.const_0;
		}
		return GEnum52.const_2;
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00064184 File Offset: 0x00062384
	public static GClass58[] smethod_1(string string_0)
	{
		GEnum52 genum = GClass59.smethod_0(string_0);
		if (genum == GEnum52.const_0)
		{
			throw new NotSupportedException();
		}
		List<GClass58> list = new List<GClass58>();
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string.Concat(new string[]
		{
			Class14.String_194,
			"\\",
			string_0,
			"\\",
			Class14.String_230
		}), false);
		if (registryKey != null)
		{
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
					byte[] array3 = (byte[])registryKey.GetValue(text, null);
					if (array3 != null)
					{
						if (genum == GEnum52.const_1 && (long)array3.Length == (long)((ulong)Class41.uint_0))
						{
							Class41 @class = new Class41(array3);
							GClass58 gclass = new GClass58(Class13.smethod_22(text, 13), @class.UInt32_1, @class.Int64_0, genum);
							list.Add(gclass);
						}
						else if (genum == GEnum52.const_2)
						{
							if ((long)array3.Length == (long)((ulong)Class42.uint_0))
							{
								Class42 class2 = new Class42(array3);
								GClass58 gclass2 = new GClass58(Class13.smethod_22(text, 13), class2.UInt32_1, class2.Int64_0, genum);
								list.Add(gclass2);
							}
						}
					}
				}
			}
			return list.ToArray();
		}
		throw new NotSupportedException();
	}
}
