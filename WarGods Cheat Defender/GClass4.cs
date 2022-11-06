using System;
using System.Runtime.CompilerServices;

// Token: 0x02000016 RID: 22
public class GClass4
{
	// Token: 0x06000080 RID: 128 RVA: 0x0003FC84 File Offset: 0x0003DE84
	public GClass4(byte[] byte_2, bool bool_0)
	{
		if (bool_0)
		{
			this.Int32_1 = BitConverter.ToInt32(byte_2, 0);
			this.Byte_0 = byte_2[4];
			this.Byte_1 = byte_2[5];
			this.Int16_0 = BitConverter.ToInt16(byte_2, 6);
			return;
		}
		this.Int32_0 = BitConverter.ToInt32(byte_2, 0);
		this.Int32_1 = BitConverter.ToInt32(byte_2, 4);
		this.Byte_0 = byte_2[8];
		this.Byte_1 = byte_2[9];
		this.Int16_0 = BitConverter.ToInt16(byte_2, 10);
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000081 RID: 129 RVA: 0x0003FD04 File Offset: 0x0003DF04
	public int Int32_0 { get; }

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000082 RID: 130 RVA: 0x0003FD18 File Offset: 0x0003DF18
	public int Int32_1 { get; }

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000083 RID: 131 RVA: 0x0003FD2C File Offset: 0x0003DF2C
	public byte Byte_0 { get; }

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000084 RID: 132 RVA: 0x0003FD40 File Offset: 0x0003DF40
	public byte Byte_1 { get; }

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000085 RID: 133 RVA: 0x0003FD54 File Offset: 0x0003DF54
	public short Int16_0 { get; }

	// Token: 0x06000086 RID: 134 RVA: 0x0003FD68 File Offset: 0x0003DF68
	public virtual string ToString()
	{
		return string.Format("Next index: {0}, Total block load count: {1}", this.Int32_0, this.Int32_1);
	}

	// Token: 0x04000057 RID: 87
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x04000058 RID: 88
	[CompilerGenerated]
	private readonly int int_1;

	// Token: 0x04000059 RID: 89
	[CompilerGenerated]
	private readonly byte byte_0;

	// Token: 0x0400005A RID: 90
	[CompilerGenerated]
	private readonly byte byte_1;

	// Token: 0x0400005B RID: 91
	[CompilerGenerated]
	private readonly short short_0;
}
