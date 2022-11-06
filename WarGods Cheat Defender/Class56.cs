using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020000ED RID: 237
internal class Class56
{
	// Token: 0x17000330 RID: 816
	// (get) Token: 0x06000783 RID: 1923 RVA: 0x00067060 File Offset: 0x00065260
	// (set) Token: 0x06000784 RID: 1924 RVA: 0x00067074 File Offset: 0x00065274
	public string String_0 { get; set; }

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x06000785 RID: 1925 RVA: 0x00067088 File Offset: 0x00065288
	// (set) Token: 0x06000786 RID: 1926 RVA: 0x0006709C File Offset: 0x0006529C
	public string String_1 { get; set; }

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x06000787 RID: 1927 RVA: 0x000670B0 File Offset: 0x000652B0
	// (set) Token: 0x06000788 RID: 1928 RVA: 0x000670C4 File Offset: 0x000652C4
	public uint UInt32_0 { get; set; }

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x06000789 RID: 1929 RVA: 0x000670D8 File Offset: 0x000652D8
	// (set) Token: 0x0600078A RID: 1930 RVA: 0x000670EC File Offset: 0x000652EC
	public ushort UInt16_0 { get; set; }

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x0600078B RID: 1931 RVA: 0x00067100 File Offset: 0x00065300
	// (set) Token: 0x0600078C RID: 1932 RVA: 0x00067114 File Offset: 0x00065314
	public string String_2 { get; set; }

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x0600078D RID: 1933 RVA: 0x00067128 File Offset: 0x00065328
	// (set) Token: 0x0600078E RID: 1934 RVA: 0x0006713C File Offset: 0x0006533C
	public string String_3 { get; set; }

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x0600078F RID: 1935 RVA: 0x00067150 File Offset: 0x00065350
	// (set) Token: 0x06000790 RID: 1936 RVA: 0x00067164 File Offset: 0x00065364
	public string String_4 { get; set; }

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x06000791 RID: 1937 RVA: 0x00067178 File Offset: 0x00065378
	// (set) Token: 0x06000792 RID: 1938 RVA: 0x0006718C File Offset: 0x0006538C
	public string String_5 { get; set; }

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x06000793 RID: 1939 RVA: 0x000671A0 File Offset: 0x000653A0
	// (set) Token: 0x06000794 RID: 1940 RVA: 0x000671B4 File Offset: 0x000653B4
	public ushort UInt16_1 { get; set; }

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x06000795 RID: 1941 RVA: 0x000671C8 File Offset: 0x000653C8
	// (set) Token: 0x06000796 RID: 1942 RVA: 0x000671DC File Offset: 0x000653DC
	public ushort UInt16_2 { get; set; }

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x06000797 RID: 1943 RVA: 0x000671F0 File Offset: 0x000653F0
	// (set) Token: 0x06000798 RID: 1944 RVA: 0x00067204 File Offset: 0x00065404
	public string String_6 { get; set; }

