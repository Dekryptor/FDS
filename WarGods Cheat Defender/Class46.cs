using System;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

// Token: 0x020000DF RID: 223
internal class Class46
{
	// Token: 0x1700030D RID: 781
	// (get) Token: 0x0600071C RID: 1820 RVA: 0x00064FEC File Offset: 0x000631EC
	// (set) Token: 0x0600071D RID: 1821 RVA: 0x00065000 File Offset: 0x00063200
	public string String_0 { get; set; }

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x0600071E RID: 1822 RVA: 0x00065014 File Offset: 0x00063214
	// (set) Token: 0x0600071F RID: 1823 RVA: 0x00065028 File Offset: 0x00063228
	public string String_1 { get; set; }

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x06000720 RID: 1824 RVA: 0x0006503C File Offset: 0x0006323C
	// (set) Token: 0x06000721 RID: 1825 RVA: 0x00065050 File Offset: 0x00063250
	public string String_2 { get; set; }

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x06000722 RID: 1826 RVA: 0x00065064 File Offset: 0x00063264
	// (set) Token: 0x06000723 RID: 1827 RVA: 0x00065078 File Offset: 0x00063278
	public string String_3 { get; set; }

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x06000724 RID: 1828 RVA: 0x0006508C File Offset: 0x0006328C
	// (set) Token: 0x06000725 RID: 1829 RVA: 0x000650A0 File Offset: 0x000632A0
	public string String_4 { get; set; }

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x06000726 RID: 1830 RVA: 0x000650B4 File Offset: 0x000632B4
	// (set) Token: 0x06000727 RID: 1831 RVA: 0x000650C8 File Offset: 0x000632C8
	public string String_5 { get; set; }

	// Token: 0x06000728 RID: 1832 RVA: 0x000650DC File Offset: 0x000632DC
	public Class46()
	{
		this.String_0 = string.Empty;
		this.String_1 = string.Empty;
		this.String_2 = string.Empty;
		this.String_3 = string.Empty;
		this.String_4 = string.Empty;
		this.String_5 = string.Empty;
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00065134 File Offset: 0x00063334
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}", new object[]
		{
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			Class15.smethod_22(this.String_2),
			Class15.char_2,
			Class15.smethod_22(this.String_3),
			Class15.char_2,
			Class15.smethod_22(this.String_4),
			Class15.char_2,
			Class15.smethod_22(this.String_5)
		});
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x000651EC File Offset: 0x000633EC
	public static string smethod_0()
	{
		Class46 @class = new Class46();
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(Class14.String_14, Class14.String_238).Get().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					try
					{
						@class.String_0 = managementObject.GetPropertyValue(Class14.String_222).ToString().Trim();
					}
					catch
					{
						@class.String_0 = string.Empty;
					}
					try
					{
						IL_69:
						@class.String_1 = managementObject.GetPropertyValue(Class14.String_84).ToString().Trim();
					}
					catch
					{
						@class.String_1 = string.Empty;
					}
					try
					{
						@class.String_2 = managementObject.GetPropertyValue(Class14.String_226).ToString().Trim();
					}
					catch
					{
						@class.String_2 = string.Empty;
					}
					try
					{
						@class.String_3 = managementObject.GetPropertyValue(Class14.String_145).ToString().Trim();
					}
					catch
					{
						@class.String_3 = string.Empty;
					}
					try
					{
						@class.String_4 = Class15.smethod_10(managementObject.GetPropertyValue(Class14.String_64).ToString().Trim()
							.Replace("-", "")
							.ToUpper());
					}
					catch
					{
						@class.String_4 = string.Empty;
					}
					try
					{
						@class.String_5 = managementObject.GetPropertyValue(Class14.String_179).ToString().Trim();
					}
					catch
					{
						@class.String_5 = string.Empty;
					}
					if (!(@class.String_0 == string.Empty) || !(@class.String_2 == string.Empty))
					{
						break;
					}
					if (!(@class.String_4 == string.Empty))
					{
						break;
					}
					continue;
					//goto IL_69;
				}
			}
		}
		catch
		{
		}
		if (@class.String_5.Length == 0)
		{
			@class.String_5 = GClass50.smethod_6(Registry.LocalMachine, Class14.String_38, Class14.String_72);
			if (@class.String_5 == null)
			{
				@class.String_5 = string.Empty;
			}
		}
		if (@class.String_0.Length == 0)
		{
			@class.String_0 = GClass50.smethod_6(Registry.LocalMachine, Class14.String_38, Class14.String_140);
			if (@class.String_0 == null)
			{
				@class.String_0 = string.Empty;
			}
		}
		return @class.ToString();
	}

	// Token: 0x040009D3 RID: 2515
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009D4 RID: 2516
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009D5 RID: 2517
	[CompilerGenerated]
	private string string_2;

	// Token: 0x040009D6 RID: 2518
	[CompilerGenerated]
	private string string_3;

	// Token: 0x040009D7 RID: 2519
	[CompilerGenerated]
	private string string_4;

	// Token: 0x040009D8 RID: 2520
	[CompilerGenerated]
	private string string_5;
}
