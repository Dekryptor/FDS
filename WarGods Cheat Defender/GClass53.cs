using System;
using System.Runtime.CompilerServices;

// Token: 0x020000B2 RID: 178
public class GClass53
{
	// Token: 0x170002CC RID: 716
	// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00055EA4 File Offset: 0x000540A4
	// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00055EB8 File Offset: 0x000540B8
	public byte[] Byte_0 { get; private set; }

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00055ECC File Offset: 0x000540CC
	// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00055EE0 File Offset: 0x000540E0
	public string String_0 { get; private set; }

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x060005BA RID: 1466 RVA: 0x00055EF4 File Offset: 0x000540F4
	// (set) Token: 0x060005BB RID: 1467 RVA: 0x00055F08 File Offset: 0x00054108
	public int[] Int32_0 { get; private set; }

	// Token: 0x060005BC RID: 1468 RVA: 0x00055F1C File Offset: 0x0005411C
	public GClass53(byte[] byte_1, string string_1, int int_1)
	{
		if (byte_1 == null || string_1.Length != byte_1.Length)
		{
			throw new ArgumentException();
		}
		this.Byte_0 = byte_1;
		this.String_0 = string_1;
		this.Int32_0 = new int[] { int_1 };
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00055F64 File Offset: 0x00054164
	public GClass53(byte[] byte_1, string string_1, int[] int_1)
	{
		if (byte_1 == null || string_1.Length != byte_1.Length)
		{
			throw new ArgumentException();
		}
		this.Byte_0 = byte_1;
		this.String_0 = string_1;
		this.Int32_0 = int_1;
	}

	// Token: 0x040008F8 RID: 2296
	[CompilerGenerated]
	private byte[] byte_0;

	// Token: 0x040008F9 RID: 2297
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040008FA RID: 2298
	[CompilerGenerated]
	private int[] int_0;
}
