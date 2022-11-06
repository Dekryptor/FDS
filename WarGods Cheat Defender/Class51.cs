using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020000E4 RID: 228
internal class Class51
{
	// Token: 0x1700031D RID: 797
	// (get) Token: 0x0600074A RID: 1866 RVA: 0x00065F04 File Offset: 0x00064104
	// (set) Token: 0x0600074B RID: 1867 RVA: 0x00065F18 File Offset: 0x00064118
	public ulong UInt64_0 { get; set; }

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x0600074C RID: 1868 RVA: 0x00065F2C File Offset: 0x0006412C
	// (set) Token: 0x0600074D RID: 1869 RVA: 0x00065F40 File Offset: 0x00064140
	public string String_0 { get; set; }

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x0600074E RID: 1870 RVA: 0x00065F54 File Offset: 0x00064154
	// (set) Token: 0x0600074F RID: 1871 RVA: 0x00065F68 File Offset: 0x00064168
	public string String_1 { get; set; }

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x06000750 RID: 1872 RVA: 0x00065F7C File Offset: 0x0006417C
	// (set) Token: 0x06000751 RID: 1873 RVA: 0x00065F90 File Offset: 0x00064190
	public uint UInt32_0 { get; set; }

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x06000752 RID: 1874 RVA: 0x00065FA4 File Offset: 0x000641A4
	// (set) Token: 0x06000753 RID: 1875 RVA: 0x00065FB8 File Offset: 0x000641B8
	public string String_2 { get; set; }

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x06000754 RID: 1876 RVA: 0x00065FCC File Offset: 0x000641CC
	// (set) Token: 0x06000755 RID: 1877 RVA: 0x00065FE0 File Offset: 0x000641E0
	public string String_3 { get; set; }

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06000756 RID: 1878 RVA: 0x00065FF4 File Offset: 0x000641F4
	// (set) Token: 0x06000757 RID: 1879 RVA: 0x00066008 File Offset: 0x00064208
	public ushort UInt16_0 { get; set; }

	// Token: 0x06000758 RID: 1880 RVA: 0x0006601C File Offset: 0x0006421C
	public Class51()
	{
		this.UInt64_0 = 0UL;
		this.String_0 = string.Empty;
		this.String_1 = string.Empty;
		this.UInt32_0 = 0U;
		this.String_2 = string.Empty;
		this.String_3 = string.Empty;
		this.UInt16_0 = 0;
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00066078 File Offset: 0x00064278
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}", new object[]
		{
			this.UInt64_0,
			Class15.char_2,
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			this.UInt32_0,
			Class15.char_2,
			Class15.smethod_22(this.String_2),
			Class15.char_2,
			Class15.smethod_22(this.String_3),
			Class15.char_2,
			this.UInt16_0
		});
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x0006614C File Offset: 0x0006434C
	public static string smethod_0()
	{
		List<Class51> list = new List<Class51>();
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(Class14.String_14, Class14.String_115).Get().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					Class51 @class = new Class51();
					try
					{
						@class.UInt64_0 = Convert.ToUInt64(managementObject.GetPropertyValue(Class14.String_234).ToString());
					}
					catch
					{
						@class.UInt64_0 = 0UL;
					}
					try
					{
						IL_75:
						@class.String_0 = managementObject.GetPropertyValue(Class14.String_84).ToString().Trim();
					}
					catch
					{
						@class.String_0 = string.Empty;
					}
					try
					{
						@class.String_1 = managementObject.GetPropertyValue(Class14.String_179).ToString().Trim();
					}
					catch
					{
						@class.String_1 = string.Empty;
					}
					try
					{
						@class.UInt32_0 = Convert.ToUInt32(managementObject.GetPropertyValue(Class14.String_154).ToString());
					}
					catch
					{
						@class.UInt32_0 = 0U;
					}
					try
					{
						@class.String_2 = managementObject.GetPropertyValue(Class14.String_111).ToString().Trim();
					}
					catch
					{
						@class.String_2 = string.Empty;
					}
					try
					{
						@class.String_3 = managementObject.GetPropertyValue(Class14.String_32).ToString().Trim();
					}
					catch
					{
						@class.String_3 = string.Empty;
					}
					try
					{
						@class.UInt16_0 = Convert.ToUInt16(managementObject.GetPropertyValue(Class14.String_91).ToString());
					}
					catch
					{
						@class.UInt16_0 = 0;
					}
					if (!(@class.String_1 == string.Empty) || !(@class.String_0 == string.Empty) || !(@class.String_3 == string.Empty) || @class.UInt64_0 != 0UL)
					{
						list.Add(@class);
						continue;
					}
					continue;
					//goto IL_75;
				}
			}
		}
		catch
		{
		}
		if (list.Count == 0)
		{
			try
			{
				GClass45.GClass46 gclass = new GClass45.GClass46();
				if (GClass45.GlobalMemoryStatusEx(gclass))
				{
					Class51 @class = new Class51();
					@class.UInt64_0 = gclass.ulong_0;
					list.Add(@class);
				}
			}
			catch
			{
			}
		}
		if (list.Count == 0)
		{
			Class51 @class = new Class51();
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

	// Token: 0x040009E3 RID: 2531
	[CompilerGenerated]
	private ulong ulong_0;

	// Token: 0x040009E4 RID: 2532
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009E5 RID: 2533
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009E6 RID: 2534
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x040009E7 RID: 2535
	[CompilerGenerated]
	private string string_2;

	// Token: 0x040009E8 RID: 2536
	[CompilerGenerated]
	private string string_3;

	// Token: 0x040009E9 RID: 2537
	[CompilerGenerated]
	private ushort ushort_0;
}
