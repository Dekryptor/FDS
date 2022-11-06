using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000050 RID: 80
public class GClass29
{
	// Token: 0x17000100 RID: 256
	// (get) Token: 0x0600025F RID: 607 RVA: 0x00049F34 File Offset: 0x00048134
	// (set) Token: 0x06000260 RID: 608 RVA: 0x00049F48 File Offset: 0x00048148
	public GClass20[] GClass20_0 { get; private set; }

	// Token: 0x06000261 RID: 609 RVA: 0x00049F5C File Offset: 0x0004815C
	public GClass29(byte[] byte_2, int int_0 = 0, bool bool_0 = false)
	{
		this.UInt16_0 = BitConverter.ToUInt16(byte_2, int_0);
		this.Byte_0 = byte_2[int_0 + 2];
		this.Byte_1 = byte_2[int_0 + 3];
		this.UInt32_0 = BitConverter.ToUInt32(byte_2, int_0 + 4);
		this.UInt32_1 = BitConverter.ToUInt32(byte_2, int_0 + 8);
		this.UInt32_2 = BitConverter.ToUInt32(byte_2, int_0 + 12);
		this.UInt32_3 = BitConverter.ToUInt32(byte_2, int_0 + 16);
		this.UInt32_4 = BitConverter.ToUInt32(byte_2, int_0 + 20);
		this.UInt32_5 = (bool_0 ? 0U : BitConverter.ToUInt32(byte_2, int_0 + 24));
		if (bool_0)
		{
			this.UInt64_0 = (ulong)((long)int_0 + 24L);
		}
		else
		{
			this.UInt64_0 = (ulong)((long)int_0 + 28L);
		}
		this.UInt64_1 = (bool_0 ? BitConverter.ToUInt64(byte_2, int_0 + 24) : ((ulong)BitConverter.ToUInt32(byte_2, int_0 + 28)));
		this.UInt32_6 = BitConverter.ToUInt32(byte_2, int_0 + 32);
		this.UInt32_7 = BitConverter.ToUInt32(byte_2, int_0 + 36);
		this.UInt16_1 = BitConverter.ToUInt16(byte_2, int_0 + 40);
		this.UInt16_2 = BitConverter.ToUInt16(byte_2, int_0 + 42);
		this.UInt16_3 = BitConverter.ToUInt16(byte_2, int_0 + 44);
		this.UInt16_4 = BitConverter.ToUInt16(byte_2, int_0 + 46);
		this.UInt16_5 = BitConverter.ToUInt16(byte_2, int_0 + 48);
		this.UInt16_6 = BitConverter.ToUInt16(byte_2, int_0 + 50);
		this.UInt32_8 = BitConverter.ToUInt32(byte_2, int_0 + 52);
		this.UInt32_9 = BitConverter.ToUInt32(byte_2, int_0 + 56);
		this.UInt32_10 = BitConverter.ToUInt32(byte_2, int_0 + 60);
		this.UInt32_11 = BitConverter.ToUInt32(byte_2, int_0 + 64);
		this.UInt16_7 = BitConverter.ToUInt16(byte_2, int_0 + 68);
		this.UInt16_8 = BitConverter.ToUInt16(byte_2, int_0 + 70);
		this.UInt64_2 = (bool_0 ? BitConverter.ToUInt64(byte_2, int_0 + 72) : ((ulong)BitConverter.ToUInt32(byte_2, int_0 + 72)));
		this.UInt64_3 = (bool_0 ? BitConverter.ToUInt64(byte_2, int_0 + 80) : ((ulong)BitConverter.ToUInt32(byte_2, int_0 + 76)));
		this.UInt64_4 = (bool_0 ? BitConverter.ToUInt64(byte_2, int_0 + 88) : ((ulong)BitConverter.ToUInt32(byte_2, int_0 + 80)));
		this.UInt64_5 = (bool_0 ? BitConverter.ToUInt64(byte_2, int_0 + 96) : ((ulong)BitConverter.ToUInt32(byte_2, int_0 + 84)));
		this.UInt32_12 = (bool_0 ? BitConverter.ToUInt32(byte_2, int_0 + 104) : BitConverter.ToUInt32(byte_2, int_0 + 88));
		this.UInt32_13 = (bool_0 ? BitConverter.ToUInt32(byte_2, int_0 + 108) : BitConverter.ToUInt32(byte_2, int_0 + 92));
		this.GClass20_0 = new GClass20[16];
		for (uint num = 0U; num < 16U; num += 1U)
		{
			if (!bool_0)
			{
				this.GClass20_0[(int)num] = new GClass20(byte_2, (int)((long)(int_0 + 96) + (long)((ulong)(num * 8U))));
			}
			else
			{
				this.GClass20_0[(int)num] = new GClass20(byte_2, (int)((long)(int_0 + 112) + (long)((ulong)(num * 8U))));
			}
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000262 RID: 610 RVA: 0x0004A230 File Offset: 0x00048430
	// (set) Token: 0x06000263 RID: 611 RVA: 0x0004A244 File Offset: 0x00048444
	public ushort UInt16_0 { get; private set; }

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000264 RID: 612 RVA: 0x0004A258 File Offset: 0x00048458
	// (set) Token: 0x06000265 RID: 613 RVA: 0x0004A26C File Offset: 0x0004846C
	public byte Byte_0 { get; private set; }

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000266 RID: 614 RVA: 0x0004A280 File Offset: 0x00048480
	// (set) Token: 0x06000267 RID: 615 RVA: 0x0004A294 File Offset: 0x00048494
	public byte Byte_1 { get; private set; }

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000268 RID: 616 RVA: 0x0004A2A8 File Offset: 0x000484A8
	// (set) Token: 0x06000269 RID: 617 RVA: 0x0004A2BC File Offset: 0x000484BC
	public uint UInt32_0 { get; private set; }

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x0600026A RID: 618 RVA: 0x0004A2D0 File Offset: 0x000484D0
	// (set) Token: 0x0600026B RID: 619 RVA: 0x0004A2E4 File Offset: 0x000484E4
	public uint UInt32_1 { get; private set; }

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x0600026C RID: 620 RVA: 0x0004A2F8 File Offset: 0x000484F8
	// (set) Token: 0x0600026D RID: 621 RVA: 0x0004A30C File Offset: 0x0004850C
	public uint UInt32_2 { get; private set; }

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x0600026E RID: 622 RVA: 0x0004A320 File Offset: 0x00048520
	// (set) Token: 0x0600026F RID: 623 RVA: 0x0004A334 File Offset: 0x00048534
	public uint UInt32_3 { get; private set; }

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000270 RID: 624 RVA: 0x0004A348 File Offset: 0x00048548
	// (set) Token: 0x06000271 RID: 625 RVA: 0x0004A35C File Offset: 0x0004855C
	public uint UInt32_4 { get; private set; }

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000272 RID: 626 RVA: 0x0004A370 File Offset: 0x00048570
	// (set) Token: 0x06000273 RID: 627 RVA: 0x0004A384 File Offset: 0x00048584
	public uint UInt32_5 { get; private set; }

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000274 RID: 628 RVA: 0x0004A398 File Offset: 0x00048598
	// (set) Token: 0x06000275 RID: 629 RVA: 0x0004A3AC File Offset: 0x000485AC
	public ulong UInt64_0 { get; set; }

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000276 RID: 630 RVA: 0x0004A3C0 File Offset: 0x000485C0
	// (set) Token: 0x06000277 RID: 631 RVA: 0x0004A3D4 File Offset: 0x000485D4
	public ulong UInt64_1 { get; private set; }

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000278 RID: 632 RVA: 0x0004A3E8 File Offset: 0x000485E8
	// (set) Token: 0x06000279 RID: 633 RVA: 0x0004A3FC File Offset: 0x000485FC
	public uint UInt32_6 { get; private set; }

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x0600027A RID: 634 RVA: 0x0004A410 File Offset: 0x00048610
	// (set) Token: 0x0600027B RID: 635 RVA: 0x0004A424 File Offset: 0x00048624
	public uint UInt32_7 { get; private set; }

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x0600027C RID: 636 RVA: 0x0004A438 File Offset: 0x00048638
	// (set) Token: 0x0600027D RID: 637 RVA: 0x0004A44C File Offset: 0x0004864C
	public ushort UInt16_1 { get; private set; }

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x0600027E RID: 638 RVA: 0x0004A460 File Offset: 0x00048660
	// (set) Token: 0x0600027F RID: 639 RVA: 0x0004A474 File Offset: 0x00048674
	public ushort UInt16_2 { get; private set; }

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000280 RID: 640 RVA: 0x0004A488 File Offset: 0x00048688
	// (set) Token: 0x06000281 RID: 641 RVA: 0x0004A49C File Offset: 0x0004869C
	public ushort UInt16_3 { get; private set; }

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000282 RID: 642 RVA: 0x0004A4B0 File Offset: 0x000486B0
	// (set) Token: 0x06000283 RID: 643 RVA: 0x0004A4C4 File Offset: 0x000486C4
	public ushort UInt16_4 { get; private set; }

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000284 RID: 644 RVA: 0x0004A4D8 File Offset: 0x000486D8
	// (set) Token: 0x06000285 RID: 645 RVA: 0x0004A4EC File Offset: 0x000486EC
	public ushort UInt16_5 { get; private set; }

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000286 RID: 646 RVA: 0x0004A500 File Offset: 0x00048700
	// (set) Token: 0x06000287 RID: 647 RVA: 0x0004A514 File Offset: 0x00048714
	public ushort UInt16_6 { get; private set; }

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000288 RID: 648 RVA: 0x0004A528 File Offset: 0x00048728
	// (set) Token: 0x06000289 RID: 649 RVA: 0x0004A53C File Offset: 0x0004873C
	public uint UInt32_8 { get; private set; }

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x0600028A RID: 650 RVA: 0x0004A550 File Offset: 0x00048750
	// (set) Token: 0x0600028B RID: 651 RVA: 0x0004A564 File Offset: 0x00048764
	public uint UInt32_9 { get; private set; }

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x0600028C RID: 652 RVA: 0x0004A578 File Offset: 0x00048778
	// (set) Token: 0x0600028D RID: 653 RVA: 0x0004A58C File Offset: 0x0004878C
	public uint UInt32_10 { get; private set; }

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x0600028E RID: 654 RVA: 0x0004A5A0 File Offset: 0x000487A0
	// (set) Token: 0x0600028F RID: 655 RVA: 0x0004A5B4 File Offset: 0x000487B4
	public uint UInt32_11 { get; private set; }

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000290 RID: 656 RVA: 0x0004A5C8 File Offset: 0x000487C8
	// (set) Token: 0x06000291 RID: 657 RVA: 0x0004A5DC File Offset: 0x000487DC
	public ushort UInt16_7 { get; private set; }

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000292 RID: 658 RVA: 0x0004A5F0 File Offset: 0x000487F0
	// (set) Token: 0x06000293 RID: 659 RVA: 0x0004A604 File Offset: 0x00048804
	public ushort UInt16_8 { get; private set; }

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000294 RID: 660 RVA: 0x0004A618 File Offset: 0x00048818
	// (set) Token: 0x06000295 RID: 661 RVA: 0x0004A62C File Offset: 0x0004882C
	public ulong UInt64_2 { get; private set; }

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000296 RID: 662 RVA: 0x0004A640 File Offset: 0x00048840
	// (set) Token: 0x06000297 RID: 663 RVA: 0x0004A654 File Offset: 0x00048854
	public ulong UInt64_3 { get; private set; }

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000298 RID: 664 RVA: 0x0004A668 File Offset: 0x00048868
	// (set) Token: 0x06000299 RID: 665 RVA: 0x0004A67C File Offset: 0x0004887C
	public ulong UInt64_4 { get; private set; }

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x0600029A RID: 666 RVA: 0x0004A690 File Offset: 0x00048890
	// (set) Token: 0x0600029B RID: 667 RVA: 0x0004A6A4 File Offset: 0x000488A4
	public ulong UInt64_5 { get; private set; }

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x0600029C RID: 668 RVA: 0x0004A6B8 File Offset: 0x000488B8
	// (set) Token: 0x0600029D RID: 669 RVA: 0x0004A6CC File Offset: 0x000488CC
	public uint UInt32_12 { get; private set; }

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x0600029E RID: 670 RVA: 0x0004A6E0 File Offset: 0x000488E0
	// (set) Token: 0x0600029F RID: 671 RVA: 0x0004A6F4 File Offset: 0x000488F4
	public uint UInt32_13 { get; private set; }

	// Token: 0x060002A0 RID: 672 RVA: 0x0004A708 File Offset: 0x00048908
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_OPTIONAL_HEADER\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-15}:\t{1,10:X}\n"));
		foreach (GClass20 gclass in this.GClass20_0)
		{
			stringBuilder.Append(gclass);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0400024F RID: 591
	[NonSerialized]
	public static readonly uint uint_0 = 96U + 16U * GClass20.uint_0;

	// Token: 0x04000250 RID: 592
	[NonSerialized]
	public static readonly uint uint_1 = 112U + 16U * GClass20.uint_0;

	// Token: 0x04000251 RID: 593
	[CompilerGenerated]
	private GClass20[] gclass20_0;

	// Token: 0x04000252 RID: 594
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x04000253 RID: 595
	[CompilerGenerated]
	private byte byte_0;

	// Token: 0x04000254 RID: 596
	[CompilerGenerated]
	private byte byte_1;

	// Token: 0x04000255 RID: 597
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x04000256 RID: 598
	[CompilerGenerated]
	private uint uint_3;

	// Token: 0x04000257 RID: 599
	[CompilerGenerated]
	private uint uint_4;

	// Token: 0x04000258 RID: 600
	[CompilerGenerated]
	private uint uint_5;

	// Token: 0x04000259 RID: 601
	[CompilerGenerated]
	private uint uint_6;

	// Token: 0x0400025A RID: 602
	[CompilerGenerated]
	private uint uint_7;

	// Token: 0x0400025B RID: 603
	[CompilerGenerated]
	private ulong ulong_0;

	// Token: 0x0400025C RID: 604
	[CompilerGenerated]
	private ulong ulong_1;

	// Token: 0x0400025D RID: 605
	[CompilerGenerated]
	private uint uint_8;

	// Token: 0x0400025E RID: 606
	[CompilerGenerated]
	private uint uint_9;

	// Token: 0x0400025F RID: 607
	[CompilerGenerated]
	private ushort ushort_1;

	// Token: 0x04000260 RID: 608
	[CompilerGenerated]
	private ushort ushort_2;

	// Token: 0x04000261 RID: 609
	[CompilerGenerated]
	private ushort ushort_3;

	// Token: 0x04000262 RID: 610
	[CompilerGenerated]
	private ushort ushort_4;

	// Token: 0x04000263 RID: 611
	[CompilerGenerated]
	private ushort ushort_5;

	// Token: 0x04000264 RID: 612
	[CompilerGenerated]
	private ushort ushort_6;

	// Token: 0x04000265 RID: 613
	[CompilerGenerated]
	private uint uint_10;

	// Token: 0x04000266 RID: 614
	[CompilerGenerated]
	private uint uint_11;

	// Token: 0x04000267 RID: 615
	[CompilerGenerated]
	private uint uint_12;

	// Token: 0x04000268 RID: 616
	[CompilerGenerated]
	private uint uint_13;

	// Token: 0x04000269 RID: 617
	[CompilerGenerated]
	private ushort ushort_7;

	// Token: 0x0400026A RID: 618
	[CompilerGenerated]
	private ushort ushort_8;

	// Token: 0x0400026B RID: 619
	[CompilerGenerated]
	private ulong ulong_2;

	// Token: 0x0400026C RID: 620
	[CompilerGenerated]
	private ulong ulong_3;

	// Token: 0x0400026D RID: 621
	[CompilerGenerated]
	private ulong ulong_4;

	// Token: 0x0400026E RID: 622
	[CompilerGenerated]
	private ulong ulong_5;

	// Token: 0x0400026F RID: 623
	[CompilerGenerated]
	private uint uint_14;

	// Token: 0x04000270 RID: 624
	[CompilerGenerated]
	private uint uint_15;
}
