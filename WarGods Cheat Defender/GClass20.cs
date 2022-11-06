using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000047 RID: 71
public class GClass20
{
	// Token: 0x060001BF RID: 447 RVA: 0x00048C40 File Offset: 0x00046E40
	public GClass20(byte[] byte_0, int int_0)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_0);
		this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_0 + 4);
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060001C0 RID: 448 RVA: 0x00048C70 File Offset: 0x00046E70
	// (set) Token: 0x060001C1 RID: 449 RVA: 0x00048C84 File Offset: 0x00046E84
	public uint UInt32_0 { get; set; }

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060001C2 RID: 450 RVA: 0x00048C98 File Offset: 0x00046E98
	// (set) Token: 0x060001C3 RID: 451 RVA: 0x00048CAC File Offset: 0x00046EAC
	public uint UInt32_1 { get; set; }

	// Token: 0x060001C4 RID: 452 RVA: 0x00048CC0 File Offset: 0x00046EC0
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_DATA_DIRECTORY\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-10}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x04000205 RID: 517
	[NonSerialized]
	public static readonly uint uint_0 = 8U;

	// Token: 0x04000206 RID: 518
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x04000207 RID: 519
	[CompilerGenerated]
	private uint uint_2;
}
