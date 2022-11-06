using System;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

// Token: 0x020000E0 RID: 224
internal class Class47
{
	// Token: 0x17000313 RID: 787
	// (get) Token: 0x0600072B RID: 1835 RVA: 0x000654E8 File Offset: 0x000636E8
	// (set) Token: 0x0600072C RID: 1836 RVA: 0x000654FC File Offset: 0x000636FC
	public string String_0 { get; set; }

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x0600072D RID: 1837 RVA: 0x00065510 File Offset: 0x00063710
	// (set) Token: 0x0600072E RID: 1838 RVA: 0x00065524 File Offset: 0x00063724
	public string String_1 { get; set; }

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x0600072F RID: 1839 RVA: 0x00065538 File Offset: 0x00063738
	// (set) Token: 0x06000730 RID: 1840 RVA: 0x0006554C File Offset: 0x0006374C
	public int Int32_0 { get; set; }

	// Token: 0x06000731 RID: 1841 RVA: 0x00065560 File Offset: 0x00063760
	public Class47(string string_2 = "", string string_3 = "", int int_1 = 1)
	{
		this.String_0 = string_2;
		this.String_1 = string_3;
		this.Int32_0 = int_1;
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00065588 File Offset: 0x00063788
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}", new object[]
		{
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			this.Int32_0.ToString()
		});
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x000655EC File Offset: 0x000637EC
	public static string smethod_0()
	{
		string text = string.Empty;
		string text2 = string.Empty;
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(Class14.String_14, Class14.String_55).Get().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					try
					{
						text = managementObject.GetPropertyValue(Class14.String_222).ToString().Trim();
					}
					catch
					{
						text = string.Empty;
					}
					try
					{
						IL_5C:
						text2 = managementObject.GetPropertyValue(Class14.String_105).ToString().Trim();
					}
					catch
					{
						text2 = string.Empty;
					}
					if (text.Length == 0)
					{
						continue;
					}
					break;
					//goto IL_5C;
				}
			}
		}
		catch
		{
		}
		if (text == string.Empty || text.Length == 0)
		{
			text = GClass50.smethod_6(Registry.LocalMachine, Class14.String_79, Class14.String_10);
			if (text == null)
			{
				text = string.Empty;
			}
		}
		return new Class47(text, text2, Environment.ProcessorCount).ToString();
	}

	// Token: 0x040009D9 RID: 2521
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009DA RID: 2522
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009DB RID: 2523
	[CompilerGenerated]
	private int int_0;
}
