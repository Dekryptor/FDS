using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200004D RID: 77
public class GClass26
{
	// Token: 0x06000242 RID: 578 RVA: 0x00049BA0 File Offset: 0x00047DA0
	public GClass26(byte[] byte_0, ulong ulong_0 = 0UL)
	{
		this.UInt16_0 = BitConverter.ToUInt16(byte_0, (int)ulong_0);
		this.String_0 = GClass18.smethod_12(ulong_0 + 2UL, byte_0);
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000243 RID: 579 RVA: 0x00049BD8 File Offset: 0x00047DD8
	// (set) Token: 0x06000244 RID: 580 RVA: 0x00049BEC File Offset: 0x00047DEC
	public ushort UInt16_0 { get; set; }

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000245 RID: 581 RVA: 0x00049C00 File Offset: 0x00047E00
	// (set) Token: 0x06000246 RID: 582 RVA: 0x00049C14 File Offset: 0x00047E14
	public string String_0 { get; set; }

	// Token: 0x06000247 RID: 583 RVA: 0x00049C28 File Offset: 0x00047E28
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_IMPORT_BY_NAME\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-10}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x04000242 RID: 578
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x04000243 RID: 579
	[CompilerGenerated]
	private string string_0;
}
