using System;
using System.Runtime.CompilerServices;

// Token: 0x02000013 RID: 19
public class GClass1
{
	// Token: 0x06000069 RID: 105 RVA: 0x0003F868 File Offset: 0x0003DA68
	public GClass1(byte[] byte_0, bool bool_0)
	{
		if (bool_0)
		{
			this.Int32_0 = BitConverter.ToInt32(byte_0, 0);
			this.Int32_1 = BitConverter.ToInt32(byte_0, 4);
			this.Int32_2 = BitConverter.ToInt32(byte_0, 8);
			this.Int32_3 = BitConverter.ToInt32(byte_0, 12);
			this.Int32_4 = BitConverter.ToInt32(byte_0, 16);
			return;
		}
		this.Int32_0 = BitConverter.ToInt32(byte_0, 0);
		this.Int32_1 = BitConverter.ToInt32(byte_0, 4);
		this.Int32_4 = BitConverter.ToInt32(byte_0, 8);
		this.Int32_2 = BitConverter.ToInt32(byte_0, 12);
		this.Int32_3 = BitConverter.ToInt32(byte_0, 16);
		this.Int32_5 = BitConverter.ToInt32(byte_0, 20);
		this.GClass3_0 = new GClass3(GClass5.smethod_0(byte_0, 24, 8));
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600006A RID: 106 RVA: 0x0003F928 File Offset: 0x0003DB28
	public int Int32_0 { get; }

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600006B RID: 107 RVA: 0x0003F93C File Offset: 0x0003DB3C
	public int Int32_1 { get; }

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600006C RID: 108 RVA: 0x0003F950 File Offset: 0x0003DB50
	public int Int32_2 { get; }

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600006D RID: 109 RVA: 0x0003F964 File Offset: 0x0003DB64
	public int Int32_3 { get; }

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600006E RID: 110 RVA: 0x0003F978 File Offset: 0x0003DB78
	public int Int32_4 { get; }

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600006F RID: 111 RVA: 0x0003F98C File Offset: 0x0003DB8C
	public int Int32_5 { get; }

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000070 RID: 112 RVA: 0x0003F9A0 File Offset: 0x0003DBA0
	public GClass3 GClass3_0 { get; }

	// Token: 0x06000071 RID: 113 RVA: 0x0003F9B4 File Offset: 0x0003DBB4
	public virtual string ToString()
	{
		return string.Format("Filename offset: {0}, Size: {1}, MFT: {2}", this.Int32_2, this.Int32_3, this.GClass3_0);
	}

	// Token: 0x04000049 RID: 73
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x0400004A RID: 74
	[CompilerGenerated]
	private readonly int int_1;

	// Token: 0x0400004B RID: 75
	[CompilerGenerated]
	private readonly int int_2;

	// Token: 0x0400004C RID: 76
	[CompilerGenerated]
	private readonly int int_3;

	// Token: 0x0400004D RID: 77
	[CompilerGenerated]
	private readonly int int_4;

	// Token: 0x0400004E RID: 78
	[CompilerGenerated]
	private readonly int int_5;

	// Token: 0x0400004F RID: 79
	[CompilerGenerated]
	private readonly GClass3 gclass3_0;
}
