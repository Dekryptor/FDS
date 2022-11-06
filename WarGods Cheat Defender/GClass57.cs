using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D4 RID: 212
public class GClass57
{
	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00063DB0 File Offset: 0x00061FB0
	// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00063DC4 File Offset: 0x00061FC4
	public uint UInt32_0 { get; set; }

	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00063DD8 File Offset: 0x00061FD8
	// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00063DEC File Offset: 0x00061FEC
	public uint UInt32_1 { get; set; }

	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00063E00 File Offset: 0x00062000
	// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00063E14 File Offset: 0x00062014
	public string String_0 { get; set; }

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00063E28 File Offset: 0x00062028
	// (set) Token: 0x060006BA RID: 1722 RVA: 0x00063E3C File Offset: 0x0006203C
	public string String_1 { get; set; }

	// Token: 0x060006BB RID: 1723 RVA: 0x00063E50 File Offset: 0x00062050
	public GClass57(string string_2, string string_3, uint uint_2, uint uint_3)
	{
		this.String_0 = string_2;
		this.String_1 = string_3;
		this.UInt32_0 = uint_2;
		this.UInt32_1 = uint_3;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00063E80 File Offset: 0x00062080
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}{5}{6}", new object[]
		{
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			Class15.smethod_22(this.String_1),
			Class15.char_2,
			this.UInt32_0,
			Class15.char_2,
			this.UInt32_1
		});
	}

	// Token: 0x0400099E RID: 2462
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x0400099F RID: 2463
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x040009A0 RID: 2464
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009A1 RID: 2465
	[CompilerGenerated]
	private string string_1;
}
