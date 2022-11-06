using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000049 RID: 73
public class GClass22
{
	// Token: 0x060001DB RID: 475 RVA: 0x00048F9C File Offset: 0x0004719C
	public GClass22(byte[] byte_0, int int_1)
	{
		this.method_0(byte_0, int_1);
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00048FB8 File Offset: 0x000471B8
	public GClass22(BinaryReader binaryReader_0, int int_1)
	{
		if (int_1 == 0 || (long)int_1 >= binaryReader_0.BaseStream.Length)
		{
			throw new ArgumentException("Invalid delay import offset");
		}
		binaryReader_0.BaseStream.Seek((long)int_1, SeekOrigin.Begin);
		byte[] array = new byte[GClass22.int_0];
		if (binaryReader_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new IOException("Read tls failed");
		}
		this.method_0(array, 0);
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00049028 File Offset: 0x00047228
	private void method_0(byte[] byte_0, int int_1)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_1);
		int_1 += 4;
		this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_1);
		int_1 += 4;
		this.UInt32_2 = BitConverter.ToUInt32(byte_0, int_1);
		int_1 += 4;
		this.UInt32_3 = BitConverter.ToUInt32(byte_0, int_1);
		int_1 += 4;
		this.UInt32_4 = BitConverter.ToUInt32(byte_0, int_1);
		int_1 += 4;
		this.UInt32_5 = BitConverter.ToUInt32(byte_0, int_1);
		int_1 += 4;
		this.UInt32_6 = BitConverter.ToUInt32(byte_0, int_1);
		int_1 += 4;
		this.UInt32_7 = BitConverter.ToUInt32(byte_0, int_1);
		int_1 += 4;
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060001DE RID: 478 RVA: 0x000490C8 File Offset: 0x000472C8
	// (set) Token: 0x060001DF RID: 479 RVA: 0x000490DC File Offset: 0x000472DC
	public uint UInt32_0 { get; set; }

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060001E0 RID: 480 RVA: 0x000490F0 File Offset: 0x000472F0
	// (set) Token: 0x060001E1 RID: 481 RVA: 0x00049104 File Offset: 0x00047304
	public uint UInt32_1 { get; set; }

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060001E2 RID: 482 RVA: 0x00049118 File Offset: 0x00047318
	// (set) Token: 0x060001E3 RID: 483 RVA: 0x0004912C File Offset: 0x0004732C
	public uint UInt32_2 { get; set; }

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060001E4 RID: 484 RVA: 0x00049140 File Offset: 0x00047340
	// (set) Token: 0x060001E5 RID: 485 RVA: 0x00049154 File Offset: 0x00047354
	public uint UInt32_3 { get; set; }

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060001E6 RID: 486 RVA: 0x00049168 File Offset: 0x00047368
	// (set) Token: 0x060001E7 RID: 487 RVA: 0x0004917C File Offset: 0x0004737C
	public uint UInt32_4 { get; set; }

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060001E8 RID: 488 RVA: 0x00049190 File Offset: 0x00047390
	// (set) Token: 0x060001E9 RID: 489 RVA: 0x000491A4 File Offset: 0x000473A4
	public uint UInt32_5 { get; set; }

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060001EA RID: 490 RVA: 0x000491B8 File Offset: 0x000473B8
	// (set) Token: 0x060001EB RID: 491 RVA: 0x000491CC File Offset: 0x000473CC
	public uint UInt32_6 { get; set; }

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060001EC RID: 492 RVA: 0x000491E0 File Offset: 0x000473E0
	// (set) Token: 0x060001ED RID: 493 RVA: 0x000491F4 File Offset: 0x000473F4
	public uint UInt32_7 { get; set; }

	// Token: 0x04000211 RID: 529
	[NonSerialized]
	public static readonly int int_0 = 32;

	// Token: 0x04000212 RID: 530
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000213 RID: 531
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x04000214 RID: 532
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x04000215 RID: 533
	[CompilerGenerated]
	private uint uint_3;

	// Token: 0x04000216 RID: 534
	[CompilerGenerated]
	private uint uint_4;

	// Token: 0x04000217 RID: 535
	[CompilerGenerated]
	private uint uint_5;

	// Token: 0x04000218 RID: 536
	[CompilerGenerated]
	private uint uint_6;

	// Token: 0x04000219 RID: 537
	[CompilerGenerated]
	private uint uint_7;
}