	// Token: 0x06000799 RID: 1945 RVA: 0x00067218 File Offset: 0x00065418
	public Class56()
	{
		this.String_0 = string.Empty;
		this.String_1 = string.Empty;
		this.UInt32_0 = 0U;
		this.UInt16_0 = 2;
		this.String_2 = string.Empty;
		this.String_3 = string.Empty;
		this.String_4 = string.Empty;
		this.String_5 = string.Empty;
		this.UInt16_1 = 2;
		this.UInt16_2 = 2;
		this.String_6 = string.Empty;
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00067294 File Offset: 0x00065494
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}", new object[]
		{
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			this.UInt32_0,
			Class15.char_2,
			this.UInt16_0,
			Class15.char_2,
			Class15.smethod_22(this.String_2),
			Class15.char_2,
			Class15.smethod_22(this.String_3),
			Class15.char_2,
			Class15.smethod_22(this.String_4),
			Class15.char_2,
			Class15.smethod_22(this.String_5),
			Class15.char_2,
			this.UInt16_1,
			Class15.char_2,
			this.UInt16_2,
			Class15.char_2,
			Class15.smethod_22(this.String_6)
		});
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x000673DC File Offset: 0x000655DC
	public static string smethod_0()
	{
		List<Class56> list = new List<Class56>();
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(Class14.String_14, Class14.String_89).Get().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					Class56 @class = new Class56();
					try
					{
						@class.String_0 = managementObject.GetPropertyValue(Class14.String_7).ToString().Trim();
					}
					catch
					{
						@class.String_0 = string.Empty;
					}
					try
					{
						IL_71:
						@class.String_1 = managementObject.GetPropertyValue(Class14.String_177).ToString().Trim();
					}
					catch
					{
						@class.String_1 = string.Empty;
					}
					try
					{
						@class.UInt32_0 = Convert.ToUInt32(managementObject.GetPropertyValue(Class14.String_35).ToString());
					}
					catch
					{
						@class.UInt32_0 = 0U;
					}
					try
					{
						@class.UInt16_0 = Convert.ToUInt16(managementObject.GetPropertyValue(Class14.String_119).ToString());
					}
					catch
					{
						@class.UInt16_0 = 2;
					}
					try
					{
						@class.String_2 = managementObject.GetPropertyValue(Class14.String_234).ToString().Trim();
					}
					catch
					{
						@class.String_2 = string.Empty;
					}
					try
					{
						@class.String_3 = managementObject.GetPropertyValue(Class14.String_226).ToString().Trim();
					}
					catch
					{
						@class.String_3 = string.Empty;
					}
					try
					{
						@class.String_4 = managementObject.GetPropertyValue(Class14.String_100).ToString().Trim();
					}
					catch
					{
						@class.String_4 = string.Empty;
					}
					try
					{
						@class.String_5 = managementObject.GetPropertyValue(Class14.String_191).ToString().Trim();
					}
					catch
					{
						@class.String_5 = string.Empty;
					}
					try
					{
						@class.UInt16_1 = Convert.ToUInt16(managementObject.GetPropertyValue(Class14.String_93).ToString());
					}
					catch
					{
						@class.UInt16_1 = 2;
					}
					try
					{
						@class.UInt16_2 = Convert.ToUInt16(managementObject.GetPropertyValue(Class14.String_160).ToString());
					}
					catch
					{
						@class.UInt16_2 = 2;
					}
					try
					{
						@class.String_6 = managementObject.GetPropertyValue(Class14.String_50).ToString().Trim();
					}
					catch
					{
						@class.String_6 = string.Empty;
					}
					if (!(@class.String_6 == string.Empty) || !(@class.String_3 == string.Empty) || !(@class.String_2 == string.Empty) || @class.UInt32_0 != 0U)
					{
						list.Add(@class);
						continue;
					}
					continue;
					//goto IL_71;
				}
			}
		}
		catch
		{
		}
		if (list.Count == 0)
		{
			Class56 @class = new Class56();
			list.Add(@class);
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < list.Count; i++)
		{
			stringBuilder.Append(list[i]);
			if (i + 1 != list.Count)
			{
				stringBuilder.Append(Class15.char_1);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x04000A1E RID: 2590
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000A1F RID: 2591
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04000A20 RID: 2592
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000A21 RID: 2593
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x04000A22 RID: 2594
	[CompilerGenerated]
	private string string_2;

	// Token: 0x04000A23 RID: 2595
	[CompilerGenerated]
	private string string_3;

	// Token: 0x04000A24 RID: 2596
	[CompilerGenerated]
	private string string_4;

	// Token: 0x04000A25 RID: 2597
	[CompilerGenerated]
	private string string_5;

	// Token: 0x04000A26 RID: 2598
	[CompilerGenerated]
	private ushort ushort_1;

	// Token: 0x04000A27 RID: 2599
	[CompilerGenerated]
	private ushort ushort_2;

	// Token: 0x04000A28 RID: 2600
	[CompilerGenerated]
	private string string_6;
}
