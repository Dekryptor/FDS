using System;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

// Token: 0x020000DD RID: 221
internal class Class44
{
	// Token: 0x17000303 RID: 771
	// (get) Token: 0x06000702 RID: 1794 RVA: 0x000648BC File Offset: 0x00062ABC
	// (set) Token: 0x06000703 RID: 1795 RVA: 0x000648D0 File Offset: 0x00062AD0
	public string String_0 { get; set; }

	// Token: 0x17000304 RID: 772
	// (get) Token: 0x06000704 RID: 1796 RVA: 0x000648E4 File Offset: 0x00062AE4
	// (set) Token: 0x06000705 RID: 1797 RVA: 0x000648F8 File Offset: 0x00062AF8
	public string String_1 { get; set; }

	// Token: 0x17000305 RID: 773
	// (get) Token: 0x06000706 RID: 1798 RVA: 0x0006490C File Offset: 0x00062B0C
	// (set) Token: 0x06000707 RID: 1799 RVA: 0x00064920 File Offset: 0x00062B20
	public string String_2 { get; set; }

	// Token: 0x17000306 RID: 774
	// (get) Token: 0x06000708 RID: 1800 RVA: 0x00064934 File Offset: 0x00062B34
	// (set) Token: 0x06000709 RID: 1801 RVA: 0x00064948 File Offset: 0x00062B48
	public string String_3 { get; set; }

	// Token: 0x0600070A RID: 1802 RVA: 0x0006495C File Offset: 0x00062B5C
	public Class44(string string_4 = "", string string_5 = "", string string_6 = "", string string_7 = "")
	{
		this.String_0 = string_4;
		this.String_1 = string_5;
		this.String_2 = string_6;
		this.String_3 = string_7;
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x0006498C File Offset: 0x00062B8C
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
		{
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			Class15.smethod_22(this.String_2),
			Class15.char_2,
			Class15.smethod_22(this.String_3)
		});
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00064A08 File Offset: 0x00062C08
	public static string smethod_0()
	{
		Class44 @class = new Class44("", "", "", "");
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(Class14.String_14, Class14.String_62).Get().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					try
					{
						@class.String_0 = managementObject.GetPropertyValue(Class14.String_179).ToString().Trim();
					}
					catch
					{
						@class.String_0 = string.Empty;
					}
					try
					{
						IL_7D:
						@class.String_1 = managementObject.GetPropertyValue(Class14.String_84).ToString().Trim();
					}
					catch
					{
						@class.String_1 = string.Empty;
					}
					try
					{
						@class.String_2 = managementObject.GetPropertyValue(Class14.String_32).ToString().Trim();
					}
					catch
					{
						@class.String_2 = string.Empty;
					}
					try
					{
						@class.String_3 = managementObject.GetPropertyValue(Class14.String_174).ToString().Trim();
					}
					catch
					{
						@class.String_3 = string.Empty;
					}
					if (!(@class.String_0 == string.Empty) || !(@class.String_1 == string.Empty))
					{
						break;
					}
					if (!(@class.String_2 == string.Empty))
					{
						break;
					}
					continue;
					//goto IL_7D;
				}
			}
		}
		catch
		{
		}
		if (@class.String_0.Length == 0)
		{
			@class.String_0 = GClass50.smethod_6(Registry.LocalMachine, Class14.String_38, Class14.String_99);
			if (@class.String_0 == null)
			{
				@class.String_0 = string.Empty;
			}
		}
		if (@class.String_3.Length == 0)
		{
			@class.String_3 = GClass50.smethod_6(Registry.LocalMachine, Class14.String_38, Class14.String_218);
			if (@class.String_3 == null)
			{
				@class.String_3 = string.Empty;
			}
		}
		return @class.ToString();
	}

	// Token: 0x040009C9 RID: 2505
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009CA RID: 2506
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009CB RID: 2507
	[CompilerGenerated]
	private string string_2;

	// Token: 0x040009CC RID: 2508
	[CompilerGenerated]
	private string string_3;
}
