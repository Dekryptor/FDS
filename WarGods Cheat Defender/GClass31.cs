using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000052 RID: 82
public class GClass31
{
	// Token: 0x060002AB RID: 683 RVA: 0x0004A940 File Offset: 0x00048B40
	public GClass31(byte[] byte_1, int int_0, uint uint_9, bool bool_0 = true)
	{
		this.Byte_0 = new byte[]
		{
			byte_1[int_0],
			byte_1[int_0 + 1],
			byte_1[int_0 + 2],
			byte_1[int_0 + 3],
			byte_1[int_0 + 4],
			byte_1[int_0 + 5],
			byte_1[int_0 + 6],
			byte_1[int_0 + 7]
		};
		this.UInt32_0 = BitConverter.ToUInt32(byte_1, int_0 + 8);
		this.UInt32_1 = this.UInt32_0;
		this.UInt32_2 = BitConverter.ToUInt32(byte_1, int_0 + 12);
		this.UInt32_3 = BitConverter.ToUInt32(byte_1, int_0 + 16);
		this.UInt32_4 = BitConverter.ToUInt32(byte_1, int_0 + 20);
		this.UInt32_5 = BitConverter.ToUInt32(byte_1, int_0 + 24);
		this.UInt32_6 = BitConverter.ToUInt32(byte_1, int_0 + 28);
		this.UInt16_0 = BitConverter.ToUInt16(byte_1, int_0 + 32);
		this.UInt16_1 = BitConverter.ToUInt16(byte_1, int_0 + 34);
		this.UInt32_7 = BitConverter.ToUInt32(byte_1, int_0 + 36);
		if (bool_0)
		{
			try
			{
				long num = (long)((ulong)(this.UInt32_4 + this.UInt32_3));
				if (uint_9 > 0U && num % (long)((ulong)uint_9) != 0L)
				{
					int num2 = (int)((double)num / uint_9);
					num2++;
					num = (long)((ulong)uint_9 * (ulong)((long)num2));
				}
				if (num != 0L)
				{
					if (num > (long)byte_1.Length)
					{
						num = (long)byte_1.Length;
					}
					string text;
					if (Class6.smethod_3(byte_1, out text, (long)((ulong)this.UInt32_4), num, 4096))
					{
						this.String_0 = text;
					}
					else
					{
						this.String_0 = null;
					}
				}
				else
				{
					this.String_0 = Class6.smethod_0(string.Empty);
				}
				return;
			}
			catch
			{
				this.String_0 = null;
				return;
			}
		}
		this.String_0 = null;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0004AAD4 File Offset: 0x00048CD4
	public GClass31(BinaryReader binaryReader_0, int int_0, uint uint_9, bool bool_0 = true)
	{
		byte[] array = new byte[GClass31.uint_0];
		if (binaryReader_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new IOException("Read section failed");
		}
		this.Byte_0 = new byte[]
		{
			array[int_0],
			array[int_0 + 1],
			array[int_0 + 2],
			array[int_0 + 3],
			array[int_0 + 4],
			array[int_0 + 5],
			array[int_0 + 6],
			array[int_0 + 7]
		};
		this.UInt32_0 = BitConverter.ToUInt32(array, int_0 + 8);
		this.UInt32_1 = this.UInt32_0;
		this.UInt32_2 = BitConverter.ToUInt32(array, int_0 + 12);
		this.UInt32_3 = BitConverter.ToUInt32(array, int_0 + 16);
		this.UInt32_4 = BitConverter.ToUInt32(array, int_0 + 20);
		this.UInt32_5 = BitConverter.ToUInt32(array, int_0 + 24);
		this.UInt32_6 = BitConverter.ToUInt32(array, int_0 + 28);
		this.UInt16_0 = BitConverter.ToUInt16(array, int_0 + 32);
		this.UInt16_1 = BitConverter.ToUInt16(array, int_0 + 34);
		this.UInt32_7 = BitConverter.ToUInt32(array, int_0 + 36);
		if (bool_0)
		{
			try
			{
				long num = (long)((ulong)(this.UInt32_4 + this.UInt32_3));
				if (uint_9 > 0U && num % (long)((ulong)uint_9) != 0L)
				{
					int num2 = (int)((double)num / uint_9);
					num2++;
					num = (long)((ulong)uint_9 * (ulong)((long)num2));
				}
				if (num != 0L)
				{
					if (num > binaryReader_0.BaseStream.Length)
					{
						num = binaryReader_0.BaseStream.Length;
					}
					string text;
					if (Class6.smethod_2(binaryReader_0, out text, (long)((ulong)this.UInt32_4), num, 4096))
					{
						this.String_0 = text;
					}
					else
					{
						this.String_0 = null;
					}
				}
				else
				{
					this.String_0 = Class6.smethod_0(string.Empty);
				}
				return;
			}
			catch
			{
				this.String_0 = null;
				return;
			}
		}
		this.String_0 = null;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0004ACA0 File Offset: 0x00048EA0
	public GClass31(IntPtr intptr_0, IntPtr intptr_1, uint uint_9, bool bool_0 = true)
	{
		byte[] array = new byte[GClass31.uint_0];
		uint num = 0U;
		if (!GClass16.ReadProcessMemory(intptr_0, intptr_1, array, (uint)array.Length, ref num) || (ulong)num != (ulong)((long)array.Length))
		{
			throw new IOException("Read section failed");
		}
		this.Byte_0 = new byte[]
		{
			array[0],
			array[1],
			array[2],
			array[3],
			array[4],
			array[5],
			array[6],
			array[7]
		};
		this.UInt32_0 = BitConverter.ToUInt32(array, 8);
		this.UInt32_1 = this.UInt32_0;
		this.UInt32_2 = BitConverter.ToUInt32(array, 12);
		this.UInt32_3 = BitConverter.ToUInt32(array, 16);
		this.UInt32_4 = BitConverter.ToUInt32(array, 20);
		this.UInt32_5 = BitConverter.ToUInt32(array, 24);
		this.UInt32_6 = BitConverter.ToUInt32(array, 28);
		this.UInt16_0 = BitConverter.ToUInt16(array, 32);
		this.UInt16_1 = BitConverter.ToUInt16(array, 34);
		this.UInt32_7 = BitConverter.ToUInt32(array, 36);
		if (!bool_0)
		{
			this.String_0 = null;
			return;
		}
		this.String_0 = null;
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x060002AE RID: 686 RVA: 0x0004ADC0 File Offset: 0x00048FC0
	// (set) Token: 0x060002AF RID: 687 RVA: 0x0004ADD4 File Offset: 0x00048FD4
	public byte[] Byte_0 { get; private set; }

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x060002B0 RID: 688 RVA: 0x0004ADE8 File Offset: 0x00048FE8
	// (set) Token: 0x060002B1 RID: 689 RVA: 0x0004ADFC File Offset: 0x00048FFC
	public uint UInt32_0 { get; private set; }

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x060002B2 RID: 690 RVA: 0x0004AE10 File Offset: 0x00049010
	// (set) Token: 0x060002B3 RID: 691 RVA: 0x0004AE24 File Offset: 0x00049024
	public uint UInt32_1 { get; private set; }

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x060002B4 RID: 692 RVA: 0x0004AE38 File Offset: 0x00049038
	// (set) Token: 0x060002B5 RID: 693 RVA: 0x0004AE4C File Offset: 0x0004904C
	public uint UInt32_2 { get; private set; }

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x060002B6 RID: 694 RVA: 0x0004AE60 File Offset: 0x00049060
	// (set) Token: 0x060002B7 RID: 695 RVA: 0x0004AE74 File Offset: 0x00049074
	public uint UInt32_3 { get; private set; }

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x060002B8 RID: 696 RVA: 0x0004AE88 File Offset: 0x00049088
	// (set) Token: 0x060002B9 RID: 697 RVA: 0x0004AE9C File Offset: 0x0004909C
	public uint UInt32_4 { get; private set; }

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x060002BA RID: 698 RVA: 0x0004AEB0 File Offset: 0x000490B0
	// (set) Token: 0x060002BB RID: 699 RVA: 0x0004AEC4 File Offset: 0x000490C4
	public uint UInt32_5 { get; private set; }

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x060002BC RID: 700 RVA: 0x0004AED8 File Offset: 0x000490D8
	// (set) Token: 0x060002BD RID: 701 RVA: 0x0004AEEC File Offset: 0x000490EC
	public uint UInt32_6 { get; private set; }

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x060002BE RID: 702 RVA: 0x0004AF00 File Offset: 0x00049100
	// (set) Token: 0x060002BF RID: 703 RVA: 0x0004AF14 File Offset: 0x00049114
	public ushort UInt16_0 { get; private set; }

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x060002C0 RID: 704 RVA: 0x0004AF28 File Offset: 0x00049128
	// (set) Token: 0x060002C1 RID: 705 RVA: 0x0004AF3C File Offset: 0x0004913C
	public ushort UInt16_1 { get; private set; }

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x060002C2 RID: 706 RVA: 0x0004AF50 File Offset: 0x00049150
	// (set) Token: 0x060002C3 RID: 707 RVA: 0x0004AF64 File Offset: 0x00049164
	public uint UInt32_7 { get; private set; }

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x060002C4 RID: 708 RVA: 0x0004AF78 File Offset: 0x00049178
	// (set) Token: 0x060002C5 RID: 709 RVA: 0x0004AF8C File Offset: 0x0004918C
	public string String_0 { get; private set; }

	// Token: 0x060002C6 RID: 710 RVA: 0x0004AFA0 File Offset: 0x000491A0
	public virtual string ToString()
	{
		string text = "";
		try
		{
			text = Class15.smethod_14(this.Byte_0);
		}
		catch
		{
			text = "";
		}
		return string.Format("{0}!{1}!{2}!{3}!{4}", new object[]
		{
			text,
			this.String_0 ?? Class14.String_215,
			this.UInt32_7,
			this.UInt32_4,
			this.UInt32_3
		});
	}

	// Token: 0x04000274 RID: 628
	[NonSerialized]
	public static readonly uint uint_0 = 40U;

	// Token: 0x04000275 RID: 629
	[CompilerGenerated]
	private byte[] byte_0;

	// Token: 0x04000276 RID: 630
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x04000277 RID: 631
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x04000278 RID: 632
	[CompilerGenerated]
	private uint uint_3;

	// Token: 0x04000279 RID: 633
	[CompilerGenerated]
	private uint uint_4;

	// Token: 0x0400027A RID: 634
	[CompilerGenerated]
	private uint uint_5;

	// Token: 0x0400027B RID: 635
	[CompilerGenerated]
	private uint uint_6;

	// Token: 0x0400027C RID: 636
	[CompilerGenerated]
	private uint uint_7;

	// Token: 0x0400027D RID: 637
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x0400027E RID: 638
	[CompilerGenerated]
	private ushort ushort_1;

	// Token: 0x0400027F RID: 639
	[CompilerGenerated]
	private uint uint_8;

	// Token: 0x04000280 RID: 640
	[CompilerGenerated]
	private string string_0;
}
