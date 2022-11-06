using System;
using System.Runtime.CompilerServices;

// Token: 0x020000FA RID: 250
internal class Class60
{
	// Token: 0x1700034B RID: 843
	// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00068230 File Offset: 0x00066430
	// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00068244 File Offset: 0x00066444
	public long Int64_0 { get; private set; }

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00068258 File Offset: 0x00066458
	// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0006826C File Offset: 0x0006646C
	public ulong UInt64_0 { get; private set; }

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00068280 File Offset: 0x00066480
	// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00068294 File Offset: 0x00066494
	public ulong UInt64_1 { get; private set; }

	// Token: 0x060007D6 RID: 2006 RVA: 0x000682A8 File Offset: 0x000664A8
	public Class60(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException();
		}
		if ((long)byte_0.Length == (long)((ulong)Class60.uint_0))
		{
			this.Int64_0 = (long)BitConverter.ToUInt64(byte_0, 0);
			this.UInt64_0 = BitConverter.ToUInt64(byte_0, 8);
			this.UInt64_1 = BitConverter.ToUInt64(byte_0, 16);
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x04000B35 RID: 2869
	public static readonly uint uint_0 = 24U;

	// Token: 0x04000B36 RID: 2870
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04000B37 RID: 2871
	[CompilerGenerated]
	private ulong ulong_0;

	// Token: 0x04000B38 RID: 2872
	[CompilerGenerated]
	private ulong ulong_1;
}
