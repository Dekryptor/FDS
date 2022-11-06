using System;
using System.Runtime.CompilerServices;

// Token: 0x0200006C RID: 108
public class GClass41
{
	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000368 RID: 872 RVA: 0x0004D634 File Offset: 0x0004B834
	// (set) Token: 0x06000369 RID: 873 RVA: 0x0004D648 File Offset: 0x0004B848
	public GEnum21 GEnum21_0 { get; set; }

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x0600036A RID: 874 RVA: 0x0004D65C File Offset: 0x0004B85C
	// (set) Token: 0x0600036B RID: 875 RVA: 0x0004D670 File Offset: 0x0004B870
	public int Int32_0 { get; set; }

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x0600036C RID: 876 RVA: 0x0004D684 File Offset: 0x0004B884
	// (set) Token: 0x0600036D RID: 877 RVA: 0x0004D698 File Offset: 0x0004B898
	public string String_0 { get; set; }

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x0600036E RID: 878 RVA: 0x0004D6AC File Offset: 0x0004B8AC
	// (set) Token: 0x0600036F RID: 879 RVA: 0x0004D6C0 File Offset: 0x0004B8C0
	public long Int64_0 { get; set; }

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000370 RID: 880 RVA: 0x0004D6D4 File Offset: 0x0004B8D4
	// (set) Token: 0x06000371 RID: 881 RVA: 0x0004D6E8 File Offset: 0x0004B8E8
	public GEnum23 GEnum23_0 { get; set; }

	// Token: 0x06000372 RID: 882 RVA: 0x0004D6FC File Offset: 0x0004B8FC
	public GClass41()
	{
		this.GEnum21_0 = GEnum21.const_0;
		this.GEnum23_0 = GEnum23.const_0;
		this.Int32_0 = -1;
		this.String_0 = string.Empty;
	}

	// Token: 0x06000373 RID: 883 RVA: 0x0004D730 File Offset: 0x0004B930
	public virtual string ToString()
	{
		return string.Format("{0}|{1}|{2}|{3}|{4}", new object[]
		{
			(int)this.GEnum21_0,
			(int)this.GEnum23_0,
			this.Int32_0,
			Class15.smethod_22(this.String_0),
			this.Int64_0
		});
	}

	// Token: 0x04000318 RID: 792
	[CompilerGenerated]
	private GEnum21 genum21_0;

	// Token: 0x04000319 RID: 793
	[CompilerGenerated]
	private int int_0;

	// Token: 0x0400031A RID: 794
	[CompilerGenerated]
	private string string_0;

	// Token: 0x0400031B RID: 795
	[CompilerGenerated]
	private long long_0;

	// Token: 0x0400031C RID: 796
	[CompilerGenerated]
	private GEnum23 genum23_0;
}
