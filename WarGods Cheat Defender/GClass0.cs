using System;
using System.Runtime.CompilerServices;

// Token: 0x0200000F RID: 15
public class GClass0
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000041 RID: 65 RVA: 0x0003F5E0 File Offset: 0x0003D7E0
	// (set) Token: 0x06000042 RID: 66 RVA: 0x0003F5F4 File Offset: 0x0003D7F4
	public GEnum0 GEnum0_0 { get; set; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000043 RID: 67 RVA: 0x0003F608 File Offset: 0x0003D808
	// (set) Token: 0x06000044 RID: 68 RVA: 0x0003F61C File Offset: 0x0003D81C
	public string String_0 { get; set; }

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000045 RID: 69 RVA: 0x0003F630 File Offset: 0x0003D830
	// (set) Token: 0x06000046 RID: 70 RVA: 0x0003F644 File Offset: 0x0003D844
	public string String_1 { get; set; }

	// Token: 0x06000047 RID: 71 RVA: 0x0003F658 File Offset: 0x0003D858
	public GClass0()
	{
		this.GEnum0_0 = GEnum0.const_0;
		this.String_1 = "";
		this.String_0 = "";
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0003F688 File Offset: 0x0003D888
	public string method_0(string string_2 = "!")
	{
		return string.Format("{0}{1}{2}{3}{4}", new object[]
		{
			(int)this.GEnum0_0,
			string_2,
			(this.String_0 != null) ? Class15.smethod_22(this.String_0) : string.Empty,
			string_2,
			(this.String_1 != null) ? Class15.smethod_22(this.String_1) : string.Empty
		});
	}

	// Token: 0x04000040 RID: 64
	[CompilerGenerated]
	private GEnum0 genum0_0;

	// Token: 0x04000041 RID: 65
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000042 RID: 66
	[CompilerGenerated]
	private string string_1;
}
