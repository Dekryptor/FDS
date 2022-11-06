using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200004A RID: 74
public class GClass23
{
	// Token: 0x060001EF RID: 495 RVA: 0x0004921C File Offset: 0x0004741C
	public GClass23(byte[] byte_0)
	{
		this.UInt16_0 = BitConverter.ToUInt16(byte_0, 0);
		this.UInt16_1 = BitConverter.ToUInt16(byte_0, 2);
		this.UInt16_2 = BitConverter.ToUInt16(byte_0, 4);
		this.UInt16_3 = BitConverter.ToUInt16(byte_0, 6);
		this.UInt16_4 = BitConverter.ToUInt16(byte_0, 8);
		this.UInt16_5 = BitConverter.ToUInt16(byte_0, 10);
		this.UInt16_6 = BitConverter.ToUInt16(byte_0, 12);
		this.UInt16_7 = BitConverter.ToUInt16(byte_0, 14);
		this.UInt16_8 = BitConverter.ToUInt16(byte_0, 16);
		this.UInt16_9 = BitConverter.ToUInt16(byte_0, 18);
		this.UInt16_10 = BitConverter.ToUInt16(byte_0, 20);
		this.UInt16_11 = BitConverter.ToUInt16(byte_0, 22);
		this.UInt16_12 = BitConverter.ToUInt16(byte_0, 24);
		this.UInt16_13 = BitConverter.ToUInt16(byte_0, 26);
		this.UInt16_14 = new ushort[]
		{
			BitConverter.ToUInt16(byte_0, 28),
			BitConverter.ToUInt16(byte_0, 30),
			BitConverter.ToUInt16(byte_0, 32),
			BitConverter.ToUInt16(byte_0, 34)
		};
		this.UInt16_15 = BitConverter.ToUInt16(byte_0, 36);
		this.UInt16_16 = BitConverter.ToUInt16(byte_0, 38);
		this.UInt16_17 = new ushort[]
		{
			BitConverter.ToUInt16(byte_0, 40),
			BitConverter.ToUInt16(byte_0, 42),
			BitConverter.ToUInt16(byte_0, 44),
			BitConverter.ToUInt16(byte_0, 46),
			BitConverter.ToUInt16(byte_0, 48),
			BitConverter.ToUInt16(byte_0, 50),
			BitConverter.ToUInt16(byte_0, 52),
			BitConverter.ToUInt16(byte_0, 54),
			BitConverter.ToUInt16(byte_0, 56),
			BitConverter.ToUInt16(byte_0, 58)
		};
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, 60);
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x060001F0 RID: 496 RVA: 0x000493CC File Offset: 0x000475CC
	// (set) Token: 0x060001F1 RID: 497 RVA: 0x000493E0 File Offset: 0x000475E0
	public ushort UInt16_0 { get; set; }

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x060001F2 RID: 498 RVA: 0x000493F4 File Offset: 0x000475F4
	// (set) Token: 0x060001F3 RID: 499 RVA: 0x00049408 File Offset: 0x00047608
	public ushort UInt16_1 { get; set; }

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x060001F4 RID: 500 RVA: 0x0004941C File Offset: 0x0004761C
	// (set) Token: 0x060001F5 RID: 501 RVA: 0x00049430 File Offset: 0x00047630
	public ushort UInt16_2 { get; set; }

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060001F6 RID: 502 RVA: 0x00049444 File Offset: 0x00047644
	// (set) Token: 0x060001F7 RID: 503 RVA: 0x00049458 File Offset: 0x00047658
	public ushort UInt16_3 { get; set; }

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x0004946C File Offset: 0x0004766C
	// (set) Token: 0x060001F9 RID: 505 RVA: 0x00049480 File Offset: 0x00047680
	public ushort UInt16_4 { get; set; }

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060001FA RID: 506 RVA: 0x00049494 File Offset: 0x00047694
	// (set) Token: 0x060001FB RID: 507 RVA: 0x000494A8 File Offset: 0x000476A8
	public ushort UInt16_5 { get; set; }

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060001FC RID: 508 RVA: 0x000494BC File Offset: 0x000476BC
	// (set) Token: 0x060001FD RID: 509 RVA: 0x000494D0 File Offset: 0x000476D0
	public ushort UInt16_6 { get; set; }

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060001FE RID: 510 RVA: 0x000494E4 File Offset: 0x000476E4
	// (set) Token: 0x060001FF RID: 511 RVA: 0x000494F8 File Offset: 0x000476F8
	public ushort UInt16_7 { get; set; }

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000200 RID: 512 RVA: 0x0004950C File Offset: 0x0004770C
	// (set) Token: 0x06000201 RID: 513 RVA: 0x00049520 File Offset: 0x00047720
	public ushort UInt16_8 { get; set; }

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000202 RID: 514 RVA: 0x00049534 File Offset: 0x00047734
	// (set) Token: 0x06000203 RID: 515 RVA: 0x00049548 File Offset: 0x00047748
	public ushort UInt16_9 { get; set; }

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06000204 RID: 516 RVA: 0x0004955C File Offset: 0x0004775C
	// (set) Token: 0x06000205 RID: 517 RVA: 0x00049570 File Offset: 0x00047770
	public ushort UInt16_10 { get; set; }

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x06000206 RID: 518 RVA: 0x00049584 File Offset: 0x00047784
	// (set) Token: 0x06000207 RID: 519 RVA: 0x00049598 File Offset: 0x00047798
	public ushort UInt16_11 { get; set; }

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06000208 RID: 520 RVA: 0x000495AC File Offset: 0x000477AC
	// (set) Token: 0x06000209 RID: 521 RVA: 0x000495C0 File Offset: 0x000477C0
	public ushort UInt16_12 { get; set; }

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x0600020A RID: 522 RVA: 0x000495D4 File Offset: 0x000477D4
	// (set) Token: 0x0600020B RID: 523 RVA: 0x000495E8 File Offset: 0x000477E8
	public ushort UInt16_13 { get; set; }

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x0600020C RID: 524 RVA: 0x000495FC File Offset: 0x000477FC
	// (set) Token: 0x0600020D RID: 525 RVA: 0x00049610 File Offset: 0x00047810
	public ushort[] UInt16_14 { get; set; }

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x0600020E RID: 526 RVA: 0x00049624 File Offset: 0x00047824
	// (set) Token: 0x0600020F RID: 527 RVA: 0x00049638 File Offset: 0x00047838
	public ushort UInt16_15 { get; set; }

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000210 RID: 528 RVA: 0x0004964C File Offset: 0x0004784C
	// (set) Token: 0x06000211 RID: 529 RVA: 0x00049660 File Offset: 0x00047860
	public ushort UInt16_16 { get; set; }

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000212 RID: 530 RVA: 0x00049674 File Offset: 0x00047874
	// (set) Token: 0x06000213 RID: 531 RVA: 0x00049688 File Offset: 0x00047888
	public ushort[] UInt16_17 { get; set; }

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000214 RID: 532 RVA: 0x0004969C File Offset: 0x0004789C
	// (set) Token: 0x06000215 RID: 533 RVA: 0x000496B0 File Offset: 0x000478B0
	public uint UInt32_0 { get; set; }

