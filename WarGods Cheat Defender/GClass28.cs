using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200004F RID: 79
public class GClass28
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000255 RID: 597 RVA: 0x00049DC4 File Offset: 0x00047FC4
	// (set) Token: 0x06000256 RID: 598 RVA: 0x00049DD8 File Offset: 0x00047FD8
	public GClass25 GClass25_0 { get; private set; }

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000257 RID: 599 RVA: 0x00049DEC File Offset: 0x00047FEC
	// (set) Token: 0x06000258 RID: 600 RVA: 0x00049E00 File Offset: 0x00048000
	public GClass29 GClass29_0 { get; private set; }

	// Token: 0x06000259 RID: 601 RVA: 0x00049E14 File Offset: 0x00048014
	public GClass28(byte[] byte_0, uint uint_3, bool bool_0)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, (int)uint_3);
		this.GClass25_0 = new GClass25(byte_0, (int)(uint_3 + 4U));
		this.GClass29_0 = new GClass29(byte_0, (int)(uint_3 + 24U), bool_0);
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00049E54 File Offset: 0x00048054
	public GClass28(byte[] byte_0, bool bool_0)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, 0);
		this.GClass25_0 = new GClass25(byte_0, 4);
		this.GClass29_0 = new GClass29(byte_0, 24, bool_0);
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x0600025B RID: 603 RVA: 0x00049E90 File Offset: 0x00048090
	// (set) Token: 0x0600025C RID: 604 RVA: 0x00049EA4 File Offset: 0x000480A4
	public uint UInt32_0 { get; set; }

	// Token: 0x0600025D RID: 605 RVA: 0x00049EB8 File Offset: 0x000480B8
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_NT_HEADERS\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-10}:\t{1,10:X}\n"));
		stringBuilder.Append(this.GClass25_0);
		stringBuilder.Append(this.GClass29_0);
		return stringBuilder.ToString();
	}

	// Token: 0x0400024A RID: 586
	[NonSerialized]
	public static readonly uint uint_0 = 4U + GClass25.uint_0 + GClass29.uint_0;

	// Token: 0x0400024B RID: 587
	[NonSerialized]
	public static readonly uint uint_1 = 4U + GClass25.uint_0 + GClass29.uint_1;

	// Token: 0x0400024C RID: 588
	[CompilerGenerated]
	private GClass25 gclass25_0;

	// Token: 0x0400024D RID: 589
	[CompilerGenerated]
	private GClass29 gclass29_0;

	// Token: 0x0400024E RID: 590
	[CompilerGenerated]
	private uint uint_2;
}
