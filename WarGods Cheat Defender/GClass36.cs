using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000057 RID: 87
public class GClass36
{
	// Token: 0x060002F4 RID: 756 RVA: 0x0004B710 File Offset: 0x00049910
	public GClass36(byte[] byte_1, int int_0)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_1, int_0);
		this.UInt16_0 = BitConverter.ToUInt16(byte_1, int_0 + 4);
		this.UInt16_1 = BitConverter.ToUInt16(byte_1, int_0 + 6);
		this.Byte_0 = new byte[this.UInt32_0 - 8U];
		Array.Copy(byte_1, (long)(int_0 + 8), this.Byte_0, 0L, (long)((ulong)(this.UInt32_0 - 8U)));
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0004B784 File Offset: 0x00049984
	public GClass36(BinaryReader binaryReader_0, int int_0)
	{
		binaryReader_0.BaseStream.Seek((long)int_0, SeekOrigin.Begin);
		int num = 8;
		byte[] array = new byte[8];
		if (binaryReader_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new IOException("win certificate read error");
		}
		this.UInt32_0 = BitConverter.ToUInt32(array, 0);
		this.UInt16_0 = BitConverter.ToUInt16(array, 4);
		this.UInt16_1 = BitConverter.ToUInt16(array, 6);
		num = (int)(this.UInt32_0 - (uint)num);
		this.Byte_0 = new byte[num];
		if (binaryReader_0.Read(this.Byte_0, 0, this.Byte_0.Length) != this.Byte_0.Length)
		{
			throw new IOException("certificate read error");
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x060002F6 RID: 758 RVA: 0x0004B830 File Offset: 0x00049A30
	// (set) Token: 0x060002F7 RID: 759 RVA: 0x0004B844 File Offset: 0x00049A44
	public uint UInt32_0 { get; private set; }

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x060002F8 RID: 760 RVA: 0x0004B858 File Offset: 0x00049A58
	// (set) Token: 0x060002F9 RID: 761 RVA: 0x0004B86C File Offset: 0x00049A6C
	public ushort UInt16_0 { get; private set; }

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x060002FA RID: 762 RVA: 0x0004B880 File Offset: 0x00049A80
	// (set) Token: 0x060002FB RID: 763 RVA: 0x0004B894 File Offset: 0x00049A94
	public ushort UInt16_1 { get; private set; }

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x060002FC RID: 764 RVA: 0x0004B8A8 File Offset: 0x00049AA8
	// (set) Token: 0x060002FD RID: 765 RVA: 0x0004B8BC File Offset: 0x00049ABC
	public byte[] Byte_0 { get; private set; }

	// Token: 0x060002FE RID: 766 RVA: 0x0004B8D0 File Offset: 0x00049AD0
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("WIN_CERTIFICATE\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-10}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x04000294 RID: 660
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000295 RID: 661
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x04000296 RID: 662
	[CompilerGenerated]
	private ushort ushort_1;

	// Token: 0x04000297 RID: 663
	[CompilerGenerated]
	private byte[] byte_0;
}
