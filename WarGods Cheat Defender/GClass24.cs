using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200004B RID: 75
public class GClass24
{
	// Token: 0x06000218 RID: 536 RVA: 0x00049708 File Offset: 0x00047908
	public GClass24(byte[] byte_0, int int_1 = 0)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_1);
		this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_1 + 4);
		this.UInt16_0 = BitConverter.ToUInt16(byte_0, int_1 + 8);
		this.UInt16_1 = BitConverter.ToUInt16(byte_0, int_1 + 10);
		this.UInt32_2 = BitConverter.ToUInt32(byte_0, int_1 + 12);
		this.UInt32_3 = BitConverter.ToUInt32(byte_0, int_1 + 16);
		this.UInt32_4 = BitConverter.ToUInt32(byte_0, int_1 + 20);
		this.UInt32_5 = BitConverter.ToUInt32(byte_0, int_1 + 24);
		this.UInt32_6 = BitConverter.ToUInt32(byte_0, int_1 + 28);
		this.UInt32_7 = BitConverter.ToUInt32(byte_0, int_1 + 32);
		this.UInt32_8 = BitConverter.ToUInt32(byte_0, int_1 + 36);
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000219 RID: 537 RVA: 0x000497C8 File Offset: 0x000479C8
	// (set) Token: 0x0600021A RID: 538 RVA: 0x000497DC File Offset: 0x000479DC
	public uint UInt32_0 { get; set; }

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x0600021B RID: 539 RVA: 0x000497F0 File Offset: 0x000479F0
	// (set) Token: 0x0600021C RID: 540 RVA: 0x00049804 File Offset: 0x00047A04
	public uint UInt32_1 { get; set; }

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x0600021D RID: 541 RVA: 0x00049818 File Offset: 0x00047A18
	// (set) Token: 0x0600021E RID: 542 RVA: 0x0004982C File Offset: 0x00047A2C
	public ushort UInt16_0 { get; set; }

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x0600021F RID: 543 RVA: 0x00049840 File Offset: 0x00047A40
	// (set) Token: 0x06000220 RID: 544 RVA: 0x00049854 File Offset: 0x00047A54
	public ushort UInt16_1 { get; set; }

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000221 RID: 545 RVA: 0x00049868 File Offset: 0x00047A68
	// (set) Token: 0x06000222 RID: 546 RVA: 0x0004987C File Offset: 0x00047A7C
	public uint UInt32_2 { get; set; }

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000223 RID: 547 RVA: 0x00049890 File Offset: 0x00047A90
	// (set) Token: 0x06000224 RID: 548 RVA: 0x000498A4 File Offset: 0x00047AA4
	public uint UInt32_3 { get; set; }

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000225 RID: 549 RVA: 0x000498B8 File Offset: 0x00047AB8
	// (set) Token: 0x06000226 RID: 550 RVA: 0x000498CC File Offset: 0x00047ACC
	public uint UInt32_4 { get; set; }

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06000227 RID: 551 RVA: 0x000498E0 File Offset: 0x00047AE0
	// (set) Token: 0x06000228 RID: 552 RVA: 0x000498F4 File Offset: 0x00047AF4
	public uint UInt32_5 { get; set; }

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000229 RID: 553 RVA: 0x00049908 File Offset: 0x00047B08
	// (set) Token: 0x0600022A RID: 554 RVA: 0x0004991C File Offset: 0x00047B1C
	public uint UInt32_6 { get; set; }

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x0600022B RID: 555 RVA: 0x00049930 File Offset: 0x00047B30
	// (set) Token: 0x0600022C RID: 556 RVA: 0x00049944 File Offset: 0x00047B44
	public uint UInt32_7 { get; set; }

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x0600022D RID: 557 RVA: 0x00049958 File Offset: 0x00047B58
	// (set) Token: 0x0600022E RID: 558 RVA: 0x0004996C File Offset: 0x00047B6C
	public uint UInt32_8 { get; set; }

	// Token: 0x0600022F RID: 559 RVA: 0x00049980 File Offset: 0x00047B80
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_EXPORT_DIRECTORY\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-15}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x0400022E RID: 558
	[NonSerialized]
	public static readonly int int_0 = 40;

	// Token: 0x0400022F RID: 559
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000230 RID: 560
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x04000231 RID: 561
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x04000232 RID: 562
	[CompilerGenerated]
	private ushort ushort_1;

	// Token: 0x04000233 RID: 563
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x04000234 RID: 564
	[CompilerGenerated]
	private uint uint_3;

	// Token: 0x04000235 RID: 565
	[CompilerGenerated]
	private uint uint_4;

	// Token: 0x04000236 RID: 566
	[CompilerGenerated]
	private uint uint_5;

	// Token: 0x04000237 RID: 567
	[CompilerGenerated]
	private uint uint_6;

	// Token: 0x04000238 RID: 568
	[CompilerGenerated]
	private uint uint_7;

	// Token: 0x04000239 RID: 569
	[CompilerGenerated]
	private uint uint_8;
}
