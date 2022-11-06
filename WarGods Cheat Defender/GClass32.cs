using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000053 RID: 83
public class GClass32
{
	// Token: 0x060002C8 RID: 712 RVA: 0x0004B040 File Offset: 0x00049240
	public GClass32(byte[] byte_0, int int_0, bool bool_0)
	{
		this.UInt64_0 = (bool_0 ? BitConverter.ToUInt64(byte_0, int_0) : ((ulong)BitConverter.ToUInt32(byte_0, int_0)));
		this.UInt64_1 = this.UInt64_0;
		this.UInt64_2 = this.UInt64_0;
		this.UInt64_3 = this.UInt64_0;
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x060002C9 RID: 713 RVA: 0x0004B094 File Offset: 0x00049294
	// (set) Token: 0x060002CA RID: 714 RVA: 0x0004B0A8 File Offset: 0x000492A8
	public ulong UInt64_0 { get; private set; }

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x060002CB RID: 715 RVA: 0x0004B0BC File Offset: 0x000492BC
	// (set) Token: 0x060002CC RID: 716 RVA: 0x0004B0D0 File Offset: 0x000492D0
	public ulong UInt64_1 { get; private set; }

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x060002CD RID: 717 RVA: 0x0004B0E4 File Offset: 0x000492E4
	// (set) Token: 0x060002CE RID: 718 RVA: 0x0004B0F8 File Offset: 0x000492F8
	public ulong UInt64_2 { get; private set; }

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x060002CF RID: 719 RVA: 0x0004B10C File Offset: 0x0004930C
	// (set) Token: 0x060002D0 RID: 720 RVA: 0x0004B120 File Offset: 0x00049320
	public ulong UInt64_3 { get; private set; }

	// Token: 0x060002D1 RID: 721 RVA: 0x0004B134 File Offset: 0x00049334
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_THUNK_DATA\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-15}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x04000281 RID: 641
	[CompilerGenerated]
	private ulong ulong_0;

	// Token: 0x04000282 RID: 642
	[CompilerGenerated]
	private ulong ulong_1;

	// Token: 0x04000283 RID: 643
	[CompilerGenerated]
	private ulong ulong_2;

	// Token: 0x04000284 RID: 644
	[CompilerGenerated]
	private ulong ulong_3;
}
