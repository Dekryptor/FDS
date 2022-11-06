using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000056 RID: 86
public class GClass35
{
	// Token: 0x060002E8 RID: 744 RVA: 0x0004B4EC File Offset: 0x000496EC
	public GClass35(byte[] byte_0, int int_1, int int_2)
	{
		this.method_0(byte_0, int_1, int_2);
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0004B508 File Offset: 0x00049708
	public GClass35(BinaryReader binaryReader_0, int int_1, int int_2)
	{
		if (int_1 == 0 || (long)(int_1 + int_2) >= binaryReader_0.BaseStream.Length)
		{
			throw new ArgumentException("Invalid pdb offset");
		}
		binaryReader_0.BaseStream.Seek((long)int_1, SeekOrigin.Begin);
		byte[] array = new byte[int_2];
		if (binaryReader_0.Read(array, 0, array.Length) != array.Length)
		{
			throw new IOException("Read pdb failed");
		}
		this.method_0(array, 0, int_2);
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0004B574 File Offset: 0x00049774
	private void method_0(byte[] byte_0, int int_1, int int_2)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_1);
		if (this.UInt32_0 == 1396986706U)
		{
			byte[] array = new byte[16];
			Array.Copy(byte_0, int_1 + 4, array, 0, array.Length);
			this.String_0 = GClass18.smethod_17(array);
			this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_1 + 20);
			int num = int_2 - GClass35.int_0;
			if (num > 0)
			{
				try
				{
					this.String_1 = Encoding.ASCII.GetString(byte_0, int_1 + GClass35.int_0, num);
					this.String_1 = this.String_1.TrimEnd(new char[1]);
				}
				catch
				{
					char[] array2 = new char[num + 1];
					Array.Clear(array2, 0, array2.Length);
					Array.Copy(byte_0, int_1 + GClass35.int_0, array2, 0, num);
					this.String_1 = new string(array2).TrimEnd(new char[1]);
				}
			}
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x060002EB RID: 747 RVA: 0x0004B65C File Offset: 0x0004985C
	// (set) Token: 0x060002EC RID: 748 RVA: 0x0004B670 File Offset: 0x00049870
	public uint UInt32_0 { get; private set; }

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060002ED RID: 749 RVA: 0x0004B684 File Offset: 0x00049884
	// (set) Token: 0x060002EE RID: 750 RVA: 0x0004B698 File Offset: 0x00049898
	public string String_0 { get; private set; }

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060002EF RID: 751 RVA: 0x0004B6AC File Offset: 0x000498AC
	// (set) Token: 0x060002F0 RID: 752 RVA: 0x0004B6C0 File Offset: 0x000498C0
	public uint UInt32_1 { get; private set; }

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x0004B6D4 File Offset: 0x000498D4
	// (set) Token: 0x060002F2 RID: 754 RVA: 0x0004B6E8 File Offset: 0x000498E8
	public string String_1 { get; private set; }

	// Token: 0x0400028F RID: 655
	[NonSerialized]
	private static readonly int int_0 = 24;

	// Token: 0x04000290 RID: 656
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000291 RID: 657
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000292 RID: 658
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x04000293 RID: 659
	[CompilerGenerated]
	private string string_1;
}
