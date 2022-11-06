using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200004C RID: 76
public class GClass25
{
	// Token: 0x06000231 RID: 561 RVA: 0x000499C4 File Offset: 0x00047BC4
	public GClass25(byte[] byte_0, int int_0)
	{
		this.UInt16_0 = BitConverter.ToUInt16(byte_0, int_0);
		this.UInt16_1 = BitConverter.ToUInt16(byte_0, int_0 + 2);
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_0 + 4);
		this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_0 + 8);
		this.UInt32_2 = BitConverter.ToUInt32(byte_0, int_0 + 12);
		this.UInt16_2 = BitConverter.ToUInt16(byte_0, int_0 + 16);
		this.UInt16_3 = BitConverter.ToUInt16(byte_0, int_0 + 18);
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06000232 RID: 562 RVA: 0x00049A44 File Offset: 0x00047C44
	// (set) Token: 0x06000233 RID: 563 RVA: 0x00049A58 File Offset: 0x00047C58
	public ushort UInt16_0 { get; set; }

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000234 RID: 564 RVA: 0x00049A6C File Offset: 0x00047C6C
	// (set) Token: 0x06000235 RID: 565 RVA: 0x00049A80 File Offset: 0x00047C80
	public ushort UInt16_1 { get; set; }

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000236 RID: 566 RVA: 0x00049A94 File Offset: 0x00047C94
	// (set) Token: 0x06000237 RID: 567 RVA: 0x00049AA8 File Offset: 0x00047CA8
	public uint UInt32_0 { get; set; }

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000238 RID: 568 RVA: 0x00049ABC File Offset: 0x00047CBC
	// (set) Token: 0x06000239 RID: 569 RVA: 0x00049AD0 File Offset: 0x00047CD0
	public uint UInt32_1 { get; set; }

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x0600023A RID: 570 RVA: 0x00049AE4 File Offset: 0x00047CE4
	// (set) Token: 0x0600023B RID: 571 RVA: 0x00049AF8 File Offset: 0x00047CF8
	public uint UInt32_2 { get; set; }

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x0600023C RID: 572 RVA: 0x00049B0C File Offset: 0x00047D0C
	// (set) Token: 0x0600023D RID: 573 RVA: 0x00049B20 File Offset: 0x00047D20
	public ushort UInt16_2 { get; set; }

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x0600023E RID: 574 RVA: 0x00049B34 File Offset: 0x00047D34
	// (set) Token: 0x0600023F RID: 575 RVA: 0x00049B48 File Offset: 0x00047D48
	public ushort UInt16_3 { get; set; }

	// Token: 0x06000240 RID: 576 RVA: 0x00049B5C File Offset: 0x00047D5C
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_FILE_HEADER\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-15}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x0400023A RID: 570
	[NonSerialized]
	public static readonly uint uint_0 = 20U;

	// Token: 0x0400023B RID: 571
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x0400023C RID: 572
	[CompilerGenerated]
	private ushort ushort_1;

	// Token: 0x0400023D RID: 573
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x0400023E RID: 574
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x0400023F RID: 575
	[CompilerGenerated]
	private uint uint_3;

	// Token: 0x04000240 RID: 576
	[CompilerGenerated]
	private ushort ushort_2;

	// Token: 0x04000241 RID: 577
	[CompilerGenerated]
	private ushort ushort_3;
}
