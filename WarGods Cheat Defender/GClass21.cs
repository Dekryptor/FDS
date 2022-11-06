using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000048 RID: 72
public class GClass21
{
	// Token: 0x060001C6 RID: 454 RVA: 0x00048D04 File Offset: 0x00046F04
	public GClass21(byte[] byte_0, int int_1)
	{
		this.method_0(byte_0, int_1);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00048D20 File Offset: 0x00046F20
	private void method_0(byte[] byte_0, int int_1)
	{
		this.UInt32_0 = BitConverter.ToUInt32(byte_0, int_1);
		this.UInt32_1 = BitConverter.ToUInt32(byte_0, int_1 + 4);
		this.UInt16_0 = BitConverter.ToUInt16(byte_0, int_1 + 8);
		this.UInt16_1 = BitConverter.ToUInt16(byte_0, int_1 + 10);
		this.UInt32_2 = BitConverter.ToUInt32(byte_0, int_1 + 12);
		this.UInt32_3 = BitConverter.ToUInt32(byte_0, int_1 + 16);
		this.UInt32_4 = BitConverter.ToUInt32(byte_0, int_1 + 20);
		this.UInt32_5 = BitConverter.ToUInt32(byte_0, int_1 + 24);
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00048DA8 File Offset: 0x00046FA8
	public GClass21(BinaryReader binaryReader_0, int int_1 = 0)
	{
		if (int_1 == 0 || (long)int_1 >= binaryReader_0.BaseStream.Length)
		{
			throw new ArgumentException("Invalid debug offset");
		}
		binaryReader_0.BaseStream.Seek((long)int_1, SeekOrigin.Begin);
		byte[] array = new byte[GClass21.int_0];
		if (binaryReader_0.Read(array, 0, array.Length) == array.Length)
		{
			this.method_0(array, 0);
			return;
		}
		throw new IOException("Read debug failed");
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060001C9 RID: 457 RVA: 0x00048E18 File Offset: 0x00047018
	// (set) Token: 0x060001CA RID: 458 RVA: 0x00048E2C File Offset: 0x0004702C
	public uint UInt32_0 { get; set; }

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060001CB RID: 459 RVA: 0x00048E40 File Offset: 0x00047040
	// (set) Token: 0x060001CC RID: 460 RVA: 0x00048E54 File Offset: 0x00047054
	public uint UInt32_1 { get; set; }

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060001CD RID: 461 RVA: 0x00048E68 File Offset: 0x00047068
	// (set) Token: 0x060001CE RID: 462 RVA: 0x00048E7C File Offset: 0x0004707C
	public ushort UInt16_0 { get; set; }

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060001CF RID: 463 RVA: 0x00048E90 File Offset: 0x00047090
	// (set) Token: 0x060001D0 RID: 464 RVA: 0x00048EA4 File Offset: 0x000470A4
	public ushort UInt16_1 { get; set; }

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060001D1 RID: 465 RVA: 0x00048EB8 File Offset: 0x000470B8
	// (set) Token: 0x060001D2 RID: 466 RVA: 0x00048ECC File Offset: 0x000470CC
	public uint UInt32_2 { get; set; }

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060001D3 RID: 467 RVA: 0x00048EE0 File Offset: 0x000470E0
	// (set) Token: 0x060001D4 RID: 468 RVA: 0x00048EF4 File Offset: 0x000470F4
	public uint UInt32_3 { get; set; }

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060001D5 RID: 469 RVA: 0x00048F08 File Offset: 0x00047108
	// (set) Token: 0x060001D6 RID: 470 RVA: 0x00048F1C File Offset: 0x0004711C
	public uint UInt32_4 { get; set; }

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060001D7 RID: 471 RVA: 0x00048F30 File Offset: 0x00047130
	// (set) Token: 0x060001D8 RID: 472 RVA: 0x00048F44 File Offset: 0x00047144
	public uint UInt32_5 { get; set; }

	// Token: 0x060001D9 RID: 473 RVA: 0x00048F58 File Offset: 0x00047158
	public virtual string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("IMAGE_DEBUG_DIRECTORY\n");
		stringBuilder.Append(GClass18.smethod_9(this, "{0,-10}:\t{1,10:X}\n"));
		return stringBuilder.ToString();
	}

	// Token: 0x04000208 RID: 520
	[NonSerialized]
	public static readonly int int_0 = 28;

	// Token: 0x04000209 RID: 521
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x0400020A RID: 522
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x0400020B RID: 523
	[CompilerGenerated]
	private ushort ushort_0;

	// Token: 0x0400020C RID: 524
	[CompilerGenerated]
	private ushort ushort_1;

	// Token: 0x0400020D RID: 525
	[CompilerGenerated]
	private uint uint_2;

	// Token: 0x0400020E RID: 526
	[CompilerGenerated]
	private uint uint_3;

	// Token: 0x0400020F RID: 527
	[CompilerGenerated]
	private uint uint_4;

	// Token: 0x04000210 RID: 528
	[CompilerGenerated]
	private uint uint_5;
}
