using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200004E RID: 78
public class GClass27
{
	// Token: 0x06000248 RID: 584 RVA: 0x00049C58 File Offset: 0x00047E58
	public GClass27(byte[] byte_0, int int_1 = 0)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_1);
		this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_1 + 4);
		this.UInt32_2 = BitConverter.ToUInt32(byte_0, int_1 + 8);
		this.UInt32_3 = BitConverter.ToUInt32(byte_0, int_1 + 12);
		this.UInt32_4 = BitConverter.ToUInt32(byte_0, int_1 + 16);
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000249 RID: 585 RVA: 0x00049CB8 File Offset: 0x00047EB8
	// (set) Token: 0x0600024A RID: 586 RVA: 0x00049CCC File Offset: 0x00047ECC
	public uint UInt32_0 { get; set; }

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x0600024B RID: 587 RVA: 0x00049CE0 File Offset: 0x00047EE0
	// (set) Token: 0x0600024C RID: 588 RVA: 0x00049CF4 File Offset: 0x00047EF4
	public uint UInt32_1 { get; set; }

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x0600024D RID: 589 RVA: 0x00049D08 File Offset: 0x00047F08
	// (set) Token: 0x0600024E RID: 590 RVA: 0x00049D1C File Offset: 0x00047F1C
	public uint UInt32_2 { get; set; }

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x0600024F RID: 591 RVA: 0x00049D30 File Offset: 0x00047F30
	// (set) Token: 0x06000250 RID: 592 RVA: 0x00049D44 File Offset: 0x00047F44
	public uint UInt32_3 { get; set; }

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000251 RID: 593 RVA: 0x00049D58 File Offset: 0x00047F58
	// (set) Token: 0x06000252 RID: 594 RVA: 0x00049D6C File Offset: 0x00047F6C
	public uint UInt32_4 { get; set; }

	// Token: 0x06000253 RID: 595 RVA: 0x00049D80 File Offset: 0x00047F80
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_IMPORT_DESCRIPTOR\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-20}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x04000244 RID: 580
	[NonSerialized]
	public static readonly int int_0 = 20;

	// Token: 0x04000245 RID: 581
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000246 RID: 582
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x04000247 RID: 583
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x04000248 RID: 584
	[CompilerGenerated]
	private uint uint_3;

	// Token: 0x04000249 RID: 585
	[CompilerGenerated]
	private uint uint_4;
}