	// Token: 0x06000216 RID: 534 RVA: 0x000496C4 File Offset: 0x000478C4
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_DOS_HEADER\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-10}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x0400021A RID: 538
	public static readonly int int_0 = 64;

	// Token: 0x0400021B RID: 539
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x0400021C RID: 540
	[CompilerGenerated]
	private ushort ushort_1;

	// Token: 0x0400021D RID: 541
	[CompilerGenerated]
	private ushort ushort_2;

	// Token: 0x0400021E RID: 542
	[CompilerGenerated]
	private ushort ushort_3;

	// Token: 0x0400021F RID: 543
	[CompilerGenerated]
	private ushort ushort_4;

	// Token: 0x04000220 RID: 544
	[CompilerGenerated]
	private ushort ushort_5;

	// Token: 0x04000221 RID: 545
	[CompilerGenerated]
	private ushort ushort_6;

	// Token: 0x04000222 RID: 546
	[CompilerGenerated]
	private ushort ushort_7;

	// Token: 0x04000223 RID: 547
	[CompilerGenerated]
	private ushort ushort_8;

	// Token: 0x04000224 RID: 548
	[CompilerGenerated]
	private ushort ushort_9;

	// Token: 0x04000225 RID: 549
	[CompilerGenerated]
	private ushort ushort_10;

	// Token: 0x04000226 RID: 550
	[CompilerGenerated]
	private ushort ushort_11;

	// Token: 0x04000227 RID: 551
	[CompilerGenerated]
	private ushort ushort_12;

	// Token: 0x04000228 RID: 552
	[CompilerGenerated]
	private ushort ushort_13;

	// Token: 0x04000229 RID: 553
	[CompilerGenerated]
	private ushort[] ushort_14;

	// Token: 0x0400022A RID: 554
	[CompilerGenerated]
	private ushort ushort_15;

	// Token: 0x0400022B RID: 555
	[CompilerGenerated]
	private ushort ushort_16;

	// Token: 0x0400022C RID: 556
	[CompilerGenerated]
	private ushort[] ushort_17;

	// Token: 0x0400022D RID: 557
	[CompilerGenerated]
	private uint uint_0;
}
