using System;
using System.Runtime.CompilerServices;

// Token: 0x02000015 RID: 21
public class GClass3
{
	// Token: 0x06000079 RID: 121 RVA: 0x0003E820 File Offset: 0x0003CA20
	public GClass3()
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0003FB78 File Offset: 0x0003DD78
	public GClass3(byte[] byte_0)
	{
		if (byte_0.Length != 8)
		{
			throw new ArgumentException("rawMFTInfo must be 8 bytes long!");
		}
		ushort num = BitConverter.ToUInt16(byte_0, 6);
		ulong num2 = (ulong)BitConverter.ToUInt32(byte_0, 0);
		ulong num3 = (ulong)BitConverter.ToUInt16(byte_0, 4);
		ulong num4;
		if (num3 != 0UL)
		{
			num3 *= 16777216UL;
			num4 = num2 + num3;
		}
		else
		{
			num4 = num2;
		}
		this.Nullable_0 = new ulong?(num4);
		this.Nullable_1 = new int?((int)num);
		if (num == 0)
		{
			this.Nullable_1 = null;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600007B RID: 123 RVA: 0x0003FC04 File Offset: 0x0003DE04
	// (set) Token: 0x0600007C RID: 124 RVA: 0x0003FC18 File Offset: 0x0003DE18
	public ulong? Nullable_0 { get; set; }

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600007D RID: 125 RVA: 0x0003FC2C File Offset: 0x0003DE2C
	// (set) Token: 0x0600007E RID: 126 RVA: 0x0003FC40 File Offset: 0x0003DE40
	public int? Nullable_1 { get; set; }

	// Token: 0x0600007F RID: 127 RVA: 0x0003FC54 File Offset: 0x0003DE54
	public virtual string ToString()
	{
		return string.Format("Entry: {0}, Seq: {1}", this.Nullable_0, this.Nullable_1);
	}

	// Token: 0x04000055 RID: 85
	[CompilerGenerated]
	private ulong? nullable_0;

	// Token: 0x04000056 RID: 86
	[CompilerGenerated]
	private int? nullable_1;
}
