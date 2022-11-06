using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D8 RID: 216
internal class Class41
{
	// Token: 0x170002EA RID: 746
	// (get) Token: 0x060006CD RID: 1741 RVA: 0x00064304 File Offset: 0x00062504
	// (set) Token: 0x060006CE RID: 1742 RVA: 0x00064318 File Offset: 0x00062518
	public uint UInt32_0 { get; private set; }

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x060006CF RID: 1743 RVA: 0x0006432C File Offset: 0x0006252C
	// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00064340 File Offset: 0x00062540
	public uint UInt32_1 { get; private set; }

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00064354 File Offset: 0x00062554
	// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00064368 File Offset: 0x00062568
	public long Int64_0 { get; private set; }

	// Token: 0x060006D3 RID: 1747 RVA: 0x0006437C File Offset: 0x0006257C
	public Class41(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException();
		}
		if ((long)byte_0.Length != (long)((ulong)Class41.uint_0))
		{
			throw new ArgumentOutOfRangeException();
		}
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, 0);
		this.UInt32_1 = BitConverter.ToUInt32(byte_0, 4);
		this.Int64_0 = BitConverter.ToInt64(byte_0, 8);
	}

	// Token: 0x040009AC RID: 2476
	public static readonly uint uint_0 = 16U;

	// Token: 0x040009AD RID: 2477
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x040009AE RID: 2478
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x040009AF RID: 2479
	[CompilerGenerated]
	private long long_0;
}
