using System;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

// Token: 0x020000E5 RID: 229
internal class Class52
{
	// Token: 0x17000324 RID: 804
	// (get) Token: 0x0600075B RID: 1883 RVA: 0x000664C0 File Offset: 0x000646C0
	// (set) Token: 0x0600075C RID: 1884 RVA: 0x000664D4 File Offset: 0x000646D4
	public string String_0 { get; set; }

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x0600075D RID: 1885 RVA: 0x000664E8 File Offset: 0x000646E8
	// (set) Token: 0x0600075E RID: 1886 RVA: 0x000664FC File Offset: 0x000646FC
	public string String_1 { get; set; }

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x0600075F RID: 1887 RVA: 0x00066510 File Offset: 0x00064710
	// (set) Token: 0x06000760 RID: 1888 RVA: 0x00066524 File Offset: 0x00064724
	public string String_2 { get; set; }

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x06000761 RID: 1889 RVA: 0x00066538 File Offset: 0x00064738
	// (set) Token: 0x06000762 RID: 1890 RVA: 0x0006654C File Offset: 0x0006474C
	public string String_3 { get; set; }

	// Token: 0x06000763 RID: 1891 RVA: 0x00066560 File Offset: 0x00064760
	public Class52(string string_4 = "", string string_5 = "", string string_6 = "", string string_7 = "")
	{
		this.String_0 = string_4;
		this.String_1 = string_5;
		this.String_2 = string_6;
		this.String_3 = string_7;
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00066590 File Offset: 0x00064790
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

	// Token: 0x06000765 RID: 1893 RVA: 0x0006660C File Offset: 0x0006480C
	public static string smethod_0()
	{
		Class52 @class = new Class52("", "", "", "");
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(Class14.String_14, Class14.String_187).Get().GetEnumerator())
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
						@class.String_1 = managementObject.GetPropertyValue(Class14.String_189).ToString().Trim();
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
			@class.String_0 = GClass50.smethod_6(Registry.LocalMachine, Class14.String_38, Class14.String_184);
			if (@class.String_0 == null)
			{
				@class.String_0 = string.Empty;
			}
		}
		if (@class.String_1.Length == 0)
		{
			@class.String_1 = GClass50.smethod_6(Registry.LocalMachine, Class14.String_38, Class14.String_124);
			if (@class.String_1 == null)
			{
				@class.String_1 = string.Empty;
			}
		}
		if (@class.String_3.Length == 0)
		{
			@class.String_3 = GClass50.smethod_6(Registry.LocalMachine, Class14.String_38, Class14.String_36);
			if (@class.String_3 == null)
			{
				@class.String_3 = string.Empty;
			}
		}
		return @class.ToString();
	}

	// Token: 0x040009EA RID: 2538
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009EB RID: 2539
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009EC RID: 2540
	[CompilerGenerated]
	private string string_2;

	// Token: 0x040009ED RID: 2541
	[CompilerGenerated]
	private string string_3;
}
