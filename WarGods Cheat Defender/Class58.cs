using System;
using System.Runtime.CompilerServices;

// Token: 0x020000F7 RID: 247
internal class Class58
{
	// Token: 0x17000347 RID: 839
	// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00067FE8 File Offset: 0x000661E8
	// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00067FFC File Offset: 0x000661FC
	public string String_0 { get; private set; }

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00068010 File Offset: 0x00066210
	// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00068024 File Offset: 0x00066224
	public long Int64_0 { get; private set; }

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00068038 File Offset: 0x00066238
	// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0006804C File Offset: 0x0006624C
	public DateTime? Nullable_0 { get; private set; }

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x060007CA RID: 1994 RVA: 0x00068060 File Offset: 0x00066260
	// (set) Token: 0x060007CB RID: 1995 RVA: 0x00068074 File Offset: 0x00066274
	public GEnum58 GEnum58_0 { get; private set; }

	// Token: 0x060007CC RID: 1996 RVA: 0x00068088 File Offset: 0x00066288
	public Class58(string string_1, long long_1, GEnum58 genum58_1)
	{
		this.String_0 = string_1;
		this.Int64_0 = long_1;
		try
		{
			this.Nullable_0 = new DateTime?(DateTime.FromFileTimeUtc(long_1));
		}
		catch (ArgumentOutOfRangeException)
		{
			this.Nullable_0 = null;
		}
		this.GEnum58_0 = genum58_1;
	}

	// Token: 0x04000B2E RID: 2862
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000B2F RID: 2863
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04000B30 RID: 2864
	[CompilerGenerated]
	private DateTime? nullable_0;

	// Token: 0x04000B31 RID: 2865
	[CompilerGenerated]
	private GEnum58 genum58_0;
}
