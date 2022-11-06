using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000051 RID: 81
public class GClass30
{
	// Token: 0x060002A2 RID: 674 RVA: 0x0004A78C File Offset: 0x0004898C
	public GClass30(byte[] byte_0, long long_0, long long_1, bool bool_0 = true)
	{
		this.UInt32_1 = (uint)long_0;
		this.UInt32_0 = (uint)long_1;
		if (bool_0)
		{
			try
			{
				string text;
				if (Class6.smethod_3(byte_0, out text, (long)((ulong)this.UInt32_1), (long)((ulong)(this.UInt32_1 + this.UInt32_0)), 4096))
				{
					this.String_0 = text;
				}
				else
				{
					this.String_0 = null;
				}
				return;
			}
			catch
			{
				this.String_0 = null;
				return;
			}
		}
		this.String_0 = null;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0004A80C File Offset: 0x00048A0C
	public GClass30(BinaryReader binaryReader_0, long long_0, long long_1, bool bool_0 = true)
	{
		this.UInt32_1 = (uint)long_0;
		this.UInt32_0 = (uint)long_1;
		if (bool_0)
		{
			try
			{
				string text;
				if (Class6.smethod_2(binaryReader_0, out text, (long)((ulong)this.UInt32_1), (long)((ulong)(this.UInt32_1 + this.UInt32_0)), 4096))
				{
					this.String_0 = text;
				}
				else
				{
					this.String_0 = null;
				}
				return;
			}
			catch
			{
				this.String_0 = null;
				return;
			}
		}
		this.String_0 = null;
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x060002A4 RID: 676 RVA: 0x0004A88C File Offset: 0x00048A8C
	// (set) Token: 0x060002A5 RID: 677 RVA: 0x0004A8A0 File Offset: 0x00048AA0
	public uint UInt32_0 { get; private set; }

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x060002A6 RID: 678 RVA: 0x0004A8B4 File Offset: 0x00048AB4
	// (set) Token: 0x060002A7 RID: 679 RVA: 0x0004A8C8 File Offset: 0x00048AC8
	public uint UInt32_1 { get; private set; }

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x060002A8 RID: 680 RVA: 0x0004A8DC File Offset: 0x00048ADC
	// (set) Token: 0x060002A9 RID: 681 RVA: 0x0004A8F0 File Offset: 0x00048AF0
	public string String_0 { get; private set; }

	// Token: 0x060002AA RID: 682 RVA: 0x0004A904 File Offset: 0x00048B04
	public virtual string ToString()
	{
		return string.Format("{0}!{1}!{2}", this.String_0 ?? Class14.String_215, this.UInt32_1, this.UInt32_0);
	}

	// Token: 0x04000271 RID: 625
	[CompilerGenerated]
	private uint uint_0;

	// Token: 0x04000272 RID: 626
	[CompilerGenerated]
	private uint uint_1;

	// Token: 0x04000273 RID: 627
	[CompilerGenerated]
	private string string_0;
}
