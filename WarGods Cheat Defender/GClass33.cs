using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000054 RID: 84
public class GClass33
{
	// Token: 0x060002D2 RID: 722 RVA: 0x0004B164 File Offset: 0x00049364
	public GClass33(byte[] byte_0, int int_0, bool bool_0)
	{
		this.UInt64_0 = (bool_0 ? BitConverter.ToUInt64(byte_0, int_0) : ((ulong)BitConverter.ToUInt32(byte_0, int_0)));
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0004B194 File Offset: 0x00049394
	public GClass33(BinaryReader binaryReader_0, int int_0, bool bool_0)
	{
		if (int_0 == 0 || (long)int_0 >= binaryReader_0.BaseStream.Length)
		{
			throw new ArgumentException("Invalid tls offset");
		}
		binaryReader_0.BaseStream.Seek((long)int_0, SeekOrigin.Begin);
		byte[] array = new byte[bool_0 ? 8 : 4];
		if (binaryReader_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new IOException("Read tls failed");
		}
		this.UInt64_0 = (bool_0 ? BitConverter.ToUInt64(array, 0) : ((ulong)BitConverter.ToUInt32(array, 0)));
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x060002D4 RID: 724 RVA: 0x0004B218 File Offset: 0x00049418
	// (set) Token: 0x060002D5 RID: 725 RVA: 0x0004B22C File Offset: 0x0004942C
	public ulong UInt64_0 { get; set; }

	// Token: 0x04000285 RID: 645
	[CompilerGenerated]
	private ulong ulong_0;
}
