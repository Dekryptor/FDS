using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000055 RID: 85
public class GClass34
{
	// Token: 0x060002D6 RID: 726 RVA: 0x0004B240 File Offset: 0x00049440
	public GClass34(byte[] byte_0, int int_0, bool bool_0)
	{
		this.method_0(byte_0, int_0, bool_0);
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0004B25C File Offset: 0x0004945C
	public GClass34(BinaryReader binaryReader_0, int int_0, bool bool_0)
	{
		if (int_0 == 0 || (long)int_0 >= binaryReader_0.BaseStream.Length)
		{
			throw new ArgumentException("Invalid tls directory offset");
		}
		binaryReader_0.BaseStream.Seek((long)int_0, SeekOrigin.Begin);
		byte[] array = new byte[bool_0 ? GClass34.uint_0 : GClass34.uint_1];
		if (binaryReader_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new IOException("Read tls directory failed");
		}
		this.method_0(array, 0, bool_0);
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0004B2D4 File Offset: 0x000494D4
	private void method_0(byte[] byte_0, int int_0, bool bool_0)
	{
		if (bool_0)
		{
			this.UInt64_0 = BitConverter.ToUInt64(byte_0, int_0);
			int_0 += 8;
			this.UInt64_1 = BitConverter.ToUInt64(byte_0, int_0);
			int_0 += 8;
			this.UInt64_2 = BitConverter.ToUInt64(byte_0, int_0);
			int_0 += 8;
			this.UInt64_3 = BitConverter.ToUInt64(byte_0, int_0);
			int_0 += 8;
			this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_0);
			int_0 += 4;
			this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_0);
			return;
		}
		this.UInt64_0 = (ulong)BitConverter.ToUInt32(byte_0, int_0);
		int_0 += 4;
		this.UInt64_1 = (ulong)BitConverter.ToUInt32(byte_0, int_0);
		int_0 += 4;
		this.UInt64_2 = (ulong)BitConverter.ToUInt32(byte_0, int_0);
		int_0 += 4;
		this.UInt64_3 = (ulong)BitConverter.ToUInt32(byte_0, int_0);
		int_0 += 4;
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_0);
		int_0 += 4;
		this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_0);
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x0004B3B8 File Offset: 0x000495B8
	// (set) Token: 0x060002DA RID: 730 RVA: 0x0004B3CC File Offset: 0x000495CC
	public ulong UInt64_0 { get; set; }

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x060002DB RID: 731 RVA: 0x0004B3E0 File Offset: 0x000495E0
	// (set) Token: 0x060002DC RID: 732 RVA: 0x0004B3F4 File Offset: 0x000495F4
	public ulong UInt64_1 { get; set; }

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060002DD RID: 733 RVA: 0x0004B408 File Offset: 0x00049608
	// (set) Token: 0x060002DE RID: 734 RVA: 0x0004B41C File Offset: 0x0004961C
	public ulong UInt64_2 { get; set; }

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x060002DF RID: 735 RVA: 0x0004B430 File Offset: 0x00049630
	// (set) Token: 0x060002E0 RID: 736 RVA: 0x0004B444 File Offset: 0x00049644
	public ulong UInt64_3 { get; set; }

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x060002E1 RID: 737 RVA: 0x0004B458 File Offset: 0x00049658
	// (set) Token: 0x060002E2 RID: 738 RVA: 0x0004B46C File Offset: 0x0004966C
	public uint UInt32_0 { get; set; }

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x060002E3 RID: 739 RVA: 0x0004B480 File Offset: 0x00049680
	// (set) Token: 0x060002E4 RID: 740 RVA: 0x0004B494 File Offset: 0x00049694
	public uint UInt32_1 { get; set; }

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x060002E5 RID: 741 RVA: 0x0004B4A8 File Offset: 0x000496A8
	// (set) Token: 0x060002E6 RID: 742 RVA: 0x0004B4BC File Offset: 0x000496BC
	public GClass33[] GClass33_0 { get; set; }

	// Token: 0x04000286 RID: 646
	[NonSerialized]
	public static readonly uint uint_0 = 40U;

	// Token: 0x04000287 RID: 647
	[NonSerialized]
	public static readonly uint uint_1 = 24U;

	// Token: 0x04000288 RID: 648
	[CompilerGenerated]
	private ulong ulong_0;

	// Token: 0x04000289 RID: 649
	[CompilerGenerated]
	private ulong ulong_1;

	// Token: 0x0400028A RID: 650
	[CompilerGenerated]
	private ulong ulong_2;

	// Token: 0x0400028B RID: 651
	[CompilerGenerated]
	private ulong ulong_3;

	// Token: 0x0400028C RID: 652
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x0400028D RID: 653
	[CompilerGenerated]
	private uint uint_3;

	// Token: 0x0400028E RID: 654
	[CompilerGenerated]
	private GClass33[] gclass33_0;
}
